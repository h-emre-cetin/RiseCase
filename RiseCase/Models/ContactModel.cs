using System.ComponentModel.DataAnnotations;

namespace RiseCase.Models
{
    public class ContactModel
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Company { get; set; }

        public List<ContactInfoModel> ContactInfos { get; set; }

        public bool IsActive { get; set; }
    }
}
