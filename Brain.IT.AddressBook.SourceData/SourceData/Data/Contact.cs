using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace SourceData.Data
{
    public partial class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [JsonIgnore]
        public bool IsSent { get; set; }
	}
}
