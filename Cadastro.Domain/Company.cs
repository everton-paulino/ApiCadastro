using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain
{
    [BsonIgnoreExtraElements]
    public class Company
    {
        public Company()
        {
            Key = Guid.NewGuid().ToString();
            Registered = DateTime.Now;
            Updated = DateTime.Now;
            IsActive = true;
        }
        public string Key { get; set; }
        public DateTime Registered { get; set; }
        public DateTime Updated { get; set; }
        public bool IsActive { get; set; }
        public string CompanyName { get; set; }
    }
}
