using System;
using System.Collections.Generic;

//IH: als het getal kleiner is dan zijn/haar voorganger verplaatst het getal naar links

namespace PI7DecCon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Getallen = new List<int>() { 10, 1, 5, 6, 3, 8, 2, 4, 9, 7 };
            List<int> CGetallen = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            

            Getallen = alg(Getallen, CGetallen, 1, 0);
            print(Getallen);
        }

        private static List<int> alg(List<int> Lijst, List<int> CLijst, int Index, int Teller)
        {
            if (Lijst[0] == 1 & Lijst[1] == 2 & Lijst[2] == 3 & Lijst[3] == 4 & Lijst[4] == 5 & Lijst[6] == 7 & Lijst[7] == 8 & Lijst[8] == 9 & Lijst[9] == 10)
            {
                return Lijst;
            }
            else if (Index < Lijst.Count)
            {
                int decrease = Lijst[Index];

                if (decrease > Lijst[Teller])
                {
                    Teller += 1;
                    print(Lijst);
                    alg(Lijst, CLijst, Index, Teller);
                }
                else
                {
                    Lijst.RemoveAt(Index);
                    Lijst.Insert(Teller, decrease);
                    Index++;
                    print(Lijst);
                    alg(Lijst, CLijst, Index, 0);
                }
                return Lijst;
            }
            return Lijst;
        }

        private static void print(List<int> Lijst)
        {
            string lijst = "";
            foreach (var item in Lijst)
            {
                lijst += item.ToString() + " ";
            }
            Console.WriteLine(lijst);
        }
    }
}
