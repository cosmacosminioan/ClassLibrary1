﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    public class Credits
    {
        private const int _maxCredits = 60;
        public static int Max { return _maxCredits; }} 

    private int _credits;
    public int Count {get {return _credits;} set { _credits= value;} }

    public Credits()
{
}
    public Credits(int credits)
    {
        _credits=credits;
         }
    }
}
