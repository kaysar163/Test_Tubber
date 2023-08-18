namespace ConsoleApp48
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "main thread";

            Thread thread1 = new Thread(()=> CountDown("TIMER #1"));
            Thread thread2 = new Thread(() => CountUp("TIMER #2"));
            thread1.Start();
            thread2.Start();



            Console.WriteLine(mainThread.Name + "is complete!");

            Console.ReadLine();
        }
        public static void CountDown(String name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("timer #1" + i + "seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("timer #1 is complete!");
        }
        public static void CountUp(String name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("timer #2" + i + "seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("timer #2 is complete!");
        }
    }
}

