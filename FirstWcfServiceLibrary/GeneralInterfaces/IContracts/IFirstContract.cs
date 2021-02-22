using System.ServiceModel;

namespace GeneralInterfaces.IContracts
{

    /// <summary>
    /// Интерфейс первого контракта.
    /// </summary>   
    [ServiceContract]
    public interface IFirstContract : IContractable
    {
        /// <summary>
        /// Обработка полученных строковых данных
        /// </summary>
        /// <param name="value">Строковые данные</param>
        /// <returns>Результат обработки строковых данных</returns>
        [OperationContract]
        string GetData(string value);
    }
}
