using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using System.ComponentModel.DataAnnotations;

namespace Pim8.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credential Credential { get; set; }
        public void OnGet()
        {
        }

        public void OnPost() { }
    }

    public class Credential
    {
        [Required(ErrorMessage = "Login incorreto ou inv�lido.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Senha incorreta ou inv�lida.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
