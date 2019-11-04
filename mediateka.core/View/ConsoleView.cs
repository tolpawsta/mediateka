﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediateka.View
{
    class ConsoleView : IView
    {
        public void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}
