using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Currency
    {
        public double value { get; set; }
        public Currency(double value)
        {
            this.value = value;
        }
    }

    class CurrencyUSD : Currency
    {
        private double exchangeRate { get; set; }
        public CurrencyUSD(double value, double exchangeRate) : base(value)
        {
            this.exchangeRate = exchangeRate;
        }
        public static explicit operator CurrencyEUR(CurrencyUSD usd)
        {
            double convertedValue = usd.value * usd.exchangeRate;
            return new CurrencyEUR(convertedValue, usd.exchangeRate);
        }
        public static explicit operator CurrencyRUB(CurrencyUSD usd)
        {
            double convertedValue = usd.value * usd.exchangeRate;
            return new CurrencyRUB(convertedValue, usd.exchangeRate);
        }
    }
    class CurrencyEUR : Currency
    {
        private double exchangeRate { get; set; }
        public CurrencyEUR(double value, double exchangeRate) : base(value)
        {
            this.exchangeRate = exchangeRate;
        }
        public static explicit operator CurrencyUSD(CurrencyEUR eur)
        {
            double convertedValue = eur.value / eur.exchangeRate;
            return new CurrencyUSD(convertedValue, eur.exchangeRate);
        }
        public static explicit operator CurrencyRUB(CurrencyEUR eur)
        {
            double convertedValue = eur.value * eur.exchangeRate; 
            return new CurrencyRUB(convertedValue, eur.exchangeRate);
        }
    }
    class CurrencyRUB : Currency
    {
        private double exchangeRate { get; set; }
        public CurrencyRUB(double value, double exchangeRate) : base(value)
        {
            this.exchangeRate = exchangeRate;
        }
        public static explicit operator CurrencyUSD(CurrencyRUB rub)
        {
            double convertedValue = rub.value / rub.exchangeRate;
            return new CurrencyUSD(convertedValue, rub.exchangeRate);
        }
        public static explicit operator CurrencyEUR(CurrencyRUB rub)
        {
            double convertedValue = rub.value / rub.exchangeRate;
            return new CurrencyEUR(convertedValue, rub.exchangeRate);
        }
    }

}
