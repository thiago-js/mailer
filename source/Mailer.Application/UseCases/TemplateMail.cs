using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mailer.Domain.Contracts;
using Mailer.Domain.Models;

namespace Mailer.Application.UseCases
{
    internal sealed class TemplateMail : ITemplateMail
    {
        private readonly ITemplateRepository _templateRepository;
        public TemplateMail(ITemplateRepository templateRepository)
        {
            _templateRepository = templateRepository;
        }

        public Task<bool> Execute(TemplateMailInput request)
        {
            // TODO: enviar e-mail
            return Task.FromResult(true);
        }

        public Task<Template> GetTemplateByTemplateIdAndCatalogId(string templateId, int catalogId)
        {
            return Task.FromResult(_templateRepository.GetTemplatesByTemplateIdAndCatalogId(templateId, catalogId));
        }

        public Task<List<Template>> GetTemplatesByCatalogId(int catalogId)
        {
            return Task.FromResult(_templateRepository.GetTemplatesByCatalogId(catalogId).ToList());
        }
    }
}