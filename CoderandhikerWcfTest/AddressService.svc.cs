using FizzWare.NBuilder;
using System.Linq;

namespace CoderandhikerWcfTest
{
    public class AddressService : IAddressService
    {
        public Address GetAddress(int addressId)
        {
            var address = Builder<Address>.CreateNew().Build();
            address.Id = addressId;
            return address;
        }

        public Address[] GetAllAddresses()
        {
            return Builder<Address>.CreateListOfSize(100).Build().ToArray();
        }
    }
}
