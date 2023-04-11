using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required] public string Name { get; set; }

        public virtual List<Members> Members { get; set;}
    }
}
