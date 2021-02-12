using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using issue_tracker_crud.Models;

namespace RazorPagesIssue.Data
{
    public class RazorPagesIssueContext : DbContext
    {
        public RazorPagesIssueContext (DbContextOptions<RazorPagesIssueContext> options)
            : base(options)
        {
        }

        public DbSet<issue_tracker_crud.Models.Issue> Issue { get; set; }
    }
}
