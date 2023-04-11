
using Microsoft.AspNetCore.Mvc;


namespace Email_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailSenderController : ControllerBase
    {
        Email_Sender Email = new Email_Sender();

        [HttpPost("sendEmail/{email}/{status}")]
        public IActionResult SendEmail([FromRoute] string email, [FromRoute] int status)
        {
            Email.Email_Method(email, status);
            return Ok();
        }
    }
}


