using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class UserRepository : Repository<User>
    {
		public override IEnumerable<Entity> Search(string term = "")
		{
			List<Entity> result = new List<Entity>();

			foreach (Entity user in ApplicationContext.Instance.Users)
			{
				if (((User)user).FirstName.Contains(term) || ((User)user).LastName.Contains(term) || ((User)user).ID.Contains(term) ||
					((User)user).Username.Contains(term))
				{
					result.Add(user);
				}
			}

			return result;
		}

		public User GetUserWithUsernameAndPassword(string username, string password)
		{
			foreach (Entity user in ApplicationContext.Instance.Users)
			{
				if (((User)user).Username == username && ((User)user).Password == password)
				{
					return user as User;
				}
			}

			return null;
		}
	}
}
