using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2.NotificationExample
{
    internal class TextNotification : INotification<string>
    {
        public void Show(string message)
        {
            Console.WriteLine($"Notificación: {message}");
        }
    }
}
