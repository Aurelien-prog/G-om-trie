﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_géométrie
{
    class ClasseCalcul
    {
        protected int UneValeur;

        protected int Init()
        {
            UneValeur = new Random().Next(1, 15);
            return UneValeur;
        }

        protected int Addition(int val1, int val2)
        {
            int res = val1 + val2;
            return res;
        }

        protected int Multiplication(int val1, int val2)
        {
            int res = val1 * val2;
            return res;
        }
    }
}