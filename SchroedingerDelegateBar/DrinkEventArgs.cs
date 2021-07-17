using System;

namespace SchroedingerDelegateBar
{
    public class DrinkEventArgs : EventArgs
    {
        public DrinkEventArgs(DrinkType type)
        {
            Drink = type;
        }

        public DrinkType Drink { get; set; }

    }
}