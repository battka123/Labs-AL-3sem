using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Task2;

class ClassRoom
{
    private Pupil[] class_;

    // Конструктор создания классa
    public ClassRoom(params Pupil[] classes)
    {
        class_ = classes;
    }

    public void StudentInfo(Pupil pupil)
    {
        pupil.Study();
        pupil.Write();
        pupil.Read();
        pupil.Relax();

        Console.WriteLine("\n");
    }

}
class Pupil
{
    public virtual void Study()
    {
    }
    public virtual void Read()
    {
    }
    public virtual void Write()
    {
    }
    public virtual void Relax()
    {
    }
}

class ExcelentPupil : Pupil
{
    // Переопределяю методы класса Pupil
    public override void Read()
    {
        Console.WriteLine("Excelent_read");
    }
    public override void Study()
    {
        Console.WriteLine("Excelent_study");
    }
    public override void Write()
    {
        Console.WriteLine("Excelent_write");
    }
    public override void Relax()
    {
        Console.WriteLine("Excelent_relax");
    }
}

class GoodPupil : Pupil
{
    // Переопределяю методы класса Pupil
    public override void Read()
    {
        Console.WriteLine("Good_read");
    }
    public override void Study()
    {
        Console.WriteLine("Good_study");
    }
    public override void Write()
    {
        Console.WriteLine("Good_write");
    }
    public override void Relax()
    {
        Console.WriteLine("Good_relax");
    }
}

class BadPupil : Pupil
{
    // Переопределяю методы класса Pupil
    public override void Read()
    {
        Console.WriteLine("Bad_read");
    }
    public override void Study()
    {
        Console.WriteLine("Bad_study");
    }
    public override void Write()
    {
        Console.WriteLine("Bad_write");
    }
    public override void Relax()
    {
        Console.WriteLine("Bad_relax");
    }
}

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Pupil s1 = new BadPupil();
            Pupil s2 = new GoodPupil();
            Pupil s3 = new ExcelentPupil();

            ClassRoom classRoom = new ClassRoom(s1, s3);

            classRoom.StudentInfo(s3);
            classRoom.StudentInfo(s2);
            classRoom.StudentInfo(s1);

            // Task 2
            Vehicle mc = new Car(100, 200, "01/01/2023");
            mc.Info();

            Vehicle mp = new Plane(100, 200, "01/01/2023", 250, 40);
            mp.Info();

            Vehicle ms = new Ship(100, 200, "01/01/2023", 250, "New York");
            ms.Info();

            //Task 3
            DocumentWorker worker = new DocumentWorker();
            worker.SaveDocument(); // Сохранение документа доступно в версии Pro
            worker.OpenDocument(); // Документ открыт
            worker.EditDocument(); // Редактирование документа доступно в версии Pro
            Console.WriteLine("");

            worker = new ProDocumentWorker(); // pro
            worker.SaveDocument(); // Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert
            worker.OpenDocument(); // Документ открыт
            worker.EditDocument(); // Документ отредактирован
            Console.WriteLine("");

            worker = new ExpertDocumentWorker(); // exp
            worker.SaveDocument(); // Документ сохранен в новом формате
            worker.OpenDocument(); // Документ открыт
            worker.EditDocument(); // Редактирование документа доступно в версии Pro
            Console.WriteLine("");

            worker = new ExpertDocumentWorker(); // qwerty /n Неправильный ключ
            worker.SaveDocument(); // 
            worker.OpenDocument(); // Документ открыт
            worker.EditDocument(); //

            Console.ReadLine();
        }
    }
}
