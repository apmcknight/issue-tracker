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
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesIssue.Data.RazorPagesIssueContext _context;

        public DeleteModel(RazorPagesIssue.Data.RazorPagesIssueContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Issue Issue { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Issue = await _context.Issue.FirstOrDefaultAsync(m => m.ID == id);

            if (Issue == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Issue = await _context.Issue.FindAsync(id);

            if (Issue != null)
            {
                _context.Issue.Remove(Issue);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
