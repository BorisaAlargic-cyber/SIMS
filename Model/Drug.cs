using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model 
{
   public class Drug : Entity
    {
        private string name = string.Empty;
        private string manifactorer = string.Empty;
        private bool issue = false;
        private double price = 0;

        public string Name
        {
            get
            {
                return name;

            }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Manifatorer
        {
            get
            {
                return manifactorer;
            }
            set
            {
                manifactorer = value;
                OnPropertyChanged(nameof(Manifatorer));
         
            }
        }
        public bool Issue
        {
            get
            {
                return issue;
            }
            set
            {
                issue = value;
                OnPropertyChanged(nameof(Issue));
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
