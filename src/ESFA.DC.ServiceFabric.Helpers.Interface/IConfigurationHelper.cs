using System;

namespace ESFA.DC.ServiceFabric.Helpers.Interface
{
    public interface IConfigurationHelper
    {
        T GetSectionValues<T>(string sectionName);
    }
}
