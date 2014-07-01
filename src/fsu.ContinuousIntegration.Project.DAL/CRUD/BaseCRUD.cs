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

namespace fsu.ContinuousIntegration.Project.DAL.CRUD
{
    /// <summary>
    /// Summary description for BaseCRUD
    /// </summary>
    public class BaseCRUD
    {
        public DataContext DataContext { get { return DataContext.Instance; } }
    }
}
