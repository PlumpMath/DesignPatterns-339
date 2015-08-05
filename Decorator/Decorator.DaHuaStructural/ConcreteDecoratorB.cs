﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DaHuaStructural
{
    class ConcreteDecoratorB: Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("具體裝飾物件B的操作");
        }

        private void AddedBehavior()
        {

        }
    }
}
