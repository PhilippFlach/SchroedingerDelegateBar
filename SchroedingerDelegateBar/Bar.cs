using System;

namespace SchroedingerDelegateBar
{
    internal class Bar
    {

        public event EventHandler<DrinkEventArgs> EsWirdEineRundeAusgegeben;

        internal void RundeAusgeben()
        {
            if (this.EsWirdEineRundeAusgegeben != null)
            {
                // Das Ereignis auslösen
                this.EsWirdEineRundeAusgegeben(this, new DrinkEventArgs(DrinkType.Alcoholic));
            };
        }
    }
}