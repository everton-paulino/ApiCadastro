using MongoDB.Bson.Serialization.Attributes;

namespace Cadastro.Domain
{
    [BsonIgnoreExtraElements]
    public class Employee    {
        
        public Employee()
        {
            Key = Guid.NewGuid().ToString();
            Registered = DateTime.Now;
            Updated = DateTime.Now;
            IsActive = true;
            Company = new Company();
                
        }
        public string Key { get; set; }
        public DateTime Registered { get; set; }
        public DateTime Updated { get; set; }
        public bool IsActive { get; set; }
        public string CompleteName { get; set; }
        public string Function { get; set; }
        public string Session { get; set; }
        public Company Company { get; set; }
    }
}