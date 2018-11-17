using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilstandsmaskiner
{
    class Program
    {
        static void Main(string[] args)
        {
            int mintilstand = 0;
            char minHendelse;
            while (true)
            {
                minHendelse = EnHendelse();
                switch (mintilstand)
                {
                    case 0: // TOM
                        switch (minHendelse)
                        {
                            case 'B':
                                mintilstand = 1;
                                break;
                            case 'E':
                            case 'R':
                            case 'G':
                            case 'N':
                            case '#':
                                break;
                        }
                        break;
                    case 1: // B
                        switch (minHendelse)
                        {
                            case 'E':
                                mintilstand = 2;
                                break;
                            case 'B':
                                mintilstand = 1;
                                break;
                            case 'R':
                            case 'G':
                            case 'N':
                            case '#':
                                break;
                        }
                        break;
                   case 2: //BE
                       switch (minHendelse)
                       {
                           case 'R':
                               mintilstand = 3;
                               break;
                           case 'E':
                           case 'B':
                               mintilstand = 1;
                               break;
                            case 'G':
                           case 'N':
                           case '#':
                               break;
                       }
                        break;
                    case 3: //BER
                        switch (minHendelse)
                        {
                            case 'G':
                                mintilstand = 4;
                                break;
                            case 'E':
                            case 'R':
                            case 'B':
                                mintilstand = 1;
                                break;
                            case 'N':
                            case '#':
                                break;
                        }
                        break;
                    case 4://BERG
                        switch (minHendelse)
                        {
                            case 'E':
                                mintilstand = 5;
                                break;
                            case 'B':
                                mintilstand = 1;
                                break;
                            case 'R':
                            case 'G':
                            case 'N':
                            case '#':
                                break;
                        }
                        break;
                    case 5://BERGE
                        switch (minHendelse)
                        {
                            case 'N':
                                mintilstand = 0;
                                Console.WriteLine($"\n\nBERGEN\n\n"); 
                                break;
                            case 'E':
                            case 'R':
                            case 'G':
                            case 'B':
                                mintilstand = 1;
                                break;
                            case '#':
                                break;
                        }
                        break;
                        ;

                }
            }
        }

        static char EnHendelse()
        {
            char svar =  (char) Console.ReadKey().KeyChar;
            if (svar != 'B' && svar != 'E' && svar != 'R' && svar != 'G' && svar != 'N') svar = '#';
            return svar;
        }
    }
}
