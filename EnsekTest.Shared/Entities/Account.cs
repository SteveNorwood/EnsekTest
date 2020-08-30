using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EnsekTest.Shared.Entities
{
    public class Account
    {
        [DisplayName("Account Id")]
        public int Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
    }
}
