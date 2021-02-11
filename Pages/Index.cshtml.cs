using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using issue_tracker.Models;
using issue_tracker.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace issue_tracker.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IssueService IssueServiceRunner;
        public IEnumerable<Issues> Issue { get; private set; }

        public IndexModel(
            ILogger<IndexModel> logger,
            IssueService issueServiceRunner)
        {
            _logger = logger;
            IssueServiceRunner = issueServiceRunner;
        }

        public void OnGet()
        {
            Issue = IssueServiceRunner.GetIssues();
        }
    }
}
