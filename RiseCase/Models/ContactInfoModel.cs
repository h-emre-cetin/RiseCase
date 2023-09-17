using System.ComponentModel.DataAnnotations;

namespace RiseCase.Models
{
    public class ContactInfoModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ContactId { get; set; }

        public ContactType ContactType { get; set; }

        [Required]
        public string Content { get; set; }
    }

    public enum ContactType
    {
        PhoneNumber,
        Email,
        Location,
    }
}

