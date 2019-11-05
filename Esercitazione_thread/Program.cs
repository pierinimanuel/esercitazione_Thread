using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Esercitazione_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread myThread = new Thread(() =>
            //{
            //    Console.WriteLine("MyThread è iniziato");
            //    Thread.Sleep(1000);
            //    Console.WriteLine("MyThread è terminato");
            //});

            ////esecuzione di myThread
            //myThread.Start();
            //Thread.Sleep(500);
            //Console.WriteLine("Main Thread");

            string someVariable = "Manuel Pierini";
            var WorkerThread = new Thread((o) =>
            {
                Console.WriteLine("Saluti da: {0}", 0);
            });

            WorkerThread.Start(someVariable);
        }

       
    }
}
