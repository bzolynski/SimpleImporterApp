using App.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.UI.Services
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

        public decimal DecimalInput()
        {
            do
            {
                decimal number = -1.0M;
                Console.Write("Wpisz liczbę: ");
                var input = Console.ReadLine();

                if (decimal.TryParse(input, out number))
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
                    Console.WriteLine("Pole nie może być puste. Wpisz jeszcze raz");

            } while (true);
        }
    }
}
