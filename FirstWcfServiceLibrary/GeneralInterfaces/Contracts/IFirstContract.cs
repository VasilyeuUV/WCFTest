using System.ServiceModel;

namespace GeneralInterfaces.Contracts
{

    /// <summary>
    /// Интерфейс первого контракта
    /// </summary>
    public interface IFirstContract : IContractable
    {
        [OperationContract]
        string GetData(string value);
    }
}
