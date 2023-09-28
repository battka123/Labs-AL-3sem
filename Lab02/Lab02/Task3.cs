using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class DocumentWorker
    {

        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Pro");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Pro");
        }
    }
    public class ProDocumentWorker : DocumentWorker
    {
        protected string key;
        public ProDocumentWorker()
        {
            Console.WriteLine("Enter key: ");
            key = Console.ReadLine();
            if (key != "pro" && key != "exp")
            {
                Console.WriteLine("Неправильный ключ");
            }
        }
        public override void EditDocument()
        {
            if (key == "pro" || key == "exp")
            {
                Console.WriteLine("Документ отредактирован");
            }
        }
        public override void SaveDocument()
        {
            if (key == "pro")
            {
                Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
            }
        }
    }
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public ExpertDocumentWorker()
        {
        }

        public override void SaveDocument()
        {
            if (key == "exp")
            {
                Console.WriteLine("Документ сохранен в новом формате");
            }
        }

    }
}
