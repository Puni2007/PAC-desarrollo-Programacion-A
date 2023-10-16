using System;

namespace PAC_UF1_UjaqueSonia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*...................
             PAC DESARROLLO UF1
             SONIA UJAQUE ORTIZ
            ......................*/

            
            string frase = "ilerna online programacion a 2º semestre 2022";
            string consonantes = "bcdfghjklmnñpqrstvwxyz";
            string numeros = "0123456789";
            int contarConsonantes = 0;
            int contarNumeros = 0;

            //Imprimir por consola la variable en mayúsculas sin espacios:

            
            Console.Write(frase.Replace(" ", "").ToUpper());
            Console.WriteLine();

            //Imprimir por consola el total de consonantes de la variable:

            for (int i = 0; i < frase.Length; i++)
            {
                for (int j = 0; j < consonantes.Length; j++)
                {
                    if (frase[i] == consonantes[j])
                    {
                        contarConsonantes++;
                    }
                }
            }
            Console.WriteLine(contarConsonantes);

            //Imprimir por consola el total de números que tiene la variable:
            for (int i = 0; i < frase.Length; i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (frase[i] == numeros[j])
                    {
                        contarNumeros++;
                    }
                }
            }
            Console.WriteLine(contarNumeros);
            //Imprimir por consola solo las consonantes y en el orden que las va encontrando:
            for (int i = 0; i < frase.Length; i++)
            {
                for (int j = 0; j < consonantes.Length; j++)
                {
                    if (frase[i] == consonantes[j])
                    {
                        Console.Write(frase[i]);
                    }
                }
            }

        }
    }
}

