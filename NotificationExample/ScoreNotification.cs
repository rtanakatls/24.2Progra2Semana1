using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2.NotificationExample
{
    internal class ScoreNotification : INotification<int>
    {
        public void Show(int message)
        {
            Console.WriteLine($"Puntaje: {message}");
        }
    }
}
