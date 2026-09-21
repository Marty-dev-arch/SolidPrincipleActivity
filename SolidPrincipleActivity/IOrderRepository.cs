using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleActivity
{
    public interface IOrderRepository
    {
        void SaveOrder(string email, decimal total);
    }
}
