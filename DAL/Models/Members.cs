using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Members
    {
        public int Id { get; set; }
        [Required] public string Name { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }
    }
}
