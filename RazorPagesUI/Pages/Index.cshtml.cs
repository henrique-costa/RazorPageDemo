using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorPagesUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public PropostaRecebida Proposta { get; set; }

        [BindProperty]
        public string JsonPropost { get; set; }
        [BindProperty]
        public int versaoPropost { get; set; }
        [BindProperty]
        public string tituloPropost { get; set; }

       

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost(string JsonPropost, int versaoPropost, string tituloPropost)
        {
            ViewData["confirmation"] = $"{JsonPropost}, {versaoPropost}, {tituloPropost}";

            Console.WriteLine($"Passou {JsonPropost}, {versaoPropost}, {tituloPropost}");
        }

        public async Task<IActionResult> OnPostRegisterAsync()
        {

                       //…
            return RedirectToPage("/Privacy");
        }
        public async Task<IActionResult> OnPostRequestInfo()
        {
            //…
            return RedirectToPage();
        }
    }
}
