using System;

namespace ConverterApp
{
    public class Converter
    {
        public Converter(double usd, double eur, double rub)
        {
            Usd = usd;
            Eur = eur;
            Rub = rub;
        }

        public double UaToUs(double uah)
        {
            return Math.Round(uah / Usd, 2);
        }

        public double UaToEu(double uah)
        {
            return Math.Round(uah / Eur, 2);
        }
        public double UaToRu(double uah)
        {
            return Math.Round(uah / Rub, 2);
        }

        public double UsToUa(double usdSum)
        {
            return Math.Round(Usd * usdSum, 2);
        }

        public double EuToUa(double eurSum)
        {
            return Math.Round(Eur * eurSum, 2);
        }

        public double RuToUa(double ruSum)
        {
            return Math.Round(Rub * ruSum, 2);
        }

        public double Rub { get; set; }

        public double Eur { get; set; }

        public double Usd { get; set; }
    }
}