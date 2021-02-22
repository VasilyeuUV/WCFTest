using ServerWinForms.Contracts;

namespace ServerWinForms.Services
{
    /// <summary>
    /// Первая реализаци сервиса WCF сервера
    /// </summary>
    internal class FirstWcfService : IContract
    {
        #region IContract

        public string GetData(string value)
        {
            return string.Format($"{Properties.Resources.Welcome}: {value}");
        }

        #endregion // IContract
    }
}
