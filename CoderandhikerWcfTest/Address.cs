using System.Runtime.Serialization;

namespace CoderandhikerWcfTest
{
    [DataContract]
    public class Address
    {
        [DataMember] public int Id { get; set; }
        [DataMember] public string FirstName { get; set; }
        [DataMember] public string LastName { get; set; }        
        [DataMember] public string Address1 { get; set; }
        [DataMember] public string Address2 { get; set; }
        [DataMember] public string City { get; set; }
        [DataMember] public string State { get; set; }
        [DataMember] public string Email { get; set; }
    }
}