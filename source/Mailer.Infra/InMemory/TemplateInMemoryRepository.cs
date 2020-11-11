using System.Collections.Generic;
using Mailer.Domain.Contracts;
using Mailer.Domain.Models;

namespace Mailer.Infra.InMemory
{
    internal class TemplateInMemoryRepository : ITemplateRepository
    {
        public IEnumerable<Template> GetTemplateByIdAndCatalogId(string templateId, int catalogId)
        {
            var list = new List<Template>();

        #region ['list templates']

            list.Add(new Template {
                FromName = "Grupo LTM",
                FromAddress = "no-reply@grupoltm.com.br",
                SubscriptionTemplateId = "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"
            });

            list.Add(new Template {
                FromName = "Grupo LTM",
                FromAddress = "no-reply@grupoltm.com.br",
                SubscriptionTemplateId = "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"
            });

        #endregion
            
            return list;
        }
    }
}