using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string Keys;
        Console.WriteLine("Введiть бажану версію продукту:");
        Keys = Console.ReadLine();

        switch (Keys)
        {
            case "":
                {
                    Console.OutputEncoding = Encoding.UTF8;
                    Console.WriteLine("Ви вибрали безкоштовну версію");
                    DocumentWorker docworker = new DocumentWorker();
                    string Free;
                    Console.WriteLine("Що Ви хочете зробити з документом?(open, edit, save)");
                    Free = Console.ReadLine();

                    switch (Free)
                    {
                        case "open":
                            {
                                docworker.OpenDocument();
                                try
                                {
                                    StreamReader sr = new StreamReader("lab4_3.txt");
                                    string line;
                                    line = sr.ReadLine();
                                    while (line != null)
                                    {
                                        Console.WriteLine(line);
                                        line = sr.ReadLine();
                                        sr.Close();
                                        Console.ReadLine();
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Exception: " + e.Message);
                                }
                                break;
                            }
                        case "edit":
                            {
                                docworker.EditDocument();
                                break;
                            }
                        case "save":
                            {
                                docworker.SaveDocument();
                                break;
                            }
                        default:
                            Console.OutputEncoding = Encoding.UTF8;
                            Console.WriteLine("Вибачте, ця дiя недоступна");
                            break;
                    }
                    break;
                }

            case "pro":
                {
                    Console.OutputEncoding = Encoding.UTF8;
                    Console.WriteLine("Ви вибрали версію Про");
                    ProDocumentWorker proDocumentWorker = new ProDocumentWorker();
                    string Pro;
                    Console.WriteLine("Що Ви хочете зробити з документом?(open, edit, save)");
                    Pro = Console.ReadLine();
                        
                    switch (Pro)
                        {
                            case "open":
                                {
                                    proDocumentWorker.OpenDocument();
                                    try
                                    {
                                        StreamReader sr = new StreamReader("lab4_3.txt");
                                        string line;
                                        line = sr.ReadLine();
                                        while (line != null)
                                        {
                                        Console.WriteLine(line);
                                        line = sr.ReadLine();
                                        sr.Close();
                                        Console.ReadLine();
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                    Console.WriteLine("Exception: " + e.Message);
                                    }
                                break;
                                }
                            case "edit":
                                {
                                    try
                                    {
                                        StreamWriter sw = new StreamWriter("lab4_3.txt");
                                        string edit_exp;
                                        edit_exp = Console.ReadLine();
                                        sw.WriteLine(edit_exp);
                                        sw.Close();
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("Exception: " + e.Message);
                                    }
                                proDocumentWorker.EditDocument();
                                    break;
                                }
                            case "save":
                                {
                                    proDocumentWorker.SaveDocument();
                                    break;
                                }
                            default:
                                    Console.OutputEncoding = Encoding.UTF8;
                                    Console.WriteLine("Вибачте, ця дiя недоступна");
                                    break;
                        }
                        break;
                }

            case "exp":
                {
                    Console.OutputEncoding = Encoding.UTF8;
                    Console.WriteLine("Ви вибрали версію Експерт");
                    ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
                    string Exp;
                    Console.WriteLine("Що Ви хочете зробити з документом?(open, edit, save)");
                    Exp = Console.ReadLine();
                        
                    switch (Exp)
                    {
                        case "open":
                            {
                                expertDocumentWorker.OpenDocument();
                                try
                                {
                                    StreamReader sr = new StreamReader("lab4_3.txt");
                                    string line;
                                    line = sr.ReadLine();
                                    while (line != null)
                                    {
                                        Console.WriteLine(line);
                                        line = sr.ReadLine();
                                        sr.Close();
                                        Console.ReadLine();
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Exception: " + e.Message);
                                }
                                break;
                            }
                        case "edit":
                            {
                                try
                                {
                                    StreamWriter sw = new StreamWriter("lab4_3.txt");
                                    string edit_exp;
                                    edit_exp = Console.ReadLine();
                                    sw.WriteLine(edit_exp);
                                    sw.Close();
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Exception: " + e.Message);
                                }
                                expertDocumentWorker.EditDocument();                               
                                break;
                            }
                        case "save":
                            {
                                expertDocumentWorker.SaveDocument();
                                break;
                            }
                        default:
                            Console.OutputEncoding = Encoding.UTF8;
                            Console.WriteLine("Вибачте, ця дiя недоступна");
                            break;
                    }
                    break;
                }

            default:
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Виникла помилка, спробуйте ще раз");
                break;
        }
    }
}

class DocumentWorker
{
public virtual void OpenDocument()
{
    Console.OutputEncoding = Encoding.UTF8;
    Console.WriteLine("Документ вiдкритий");
}

public virtual void EditDocument()
{
    Console.OutputEncoding = Encoding.UTF8;
    Console.WriteLine("Правка документа доступна у версії Про");
}

public virtual void SaveDocument()
{
    Console.OutputEncoding = Encoding.UTF8;
    Console.WriteLine("Збереження документа доступне у версії Про");
}
}

class ProDocumentWorker : DocumentWorker
{
public override void EditDocument()
{
    Console.OutputEncoding = Encoding.UTF8;
    Console.WriteLine("Документ вiдредаговано");
}

public override void SaveDocument()
{
    Console.OutputEncoding = Encoding.UTF8;
    Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах доступне у версії Експерт");
}
}

class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Документ збережений в новому форматi");
    }
}