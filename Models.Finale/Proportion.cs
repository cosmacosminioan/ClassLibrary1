using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
 {
     public class Proportion
     {
         private int _numerator;
         private int _denominator;
         public decimal Fraction { get { return _numerator / _denominator; } }
 
         public Proportion(int numerator, int denominator)
         {
             _numerator = numerator;
             _denominator = denominator;
         }
     }
 }
