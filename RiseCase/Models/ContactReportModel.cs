using System.ComponentModel.DataAnnotations;

namespace RiseCase.Models
{
    public class ContactReportModel
    {

        [Key]
        public Guid Id { get; set; }
        public Dictionary<string, List<ContactModel>>? LocationInfo { get; set; }

        public Dictionary<string, int>? LocationRank { get; set; }

        public Tuple<string, int>? LocationContactCount { get; set; }

        public Tuple<string, int>? LocationContactPhoneNumberCount { get; set; }
    }
}
