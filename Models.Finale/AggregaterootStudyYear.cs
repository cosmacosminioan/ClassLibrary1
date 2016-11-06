using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Finale
{
    class Aggregate
    {
         public PlainText name { get; set; }
         public List<Credits> credits { get; set; }
         public Professor.Professor professor { get; set; }
         public List<Proportion> activityProportion { get; set; }
         public EvaluationType evaluation { get; set; }
    }

    class Credits 
    {
        public int  Credits1{ get; set;}
        public int  Type1 {get; set;}
    }
  
    class Proportion 
    {
        public string  Proportion1{get;set;} 
        public string Type2 {get;set;}
    }
   
    
    Aggregate aggre= new Aggregate();
    Console.WriteLine(aggre.Name);
    Console.WriteLine(aggre.Professor);
     Console.WriteLine(aggre.Evaluation);

    Credits Credits1 = new Credit();
    Console.WriteLine(Credits1.Credits1);
     Console.WriteLine(Credits1.Type);

    Credits Credits2 = new Credit();
    Console.WriteLine(Credits2.Credits1);
     Console.WriteLine(Credits2.Type);


    Proportion Proportion1= new Proportion();
    Console.WriteLine(Proportion1.Proportion1);
    Console.WriteLine(Proportion1.Type1);
    
    Proportion Proportion2= new Proportion();
    Console.WriteLine(Proportion2.Proportion1);
    Console.WriteLine(Proportion2.Type1);

   

    class Aggregate
    {
        private List<Credits> _Credits;

        public void Add(Credits obj)
        {
        int aggre=0;
        foreach (Credits t in _Credits)
    {
        if (t.Type1 =="60")
        {
            Aggre++;
            if ((Aggregate >1 ) 
            {
                throw new Exception(" Only one value of the credit is allowed");
            }
        }
        }
            _Credits.Add(obj);
        }
        public IEnumerable<Credits> Credits 
        {
            get { return _Credits;} 
        }

        private List<Proportion> _ActivityProportion;

        public void Add(Proportion obj)
        {
        int aggre=0;
        foreach (Proportion t in _ActivityProportion)
    {
        if (t.Type2 =="100")
        {
            Aggre++;
            if ((Aggregate >1 ) 
            {
                throw new Exception(" Only one value of the proportion is allowed");
            }
        }
        }
            _ActivityProportion.Add(obj);
        }
        public IEnumerable<Credits> Credits 
        {
            get { return _ActivityProportion;} 
        }
}
