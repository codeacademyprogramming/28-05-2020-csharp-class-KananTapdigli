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

        public Invoice(string account, string customer, string provider)
        {
            this._provider = provider;
            this._account = account;
            this._customer = customer;
        }

        public string article { get; set; }
        public int quantity { get; set; }
        public double cost { get; set; }

        public void CostCalculation(bool needEdv)
        {
            if (needEdv == true)
            {
                Console.WriteLine($"Mehsulun adi:{this.article}, mehsulun qiymeti: {this.cost}, mesulun sayi: {this.quantity},Umumi mebleg(EDV odenilir):{this.cost * this.quantity + this.cost * 0.18}");  
            }
            else
            {
                Console.WriteLine($"Mehsulun adi:{this.article}, mehsulun qiymeti: {this.cost}, mesulun sayi: {this.quantity},Umumi mebleg(EDV odenilmir):{this.cost * this.quantity}"); 
            }
        }
    }
}
