using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

class Printer
{
    public virtual void Print(string argument)
    {
        Console.WriteLine(argument);
        Console.ForegroundColor = ConsoleColor.Black;
    }
}

class FirstLine : Printer
{
    public override void Print(string argument)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        base.Print(argument);
    }
}

class SecondLine : Printer
{
    public override void Print(string argument)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        base.Print(argument);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Printer firstLine = new FirstLine();
        firstLine.Print("first line");
        Printer secondLine = new SecondLine();
        secondLine.Print("second line");
    }
}
