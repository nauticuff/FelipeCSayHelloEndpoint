/*
Carlos Felipe
10/25/22
Say Hello - Endpoint
CODE: This code takes in a user's name through URL input and then displays it
Peer review by: Andrew Nilsson - Inputs work well. Really cool that you can enter the inputs inside the web browser. I like the extra fun parts of the string that is returned.
*/

using Microsoft.AspNetCore.Mvc;

namespace FelipeCSayHelloEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
    public string Instructions(){
        return "Type in https://localhost:7186/sayhello/greet/(Your Name)";
    }

    [HttpGet]
    [Route("Greet/{name}")]
    public string Greet(string name){
        return $"Hello {name} nice to meet you. Nice weather we are having huh. It looks to be pretty cool today with and average of 72 degrees farenheit. Okay goodbye now!.";
    }
}
