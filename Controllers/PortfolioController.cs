    using Microsoft.AspNetCore.Mvc;
    namespace Portfolio.Controllers     //be sure to use your own project's namespace!
    {
        public class PortfolioController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("")]     //associated route string (exclude the leading /)
            public IActionResult Index()
            {
                return View(); // View() method w/o arguments passed uses the  IActionResult method name for the view
            }
            [HttpGet]       //type of request
            [Route("projects")]     //associated route string (exclude the leading /)
            public IActionResult Projects()
            {
                return View();
            }
            [HttpGet]       //type of request
            [Route("contact")]     //associated route string (exclude the leading /)
            public IActionResult Contact()
            {
                return View();
            }
        }
    }