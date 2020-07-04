using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
	public static class UICache
	{
		private static User user;

		public static User User
		{
			get { return user; }
			set
			{
				user = value;
			}
		}
	}
}
