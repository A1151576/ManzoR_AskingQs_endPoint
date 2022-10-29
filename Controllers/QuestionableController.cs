/*
Rafael Manzo
Asking Questions End point API
10/25/2022
Peer Rview: Arely - Rafeeal's program works as needed. When i enter my name and timei woke up its spit out on the respond sectioof postman. I also liked how he had a try parse within time input. 
*/
using Microsoft.AspNetCore.Mvc;

namespace ManzoR_AskingQs_endPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class questionableController : ControllerBase
{
    [HttpGet]
    [Route("AskingQs/{name}/{time}")]
    //need to create a function or method
    public string questionable(string name, string time)
    {
        //what do we need within our method to terminate  ... return
        //return "Program where we ask the user some questions, like what time they woke up";
        return $"Hello, {name} You woke up at {int.Parse(time)}";


    }
}
