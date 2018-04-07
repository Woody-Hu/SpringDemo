using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpringDemo.Service
{
    public class TestServiceImp:ITestService
    {

        public void Save(Models.TestDataModel input)
        {
            UseDao.Save(input);
            return;
        }

        public Models.TestDataModel Get(int inputId)
        {
            return UseDao.Get(inputId);
        }

        public DAO.IRepository<Models.TestDataModel> UseDao
        {
            get;
            set;
        }
    }
}