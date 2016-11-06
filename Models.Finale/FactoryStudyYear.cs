using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoFactory.GangOfFour.Factory.Structural
{
    /// <summary>
    /// MainApp startup class for Structural 
    /// Factory Method Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // An array of creators
            Creator[] creators = new Creator[2];

            creators[0] = new Name();
            creators[1] = new Credits();
            creators[2] = new Professor();
            creators[3] = new ActivityProportion();
            creators[4] = new Evaluation();

            // Iterate over creators and create products
            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  product.GetType().Name);
            }

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Product' abstract class
    /// </summary>
    abstract class Deanship
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class Name : Deanship
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class Credits : Deanship
    {
    }
    class Professor : Deanship
    {
    }
    class ActivityProportion : Deanship
    {
    }
    class Evaluation : Deanship
    {
    }
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Name : Creator
    {
        public override Product FactoryMethod()
        {
            return new Name();
        }
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Credits : Creator
    {
        public override Product FactoryMethod()
        {
            return new Credits();
        }
    }
    class Professor : Creator
    {
        public override Product FactoryMethod()
        {
            return new Professor();
        }
    }
    class ActivityProportion : Creator
    {
        public override Product FactoryMethod()
        {
            return new ActivityProportion();
        }
    }
    class  Evaluation: Creator
    {
        public override Product FactoryMethod()
        {
            return new Evaluation();
        }
    }

}