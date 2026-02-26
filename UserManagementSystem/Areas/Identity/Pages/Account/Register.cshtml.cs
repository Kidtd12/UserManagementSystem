using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using UserManagementSystem.Data;
using UserManagementSystem.Models;

namespace UserManagementSystem.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public RegisterModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            public string UserName { get; set; }

            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Required(ErrorMessage = "Please select a role")]
            public string Role { get; set; }
        }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            // Save user to database
            var user = new User
            {
                UserName = Input.UserName,
                Email = Input.Email,
                Password = Input.Password,
                Role = Input.Role
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return RedirectToPage("/Index"); // redirect after registration
        }
    }
}