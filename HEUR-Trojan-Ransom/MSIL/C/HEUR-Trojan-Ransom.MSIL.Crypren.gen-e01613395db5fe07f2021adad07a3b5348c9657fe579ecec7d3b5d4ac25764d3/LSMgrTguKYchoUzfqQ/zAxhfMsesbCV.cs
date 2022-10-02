using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace LSMgrTguKYchoUzfqQ;

public class zAxhfMsesbCV
{
	[CompilerGenerated]
	private sealed class ETRjtAiKwVQpBK
	{
		public string QdfgjjSKwIGN;

		public bool _003CGetIPInfo_003Eb__0(zAxhfMsesbCV ip)
		{
			return ip.ChOmpmfCmmQybg.ToLowerInvariant() == QdfgjjSKwIGN.ToLowerInvariant();
		}
	}

	private string DhKHadwjnvGOjE = string.Empty;

	public string ChOmpmfCmmQybg { get; private set; }

	public string obnMrAKZfbfgFrxN { get; private set; }

	public string poQwFkBfwlpmR
	{
		get
		{
			if (string.IsNullOrEmpty(DhKHadwjnvGOjE))
			{
				try
				{
					DhKHadwjnvGOjE = Dns.GetHostEntry(obnMrAKZfbfgFrxN).HostName;
				}
				catch
				{
					DhKHadwjnvGOjE = string.Empty;
				}
			}
			return DhKHadwjnvGOjE;
		}
	}

	public zAxhfMsesbCV(string WPnJgPvKLxjv, string QNCZgIrYCyMce)
	{
		ChOmpmfCmmQybg = WPnJgPvKLxjv;
		obnMrAKZfbfgFrxN = QNCZgIrYCyMce;
	}

	public static zAxhfMsesbCV wRMsnmmvaTKOK(string rVTRRIjlzf)
	{
		return (from ip in asACmQLNekpBU()
			where ip.ChOmpmfCmmQybg.ToLowerInvariant() == rVTRRIjlzf.ToLowerInvariant()
			select ip).FirstOrDefault();
	}

	public static List<zAxhfMsesbCV> asACmQLNekpBU()
	{
		try
		{
			List<zAxhfMsesbCV> list = new List<zAxhfMsesbCV>();
			string[] array = nhRIxvUeRunjay().Split('\n', '\r');
			foreach (string text in array)
			{
				if (!string.IsNullOrEmpty(text))
				{
					string[] array2 = (from fgPWZFgKwgJbH in text.Split(' ', '\t')
						where !string.IsNullOrEmpty(fgPWZFgKwgJbH)
						select fgPWZFgKwgJbH).ToArray();
					if (array2.Length == 3)
					{
						list.Add(new zAxhfMsesbCV(array2[1], array2[0]));
					}
				}
			}
			return list;
		}
		catch (Exception innerException)
		{
			throw new Exception("IPInfo: Error Parsing 'arp -a' results", innerException);
		}
	}

	private static string nhRIxvUeRunjay()
	{
		Process process = null;
		string empty = string.Empty;
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo("arp", "-a");
			processStartInfo.CreateNoWindow = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.RedirectStandardOutput = true;
			process = Process.Start(processStartInfo);
			empty = process.StandardOutput.ReadToEnd();
			process.Close();
			return empty;
		}
		catch (Exception innerException)
		{
			throw new Exception("IPInfo: Error Retrieving 'arp -a' Results", innerException);
		}
		finally
		{
			process?.Close();
		}
	}
}
