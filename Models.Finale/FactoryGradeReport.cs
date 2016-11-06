﻿using System;
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

            creators[0] = new ID();
            creators[1] = new Name();
            creators[2] = new Grade();

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
    abstract class Student
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class ID : Student
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class Name : Student
    {
    }
    class Grade : Student
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
    class ID : Creator
    {
        public override Product FactoryMethod()
        {
            return new ID();
        }
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
    class Grade : Creator
    {
        public override Product FactoryMethod()
        {
            return new Grade();
        }
    }
}

