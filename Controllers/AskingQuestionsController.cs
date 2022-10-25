using Microsoft.AspNetCore.Mvc;

namespace JohnsonRAskingQuestionsEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AskingQuestionsController : ControllerBase
{
    [HttpGet]
    [Route("Asking/{name}/{time}")]

    public string AskingQuestions(string name, string time)
    {
        return $"So, your name is {name}, and you woke up at {time} this morning. \nHopefully you had enough sleep.";
    }
}
