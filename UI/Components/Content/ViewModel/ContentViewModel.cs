using CompositeCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UI.Components.Content.ViewModel
{
    public class ContentViewModel : ViewModelBase
    {
        private Visibility userVisibility = Visibility.Visible;
        private Visibility drugVisibility = Visibility.Collapsed;
        private Visibility recepieVisibility = Visibility.Collapsed;
        private Visibility receitVisibility = Visibility.Collapsed;
        private MainWindowViewModel mainWindowViewModel;

        public Visibility UserVisibility
        {
            get { return userVisibility; }
            set
            {
                userVisibility = value;
                OnPropertyChanged(nameof(UserVisibility));
            }
        }

        public Visibility DrugVisibility
        {
            get { return drugVisibility; }
            set
            {
                drugVisibility = value;
                OnPropertyChanged(nameof(DrugVisibility));
            }
        }

        public Visibility RecepieVisibility
		{
            get { return recepieVisibility; }
            set
            {
				recepieVisibility = value;
                OnPropertyChanged(nameof(RecepieVisibility));
            }
        }

        public Visibility ReceitVisibility
		{
            get { return receitVisibility; }
            set
            {
				receitVisibility = value;
                OnPropertyChanged(nameof(ReceitVisibility));
            }
        }
        public MainWindowViewModel MainWindowViewModel
        {
            get { return mainWindowViewModel; }
            set { mainWindowViewModel = value; }
        }

        public void SetUser()
        {
            UserVisibility = Visibility.Visible;
            DrugVisibility = Visibility.Collapsed;
			RecepieVisibility = Visibility.Collapsed;
			ReceitVisibility = Visibility.Collapsed;
		}

        public void SetDrug()
        {
            UserVisibility = Visibility.Collapsed;
            DrugVisibility = Visibility.Visible;
			RecepieVisibility = Visibility.Collapsed;
			ReceitVisibility = Visibility.Collapsed;
		}

        public void SetRecepie()
        {
			RecepieVisibility = Visibility.Visible;
			UserVisibility = Visibility.Collapsed;
			DrugVisibility = Visibility.Collapsed;
			ReceitVisibility = Visibility.Collapsed;
		}

        public void SetReceit()
        {
			RecepieVisibility = Visibility.Collapsed;
			UserVisibility = Visibility.Collapsed;
			DrugVisibility = Visibility.Collapsed;
			ReceitVisibility = Visibility.Visible;
		}
    }
}
