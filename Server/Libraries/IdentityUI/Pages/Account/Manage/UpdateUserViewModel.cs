using System.ComponentModel.DataAnnotations;

namespace IdentityUI.Pages.Account.Manage
{
    public partial class IndexModel
    {
        public class UpdateUserViewModel
        {
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }

            [Required]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }
        }
    }
}
