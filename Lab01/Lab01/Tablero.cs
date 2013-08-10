using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Tablero
    {
        private string[] Pos = new string[9];
        
        public Tablero(){
            for (int i = 1; i <= 9; i++)
            {
                Pos[i-1] = ""+i;
            }
        }


        public void mostrarTablero(){
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" " + Pos[0] + " | " + Pos[1] + " | " + Pos[2] + " ");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" " + Pos[3] + " | " + Pos[4] + " | " + Pos[5] + " ");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" " + Pos[6] + " | " + Pos[7] + " | " + Pos[8] + " ");
            Console.WriteLine("   |   |   ");
        }

        public void setPos(int i, string s)
        {
            Pos[i] = s;
            mostrarTablero();
        }
    }
}
