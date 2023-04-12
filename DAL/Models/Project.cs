using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required] public string Title { get; set; }
        [Required] public bool Status { get; set; }
        [Required] public DateTime StartDate { get; set; }
        [Required] public DateTime EndDate { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}