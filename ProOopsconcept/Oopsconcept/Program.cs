using System;
using Oopsconcept.Inheritance;
using Oopsconcept.Interface;
using Oopsconcept.Incapsulation;
using Oopsconcept.classobject;
using Oopsconcept.Polymorphism.Methodoverloading;
using Oopsconcept.Polymorphism.Methodoverriding;
using Oopsconcept.Constructor;
using Oopsconcept.Pass_by_the_value_and_referance;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Oopsconcept
{ 


    internal class Program
{ 

        static void Main(string[] args)
        {
            /*
            Dog d = new Dog();
            d.display();
            //Tiger tiger= new Tiger();
            //tiger.AnimalSound();
            Pig p = new Pig();
            p.AnimalSound();
            p.Details();
            
            Account ac= new Account();
            ac.setbalance(-1000);
            ac.Getbalance();
            Rectangle r = new Rectangle();
            r.RectangleDetails();
            r.display();*/

            /* Dog1 pug = new Dog1();
             pug.age = 10;
             pug.breed = "pug";
             pug.color = "black";
             pug.size = 23;
             pug.Sleep();
             Console.WriteLine("pug details:age;{0},size;{1},color:{2},breed:{3}", pug.age, pug.size, pug.color, pug.breed);

             Dog1 puppy = new Dog1();
             puppy.age = 20;
             puppy.breed = "puppy";
             puppy.color = "white";
             puppy.size = 23;
             puppy.Sleep();
             Console.WriteLine("puppy details:age;{0},size;{1},color:{2},breed:{3}", puppy.age, puppy.size, puppy.color, puppy.breed);

             Dog1 moti = new Dog1();
             moti.age = 30;
             moti.breed = "moti";
             moti.color = "";
             moti.size = 23;
             moti.Sleep();
             Console.WriteLine("moti details:age;{0},size;{1},color:{2},breed:{3}", moti.age, moti.size, moti.color, moti.breed);
             */
            /*
            Console.WriteLine("method overloading....");
            Addition add = new Addition();
            add.SumOfNumbers(10, 20, 30);
            */
            /*
            Partimeemployee part = new Partimeemployee();
            part.GetSalary();
            */
            /*
            Employee1 emp = new Employee1();
            */
            /*
            Employee12 e = new Employee12(101, "ronit", 50000);
            e.Display();
            */
            /*
            PassByValue.Test();
            
            PassByReferance.TestReferenceType();
            */
            ArrayMultiplication.GetArrrayMultiplication();
            Console.ReadLine();

         

        }
    }
}
