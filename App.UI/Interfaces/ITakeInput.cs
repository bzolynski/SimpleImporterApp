using System;
using System.Collections.Generic;
using System.Text;

namespace App.UI.Interfaces
{
    public interface ITakeInput
    {
        int MenuInput();
        int IntInput();
        decimal DecimalInput();
        string StringInput();
    }
}
