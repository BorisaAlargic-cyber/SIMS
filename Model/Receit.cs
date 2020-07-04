using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
     public class Receit : Entity
    {
        private string drugDealer;
        private DateTime dateAndTime;
        private Dictionary<string, double> drugsAndQuantity = new Dictionary<string, double>();
        private double price;

        public string DrugDealer
        {
            get
            {
                return drugDealer;

            }
            set
            {
                drugDealer = value;
                OnPropertyChanged(nameof(DrugDealer));
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
        public Dictionary<string,double> DrugsAndQuantity
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
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                OnPropertyChanged(nameof(Price));
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
    }
}
