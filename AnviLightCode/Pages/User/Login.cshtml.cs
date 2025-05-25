using AnviLightCode.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AnviLightCode.Pages.User
{
    public class LoginModel : PageModel
    {
        INguoiDungService _nguoiDungService;
        public LoginModel(INguoiDungService nguoiDungService)
        {
            _nguoiDungService = nguoiDungService;
        }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                ErrorMessage = "Vui lòng nhập đầy đủ email và mật khẩu.";
                return Page();
            }

            var user = (await _nguoiDungService.GetAllAsync())
                .Where(u => u.Email == Email && u.MatKhau == Password)
                .ToList();

            if (user == null)
            {
                ErrorMessage = "Email hoặc mật khẩu không chính xác.";
                return Page();
            }
            HttpContext.Session.SetString("UserId", user[0].MaNguoiDung.ToString());
            HttpContext.Session.SetString("UserName", user[0].HoTen);
            HttpContext.Session.SetString("UserEmail", user[0].Email);

            return RedirectToPage("/User/Home");
        }

    }
}
