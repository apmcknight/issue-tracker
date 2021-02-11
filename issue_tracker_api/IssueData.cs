using System;

namespace issue_tracker_api
{
    public class IssueData
    {
        public int IssueID { get; set; }

        public DateTime Date { get; set; }

        public string IssueTitle { get; set; }

        public string IssueDescription { get; set; }

        public int IssueLevel { get; set; }

        public bool IsIssueAssigned { get; set; }

        public bool IsIssueResolved { get; set; }
    }
}
