namespace Mailer.Domain.Models
{
    public class Template
    {
        public string FromName { get; set; }
        public string FromAddress { get; set; }
        public string Subscriptionkey { get; set; }

        public string TemplateId { get; set; }

        public string TemplateType { get; set; }
    }
}