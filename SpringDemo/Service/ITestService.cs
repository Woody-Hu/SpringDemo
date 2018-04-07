using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpringDemo.DAO;
using SpringDemo.Models;

namespace SpringDemo.Service
{
    interface ITestService
    {
        IRepository<TestDataModel> UseDao {set;get;}

        void Save(TestDataModel input);

        TestDataModel Get(int inputId);
    }
}
