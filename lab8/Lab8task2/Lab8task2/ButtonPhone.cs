using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8task2
{
    class ButtonPhone : DiskPhone
    {

        public bool Buttons = true;

        public override void Call()
        {
            Console.WriteLine("Hi! I can call someone using buttons and radio waves!");
        }

    }
}
