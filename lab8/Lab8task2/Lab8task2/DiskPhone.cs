using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8task2
{
    class DiskPhone
    {
        public bool calls = true;
        public int numOfDigits = 10;

        public virtual void Call()
        {
            Console.WriteLine("Привет , могу звонить с помощью кабеля и диска!");
        }

        public virtual void RingTone()
        {
            Console.WriteLine("Рингтон");
        }
    }
}
