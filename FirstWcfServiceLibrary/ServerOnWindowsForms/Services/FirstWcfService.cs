using GeneralInterfaces.IContracts;

namespace ServerWinForms.Services
{
    /// <summary>
    /// Первая реализаци сервиса WCF сервера
    /// </summary>
    internal class FirstWcfService : AWcfServiceBase, IFirstContract
    {
        #region IFirstContract

        public string GetData(string value)
        {
            return string.Format($"{Properties.Resources.Welcome}: {value}");
        }

        #endregion // IFirstContract
    }
}
