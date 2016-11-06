using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Finale
{
    class Aggregate
    {
         public List<ID> ID { get; set; } 
         public PlainText name { get; set; }
         public List<activityGrade> activityGrade { get; set;} 
         public  int examAverage { get; set;}
    } 

    class ID 
    {
        public int  ID1{ get; set;}
        public int  Type {get; set;}
    }
  
    class activityGrade 
    {
        public string  activityGrade1{get;set;} 
        public string Type {get;set;}
    }
   

  
    
    Aggregate aggre= new Aggregate();
    Console.WriteLine(aggre.Name);
     Console.WriteLine(aggre.examAverage);

    ID ID1 = new ID();
    Console.WriteLine(ID1.ID1);
     Console.WriteLine(ID1.Type);

    ID ID2 = new ID();
    Console.WriteLine(ID2.ID1);
     Console.WriteLine(ID2.Type);

     activityGrade activityGrade1= new activityGrade();
    Console.WriteLine(activityGrade1.activityGrade1);
    Console.WriteLine(activityGrade1.Type1)
   
    activityGrade activityGrade2= new activityGrade();
    Console.WriteLine(activityGrade2.activityGrade1);
    Console.WriteLine(activityGrade2.Type1);

    
      class Aggregate
    {
        private List<ID> _ID;

        public void Add(ID obj)
        {
        int aggre=0;
        foreach (ID t in _ID)
    {
        if (t.Type1 =="1")
        {
            Aggre++;
            if ((Aggregate >1 ) 
            {
                throw new Exception(" Only one value of the ID is allowed");
            }
        }
        }
            _ID.Add(obj);
        }
        public IEnumerable<ID> ID
        {
            get { return _ID;} 
        }

        private List<activityGrade> _activityGrade;

        public void Add(activityGrade obj)
        {
        int aggre=0;
        foreach (activityGrade t in _activityGrade)
    {
        if (t.Type2 =="100")
        {
            Aggre++;
            if ((Aggregate >1 ) 
            {
                throw new Exception(" Only one value of the activityGrade is allowed");
            }
        }
        }
            _Grade.Add(obj);
        }
        public IEnumerable<activityGrade> activityGrade 
        {
            get { return _activityGrade;} 
        }
}
   