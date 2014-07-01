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
using System.Collections.ObjectModel;
using System.Text;
using fsu.ContinuousIntegration.Project.DAL.Entities;
using library.Ui;

namespace fsu.ContinuousIntegration.Project.Gui
{
    /// <summary>
    /// Summary description for Model
    /// </summary>
    public class Model : NotifyPropertyChanged
    {
        public ObservableCollection<AncienModel> Anciens { get; set; }

        public Model()
        {
            Anciens = new ObservableCollection<AncienModel>();
        }

        public Model(List<Person> anciens)
            : this()
        {
            foreach (var ancien in anciens)
            {
                Anciens.Add(new AncienModel() { FirstName = ancien.FirstName, LastName = ancien.LastName });
            }
        }
    }
}
