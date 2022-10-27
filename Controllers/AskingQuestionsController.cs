// Richard Johnson
// 10-25-22
// This API will take the name and time the user typed into the URL, and save them as strings so they can be printed on the screen
// Peer Review: Marcel R. Program ran smooth, took two strings as name and time and output a message saying the name and time woke up. It also had a nice message :)

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
