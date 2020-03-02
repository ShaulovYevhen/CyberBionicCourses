using System;

namespace InvoiceApp
{
    public class Invoice
    {
        private readonly int _account;
        private readonly string _customer;
        private readonly string _provider;

        public Invoice(int account, string customer, string provider)
        {
            _account = account;
            _customer = customer;
            _provider = provider;
        }

        public string Article { get; set; }

        public int Quantity { get; set; }

        public string Cost(bool needNds)
        {
            double cost;
            switch (Article)
            {
                case "laptop":
                    cost = 5400;
                    break;
                case "SD-cadr":
                    cost = 30;
                    break;
                case "USB-hab":
                    cost = 12;
                    break;
                case "Article":
                    cost = 100;
                    break;
                default:
                    return "Нет ифформации о таком товаре";
            }
            if (needNds)
            {
                cost = cost * 7 / 6;
            }
            return "Cуммa оплаты: " + Math.Round(Quantity * cost, 2);
        }
    }
}