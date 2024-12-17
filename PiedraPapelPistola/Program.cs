using System;
using System.Threading;
using PiedraPapelPistola;

class Program
{
    static void Main(string[] args) 
    {
        Boolean flag = true;
        while (flag)
        {
            Console.WriteLine("Seleccione modo de juego: \n1. Partida normal \n2.Torneo \n3. Salir");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Partida.Game();
                    break;
                case 2:
                    Torneo.Bracket();
                    break;
                case 3:
                    flag = false;
                    break;
            }
        }
    }
}
