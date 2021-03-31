using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieEmporium
{
    class SpecialCookieOrder : CookieOrder
    {
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        //Inherited CookieOrder Constructor
        public SpecialCookieOrder(int orderNumber,
            string recipientName,
            string cookieType,
            int dozens, string description) : base(orderNumber, recipientName, cookieType, dozens)
        {
            Description = description;
        }


        //Override method that sets special price if SpecialCookieOrder <T>
        protected override double SetPrice(double dozens)
        {
            if (dozens > 2)
            {
                totalPrice = ((dozens - 2) * 13) + 30;
                if (totalPrice <= 40)
                {
                    return totalPrice += 10;
                }
                if (totalPrice > 40)
                {
                    return totalPrice += 8;
                }
                else
                    return totalPrice;
            }
            else
                return totalPrice = (15 * dozens) + 10;
        }

        public override string ToString()
        {
            return $"Description: {Description}, {base.ToString()}";
        }
    }
}
