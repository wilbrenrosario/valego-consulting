using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace valego.core.Models
{
    public class Announcement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public string link { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string date { get; set; }
    }
}
