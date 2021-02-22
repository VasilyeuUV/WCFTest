using System;
using System.ServiceModel.Channels;

namespace ServerOnWindowsForms.Models
{
    /// <summary>
    /// Модель конечной точки
    /// </summary>
    internal class EndpointModel
    {
        /// <summary>
        /// Адрес, где ожидать входящие сообщения 
        /// </summary>
        public Uri Uri { get; internal set; }

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
