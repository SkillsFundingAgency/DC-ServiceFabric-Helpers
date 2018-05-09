using Microsoft.ServiceFabric.Services.Remoting.V2;

namespace ESFA.DC.ServiceFabric.Helpers.RemotingSerialization
{
    internal class JsonMessageFactory : IServiceRemotingMessageBodyFactory
    {
        public IServiceRemotingRequestMessageBody CreateRequest(
            string interfaceName,
            string methodName,
            int numberOfParameters)
        {
            return new JsonRemotingRequestBody();
        }

        public IServiceRemotingResponseMessageBody CreateResponse(string interfaceName, string methodName)
        {
            return new JsonRemotingResponseBody();
        }
    }
}