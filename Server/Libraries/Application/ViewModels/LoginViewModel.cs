using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [JsonProperty(PropertyName = "ReturnUrl")]
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember me?")]
        [JsonProperty(PropertyName = "RememberMe")]
        public bool RememberMe { get; set; }
    }
}
