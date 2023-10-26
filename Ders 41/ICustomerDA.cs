using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ders_41
{
    internal interface ICustomerDA
    {
        void Add();
        void Update();
        void Delete();
    }

    class SQLServerCustomerDal:ICustomerDA
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Update()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Delete()
        {
            Console.WriteLine("Sql updated");
        }
    }
    class OracleCustomerDal : ICustomerDA
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }
    }
    class MySqlCustomerDal : ICustomerDA
    {
        public void Add()
        {
            Console.WriteLine("MySql added");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated");
        }
        public void Delete()
        {
            Console.WriteLine("MySql deleted");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDA customerDal)
        {
            customerDal.Add();
        }
    }
}
