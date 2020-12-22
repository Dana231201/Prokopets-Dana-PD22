using System;

namespace Lab8task2
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Disk Phone");
                DiskPhone dp = new DiskPhone();
                dp.Call();
                Console.WriteLine();

                Console.WriteLine("Button Phone");
                ButtonPhone nokia = new ButtonPhone();
                nokia.RingTone();
                Console.WriteLine();

                Console.WriteLine("Black White Phone");
                BlackWhitePhone Prestigio = new BlackWhitePhone();
                Prestigio.Call();
                Prestigio.RingTone();
                Console.WriteLine();

                Console.WriteLine("Color Phone");
                ColorScreenPhone smsg = new ColorScreenPhone();
                smsg.Call();
                smsg.SurfTheNet();
                Console.WriteLine();

                Console.WriteLine("Apple");
                Apple iPhonetwelve = new Apple();
                iPhonetwelve.Call();
                iPhonetwelve.SurfTheNet();
                Console.WriteLine();

                Console.WriteLine("Siri");
                Siri Siri = new Siri();
                Siri.Call();
                Siri.RingTone();
                Siri.SurfTheNet();
        }
    }
}
