using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

    class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
    }

    class Company : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.Print(value);
        }
    }

    class Position : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Print(value);
        }
    }

    class NamePerson : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Print(value);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Printer name = new NamePerson();
            name.Print("Elon");
            Printer company = new Company();
            company.Print("Tesla, SpaceX");
            Printer position = new Position();
            position.Print("Head");
        }
    }
}