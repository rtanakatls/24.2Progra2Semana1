using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2.NotificationExample
{
    internal interface INotification<T>
    {
        void Show(T message);
    }
}
