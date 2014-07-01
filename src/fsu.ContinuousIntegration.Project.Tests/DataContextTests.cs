using System;
using System.Data;
using fsu.ContinuousIntegration.Project.DAL.CRUD;
using NUnit.Framework;

namespace fsu.ContinuousIntegration.Project.Tests
{

    public class DataContextTests
    {
        [Test]
        public void DataContext_NotNull()
        {
            var dataContext = DataContext.Instance;
            Assert.NotNull(dataContext, "DataContext singleton should not be null");
            Console.WriteLine("DataContext instanciated");
        }

        [Test]
        public void DataContext_BaseData()
        {
            var dataContext = DataContext.Instance;
            var results = dataContext.Retrieve("Ancien");

            var found = false;
            foreach (DataRow row in results.Rows)
            {
                if (row["FirstName"].ToString() == "Florian" && row["LastName"].ToString() == "Sureau")
                {
                    found = true;
                    Console.WriteLine("User found");
                }
            }

            Assert.IsTrue(found, "Base data doesn't exist");
        }
    }
}
