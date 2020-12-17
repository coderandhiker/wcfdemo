using System.ServiceModel;

namespace CoderandhikerWcfTest
{
    [ServiceContract]
    public interface IAddressService
    {
        [OperationContract]
        Address[] GetAllAddresses();

        [OperationContract]
        Address GetAddress(int addressId);
    }
}
