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
using library.Ui;

namespace fsu.ContinuousIntegration.Project.Gui
{
    /// <summary>
    /// Summary description for AncienModel
    /// </summary>
    public class AncienModel : NotifyPropertyChanged
    {
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        
        public AncienModel(){}
    }
}
