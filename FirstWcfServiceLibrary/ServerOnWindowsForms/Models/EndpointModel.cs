using System;
using System.ServiceModel.Channels;

namespace ServerWinForms.Models
{
    /// <summary>
    /// Модель конечной точки
    /// </summary>
    internal class EndpointModel
    {
        /// <summary>
        /// Адрес, где ожидать входящие сообщения 
        /// </summary>
        public Uri Adress { get; internal set; }

        /// <summary>
        /// Указание привязки, как обмениваться сообщениями
        /// </summary>
        public Binding Binding { get; internal set; }

        /// <summary>
        /// Контракт
        /// </summary>
        public Type Contract { get; internal set; }


    }
}
