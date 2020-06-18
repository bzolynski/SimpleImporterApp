using App.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.UI
{
    public class TakeInput : ITakeInput
    {
        public int MenuInput()
        {
            Console.Write("Opcja: ");
            var input = IntInput();
            Console.WriteLine();

            return input;
        }
        public int IntInput()
        {
            do
            {
                int number = -1;
                var input = Console.ReadLine();

                if (int.TryParse(input, out number))
                    return number;
                else
                    Console.Write("Błąd! Podaj liczbę: ");


            } while (true);            
        }

        public double DoubleInput()
        {
            do
            {
                double number = -1.0;
                Console.Write("Wpisz liczbę: ");
                var input = Console.ReadLine();

                if (double.TryParse(input, out number))
                    return number;
                else
                    Console.Write("Błąd! Podaj liczbę: ");


            } while (true);
        }

        public string StringInput()
        {
            do
            {                
                var input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                    return input;
                else
                    Console.WriteLine("Pole nie może być psuste. Wpisz jeszcze raz");

            } while (true);
        }
    }
}
