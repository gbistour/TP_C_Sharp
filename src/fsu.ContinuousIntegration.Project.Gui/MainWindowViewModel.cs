// <copyright company="Schneider">
// All rights reserved Copyright 2014 Schneider (Paris, France)
// This computer program may not be used, copied, distributed, corrected, modified,
// translated, transmitted or assigned without Schneider's prior written authorization
// </copyright>
//
// <updates>
// 20yy-mm-dd WHO Reference: Free comments
// </updates>

using fsu.ContinuousIntegration.Project.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace fsu.ContinuousIntegration.Project.Gui
{
    /// <summary>
    /// Summary description for MainWindowViewModel
    /// </summary>
    public class MainWindowViewModel
    {
        public Model Model { get; set; }

        public MainWindowViewModel()
        {
            // TODO change Model constructor parameter to access data
            Model = new Model(AnciensManagementService.RetrieveAllAnciens());
            var view = new MainWindow { DataContext = Model };

            view.ShowDialog();
        }
    }
}
