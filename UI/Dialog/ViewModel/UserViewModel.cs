using Model;
using Persistance;
using Persistence;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Dialog.Model;
using UI.Dialog.View;

namespace UI.Dialogs.ViewModel
{
    public class UserViewModel : BaseDialogViewModel
    {
        private UserRepository repository = new UserRepository();
        private UserView dialog;
		private List<ComboData<UserType>> userTypes = new List<ComboData<UserType>>();

		public UserViewModel(UserView view) : base(view, typeof(User))
        {
            dialog = view;
            Init();
			InitUserTypes();
        }

		public void InitUserTypes()
		{
			userTypes.Add(new ComboData<UserType> { Name = "Admin", Value = UserType.Administratior });
			userTypes.Add(new ComboData<UserType> { Name = "Doctor", Value = UserType.Doctor });
			userTypes.Add(new ComboData<UserType> { Name = "Drug Dealer", Value = UserType.DrugDealer });
		}

        protected override void Init()
        {
            Items = new ObservableCollection<Entity>(repository.GetAll());
        }

		public List<ComboData<UserType>> UserTypes
		{
			get { return userTypes; }
			set
			{
				userTypes = value;
				OnPropertyChanged(nameof(UserTypes));
			}
		}

		protected override void OkCommandExecute()
        {
            ((User)SelectedItem).Password = dialog.Password;
            base.OkCommandExecute();

            ApplicationContext.Instance.Users = new List<Entity>(Items);
            repository.Save();
            Init();
        }

        protected override Entity OkAfterAddDatabase()
        {
            return SelectedItem;
        }

        protected override Entity OkAfterEditDatabase()
        {
            repository.Save();
            return SelectedItem;
        }

        protected override bool DatabaseRemove(Entity item)
        {
            repository.Remove(item);
            repository.Save();
            return true;
        }

        protected override void DoSearch()
        {
            Items = new ObservableCollection<Entity>(repository.Search(Search));
        }
    }
}
