using GeneralInterfaces.IContracts;
using System.ServiceModel;

namespace ServerWinForms.Contracts
{
    /// <summary>
    /// Контракт на сервере
    /// </summary>
    [ServiceContract]
    internal interface IContract : IFirstContract
    {
    }
}
