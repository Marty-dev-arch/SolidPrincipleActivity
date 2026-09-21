using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleActivity
{
    public interface IDiscountStrategy
    {
        decimal Apply(decimal total);
    }

    public class NoDiscount : IDiscountStrategy
    {
        public decimal Apply(decimal total) => total;
    }

    public class StudentDiscount : IDiscountStrategy
    {
        public decimal Apply(decimal total) => total * 0.9m;
    }

    public class SeniorDiscount : IDiscountStrategy
    {
        public decimal Apply(decimal total) => total * 0.85m;
    }

    public class BlackFridayDiscount : IDiscountStrategy
    {
        public decimal Apply(decimal total) => total * 0.7m;
    }

    public class FreeShippingDiscount : IDiscountStrategy
    {
        public decimal Apply(decimal total)
        {
            throw new NotSupportedException("Doesn't apply to order totals, only shipping!");
        }
    }
}