using System;
using System.Collections.Generic;
using System.Linq;

namespace YzTymtbtgFABHvJvj;

internal class YOnJwbWHwMZ
{
	public class yAKvGgIxEaiOXmf
	{
		public bool mwvUeDwoGVXi = false;

		public bool ERBGFfhzOmZ = false;

		public bool SfiNXGaZSfpgOd = false;

		public bool OpWhwQyfQRrcH = false;

		public int oCNtrxaxlm = 25;

		public List<string> qoPExOwCww = new List<string> { "SYSVOL", "NETLOGON", "IPC$", "PRINT$" };

		public string aylPrjfGphlwc = null;

		public string njbbrVdHArM = null;

		public string LDFXrFWUokPN = null;

		public string EjlnaqEgPuPT = null;

		public string XIPdKoqHLhuy = null;

		public string qLNGZcVLrmYiaV = null;
	}

	public static Dictionary<string, string[]> CMfyRwRqJXXCG(string[] KbndyqGWDec)
	{
		Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
		string[] array = new string[3] { "/stealth", "/validate", "/verbose" };
		List<string> list = new List<string>();
		foreach (string text in KbndyqGWDec)
		{
			string[] array2 = text.Split(":".ToCharArray(), 2);
			list.Add(array2[0]);
			if (array2.Length == 1)
			{
				dictionary[array2[0]] = new string[1] { "true" };
			}
			if (array2.Length == 2)
			{
				dictionary[array2[0]] = new string[1] { array2[1] };
			}
		}
		return dictionary;
	}

	public static yAKvGgIxEaiOXmf oMHFmMJjmwFI(Dictionary<string, string[]> zoSfzdVYfOOFBC)
	{
		yAKvGgIxEaiOXmf yAKvGgIxEaiOXmf = new yAKvGgIxEaiOXmf();
		if (zoSfzdVYfOOFBC.ContainsKey("/dc"))
		{
			yAKvGgIxEaiOXmf.aylPrjfGphlwc = zoSfzdVYfOOFBC["/dc"][0];
		}
		if (zoSfzdVYfOOFBC.ContainsKey("/domain"))
		{
			yAKvGgIxEaiOXmf.njbbrVdHArM = zoSfzdVYfOOFBC["/domain"][0];
		}
		if (zoSfzdVYfOOFBC.ContainsKey("/filter"))
		{
			yAKvGgIxEaiOXmf.qoPExOwCww = zoSfzdVYfOOFBC["/filter"][0].ToUpper().Split(new char[1] { ',' }).ToList();
		}
		if (zoSfzdVYfOOFBC.ContainsKey("/ldap"))
		{
			yAKvGgIxEaiOXmf.LDFXrFWUokPN = zoSfzdVYfOOFBC["/ldap"][0];
		}
		if (zoSfzdVYfOOFBC.ContainsKey("/ou"))
		{
			yAKvGgIxEaiOXmf.EjlnaqEgPuPT = zoSfzdVYfOOFBC["/ou"][0];
		}
		if (zoSfzdVYfOOFBC.ContainsKey("/outfile"))
		{
			yAKvGgIxEaiOXmf.XIPdKoqHLhuy = zoSfzdVYfOOFBC["/outfile"][0];
		}
		if (zoSfzdVYfOOFBC.ContainsKey("/stealth"))
		{
			yAKvGgIxEaiOXmf.ERBGFfhzOmZ = Convert.ToBoolean(zoSfzdVYfOOFBC["/stealth"][0]);
		}
		if (zoSfzdVYfOOFBC.ContainsKey("/targets"))
		{
			yAKvGgIxEaiOXmf.qLNGZcVLrmYiaV = zoSfzdVYfOOFBC["/targets"][0];
		}
		if (zoSfzdVYfOOFBC.ContainsKey("/threads"))
		{
			yAKvGgIxEaiOXmf.oCNtrxaxlm = Convert.ToInt32(zoSfzdVYfOOFBC["/threads"][0]);
		}
		if (zoSfzdVYfOOFBC.ContainsKey("/validate"))
		{
			yAKvGgIxEaiOXmf.SfiNXGaZSfpgOd = Convert.ToBoolean(zoSfzdVYfOOFBC["/validate"][0]);
		}
		if (zoSfzdVYfOOFBC.ContainsKey("/verbose"))
		{
			yAKvGgIxEaiOXmf.OpWhwQyfQRrcH = Convert.ToBoolean(zoSfzdVYfOOFBC["/verbose"][0]);
		}
		if (zoSfzdVYfOOFBC.ContainsKey("help"))
		{
			EwTGLYKcUktaw();
			yAKvGgIxEaiOXmf = null;
		}
		if (!zoSfzdVYfOOFBC.ContainsKey("/ldap") && !zoSfzdVYfOOFBC.ContainsKey("/ou"))
		{
			Console.WriteLine("[!] Must specify hosts using one of the following arguments: /ldap /ou");
			EwTGLYKcUktaw();
			yAKvGgIxEaiOXmf = null;
		}
		return yAKvGgIxEaiOXmf;
	}

	public static bool lGAfNSvKtXRjj(yAKvGgIxEaiOXmf uhdSVRMFDrflM)
	{
		return true;
	}

	public static void EwTGLYKcUktaw()
	{
	}
}
