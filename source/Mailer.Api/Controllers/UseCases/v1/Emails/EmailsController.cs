using System.Threading.Tasks;
using Mailer.Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace Mailer.Api.Controllers
{
    [ApiController]
    [Route("v1/Email")]
    public class EmailsController : ControllerBase
    {
        private readonly ISendMail _sendMail;

        public EmailsController(ISendMail sendMail)
        {
            _sendMail = sendMail;
        }

        [HttpGet]
        public Task<bool> getMail()
        {
            return Task.FromResult(true);
        }

        [HttpPost]
        public Task<bool> SendMail(SendMailInput sendMailInput)
        {
            return _sendMail.Execute(sendMailInput);
        }
    }
}
