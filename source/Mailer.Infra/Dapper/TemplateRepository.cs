using Mailer.Domain.Contracts;
using Mailer.Domain.Models;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

namespace Mailer.Infra.Dapper
{
    internal class TemplateRepository : ITemplateRepository
    {
        private readonly ConnectionString _connectionString;  
  
        public TemplateRepository(ConnectionString connectionString)  
        {  
            _connectionString = connectionString;  
        }

        private string MounthQuery (string templateId, int catalogId) {
            var templateQuery = string.Empty;
            var catalogQuery = string.Empty;

            string query = @"select t.FromName,
                                    t.FromAddress,
                                    tvp.PartnerAuthClientSecret as Subscriptionkey,
                                    t.TemplateProviderId as TemplateId,
                                    tt.Description as TemplateType
                             from tb_template t
                                    inner join TB_TemplateVendorProvider tvp on t.TemplateVendorProviderId = tvp.Id
                                    inner join TB_TemplateType tt on t.TemplateTypeId = tt.Id
                             where ";

            if (!string.IsNullOrEmpty(templateId))
                templateQuery = string.Format("t.TemplateProviderId = '{0}'", templateId);
            
            if(catalogId > 0) 
                catalogQuery = string.Format("{0} ProjectConfigurationId = {1}", !string.IsNullOrEmpty(templateQuery) ? " and " : string.Empty, catalogId);

            return (query + templateQuery + catalogQuery);
        }

        public Template GetTemplatesByTemplateIdAndCatalogId(string templateId, int catalogId)
        {
            using (var conn = new SqlConnection(_connectionString.Value))  
            {
                return conn.QueryFirstOrDefault<Template>(MounthQuery(templateId, catalogId));
            }
        }

        public IEnumerable<Template> GetTemplatesByCatalogId(int catalogId)
        {
            using (var conn = new SqlConnection(_connectionString.Value))  
            {
                return conn.Query<Template>(MounthQuery(string.Empty, catalogId));
            }
        }
    }
}