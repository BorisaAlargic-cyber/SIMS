using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Recepie : Entity
    {
        private string jmbg;
        private DateTime dateAndTime;
		private string doctor;
        private Dictionary<string, double> drugsAndQuantity = new Dictionary<string, double>();

		public string Doctor
		{
			get
			{
				return doctor;
			}
			set
			{
				doctor = value;
				OnPropertyChanged(nameof(Doctor));
			}
		}

        public string JMBG
        {
            get
            {
                return jmbg;
            }
            set
            {
                jmbg = value;
                OnPropertyChanged(nameof(JMBG));
            }
        }
		public DateTime DateAndTime
        {
            get
            {
                return dateAndTime;
            }
            set
            {
                dateAndTime = value;
                OnPropertyChanged(nameof(DateAndTime));
            }

        }
        public Dictionary<string, double> DrugsAndQuantity
        {
            get
            {
                return drugsAndQuantity;
            }
            set
            {
                drugsAndQuantity = value;
                OnPropertyChanged(nameof(DrugsAndQuantity));
            }
        }
        public override void InitExportList()
        {
            throw new NotImplementedException();
        }

        public override string Validate(string columnName)
        {
			return null;
        }

		public void Refresh()
		{
			OnPropertyChanged(nameof(DrugsAndQuantity));
		}
	}
}
