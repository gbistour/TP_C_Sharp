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
using System.Text;
using fsu.ContinuousIntegration.Project.DAL.CRUD;
using fsu.ContinuousIntegration.Project.DAL.Entities;

namespace fsu.ContinuousIntegration.Project.Services
{
    /// <summary>
    /// Summary description for AnciensManagementService
    /// </summary>
    public class AnciensManagementService
    {
        /// <summary>
        /// Retrieve all Ancien entities from database
        /// </summary>
        /// <returns></returns>
        public static List<Person> RetrieveAllAnciens()
        {
            return PersonData.GetAll();
        }
    }
}
