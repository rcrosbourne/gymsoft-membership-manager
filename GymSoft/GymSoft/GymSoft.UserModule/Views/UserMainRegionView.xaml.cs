﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GymSoft.UserModule.ViewModels;

namespace GymSoft.UserModule.Views
{
    /// <summary>
    /// Interaction logic for UserMainRegionView.xaml
    /// </summary>
    public partial class UserMainRegionView : UserControl
    {
        public UserMainRegionView(UserMainRegionViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
