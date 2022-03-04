using System;
using System.Collections;
//https://docs.microsoft.com/pt-br/dotnet/api/system.collections.arraylist?view=net-6.0

namespace PArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria e instancia um ArrayList
            // Classe derivada da classe Object
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");

            // Displays the properties and values of the ArrayList.
            Console.WriteLine("myAL");
            Console.WriteLine("    Contador:    {0}", myAL.Count);// Retorna a quantidade atual de elementos no ArrayList
            Console.WriteLine("    Capacidade: {0}", myAL.Capacity); //Controla a quantidade de valores que um ArrayList pode conter
            Console.Write("    Valores:");
            PrintValues(myAL);
        }

        public static void PrintValues(IEnumerable myList) //IIEnumerable manipula um enumerador
        {
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }
    }
}
