using System;
using System.Text;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            string tekst = String.Empty;
            float suma =  0;
            float wynik = 0;
            while(tekst !="stop")
            {
                tekst = Console.ReadLine();
                builder.Append(tekst + ";");
                string[] ocenyTxt = builder.ToString().Split(new[] { "\r\n", "stop", ";" }, StringSplitOptions.RemoveEmptyEntries);
                    float[] oceny = new float[ocenyTxt.Length];
                for(int i=0;i<oceny.Length;i++)
                {
                    oceny[i] = Convert.ToSingle(ocenyTxt[i]);
                }
                foreach (float ocena in oceny)
                {
                    suma += ocena;

                }
                wynik = suma / oceny.Length;
                Console.WriteLine(wynik.ToString("0.00"));
            }
           
        }
    }
}
