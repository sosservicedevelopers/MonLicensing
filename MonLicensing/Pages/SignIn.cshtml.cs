using MonLicensing.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace MonLicensing.Pages
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(SignInManager<ApplicationUser> signInManager,
            ILogger<LoginModel> logger,
            UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        //[BindProperty]
        //public InputModel Input { get; set; }

        //public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        //[TempData]
        //public string ErrorMessage { get; set; }

        //public class InputModel
        //{
        //    [Required]
        //    [EmailAddress]
        //    [Display(Name ="Пользователь")]
        //    public string Email { get; set; }

        //    [Required]
        //    [Display(Name = "Пароль")]
        //    [DataType(DataType.Password)]
        //    public string Password { get; set; }

        //    [Display(Name = "Remember me?")]
        //    public bool RememberMe { get; set; }
        //}

      //  public async Task OnGetAsync(string Email, string Password)
        public async Task<IActionResult> OnGetAsync(string Email, string Password)
        {

            string returnUrl = Url.Content("~/");

            //if (ModelState.IsValid)
            if (!string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password))
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Email, Password, false, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    return LocalRedirect(returnUrl);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return LocalRedirect("/Login/Invalid login attempt!");
                    //return LocalRedirect("/Login/jkl;m;l!");
                }

            }
                // If we got this far, something failed, redisplay form
                return Page();
            }
        }
  }

