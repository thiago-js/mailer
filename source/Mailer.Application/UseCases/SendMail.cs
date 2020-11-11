using System.Threading.Tasks;
using Mailer.Domain.Contracts;

namespace Mailer.Application.UseCases
{
    internal class SendMail : ISendMail
    {
        private readonly ITemplateRepository _templateRepository;
        public SendMail(ITemplateRepository templateRepository)
        {
            _templateRepository = templateRepository;
        }

        public Task<bool> Execute(SendMailInput request)
        {
            var response = _templateRepository.GetTemplateByIdAndCatalogId(request.TemplateId, request.CatalogId);
            
            // TODO: enviar e-mail
            return Task.FromResult(true);
        }
    }
}