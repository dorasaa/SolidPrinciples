using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    interface IDiscount
    {
        double getDiscount(double TotalSales);

    }
    interface IDatabase
    {
        void Add();

    }
    interface IDatabasev1
    {
        void Read();

    }
}

