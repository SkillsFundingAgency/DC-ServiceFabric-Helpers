namespace ESFA.DC.ServiceFabric.Helpers.Interfaces
{
    public interface IConfigurationHelper
    {
        T GetSectionValues<T>(string sectionName);
    }
}
