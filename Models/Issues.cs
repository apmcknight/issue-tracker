using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace issue_tracker.Models
{
    public class Issues
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("issue_title")]
        public string Issue_title { get; set; }

        //[JsonPropertyName("issue_description")]
        //public string Issue_description { get; set; }

        //[JsonPropertyName("issue_priority")]
        //public string Issue_priority { get; set; }

        //[JsonPropertyName("issue_status")]
        //public string Issue_status { get; set; }

        //[JsonPropertyName("is_issue_assigned")]
        //public bool Is_issue_assigned { get; set; }

        //[JsonPropertyName("issue_assigned_to")]
        //public string Issue_assigned_to { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Issues>(this);

    }


}
