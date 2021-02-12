using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesIssue.Data;
using issue_tracker_crud.Models;

namespace issue_tracker_crud.Pages.Issues
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesIssue.Data.RazorPagesIssueContext _context;

        public IndexModel(RazorPagesIssue.Data.RazorPagesIssueContext context)
        {
            _context = context;
        }

        public IList<Issue> Issue { get;set; }

        public async Task OnGetAsync()
        {
            Issue = await _context.Issue.ToListAsync();
        }
    }
}
