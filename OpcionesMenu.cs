using System;

namespace inclui.edadfecha
{
    class OpcionesMenu
    {
        public static int LeerOpciones()
        {
            ConsoleKeyInfo tecla;
            int valor = 0;
            bool fin = false;
            do
            {
                tecla = Console.ReadKey(true);
                switch (tecla.KeyChar)
                {
                    case '1': valor = 1; break;
                    case '2': valor = 2; break;
                    case '3': valor = 3; break;
                    case '4': valor = 4; break;
                    case '5': valor = 5; break;
                    case '6': valor = 6; break;
                    case '7': valor = 7; break;
                    case '8': valor = 8; break;
                }

            } while (valor == 0);

            return valor;
        }

        public static char LeerOpcionFecha()
        {
            ConsoleKeyInfo tecla;
            char valor = ' ';
            bool fin = false;
            do
            {
                Console.WriteLine("Indique si el año es antes de cristo o despues");
                Console.WriteLine("Pulse S para A.C o N para D.C");

                tecla = Console.ReadKey(true);
                switch (tecla.KeyChar)
                {
                    case 'S': valor = 'S'; fin = true; break;
                    case 'N': valor = 'N'; fin = true; break;

                }

            } while (!fin);

            return valor;
        }


    }
}
