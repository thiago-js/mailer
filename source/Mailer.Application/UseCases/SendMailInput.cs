using System.Collections.Generic;

namespace Mailer.Application.UseCases
{
    public class SendMailInput
    {
        public MailAddress  To { get; set; }
        public string TemplateId { get; set; }

        public int CatalogId { get; set; }
        public Dictionary<string, string> BodyProperties { get; set; }
    } 

    public class MailAddress
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}