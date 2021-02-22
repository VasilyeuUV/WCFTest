using GeneralInterfaces.IContracts;

namespace FirstServer.Services
{
    /// <summary>
    /// Первая реализаци сервиса WCF сервера
    /// </summary>
    internal class FirstWcfService : AWcfServiceBase, IFirstContract
    {
        #region IFirstContract

        public string GetData(string value)
        {
            return string.Format($"{Properties.strings.Welcome}: {value}");
        }

        #endregion // IFirstContract
    }
}
