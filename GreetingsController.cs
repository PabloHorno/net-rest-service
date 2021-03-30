using Microsoft.AspNetCore.Mvc;
using net_rest_service.Model;

namespace net_rest_service
{
    [Route("/greetings")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        private int counter;

        [HttpGet]
        public Greetings GetGreetings(string name = "Wolrd!")
        {
            return new Greetings(counter++, name);
        }
    }
}
