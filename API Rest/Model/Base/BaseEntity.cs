using System.Runtime.Serialization;

namespace WebApplication1.Model.Base
{
    [DataContract]
    public class BaseEntity
    {
        public long? id { get; set; }
    }
}
