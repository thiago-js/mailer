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
        
        public IEnumerable<Template> GetTemplateByIdAndCatalogId(string templateId, int catalogId)
        {
            const string query = @"select t.FromName,
                                          t.FromAddress,
                                          tvp.PartnerAuthClientSecret
                                    from tb_template t
                                            inner join TB_TemplateVendorProvider tvp on t.TemplateVendorProviderId = tvp.Id
                                    where t.TemplateProviderId = '@templateId'
                                      and ProjectConfigurationId = @catalogId";
            
            using (var conn = new SqlConnection(_connectionString.Value))  
            {
                return conn.Query<Template>(query);
            }
        }
    }
}