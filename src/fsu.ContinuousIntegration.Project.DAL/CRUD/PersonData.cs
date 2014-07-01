// <copyright company="Schneider">
// All rights reserved Copyright 2014 Schneider (Paris, France)
// This computer program may not be used, copied, distributed, corrected, modified,
// translated, transmitted or assigned without Schneider's prior written authorization
// </copyright>
//
// <updates>
// 20yy-mm-dd WHO Reference: Free comments
// </updates>

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using fsu.ContinuousIntegration.Project.DAL.Entities;

namespace fsu.ContinuousIntegration.Project.DAL.CRUD
{
    /// <summary>
    /// Summary description for Ancien
    /// </summary>
    public class PersonData : BaseCRUD
    {
        public static List<Person> GetAll()
        {
            var datatable = DataContext.Instance.Retrieve("Ancien");

            var results = new List<Person>();
            foreach (DataRow row in datatable.Rows)
            {
                var ancien = new Person
                {
                    LastName = row["LASTNAME"].ToString(), 
                    FirstName = row["FIRSTNAME"].ToString()
                };
                results.Add(ancien);
            }
            return results;
        }
    }
}
