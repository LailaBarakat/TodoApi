using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        [StringLength(400, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "boolean")]
        [Required]
        public bool IsComplete { get; set; }
    }
}