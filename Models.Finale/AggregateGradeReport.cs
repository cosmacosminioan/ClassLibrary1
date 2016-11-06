using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Finale
{
    class Aggregate
    {
        public List<ID> ID { get; set;} 
         public PlainText Name { get; set; }
       public  List<Grade> Grade { get; set;} 
    }

    class ID
    {
        public int  ID1{ get; set;}
        public int  Type1 {get; set;}
    }
  
    class Grade  
    {
        public string  Grade1 {get;set;} 
        public string Type2 {get;set;}
    }
   
    
    Aggregate aggre= new Aggregate();
    Console.WriteLine(aggre.Name);

    ID ID1 = new ID();
    Console.WriteLine(ID1.ID1);
     Console.WriteLine(ID1.Type);

    ID ID2 = new ID();
    Console.WriteLine(ID2.ID1);
     Console.WriteLine(ID2.Type);


    Grade Grade1= new Grade();
    Console.WriteLine(Grade1.Grade1);
    Console.WriteLine(Grade1.Type1);
    
    Grade Grade2= new Grade();
    Console.WriteLine(Grade2.Grade1);
    Console.WriteLine(Grade2.Type1);

   

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

        private List<Grade> _Grade;

        public void Add(Grade obj)
        {
        int aggre=0;
        foreach (Grade t in _Grade)
    {
        if (t.Type2 =="100")
        {
            Aggre++;
            if ((Aggregate >1 ) 
            {
                throw new Exception(" Only one value of the grade is allowed");
            }
        }
        }
            _Grade.Add(obj);
        }
        public IEnumerable<Grade> Grade 
        {
            get { return _Grade;} 
        }
}