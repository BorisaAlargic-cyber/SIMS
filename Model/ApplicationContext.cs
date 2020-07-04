using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public  class ApplicationContext
    {
        private static ApplicationContext instance = null;
        private List<Entity> drugs;
        private List<Entity> receits;
        private List<Entity> recepies;
        private List<Entity> users;

        public static ApplicationContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ApplicationContext();
                }

                return instance;
            }
        }
        public List<Entity> Drugs
        {
            get
            {
                if(drugs == null)
                {
                    drugs = ImportDrugs();
                }

                return drugs;
            }
            set
            {
                drugs = value;
            }
        }

        public List<Entity> Receits
        {
            get
            {
                if(receits == null)
                {
                    receits = ImportReceits();
                }

                return receits;
            }
            set
            {
                receits = value;
            }
        }

        public List<Entity> Recepies
        {
            get
            {
                if (recepies == null)
                {
                    recepies = ImportRecepies();
                }

                return recepies;
            }
            set
            {
                recepies = value;
            }
        }

        public List<Entity> Users
        {
            get
            {
                if (users == null)
                {
                    users = ImportUsers();
                }

                return users;
            }
            set
            {
                users = value;
            }
        }
        public List<Entity> ImportUsers()
        {
            List<Entity> result = new List<Entity>();

            if(!File.Exists("users.txt"))
            {
                return result;
            }

            StreamReader reader = new StreamReader("users.txt");
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');

                User user = new User();
                user.ID = data[0];
                user.Username = data[1];
                user.Password = data[2];
                user.FirstName = data[3];
                user.LastName = data[4];
				user.UserType = GetUserType(data[5]);
                result.Add(user);
            }

            return result;
        }

        public List<Entity> Get(Type type)
        {
            if (type == typeof(Drug))
            {
                return Drugs;
            }
            else if (type == typeof(Receit))
            {
                return Receits;
            }
            else if (type == typeof(User))
            {
                return Users;
            }

            return Recepies;
        }

        public void Set(Type type, List<Entity> entities)
        {
            if (type == typeof(Drug))
            {
                Drugs = entities;
            }
            else if (type == typeof(Receit))
            {
                Receits = entities;
            }
            else if (type == typeof(User))
            {
                Users = entities;
            }

            Recepies = entities;
        }

        public void SaveUsers()
        {
            if (users == null)
            {
                return;
            }

            using (StreamWriter file = new StreamWriter("users.txt"))
            {
                foreach (Entity entity in Users)
                {
                    string line = string.Empty;

                    line += ((User)entity).ID + "|";
                    line += ((User)entity).Username + "|";
                    line += ((User)entity).Password + "|";
                    line += ((User)entity).FirstName + "|";
                    line += ((User)entity).LastName + "|";
					line += ((User)entity).UserType.ToString() ;

					file.WriteLine(line);
                }
            }
        }

		public void SaveRecepie()
		{
            if (recepies == null)
            {
                return;
            }

            using (StreamWriter file = new StreamWriter("recepie.txt"))
			{
				foreach (Entity entity in Recepies)
				{
					string line = string.Empty;
					((Recepie)entity).ID = GenerateRecepieID().ToString();
					line += ((Recepie)entity).ID + "|";
					line += ((Recepie)entity).Doctor + "|";
					line += ((Recepie)entity).JMBG + "|";
					line += ((Recepie)entity).DateAndTime.ToString("MM/dd/yyyy") + "|";

					string drugs = string.Empty;

					foreach (KeyValuePair<string, double> item in ((Recepie)entity).DrugsAndQuantity)
					{
						drugs += item.Key + "," + item.Value + ";";
					}

					if (drugs != "")
					{
						drugs.Remove(drugs.Length - 1);
					}

					line += drugs;

					file.WriteLine(line);
				}
			}
		}

		public List<Entity> ImportRecepies()
		{
			List<Entity> result = new List<Entity>();

			if (!File.Exists("recepie.txt"))
			{
				return result;
			}

			StreamReader reader = new StreamReader("recepie.txt");
			string line;

			while ((line = reader.ReadLine()) != null)
			{
				string[] data = line.Split('|');

				Recepie recepie = new Recepie();
				recepie.ID = data[0];
				recepie.Doctor = data[1];
				recepie.JMBG = data[2];
				recepie.DateAndTime = DateTime.ParseExact(data[3], "MM/dd/yyyy", null);

				Dictionary<string, double> dic = new Dictionary<string, double>();

				string[] items = data[4].Split(';');

				foreach(string i in items)
				{
					if(i == "")
					{
						continue;
					}

					string[] ii = i.Split(',');

					dic.Add(ii[0], double.Parse(ii[1]));
				}

				recepie.DrugsAndQuantity = dic;

				result.Add(recepie);
			}

			return result;
		}

		public void SaveDrugs()
        {
            if(drugs == null)
            {
                return;
            }

            using (StreamWriter file = new StreamWriter("drugs.txt"))
            {
                foreach (Entity entity in Drugs)
                {
                    string line = string.Empty;

                    line += ((Drug)entity).ID + "|";
                    line += ((Drug)entity).Name + "|";
                    line += ((Drug)entity).Issue + "|";
                    line += ((Drug)entity).Price;

                    file.WriteLine(line);
                }
            }
        }

        public List<Entity> ImportDrugs()
        {
            List<Entity> result = new List<Entity>();

            if (!File.Exists("drugs.txt"))
            {
                return result;
            }

            StreamReader reader = new StreamReader("drugs.txt");
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');

                Drug drug = new Drug();
                drug.ID = data[0];
                drug.Name = data[1];
                drug.Issue = data[2] == "True" ? true : false;
                drug.Price = double.Parse(data[3]);
                

                result.Add(drug);
            }

            return result;
        }

		public void SaveReceis()
		{
            if (receits == null)
            {
                return;
            }

            using (StreamWriter file = new StreamWriter("receis.txt"))
			{
				foreach (Entity entity in Receits)
				{
					string line = string.Empty;
					((Receit)entity).ID = GenerateReceitsID().ToString();
					line += ((Receit)entity).ID + "|";
					line += ((Receit)entity).Price.ToString() + "|";
					line += ((Receit)entity).DrugDealer + "|";
					line += ((Receit)entity).DateAndTime.ToString("MM/dd/yyyy") + "|";

					string drugs = string.Empty;

					foreach (KeyValuePair<string, double> item in ((Receit)entity).DrugsAndQuantity)
					{
						drugs += item.Key + "," + item.Value + ";";
					}

					if (drugs != "")
					{
						drugs.Remove(drugs.Length - 1);
					}

					line += drugs;

					file.WriteLine(line);
				}
			}
		}

		public List<Entity> ImportReceits()
		{
			List<Entity> result = new List<Entity>();

			if (!File.Exists("receis.txt"))
			{
				return result;
			}

			StreamReader reader = new StreamReader("receis.txt");
			string line;

			while ((line = reader.ReadLine()) != null)
			{
				string[] data = line.Split('|');

				Receit recepie = new Receit();
				recepie.ID = data[0];
				recepie.Price = double.Parse(data[1]);
				recepie.DrugDealer = data[2];
				recepie.DateAndTime = DateTime.ParseExact(data[3], "MM/dd/yyyy", null);

				Dictionary<string, double> dic = new Dictionary<string, double>();

				string[] items = data[4].Split(';');
				
				foreach (string i in items)
				{
					if (i == "")
					{
						continue;
					}

					string[] ii = i.Split(',');

					dic.Add(ii[0], double.Parse(ii[1]));
				}

				recepie.DrugsAndQuantity = dic;

				result.Add(recepie);
			}

			return result;
		}

		public void Save()
        {
            SaveUsers();
            SaveDrugs();
			SaveRecepie();
			SaveReceis();

		}

		public int GenerateRecepieID()
		{
			int i = 0;

			foreach(Entity entity in Recepies)
			{
				if(entity.ID == "" )
				{
					continue;
				}

				if(int.Parse(entity.ID) > i)
				{
					i = int.Parse(entity.ID);
				}
			}

			return i + 1; 
		}

		public int GenerateReceitsID()
		{
			int i = 0;

			foreach (Entity entity in Recepies)
			{
				if (entity.ID == "")
				{
					continue;
				}

				if (int.Parse(entity.ID) > i)
				{
					i = int.Parse(entity.ID);
				}
			}

			return i + 1;
		}

		public UserType GetUserType(string value)
		{
			if(value == "Administratior")
			{
				return UserType.Administratior;
			}

			if(value == "Doctor")
			{
				return UserType.Doctor;
			}

			return UserType.DrugDealer;
		}
	}
}
