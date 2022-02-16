using System;
using System.Threading;

namespace Show_Slow_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            Show_Message("Hello World",80);
            Console.ReadKey();
        }

        static void Show_Message(string Message = "This Is Test Message !",int Speed = 60)
        {
            for (int i = 0; i < Message.Length; i++)
            {
                Console.Write(Message[i]);
                Thread.Sleep(Speed);
            }
        }
    }
}
