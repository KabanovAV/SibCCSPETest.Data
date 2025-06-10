﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SibCCSPETest.Data
{
    public class GroupUser
    {
        [Key]
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public int Status { get; set; } // 1 Недопущен; 2 Допущен; 3 Пройден
        public DateTime StartTest { get; set; }
        public DateTime EndTest { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ChangedDate { get; set; }

        [JsonIgnore]
        public Group? Group { get; set; }
        [JsonIgnore]
        public User? User { get; set; }
        [JsonIgnore]
        public List<Result>? Results { get; set; }
    }
}
