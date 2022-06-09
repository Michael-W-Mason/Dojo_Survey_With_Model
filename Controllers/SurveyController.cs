using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;
namespace DojoSurvey.Controllers;
public class SurveyController : Controller
{
    [HttpGet("")]
    public ViewResult Home()
    {
        return View("Home");
    }

    [HttpPost("survey")]
    public IActionResult Result(Survey survey){
        
        return View("Result", survey);
    }
}

