>using System;

namespace Program
{
    class main
    {
        static void Main(string[] args)
        {
            // Create an object
            constructor1 obj1 = new constructor1();
            Console.WriteLine("Contruct type1 : " + obj1.Name);
            Console.WriteLine();

            constructor2 obj2 = new constructor2("Bosco");
            Console.WriteLine("Contruct type2 : " + obj2.Name);
            Console.WriteLine();

            constructor3 obj3 = new constructor3("Tamil", 3000, "Tamil Nadu");
            Console.WriteLine("Contruct type3 Name : " + obj3.Name);
            Console.WriteLine("Contruct type3 Age : " + obj3.age);
            Console.WriteLine("Contruct type3 Location : " + obj3.location);
            Console.WriteLine();

            constructor4 obj4 = new constructor4();
            obj4.Name = "Kanya Kumari";
            obj4.age = 50;
            obj4.location = "South India";
            Console.WriteLine("Contruct type4 Name : " + obj4.Name);
            Console.WriteLine("Contruct type4 Age : " + obj4.age);
            Console.WriteLine("Contruct type4 Location : " + obj4.location);
            Console.WriteLine();

            constructor4 obj44 = new constructor4("Malayalam", 2000, "Kerala");
            Console.WriteLine("Contruct type4 Name : " + obj44.Name);
            Console.WriteLine("Contruct type4 Age : " + obj44.age);
            Console.WriteLine("Contruct type4 Location : " + obj44.location);
            Console.WriteLine();
        }
    }

    class constructor1
    {
        // Class member
        public string Name;

        // Class method definition
        public constructor1()
        {
            Name = "Lal";
        }
    }
    class constructor2
    {
        // Class field
        public string Name;

        // Class method definition
        public constructor2(string myName)
        {
            Name = myName;
        }
    }

    class constructor3
    {
        // Class fields
        public string Name;
        public int age;
        public string location;

        // Class method definition
        public constructor3(string myName, int myAge, string myLocation)
        {
            Name = myName;
            age = myAge;
            location = myLocation;
        }
    }

    class constructor4
    {
        // Class fields
        public string Name;
        public int age;
        public string location;

        public constructor4()
        {
        }

        // Create a class constructor with multiple parameters
        public constructor4(string myName, int myAge, string myLocation)
        {
            Name = myName;
            age = myAge;
            location = myLocation;
        }
    }
}