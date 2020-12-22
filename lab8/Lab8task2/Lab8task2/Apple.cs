using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8task2
{
    class Apple : ColorScreenPhone
    {
        public override void Call()
        {
            Console.WriteLine("Позвоните кому-нибудь");
        }
        public override void RingTone()
        {
            Console.WriteLine("Играет рингтон Айфона");
        }
        public override void SurfTheNet()
        {
            Console.WriteLine("Используйте вай фай для просмотра чего нибудь");
        }
    }
}
