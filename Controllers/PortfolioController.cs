using Microsoft.AspNetCore.Mvc;
namespace Portfolio
{
    public class PortfolioController : Controller
    {
        [HttpGet]
        [Route("")]
        public string index()
        {
            return "This is my index";
        }
        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my projects";
        }
        [HttpGet("contacts")]
        public string Contacts()
        {
            return "This is my Contact";
        }
    }
}