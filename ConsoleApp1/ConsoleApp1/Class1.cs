using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Boots
    {




        private string proizvod;
        public float size;
        public double cena;


        public void Boot(string proizvod, float size, double cena)
        {
            this.proizvod = proizvod;
            this.size = size;
            this.cena = cena;
        }





        public string Proizvod
        {
            get
            {
                return proizvod;
            }
            set
            {
                proizvod = value;
            }

        }
        public float Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }

        }
        public double Cena
        {
            get
            {
                return cena;
            }
            set
            {
                cena = value;
            }

        }

        public void Zap()
        {
            Console.WriteLine("Введите название обуви");
            proizvod = Console.ReadLine();
            Console.WriteLine("Введите размер обуви");
            size = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите цену обуви");
            cena = Convert.ToDouble(Console.ReadLine());
        }
        public void GetInfo()
        {
            Console.WriteLine($"Обувь:{proizvod}\nРазмер:{size}\nЦена:{cena}");
        }
    }
}