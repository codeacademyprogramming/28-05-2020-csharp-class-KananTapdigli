using System;
using System.Collections.Generic;
using System.Text;

namespace Invoice
{
    class Invoice
    {

        private string _provider;
        private string _account;
        private string _customer;

        private int _cost;
        private string _article;

        public string Article
        {
            get
            {
                return this._article;
            }

            set
            {
                this._article = value;

                if (this._article.ToLower() == "laptop")
                {
                    this._cost = 1400;
                }
                else if (this._article.ToLower() == "sd-card")
                {
                    this._cost = 30;
                }
                else if (this._article.ToLower() == "usb-hab")
                {
                    this._cost = 12;
                }
            }
        }

        public int Quantity { get; set; }

        public Invoice(string account, string customer, string provider)
        {
            this._provider = provider;
            this._account = account;
            this._customer = customer;         
        }

        public void CostCalculation(bool needEdv)
        {
            if (needEdv == true)
            {
                Console.WriteLine($"Mehsulun adi:{this.Article}, mehsulun qiymeti: {this._cost}, mesulun sayi: {this.Quantity},Umumi mebleg(EDV odenilir):{this._cost * this.Quantity + this._cost * 0.18}");  
            }
            else
            {
                Console.WriteLine($"Mehsulun adi:{this.Article}, mehsulun qiymeti: {this._cost}, mesulun sayi: {this.Quantity},Umumi mebleg(EDV odenilmir):{this._cost * this.Quantity}"); 
            }
        }
    }
}
