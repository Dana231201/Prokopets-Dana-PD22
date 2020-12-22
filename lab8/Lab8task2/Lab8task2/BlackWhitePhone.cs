using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8task2
{
    class BlackWhitePhone : ButtonPhone
    {

        public bool display = true;
        public override void Call()
        {
          Console.WriteLine("Привет! Могу позвонить кому-нибудь с помощью дисплея!");
        }

        public override void RingTone()
        {
            Console.WriteLine("Играет рингтон Prestigio");
        }
    }
}
