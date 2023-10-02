using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Threading;

namespace ImpartireNumere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numarD = CitescNumar("Introduceti Deimpartitul:","D");
            double numarI = CitescNumar("Introduceti Impartitorul:","I");

            if ((numarD % numarI)==0) 
            {
                Console.WriteLine("Rezultatul impartirii este un numar intreg:" + numarD / numarI + ".");
            }
           else
            {
               /* decimal rezultat = numarD / numarI;
                int zecimale = Math.DivRem(numarD,numarI,out zecimale);*/
                double rezZecimale;
                rezZecimale=numarD / numarI;
                int rezIntreg;
                rezIntreg = (int)(Math.Floor(rezZecimale));
                double rezZec1 =rezZecimale-rezIntreg;

                Console.WriteLine("Rezultatul impartirii este un numar cu zecimale. Parte Intreaga:"+ rezIntreg + " Parte Zecimale: " + rezZec1);
                /*Console.WriteLine("Rezultatul impartirii este un numar cu zecimale: Intreg =" + (int) rezultat + ", Zecimale=" + zecimale);*/

            }


        }

        static int CitescNumar(string numar,string op) /* op=D > Deimpartit , op=I > Impartitor */
        {
            bool fNumar = false;


            while (!fNumar)
            {
           repeat:
                Console.Write(numar);
                string txtRead = Console.ReadLine();
                fNumar = int.TryParse(txtRead, out int result);
                if (fNumar)
                {
                    if (op == "I" && txtRead == "0")
                    {                       
                            Console.WriteLine("Valoarea '" + txtRead + "' introdusa pentru Impartitor trebuie sa fie <>0! ");
                            goto repeat;
                    }
                    else
                    {
                        return result;
                    }
                }

                else
                {
                    Console.WriteLine("Valoarea introdusa '" + txtRead + "' nu reprezinta un numar! ");
                }

            }
            return 0;
        }

    }
}