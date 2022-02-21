﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Classes.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public string Fly()
        {
            return "Хлооооп Хлооооп";
        }
    }
}

