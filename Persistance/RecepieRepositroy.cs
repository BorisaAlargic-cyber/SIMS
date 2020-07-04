using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class RecepieRepository : Repository<Recepie>
    {
		public override IEnumerable<Entity> Search(string term = "")
		{
			List<Entity> result = new List<Entity>();

			foreach (Entity item in ApplicationContext.Instance.Recepies)
			{
				if (((Recepie)item).ID.Contains(term) || ((Recepie)item).JMBG.Contains(term) || ((Recepie)item).Doctor.Contains(term) || ((Recepie)item).DrugsAndQuantity.ContainsKey(term))
				{
					result.Add(item);
				}
			}

			return result;
		}
	}
}
