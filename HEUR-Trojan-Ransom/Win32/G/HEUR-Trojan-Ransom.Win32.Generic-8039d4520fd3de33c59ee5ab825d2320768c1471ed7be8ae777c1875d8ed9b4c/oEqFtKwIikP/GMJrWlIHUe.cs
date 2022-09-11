using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace oEqFtKwIikP;

public class GMJrWlIHUe
{
	[CompilerGenerated]
	private sealed class IbIuWEzLZBlLXqr
	{
		public string VEOJOXgJLp;

		public bool _003CGetIPInfo_003Eb__0(GMJrWlIHUe ip)
		{
			return ip.BTYBwtefAvJTFufg.ToLowerInvariant() == VEOJOXgJLp.ToLowerInvariant();
		}
	}

	private string JTOQMjLfuLpvn = string.Empty;

	public string BTYBwtefAvJTFufg { get; private set; }

	public string XqooAECwffbFXthoSi { get; private set; }

	public string sYsFRrqDzfAPk
	{
		get
		{
			if (string.IsNullOrEmpty(JTOQMjLfuLpvn))
			{
				try
				{
					JTOQMjLfuLpvn = Dns.GetHostEntry(XqooAECwffbFXthoSi).HostName;
				}
				catch
				{
					JTOQMjLfuLpvn = string.Empty;
				}
			}
			return JTOQMjLfuLpvn;
		}
	}

	public GMJrWlIHUe(string gOjFduzdrRifK, string CRwUveiMWuXxBYj)
	{
		BTYBwtefAvJTFufg = gOjFduzdrRifK;
		XqooAECwffbFXthoSi = CRwUveiMWuXxBYj;
	}

	public static GMJrWlIHUe JnIRFUeCKy(string TYQmmIYxzRwM)
	{
		return (from ip in niOvZnVGLkKrPrn()
			where ip.BTYBwtefAvJTFufg.ToLowerInvariant() == TYQmmIYxzRwM.ToLowerInvariant()
			select ip).FirstOrDefault();
	}

	public static List<GMJrWlIHUe> niOvZnVGLkKrPrn()
	{
		try
		{
			List<GMJrWlIHUe> list = new List<GMJrWlIHUe>();
			string[] array = OVmECOmiJnQu().Split('\n', '\r');
			foreach (string text in array)
			{
				if (!string.IsNullOrEmpty(text))
				{
					string[] array2 = (from StWPvlyDvFSUw in text.Split(' ', '\t')
						where !string.IsNullOrEmpty(StWPvlyDvFSUw)
						select StWPvlyDvFSUw).ToArray();
					if (array2.Length == 3)
					{
						list.Add(new GMJrWlIHUe(array2[1], array2[0]));
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

	private static string OVmECOmiJnQu()
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
