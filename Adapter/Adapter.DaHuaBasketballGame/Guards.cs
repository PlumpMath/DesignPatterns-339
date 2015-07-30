﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.DaHuaBasketballGame
{
    class Guards : Player
    {
        public Guards(string name)
            : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine("後衛 {0} 進攻", name);
        }

        public override void Defense()
        {
            Console.WriteLine("後衛 {0} 防守", name);
        }
    }
}
