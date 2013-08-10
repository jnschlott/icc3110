using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablero t = new Tablero();
            t.mostrarTablero();

            int nu = 0;
            int i = 1;
            while (true)
            {    
            Console.WriteLine("Ingrese una posición:");
                i = Int32.Parse(Console.ReadLine())-1;

                if (nu == 0)
	{
                t.setPos(i,"X");
                nu = 1;
	}
                if (nu == 0)
	{
                t.setPos(i,"O");
                nu = 0;
	}
            }
            Console.ReadKey();
        }
    }
}
