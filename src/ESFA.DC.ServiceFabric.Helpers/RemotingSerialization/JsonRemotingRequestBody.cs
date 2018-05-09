using System;
using System.Collections.Generic;
using Microsoft.ServiceFabric.Services.Remoting.V2;

namespace ESFA.DC.ServiceFabric.Helpers.RemotingSerialization
{
    internal class JsonRemotingRequestBody : IServiceRemotingRequestMessageBody
    {
        public readonly Dictionary<string, object> parameters = new Dictionary<string, object>();

        public void SetParameter(int position, string parameName, object parameter)
        {
            this.parameters[parameName] = parameter;
        }

        public object GetParameter(int position, string parameName, Type paramType)
        {
            return this.parameters[parameName];
        }
    }
}