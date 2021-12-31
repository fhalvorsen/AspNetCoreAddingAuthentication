using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WishList.Models;

namespace WishList.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> UserManager, SignInManager<ApplicationUser> SignInManager)
        {
            _userManager = UserManager;
            _signInManager = SignInManager;
        }
        
        // GET
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
