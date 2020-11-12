using System.Collections.Generic;

namespace Mailer.Application.UseCases
{
    public class TemplateMailInput
    {
        public string TemplateId { get; set; }

        public int CatalogId { get; set; }
    } 
}