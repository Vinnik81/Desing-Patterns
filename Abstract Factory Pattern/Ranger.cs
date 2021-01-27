﻿using System;

namespace Abstract_Factory_Pattern
{
    public abstract class Ranger : Unit
    {
        public override void Attack(Unit target)
        {
            target.HP -= Damage;
            Console.WriteLine("Range attack");
        }
    }
}