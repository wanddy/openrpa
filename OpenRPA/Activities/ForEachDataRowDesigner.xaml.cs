﻿using Microsoft.VisualBasic.Activities;
using System;
using System.Activities;
using System.Activities.Expressions;
using System.Activities.Presentation.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace OpenRPA.Activities
{
    public partial class ForEachDataRowDesigner : INotifyPropertyChanged
    {
        public ForEachDataRowDesigner()
        {
            InitializeComponent();
            Loaded += (sender, e) =>
            {
                var Variables = ModelItem.Properties[nameof(ForEachDataRow.Variables)].Collection;
                if (Variables != null && Variables.Count == 0)
                {
                    Variables.Add(new Variable<int>("Index", 0));
                    Variables.Add(new Variable<int>("Total", 0));
                }
            };
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}