using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base
{
    public class SubscriptionInfo
    {
        //dışarıdan bize gönderilen verilerin tipini döndürür
        public Type HandlerType { get; }

        public SubscriptionInfo(Type handlerType)
        {
            HandlerType = handlerType ?? throw new ArgumentNullException(nameof(handlerType));
        }
        public static SubscriptionInfo Typed(Type handlerType)
        {
            return new SubscriptionInfo(handlerType);
        }
    }
}
