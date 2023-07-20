﻿using LenovoToolkit.ViewModels;
using ModernWpf.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LenovoToolkit.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainPage : ModernWpf.Controls.Page
    {
        private readonly LenovoSettingsViewModel _vm;

        public MainPage(LenovoSettingsViewModel vm)
        {
            this.DataContext = vm;
            InitializeComponent();
            this._vm = vm;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _vm.Refresh();
        }
    }
}
