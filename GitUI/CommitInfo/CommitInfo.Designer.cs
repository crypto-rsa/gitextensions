﻿namespace GitUI.CommitInfo
{
    partial class CommitInfo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.gravatar1 = new GitUI.GravatarControl();
            this.RevisionInfo = new System.Windows.Forms.RichTextBox();
            this.commitInfoContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyCommitInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySelectionToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.copyCommitHashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCommitSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCommitMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAuthorNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAuthorEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAuthorDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCommitterNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCommitterEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCommitDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showContainedInBranchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showContainedInBranchesRemoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showContainedInBranchesRemoteIfNoLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showContainedInTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMessagesOfAnnotatedTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._RevisionHeader = new System.Windows.Forms.RichTextBox();
            this.tableLayout.SuspendLayout();
            this.commitInfoContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.AutoSize = true;
            this.tableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayout.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(this.gravatar1, 0, 0);
            this.tableLayout.Controls.Add(this.RevisionInfo, 1, 1);
            this.tableLayout.Controls.Add(this._RevisionHeader, 1, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout.Size = new System.Drawing.Size(893, 386);
            this.tableLayout.TabIndex = 3;
            // 
            // gravatar1
            // 
            this.gravatar1.BackColor = System.Drawing.SystemColors.Window;
            this.gravatar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gravatar1.Location = new System.Drawing.Point(0, 0);
            this.gravatar1.Margin = new System.Windows.Forms.Padding(0);
            this.gravatar1.Name = "gravatar1";
            this.tableLayout.SetRowSpan(this.gravatar1, 2);
            this.gravatar1.Size = new System.Drawing.Size(105, 386);
            this.gravatar1.TabIndex = 1;
            // 
            // RevisionInfo
            // 
            this.RevisionInfo.BackColor = System.Drawing.SystemColors.Window;
            this.RevisionInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RevisionInfo.ContextMenuStrip = this.commitInfoContextMenuStrip;
            this.RevisionInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RevisionInfo.Location = new System.Drawing.Point(110, 102);
            this.RevisionInfo.Margin = new System.Windows.Forms.Padding(5);
            this.RevisionInfo.Name = "RevisionInfo";
            this.RevisionInfo.ReadOnly = true;
            this.RevisionInfo.Size = new System.Drawing.Size(778, 279);
            this.RevisionInfo.TabIndex = 0;
            this.RevisionInfo.Text = "";
            this.RevisionInfo.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RevisionInfoLinkClicked);
            this.RevisionInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this._RevisionHeader_MouseDown);
            // 
            // commitInfoContextMenuStrip
            // 
            this.commitInfoContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyCommitInfoToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.toolStripSeparator1,
            this.showContainedInBranchesToolStripMenuItem,
            this.showContainedInBranchesRemoteToolStripMenuItem,
            this.showContainedInBranchesRemoteIfNoLocalToolStripMenuItem,
            this.showContainedInTagsToolStripMenuItem,
            this.showMessagesOfAnnotatedTagsToolStripMenuItem,
            this.toolStripSeparator2,
            this.addNoteToolStripMenuItem});
            this.commitInfoContextMenuStrip.Name = "commitInfoContextMenuStrip";
            this.commitInfoContextMenuStrip.Size = new System.Drawing.Size(454, 192);
            this.commitInfoContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.commitInfoContextMenuStrip_Opening);
            // 
            // copyCommitInfoToolStripMenuItem
            // 
            this.copyCommitInfoToolStripMenuItem.Name = "copyCommitInfoToolStripMenuItem";
            this.copyCommitInfoToolStripMenuItem.Size = new System.Drawing.Size(453, 22);
            this.copyCommitInfoToolStripMenuItem.Text = "Copy full commit info";
            this.copyCommitInfoToolStripMenuItem.Click += new System.EventHandler(this.copyCommitInfoToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copySelectionToolStripMenuItem,
            this.copySelectionToolStripSeparator,
            this.copyCommitHashToolStripMenuItem,
            this.copyCommitSubjectToolStripMenuItem,
            this.copyCommitMessageToolStripMenuItem,
            this.copyAuthorNameToolStripMenuItem,
            this.copyAuthorEmailToolStripMenuItem,
            this.copyAuthorDateToolStripMenuItem,
            this.copyCommitterNameToolStripMenuItem,
            this.copyCommitterEmailToolStripMenuItem,
            this.copyCommitDateToolStripMenuItem});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(453, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyCommitHashToolStripMenuItem_Click);
            // 
            // copySelectionToolStripMenuItem
            // 
            this.copySelectionToolStripMenuItem.Name = "copySelectionToolStripMenuItem";
            this.copySelectionToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.copySelectionToolStripMenuItem.Text = "Selection";
            this.copySelectionToolStripMenuItem.Click += new System.EventHandler(this.copySelectionToolStripMenuItem_Click);
            // 
            // copySelectionToolStripSeparator
            // 
            this.copySelectionToolStripSeparator.Name = "copySelectionToolStripSeparator";
            this.copySelectionToolStripSeparator.Size = new System.Drawing.Size(166, 6);
            // 
            // copyCommitHashToolStripMenuItem
            // 
            this.copyCommitHashToolStripMenuItem.Name = "copyCommitHashToolStripMenuItem";
            this.copyCommitHashToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.copyCommitHashToolStripMenuItem.Text = "Commit hash";
            this.copyCommitHashToolStripMenuItem.Click += new System.EventHandler(this.copyCommitHashToolStripMenuItem_Click);
            // 
            // copyCommitSubjectToolStripMenuItem
            // 
            this.copyCommitSubjectToolStripMenuItem.Name = "copyCommitSubjectToolStripMenuItem";
            this.copyCommitSubjectToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.copyCommitSubjectToolStripMenuItem.Text = "Commit subject";
            this.copyCommitSubjectToolStripMenuItem.Click += new System.EventHandler(this.copyCommitSubjectToolStripMenuItem_Click);
            // 
            // copyCommitMessageToolStripMenuItem
            // 
            this.copyCommitMessageToolStripMenuItem.Name = "copyCommitMessageToolStripMenuItem";
            this.copyCommitMessageToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.copyCommitMessageToolStripMenuItem.Text = "Commit message";
            this.copyCommitMessageToolStripMenuItem.Click += new System.EventHandler(this.copyCommitMessageToolStripMenuItem_Click);
            // 
            // copyAuthorNameToolStripMenuItem
            // 
            this.copyAuthorNameToolStripMenuItem.Name = "copyAuthorNameToolStripMenuItem";
            this.copyAuthorNameToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.copyAuthorNameToolStripMenuItem.Text = "Author name";
            this.copyAuthorNameToolStripMenuItem.Click += new System.EventHandler(this.copyAuthorNameToolStripMenuItem_Click);
            // 
            // copyAuthorEmailToolStripMenuItem
            // 
            this.copyAuthorEmailToolStripMenuItem.Name = "copyAuthorEmailToolStripMenuItem";
            this.copyAuthorEmailToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.copyAuthorEmailToolStripMenuItem.Text = "Author e-mail";
            this.copyAuthorEmailToolStripMenuItem.Click += new System.EventHandler(this.copyAuthorEmailToolStripMenuItem_Click);
            // 
            // copyAuthorDateToolStripMenuItem
            // 
            this.copyAuthorDateToolStripMenuItem.Name = "copyAuthorDateToolStripMenuItem";
            this.copyAuthorDateToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.copyAuthorDateToolStripMenuItem.Text = "Author date";
            this.copyAuthorDateToolStripMenuItem.Click += new System.EventHandler(this.copyAuthorDateToolStripMenuItem_Click);
            // 
            // copyCommitterNameToolStripMenuItem
            // 
            this.copyCommitterNameToolStripMenuItem.Name = "copyCommitterNameToolStripMenuItem";
            this.copyCommitterNameToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.copyCommitterNameToolStripMenuItem.Text = "Committer name";
            this.copyCommitterNameToolStripMenuItem.Click += new System.EventHandler(this.copyCommitterNameToolStripMenuItem_Click);
            // 
            // copyCommitterEmailToolStripMenuItem
            // 
            this.copyCommitterEmailToolStripMenuItem.Name = "copyCommitterEmailToolStripMenuItem";
            this.copyCommitterEmailToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.copyCommitterEmailToolStripMenuItem.Text = "Committer e-mail";
            this.copyCommitterEmailToolStripMenuItem.Click += new System.EventHandler(this.copyCommitterEmailToolStripMenuItem_Click);
            // 
            // copyCommitDateToolStripMenuItem
            // 
            this.copyCommitDateToolStripMenuItem.Name = "copyCommitDateToolStripMenuItem";
            this.copyCommitDateToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.copyCommitDateToolStripMenuItem.Text = "Commit date";
            this.copyCommitDateToolStripMenuItem.Click += new System.EventHandler(this.copyCommitDateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(450, 6);
            // 
            // showContainedInBranchesToolStripMenuItem
            // 
            this.showContainedInBranchesToolStripMenuItem.Name = "showContainedInBranchesToolStripMenuItem";
            this.showContainedInBranchesToolStripMenuItem.Size = new System.Drawing.Size(453, 22);
            this.showContainedInBranchesToolStripMenuItem.Text = "Show local branches containing this commit";
            this.showContainedInBranchesToolStripMenuItem.Click += new System.EventHandler(this.showContainedInBranchesToolStripMenuItem_Click);
            // 
            // showContainedInBranchesRemoteToolStripMenuItem
            // 
            this.showContainedInBranchesRemoteToolStripMenuItem.Name = "showContainedInBranchesRemoteToolStripMenuItem";
            this.showContainedInBranchesRemoteToolStripMenuItem.Size = new System.Drawing.Size(453, 22);
            this.showContainedInBranchesRemoteToolStripMenuItem.Text = "Show remote branches containing this commit";
            this.showContainedInBranchesRemoteToolStripMenuItem.Click += new System.EventHandler(this.showContainedInBranchesRemoteToolStripMenuItem_Click);
            // 
            // showContainedInBranchesRemoteIfNoLocalToolStripMenuItem
            // 
            this.showContainedInBranchesRemoteIfNoLocalToolStripMenuItem.Name = "showContainedInBranchesRemoteIfNoLocalToolStripMenuItem";
            this.showContainedInBranchesRemoteIfNoLocalToolStripMenuItem.Size = new System.Drawing.Size(453, 22);
            this.showContainedInBranchesRemoteIfNoLocalToolStripMenuItem.Text = "Show remote branches only when no local branch contains this commit";
            this.showContainedInBranchesRemoteIfNoLocalToolStripMenuItem.Click += new System.EventHandler(this.showContainedInBranchesRemoteIfNoLocalToolStripMenuItem_Click);
            // 
            // showContainedInTagsToolStripMenuItem
            // 
            this.showContainedInTagsToolStripMenuItem.Name = "showContainedInTagsToolStripMenuItem";
            this.showContainedInTagsToolStripMenuItem.Size = new System.Drawing.Size(453, 22);
            this.showContainedInTagsToolStripMenuItem.Text = "Show tags containing this commit";
            this.showContainedInTagsToolStripMenuItem.Click += new System.EventHandler(this.showContainedInTagsToolStripMenuItem_Click);
            // 
            // showMessagesOfAnnotatedTagsToolStripMenuItem
            // 
            this.showMessagesOfAnnotatedTagsToolStripMenuItem.Name = "showMessagesOfAnnotatedTagsToolStripMenuItem";
            this.showMessagesOfAnnotatedTagsToolStripMenuItem.Size = new System.Drawing.Size(453, 22);
            this.showMessagesOfAnnotatedTagsToolStripMenuItem.Text = "Show messages of annotated tags";
            this.showMessagesOfAnnotatedTagsToolStripMenuItem.Click += new System.EventHandler(this.showMessagesOfAnnotatedTagsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(450, 6);
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(453, 22);
            this.addNoteToolStripMenuItem.Text = "Add notes";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // _RevisionHeader
            // 
            this._RevisionHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this._RevisionHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._RevisionHeader.ContextMenuStrip = this.commitInfoContextMenuStrip;
            this._RevisionHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this._RevisionHeader.Location = new System.Drawing.Point(109, 2);
            this._RevisionHeader.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this._RevisionHeader.Name = "_RevisionHeader";
            this._RevisionHeader.ReadOnly = true;
            this._RevisionHeader.Size = new System.Drawing.Size(780, 93);
            this._RevisionHeader.TabIndex = 0;
            this._RevisionHeader.Text = "";
            this._RevisionHeader.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this._RevisionHeader_ContentsResized);
            this._RevisionHeader.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RevisionInfoLinkClicked);
            this._RevisionHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this._RevisionHeader_MouseDown);
            // 
            // CommitInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.tableLayout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CommitInfo";
            this.Size = new System.Drawing.Size(893, 386);
            this.tableLayout.ResumeLayout(false);
            this.commitInfoContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private GravatarControl gravatar1;
        private System.Windows.Forms.RichTextBox RevisionInfo;
        private System.Windows.Forms.ContextMenuStrip commitInfoContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showContainedInBranchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showContainedInTagsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox _RevisionHeader;
        private System.Windows.Forms.ToolStripMenuItem copyCommitInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showContainedInBranchesRemoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showContainedInBranchesRemoteIfNoLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMessagesOfAnnotatedTagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCommitHashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAuthorNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAuthorEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAuthorDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCommitterNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCommitterEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCommitMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCommitDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCommitSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copySelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator copySelectionToolStripSeparator;
    }
}
