using System.ServiceModel;

namespace WCFServer
{
    [ServiceContract]
    interface IHelloWorld
    {
        [OperationContract]
        string Hello();
    }
}
