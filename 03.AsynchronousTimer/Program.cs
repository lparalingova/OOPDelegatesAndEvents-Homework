namespace _03.AsynchronousTimer
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            var async = new AsyncTimer(Console.WriteLine, 10, 1000, "Hellow world!");
            Console.WriteLine("Will print 10 times \"Hello world!\" with delay of 1000 ms:");
            async.Run();
        }
    }
}
