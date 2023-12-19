using System;

using ExamQ1;


namespace ExamQ1

{
    public class Program
    {

        static void Main(string[] args)

        {

            Class1[] adults = new Class1[2] { new Class1() { FirstName = "Menb", LastName = "A" }, new Class1() { FirstName = "Menb", LastName = "A" } };

            Class2[] childs = new Class2[2] { new Class2() { FirstName = "Dag", LastName = "D" }, new Class2() { FirstName = "Dag", LastName = "D" } };

            interface1[] array = new interface1[4];

            array[0] = adults[0];

            array[1] = adults[1];

            array[2] = childs[0];

            array[3] = childs[1];

            Print(adults);

            Print(childs);

            Print(array);

        }

        static void Print(interface1[] a)

        {

            foreach (var item in a)

            {

                Console.WriteLine(item.FirstName + " - " + item.LastName);

            }

        }

        public class Class1 : interface1

        {

            public string? FirstName { get; set; }

            public string? LastName { get; set; }

        }

        public class Class2 : interface1

        {

            public string? FirstName { get; set; }

            public string? LastName { get; set; }

        }

    }


}