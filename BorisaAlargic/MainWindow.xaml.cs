﻿using System;
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
using UI;
using UI.Components.Content.ViewModel;
using UI.Components.Login.View;
using UI.Components.Toolbar.ViewModel;

namespace BorisaAlargic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainWindowViewModel mainViewModel = new MainWindowViewModel();

            DataContext = mainViewModel;

			LoginView view = new LoginView(DataContext as MainWindowViewModel);

			((ToolbarViewModel)toolbar.DataContext).MainWindowViewModel = mainViewModel;
            ((ContentViewModel)content.DataContext).MainWindowViewModel = mainViewModel;

            mainViewModel.ToolbarViewModel = (ToolbarViewModel)toolbar.DataContext;
            mainViewModel.ContentViewModel = (ContentViewModel)content.DataContext;

			view.ShowDialog();
		}
    }
}
