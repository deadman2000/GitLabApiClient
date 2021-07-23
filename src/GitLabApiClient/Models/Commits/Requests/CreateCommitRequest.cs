using System.Collections.Generic;
using GitLabApiClient.Internal.Paths;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Commits.Requests
{
    /// <summary>
    /// Create a commit by project
    /// </summary>
    public sealed class CreateCommitRequest
    {
        /// <summary>
        /// Name of the branch to commit into.
        /// </summary>
        [JsonProperty("branch")]
        public string Branch { get; set; }

        /// <summary>
        /// Commit message
        /// </summary>
        [JsonProperty("commit_message")]
        public string CommitMessage { get; set; }

        /// <summary>
        /// Name of the branch to start the new branch from
        /// </summary>
        [JsonProperty("start_branch")]
        public string StartBranch { get; set; }

        /// <summary>
        /// SHA of the commit to start the new branch from
        /// </summary>
        [JsonProperty("start_sha")]
        public string StartSHA { get; set; }

        /// <summary>
        /// The project ID or URL-encoded path of the project to start the new branch from
        /// </summary>
        [JsonProperty("start_project")]
        public ProjectId StartProject { get; set; }

        /// <summary>
        /// An array of action hashes to commit as a batch
        /// </summary>
        [JsonProperty("actions")]
        public List<CommitAction> Actions { get; set; }

        /// <summary>
        /// Specify the commit author’s email address
        /// </summary>
        [JsonProperty("author_email")]
        public string AuthorEmail { get; set; }

        /// <summary>
        /// Specify the commit author’s name
        /// </summary>
        [JsonProperty("author_name")]
        public string AuthorName { get; set; }

        /// <summary>
        /// Include commit stats
        /// </summary>
        [JsonProperty("stats")]
        public bool? Stats { get; set; }

        /// <summary>
        /// When true overwrites the target branch with a new commit based on the <see cref="StartBranch"/> or <see cref="StartSHA"/>
        /// </summary>
        [JsonProperty("force")]
        public bool? Force { get; set; }
    }
}
