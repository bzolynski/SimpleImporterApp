using App.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.UI
{
    public class TakeInput : ITakeInput
    {
        public void MenuOptions()
        {
            try
            {
                var option = int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.Write("Błąd: Podaj właściwą opcję: ");
                MenuOptions();
            }
        }

        public void StringInput()
        {
            try
            {
                var input = Console.ReadLine();
            }
            catch (Exception)
            {

                Console.WriteLine("Coś poszło nie tak, spróbuj ponownie");
                StringInput();
            }
        }
    }
}
