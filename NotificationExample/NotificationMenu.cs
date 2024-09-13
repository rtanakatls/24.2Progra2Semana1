using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2.NotificationExample
{
    internal class NotificationMenu : Menu
    {
        public override void Execute()
        {
            NotificationHandler notificationHandler = new NotificationHandler();

            notificationHandler.Show(new TextNotification(), "Esta es una notificación");
            notificationHandler.Show(new ScoreNotification(), 10);

            List<string> list = new List<string>();

            list.Add("Pedro");
            list.Add("Pablo");
            list.Add("Vilma");
            list.Add("Betty");



            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Pedro");
            queue.Enqueue("Pablo");
            queue.Enqueue("Vilma");
            queue.Enqueue("Betty");

            bool continueFlag=true;
            while (continueFlag)
            {
                Console.WriteLine($"Hay {queue.Count} elementos en la cola. Introduce s para sacar un elemento de la cola y n para salir");

                switch (Console.ReadLine())
                {
                    case "s":
                        Console.WriteLine($"Sacaste a: {queue.Dequeue()}");
                        break;
                    case "n":
                        continueFlag = false;
                        break;
                }
            }

            Stack<string> stack = new Stack<string>();
            stack.Push("Pedro");
            stack.Push("Pablo");
            stack.Push("Vilma");
            stack.Push("Betty");

            continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine($"Hay {stack.Count} elementos en la pila. Introduce s para sacar un elemento de la pila y n para salir");

                switch (Console.ReadLine())
                {
                    case "s":
                        Console.WriteLine($"Sacaste a: {stack.Pop()}");
                        break;
                    case "n":
                        continueFlag = false;
                        break;
                }
            }

            Dictionary<string,string> dictionary = new Dictionary<string,string>();

            dictionary.Add("Pedro", "TLS");
            dictionary.Add("Pablo", "San Marcos");
            dictionary.Add("Vilma", "UNI");
            dictionary.Add("Betty", "Senati");

            Console.WriteLine(dictionary["Vilma"]);
        }
    }
}
