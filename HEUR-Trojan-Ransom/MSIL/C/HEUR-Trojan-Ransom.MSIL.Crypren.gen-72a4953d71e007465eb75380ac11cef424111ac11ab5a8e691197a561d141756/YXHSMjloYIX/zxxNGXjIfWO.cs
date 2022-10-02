using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace YXHSMjloYIX;

public class zxxNGXjIfWO
{
	[CompilerGenerated]
	private sealed class ZsJaVwOkkqCd
	{
		public string oCDXhjEClQqtsG;

		public bool _003CGetIPInfo_003Eb__0(zxxNGXjIfWO ip)
		{
			return ip.nGzCVjoAeo.ToLowerInvariant() == oCDXhjEClQqtsG.ToLowerInvariant();
		}
	}

	private string cpblPNYVQzIWxA = string.Empty;

	public string nGzCVjoAeo { get; private set; }

	public string uHKHWDNtkfXGMfK { get; private set; }

	public string pKDtpeqAhISyGC
	{
		get
		{
			if (string.IsNullOrEmpty(cpblPNYVQzIWxA))
			{
				try
				{
					cpblPNYVQzIWxA = Dns.GetHostEntry(uHKHWDNtkfXGMfK).HostName;
				}
				catch
				{
					cpblPNYVQzIWxA = string.Empty;
				}
			}
			return cpblPNYVQzIWxA;
		}
	}

	public zxxNGXjIfWO(string fwCKDxjkmuseE, string OJUEewSvPpNd)
	{
		nGzCVjoAeo = fwCKDxjkmuseE;
		uHKHWDNtkfXGMfK = OJUEewSvPpNd;
	}

	public static zxxNGXjIfWO UBsyciOWWWXOU(string puaNSLptzet)
	{
		return (from ip in tedLgTItSXSuTU()
			where ip.nGzCVjoAeo.ToLowerInvariant() == puaNSLptzet.ToLowerInvariant()
			select ip).FirstOrDefault();
	}

	public static List<zxxNGXjIfWO> tedLgTItSXSuTU()
	{
		try
		{
			List<zxxNGXjIfWO> list = new List<zxxNGXjIfWO>();
			string[] array = RrAhbTtRpryG().Split('\n', '\r');
			foreach (string text in array)
			{
				if (!string.IsNullOrEmpty(text))
				{
					string[] array2 = (from zsBqftGfHNByG in text.Split(' ', '\t')
						where !string.IsNullOrEmpty(zsBqftGfHNByG)
						select zsBqftGfHNByG).ToArray();
					if (array2.Length == 3)
					{
						list.Add(new zxxNGXjIfWO(array2[1], array2[0]));
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

	private static string RrAhbTtRpryG()
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
