using System.Collections.Generic;
using System.Threading.Tasks;
using Mailer.Domain.Contracts;
using Mailer.Domain.Models;

namespace Mailer.Application.UseCases
{
    public interface ITemplateMail: IUseCase<TemplateMailInput, bool> {
        Task<List<Template>> GetTemplatesByCatalogId(int catalogId);
        Task<Template> GetTemplateByTemplateIdAndCatalogId(string templateId, int catalogId);
    }
}