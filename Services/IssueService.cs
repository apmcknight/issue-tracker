using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using issue_tracker.Models;
using Microsoft.AspNetCore.Hosting;

namespace issue_tracker.Services
{
    public class IssueService
    {
        public IssueService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "data.json"); }
        }

        public IEnumerable<Issues> GetIssues()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Issues[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}