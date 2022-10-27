using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ClassRoom
{
    public void Entrie(Pupil pupil)
    {
        pupil.Study();
        pupil.Read();
        pupil.Write();
        pupil.Relax();
    }
}

abstract class Pupil
{
    public abstract void Study();
    public abstract void Read();
    public abstract void Write();
    public abstract void Relax();
}


class ExcelentPupil : Pupil
{
    public override void Study()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("учень відмінно навчається");
    }

    public override void Read()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("учень відмінно читає");
    }

    public override void Write()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("учень відмінно пише");
    }

    public override void Relax()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("учень погано відпочиває\n");
    }

}

class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("учень добре навчається");
    }

    public override void Read()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("учень добре читає");
    }

    public override void Write()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("учень добре пише");
    }

    public override void Relax()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("учень так собі відпочиває\n");
    }

}

class BadPupil : Pupil
{
    public override void Study()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("учень погано навчається");
    }

    public override void Read()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("учень погано читає");
    }

    public override void Write()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("учень погано пише");
    }

    public override void Relax()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("учень відмінно відпочиває\n");
    }
}

class AveragePupil : Pupil
{
    public override void Study()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("учень так собі навчається");
    }

    public override void Read()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("учень так собі читає");
    }

    public override void Write()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("учень так собі пише");
    }

    public override void Relax()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("учень добре відпочиває\n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ClassRoom classRoom = new ClassRoom();
        ExcelentPupil excelentPupil = new ExcelentPupil();
        GoodPupil goodPupil = new GoodPupil();
        BadPupil badPupil = new BadPupil();
        AveragePupil averagePupil = new AveragePupil();

        classRoom.Entrie(excelentPupil);
        classRoom.Entrie(goodPupil);
        classRoom.Entrie(badPupil);
        classRoom.Entrie(averagePupil);
    }
}