using System;

namespace CSharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail =1 ,
        RegisteredAirmail =2 ,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            //USING ENUMS
            var method = (int) ShippingMethod.Express;
            Console.WriteLine("Here is the enum " + method);

            var methodId = 2;
            Console.WriteLine((ShippingMethod)methodId + "\n");
            //convertign the int to a string
            Console.WriteLine(method.ToString());

            var methodName = "Express";
            //convert into an enum type
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            //STRINGS
            var firstName = "Own";
            var lastName = "Something";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3]{"John", "Jack", "Mary"};
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(fullName);
            Console.WriteLine('\n');
            Console.WriteLine(myFullName);
            Console.WriteLine('\n');
            Console.WriteLine(formattedNames);
            Console.WriteLine('\n');

            var text = @"Hi John
                        Look into this path
                        c:\folder1\folder2";
            Console.WriteLine(text);

            //REFERENCE TYPES ABD VALUE TYPES

            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));


            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person()
            {
                Age = 20
            };
            MakeOld(person);
            Console.WriteLine("his age now is " + person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
