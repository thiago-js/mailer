using System.Collections.Generic;
using Mailer.Domain.Models;

namespace Mailer.Domain.Contracts
{
    public interface ITemplateRepository
    {
        Template GetTemplatesByTemplateIdAndCatalogId(string templateId, int catalogId);

        IEnumerable<Template> GetTemplatesByCatalogId(int catalogId);
    }
}