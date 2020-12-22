using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8task2
{
    class Siri : ColorScreenPhone
    {
        public int lenses = 2;

        public override void Call()
        {
            Console.WriteLine("Просто скажи");
        }
        public override void RingTone()
        {
            Console.WriteLine("Я не умею делать рингтон(");
        }
        public override void SurfTheNet()
        {
            Console.WriteLine("Скажи что тебе нужно в интернете");
        }

    }
}
