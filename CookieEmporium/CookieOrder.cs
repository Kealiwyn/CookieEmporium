using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieEmporium
{
    class CookieOrder
    {
        protected int dozens;
        protected double totalPrice;

        public int Dozens
        {
            get { return dozens; }
            set 
            { 
                dozens = value;
                totalPrice = SetPrice(dozens);
            }
        }

        public double TotalPrice
        {
            get => totalPrice;
        }
        
        public int OrderNumber { get; set; }
        public string RecipientName { get; set; }
        public string CookieType { get; set; }

        public CookieOrder(int orderNumber,
            string recipientName,
            string cookieType,
            int dozens)
        {
            OrderNumber = orderNumber;
            RecipientName = recipientName;
            CookieType = cookieType;
            Dozens = dozens;
        }

        protected virtual double SetPrice(double dozens)
        {
            if (dozens > 2)
            {
                return totalPrice = ((dozens - 2) * 13) + 30;
            }
            else
                return totalPrice = 15 * dozens;
        }

        public override string ToString()
        {
            return $"Order Number: {OrderNumber}," +
                $" Recipient: {RecipientName}," +
                $" Cookie Type: {CookieType}," +
                $" Quantity: {Dozens}," +
                $" Total Cost: {TotalPrice}";
        }
    }
}
