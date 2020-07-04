using CompositeCommon;
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
    public class RecepieViewModel : BaseDialogViewModel
    {
        private RecepieRepository repository = new RecepieRepository();
		private List<ComboData<Drug>> drugs = new List<ComboData<Drug>>();
		private Drug selectedDrug;
		private double quantity;
		private RelayCommand addDrugCommand;

		public RecepieViewModel(RecepieView view) : base(view, typeof(Recepie))
        {
            Init();
			InitDrugs();
		}

		public RelayCommand AddDrugCommand
		{
			get
			{
				return addDrugCommand ?? (addDrugCommand = new RelayCommand(param => this.AddDrugCommandExecute(), param => this.CanAddDrugCommandExecute()));
			}
		}

		public Drug SelectedDrug
		{
			get
			{
				return selectedDrug;
			}
			set
			{
				selectedDrug = value;
				OnPropertyChanged(nameof(SelectedDrug));
			}
		}

		public double Quantity
		{
			get { return quantity; }
			set
			{
				quantity = value;
				OnPropertyChanged(nameof(Quantity));
			}
		}

		public void InitDrugs()
		{
			foreach (Entity drug in ApplicationContext.Instance.Drugs)
			{
				drugs.Add(new ComboData<Drug> { Name = ((Drug)drug).Name, Value = (Drug)drug });
			}
		}

		protected override void Init()
        {
            Items = new ObservableCollection<Entity>(repository.GetAll());
        }

        protected override void OkCommandExecute()
        {
            base.OkCommandExecute();

            ApplicationContext.Instance.Recepies = new List<Entity>(Items);
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

		public List<ComboData<Drug>> Drugs
		{
			get { return drugs; }
			set
			{
				drugs = value;
				OnPropertyChanged(nameof(Drugs));
			}
		}

		public void AddDrugCommandExecute()
		{
			if(((Recepie)SelectedItem).DrugsAndQuantity.ContainsKey(SelectedDrug.Name))
			{
				return;
			}

			((Recepie)SelectedItem).DrugsAndQuantity.Add(SelectedDrug.Name, Quantity);
			((RecepieView)dialog).Refresh();

			repository.Save();
		}

		public bool CanAddDrugCommandExecute()
		{
			return SelectedDrug != null && SelectedItem != null;
		}
	}
}
