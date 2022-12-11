using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Logic.Entities
{
    public abstract class Entity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[JsonIgnore]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

