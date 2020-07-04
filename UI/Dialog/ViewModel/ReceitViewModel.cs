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
    public class ReceitViewModel : BaseDialogViewModel
    {
        private ReceitRepository repository = new ReceitRepository();
		private List<ComboData<Drug>> drugs = new List<ComboData<Drug>>();
		private Drug selectedDrug;
		private double quantity;
		private RelayCommand addDrugCommand;
		private string recepie;

		public ReceitViewModel(ReceitView view) : base(view, typeof(Receit))
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

		public string Recepie
		{
			get { return recepie; }
			set
			{
				recepie = value;
				OnPropertyChanged(nameof(Recepie));
			}
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

            ApplicationContext.Instance.Receits = new List<Entity>(Items);
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

		public void AddDrugCommandExecute()
		{
			if (((Receit)SelectedItem).DrugsAndQuantity.ContainsKey(SelectedDrug.Name))
			{
				return;
			}

			((Receit)SelectedItem).DrugsAndQuantity.Add(SelectedDrug.Name, Quantity);
			((ReceitView)dialog).Refresh();

			((Receit)SelectedItem).Price += Quantity * SelectedDrug.Price;

			repository.Save();
		}

		public bool CanAddDrugCommandExecute()
		{
			return SelectedDrug != null && SelectedItem != null;
		}
	}
}
