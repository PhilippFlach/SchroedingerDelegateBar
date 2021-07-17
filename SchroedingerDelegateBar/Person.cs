using System;

namespace SchroedingerDelegateBar
{
    internal class Person
    {
        public string Name { get; internal set; }

        internal void Eintreten(Bar bar)
        {
            // Ereignis registrieren
            bar.EsWirdEineRundeAusgegeben += RundeEmpfangen;
        }

        internal void Verlassen(Bar bar)
        {
            // Ereignis deregistrieren
            bar.EsWirdEineRundeAusgegeben -= RundeEmpfangen;
        }
        private void RundeEmpfangen(object sender, DrinkEventArgs e)
        {
            string drinkType = "alkoholisches";
            if (e.Drink == DrinkType.NonAlcoholic)
            {
                drinkType = "alkoholfreies";
            }
            Console.WriteLine($"{Name} freut sich über ein {drinkType} Getränk!");
        }
    }
}