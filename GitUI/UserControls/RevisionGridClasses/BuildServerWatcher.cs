﻿using System;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Threading;
using System.Windows.Forms;
using GitCommands;

namespace GitUI.RevisionGridClasses
{
    public class BuildServerWatcher : IDisposable
    {
        private readonly RevisionGrid revisionGrid;
        private readonly DvcsGraph revisions;

        private IDisposable buildStatusCancellationToken;

        public BuildServerWatcher(RevisionGrid revisionGrid, DvcsGraph revisions)
        {
            this.revisionGrid = revisionGrid;
            this.revisions = revisions;

            AddBuildStatusColumns();
        }

        private void AddBuildStatusColumns()
        {
            var buildStatusImageColumn = new DataGridViewImageColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 16,
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            var buildMessageTextBoxColumn = new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                HeaderText = "Build Status",
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };

            revisions.Columns.Add(buildStatusImageColumn);
            revisions.Columns.Add(buildMessageTextBoxColumn);
        }

        public void LaunchBuildServerInfoFetchOperation()
        {
            var projectName = revisionGrid.Module.GitWorkingDir.Split(new[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar }, StringSplitOptions.RemoveEmptyEntries).Last();
            IBuildServerWatcher buildServerWatcher = new TeamCityBuildWatcher(projectName);

            var fullDayObservable = buildServerWatcher.CreateObservable(DateTime.Now.Date);
            var fullObservable = buildServerWatcher.CreateObservable();
            var fromNowObservable = buildServerWatcher.CreateObservable(DateTime.Now);

            buildStatusCancellationToken =
                fullDayObservable.Concat(fullObservable)
                                 .Concat(Observable.Empty<BuildInfo>().Delay(TimeSpan.FromMinutes(1))
                                                   .Concat(fromNowObservable)
                                                   .Repeat())
                                 .Subscribe(item =>
                                     {
                                         if (buildStatusCancellationToken == null)
                                             return;

                                         string graphRevision;
                                         int row = revisionGrid.SearchRevision(item.CommitHash, out graphRevision);
                                         if (row >= 0)
                                         {
                                             var rowData = revisions.GetRowData(row);
                                             if (rowData.BuildStatus == null ||
                                                 item.StartDate > rowData.BuildStatus.StartDate)
                                             {
                                                 rowData.BuildStatus = item;

                                                 revisions.UpdateCellValue(4, row);
                                                 revisions.UpdateCellValue(5, row);
                                             }
                                         }
                                     });
        }

        public void CancelBuildStatusFetchOperation()
        {
            var cancellationToken = Interlocked.Exchange(ref buildStatusCancellationToken, null);

            if (cancellationToken != null)
            {
                cancellationToken.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                CancelBuildStatusFetchOperation();
            }
        }
    }
}