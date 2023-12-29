using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;



namespace Lab06
{


    // Структура погоды
    struct Weather
    {
        public string Country { get; set; }
        public string Name { get; set; }
        public double Temp { get; set; }
        public string Description { get; set; }

        public void Print()
        {
            Console.WriteLine(Country + " " + Name + " " + Description + " " + Temp);
        }
    }
}
