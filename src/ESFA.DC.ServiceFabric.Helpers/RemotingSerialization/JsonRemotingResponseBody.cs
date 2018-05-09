using System;
using Microsoft.ServiceFabric.Services.Remoting.V2;

namespace ESFA.DC.ServiceFabric.Helpers.RemotingSerialization
{
    internal class JsonRemotingResponseBody : IServiceRemotingResponseMessageBody
    {
        public object Value;

        public void Set(object response)
        {
            this.Value = response;
        }

        public object Get(Type paramType)
        {
            return this.Value;
        }
    }
}