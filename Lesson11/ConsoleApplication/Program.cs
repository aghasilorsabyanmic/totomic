using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication.ServiceReference1;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWork();
            Console.WriteLine("Hello");
            Console.ReadKey();
        }

        public static async void DoWork()
        {
            Service1Client proxy = new Service1Client();
            Console.WriteLine(await proxy.GetDataAsync(5));
            var game = proxy.GetGameById(Guid.NewGuid().ToString());
            Console.WriteLine($"{game.UserId} - {game.Created}");
        }
    }
}
