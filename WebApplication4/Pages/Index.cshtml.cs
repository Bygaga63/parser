using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication4.ViewModels;

namespace WebApplication4.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }
        public string IsError { get; set; }

        [BindProperty]
        public LinkViewModel LinkViewModel { get; set; }
        
        public void OnGet()
        {
            Message = "Запуск";
        }
        
        public void OnPost()
        {
            bool isUri = Uri.IsWellFormedUriString(LinkViewModel.Url, UriKind.RelativeOrAbsolute);
            if (isUri)
            {

            }
            else
            {
                IsError = "is-invalid";
            }
        }
    }
}