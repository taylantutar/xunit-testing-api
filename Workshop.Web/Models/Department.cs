﻿using System.ComponentModel.DataAnnotations;

namespace Workshop.Web.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
