using System.ComponentModel.DataAnnotations;

namespace GerenciaLeads.Api.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        public DateTime DateCreated { get; set; }
        public string Suburb { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [StringLength(15)]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress,StringLength(100)]
        public string EmailAddress { get; set; }
        [StringLength(1)]
        public string Accepted { get; set; }
    }
}
