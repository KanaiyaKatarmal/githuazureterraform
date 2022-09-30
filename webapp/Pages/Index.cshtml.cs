using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webapp.Pages
{
    public class IndexModel : PageModel
    {
        public  ILogger<IndexModel> _logger;
		public bool ShowRequestId;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
		
		public void testmethod()
        {

        }
    }
}