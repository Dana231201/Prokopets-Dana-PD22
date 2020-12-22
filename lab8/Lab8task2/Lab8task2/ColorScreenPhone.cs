using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8task2
{
    class ColorScreenPhone : BlackWhitePhone
    {
        public bool wifi = true;
        public override void Call()
        {
            Console.WriteLine("Могу звонить тому, на кого вы нажимаете.");
        }
        public override void RingTone()
        {
            Console.WriteLine("Воспроизводит песню");
        }
        public virtual void SurfTheNet()
        {
            Console.WriteLine("Я могу путешествовать по Интернету с помощью Wi-Fi");
        }

    }
}
