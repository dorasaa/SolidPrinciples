using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    

    public class Customer :IDiscount, IDatabase
    {
        private ILogger _obj;
        public Customer(ILogger obj)
            {
            _obj = obj;
            }
        private int _custType;

        public int CustType {
            get { return _custType; }
            set { _custType = value; }
        }


        public virtual  double getDiscount(double TotalSales)
        {
            return TotalSales;
        }

        public virtual void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                //
              //  fl.Handle(ex.ToString());
            }
        }

    }

    public class customerWithRead : IDatabase,IDatabasev1
    {
            public void Add()
                    {
                        var obj = new Customer(new EmailLogger());
                        obj.Add();
                    }

        public void Read()
        { //implement
        }

    }
    public class SilverCustomer : Customer
    {
         public SilverCustomer(ILogger obj):base(obj)
            {
            
            }
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales)-50;
        }
    }
    public class GoldCustomer : Customer
    {
        public GoldCustomer(ILogger obj):base(obj)
            {

        }
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 100;
        }
    }

    public class enquiry : IDiscount
    {
        public double getDiscount(double TotalSales)
        {
            return getDiscount(TotalSales)-100;
        }
         
    }
}
