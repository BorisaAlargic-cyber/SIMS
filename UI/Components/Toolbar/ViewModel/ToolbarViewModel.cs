using CompositeCommon;
using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UI.Components.Toolbar.ViewModel
{
    public class ToolbarViewModel : ViewModelBase
    {
        private RelayCommand userCommand;
        private RelayCommand drugCommand;
        private RelayCommand recepieCommand;
        private RelayCommand receitCommand;
		private RelayCommand helpCommand;
		private User user;

		private MainWindowViewModel mainWindowViewModel;

		public RelayCommand HelpCommand
		{
			get
			{
				return helpCommand ?? (helpCommand = new RelayCommand(param => HelpCommandExecute()));
			}
		}


		public RelayCommand ReceitCommand
		{
			get
			{
				return receitCommand ?? (receitCommand = new RelayCommand(param => ReceitCommandExecute()));
			}
		}

		public RelayCommand UserCommand
        {
            get
            {
                return userCommand ?? (userCommand = new RelayCommand(param => UserCommandExecute()));
            }
        }

        public RelayCommand DrugCommand
        {
            get
            {
                return drugCommand ?? (drugCommand = new RelayCommand(param => DrugCommandExecute()));
            }
        }

        public RelayCommand RecepieCommand
		{
            get
            {
                return recepieCommand ?? (recepieCommand = new RelayCommand(param => RecepieCommandExecute()));
            }
        }

		public User User
		{
			get { return user; }
			set
			{
				user = value;
				OnPropertyChanged(nameof(User));
				OnPropertyChanged(nameof(IsUserVisible));
				OnPropertyChanged(nameof(IsDrugVisible));
				OnPropertyChanged(nameof(IsRecepieVisible));
				OnPropertyChanged(nameof(IsRecepVisible));
			}
		}

		public Visibility IsUserVisible
		{
			get { return user != null && user.UserType == UserType.Administratior ? Visibility.Visible : Visibility.Collapsed; }
		}

		public Visibility IsDrugVisible
		{
			get { return user != null && (user.UserType == UserType.Administratior ||
					user.UserType == UserType.DrugDealer) ? Visibility.Visible : Visibility.Collapsed; }
		}

		public Visibility IsRecepieVisible
		{
			get
			{
				return user != null && (user.UserType == UserType.Administratior ||
				  user.UserType == UserType.Doctor) ? Visibility.Visible : Visibility.Collapsed;
			}
		}

		public Visibility IsRecepVisible
		{
			get
			{
				return user != null && (user.UserType == UserType.Administratior ||
				  user.UserType == UserType.DrugDealer) ? Visibility.Visible : Visibility.Collapsed;
			}
		}

		public MainWindowViewModel MainWindowViewModel
        {
            get { return mainWindowViewModel; }
            set { mainWindowViewModel = value; }
        }

        private void UserCommandExecute()
        {
            mainWindowViewModel.ContentViewModel.SetUser();
        }

        private void DrugCommandExecute()
        {
            mainWindowViewModel.ContentViewModel.SetDrug();
        }

        private void RecepieCommandExecute()
        {
            mainWindowViewModel.ContentViewModel.SetRecepie();
        }

        private void ReceitCommandExecute()
        {
            mainWindowViewModel.ContentViewModel.SetReceit();
        }

		private void HelpCommandExecute()
		{
			System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.BaseDirectory + "\\test.chm");
		}

	}
}
