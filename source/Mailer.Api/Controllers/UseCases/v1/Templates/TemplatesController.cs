using System.Collections.Generic;
using System.Threading.Tasks;
using Mailer.Application.UseCases;
using Mailer.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mailer.Api.Controllers
{
    [ApiController]
    [Route("v1/template")]
    public class TemplatesController : ControllerBase
    {
        private readonly ITemplateMail _templateMail;

        public TemplatesController(ITemplateMail templateMail)
        {
            _templateMail = templateMail;
        }

        [HttpGet]
        [Route("{catalogId}/{templateId}")]
        public Task<Template> getTemplate([FromQuery] int catalogId, string templateId)
        {
            return _templateMail.GetTemplateByTemplateIdAndCatalogId(templateId, catalogId);
        }

        [HttpGet]
        [Route("{catalogId}")]
        public Task<List<Template>> getTemplates(int catalogId)
        {
            return _templateMail.GetTemplatesByCatalogId(catalogId);
        }
    }
}
