using System.Collections.Generic;
using Mailer.Domain.Models;

namespace Mailer.Domain.Contracts
{
    public interface ITemplateRepository
    {
        IEnumerable<Template> GetTemplateByIdAndCatalogId(string templateId, int catalogId);
    }
}