using System;
using System.Threading.Tasks;
using Halibut.Transport.Protocol;

namespace Halibut.Transport
{
    public interface ISecureClient
    {
        ServiceEndPoint ServiceEndpoint { get; }
        Task ExecuteTransaction(Func<MessageExchangeProtocol, Task> protocolHandler);
    }
}