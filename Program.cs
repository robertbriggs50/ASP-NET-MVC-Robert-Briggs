using MyLibrary;
using System;

namespace CertificationTrainingOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            var customer = new Customer();
            customer.customerId = 10;

            ICalculate function = new MultiplyCalculate();


            var result = function.performCal(10, 10);



            MyObject myObject = new MyLibrary.MyObject();
            MySecondaryLibrary.MyObject myObject2 =new MySecondaryLibrary.MyObject(10,10);



            myObject.Calculate(10, 10);
            myObject.number1 = 10;
            myObject.number2 = 5;

           Console.WriteLine("object1 property is " + myObject.number3);
            Console.WriteLine("object2 property is " + myObject2.number3);

            Console.ReadLine();
        }
    }


    
}
