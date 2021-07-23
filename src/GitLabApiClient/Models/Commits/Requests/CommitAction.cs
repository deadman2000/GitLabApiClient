using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Commits.Requests
{
    public sealed class CommitAction
    {
        /// <summary>
        /// The action to perform
        /// </summary>
        [JsonProperty("action")]
        public CommitActionType Action { get; set; }

        /// <summary>
        /// Full path to the file
        /// </summary>
        [JsonProperty("file_path")]
        public string FilePath { get; set; }

        /// <summary>
        /// Original full path to the file being moved. Only considered for <see cref="CommitActionType.Move"> action
        /// </summary>
        [JsonProperty("previous_path")]
        public string PreviousPath { get; set; }

        /// <summary>
        /// File content
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// text or base64. text is default
        /// </summary>
        [JsonProperty("encoding")]
        public string Encoding { get; set; }

        /// <summary>
        /// Last known file commit ID. Only considered in update, move, and delete actions
        /// </summary>
        [JsonProperty("last_commit_id")]
        public string LastCommitId { get; set; }

        /// <summary>
        /// When true/false enables/disables the execute flag on the file. Only considered for chmod action
        /// </summary>
        [JsonProperty("execute_filemode")]
        public bool? ExecuteFilemode { get; set; }
    }
}
