using System;

namespace issue_tracker_crud.Models
{
    public class Issue
    {
        public int  ID { get; set; }
        public string IssueTitle { get; set; }
        public string IssueDescription { get; set; }
        public string IssueLevel { get; set; }
        public bool IssueAssigned { get; set; }
        public bool IsIssueOpen { get; set; }
    }
}
