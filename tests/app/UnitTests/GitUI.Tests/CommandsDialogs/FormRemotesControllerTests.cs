﻿using FluentAssertions;
using GitCommands.UserRepositoryHistory;
using GitUI.CommandsDialogs;

namespace GitUITests.CommandsDialogs
{
    [TestFixture]
    public class FormRemotesControllerTests
    {
        private FormRemotesController _controller;

        [SetUp]
        public void Setup()
        {
            _controller = new FormRemotesController();
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("\t")]
        public void RemoteDelete_should_not_throw_or_mutate_list_of_remotes_if_oldRemoteUrl_null_or_empty(string oldRemoteUrl)
        {
            List<Repository> remotes =
            [
                new Repository("a"),
                new Repository("b")
            ];

            _controller.RemoteDelete(remotes, oldRemoteUrl);

            remotes.Should().HaveCount(2);
        }

        [Test]
        public void RemoteDelete_should_not_throw_or_mutate_list_of_remotes_if_oldRemoteUrl_not_in_list()
        {
            List<Repository> remotes =
            [
                new Repository("a"),
                new Repository("b")
            ];

            _controller.RemoteDelete(remotes, "foo");

            remotes.Should().HaveCount(2);
        }

        [Test]
        public void RemoteDelete_should_remove_remotes_matching_oldRemoteUrl()
        {
            List<Repository> remotes =
            [
                new Repository("a"),
                new Repository("b")
            ];

            _controller.RemoteDelete(remotes, "b");

            remotes.Should().ContainSingle();
            remotes[0].Path.Should().Be("a");
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("\t")]
        public void RemoteUpdate_should_not_throw_or_mutate_list_of_remotes_if_newRemoteUrl_null_or_empty(string newRemoteUrl)
        {
            List<Repository> remotes =
            [
                new Repository("a"),
                new Repository("b")
            ];

            _controller.RemoteUpdate(remotes, "who cares", newRemoteUrl);

            remotes.Should().HaveCount(2);
            remotes[0].Path.Should().Be("a");
            remotes[1].Path.Should().Be("b");
        }

        [Test]
        public void RemoteDelete_should_replace_matching_oldRemoteUrl()
        {
            List<Repository> remotes =
            [
                new Repository("a"),
                new Repository("b")
            ];

            _controller.RemoteUpdate(remotes, "a", "a1");

            remotes.Should().HaveCount(2);
            remotes.Select(r => r.Path).Should().BeEquivalentTo(new[] { "a1", "b" });
        }

        [Test]
        public void RemoteDelete_should_place_newRemoteUrl_as_first()
        {
            List<Repository> remotes =
            [
                new Repository("a"),
                new Repository("b"),
                new Repository("c")
            ];

            _controller.RemoteUpdate(remotes, "c", "a1");

            remotes.Should().HaveCount(3);
            remotes[0].Path.Should().Be("a1");
            remotes[1].Path.Should().Be("a");
            remotes[2].Path.Should().Be("b");

            _controller.RemoteUpdate(remotes, null, "q");

            remotes.Should().HaveCount(4);
            remotes[0].Path.Should().Be("q");
            remotes[1].Path.Should().Be("a1");
            remotes[2].Path.Should().Be("a");
            remotes[3].Path.Should().Be("b");
        }
    }
}
