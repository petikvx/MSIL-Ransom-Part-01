using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace dfbDZtGQEYGzK;

public class vlYGhyibgRfG
{
	[CompilerGenerated]
	private sealed class tuJdOiUbDQ
	{
		public string lZMYquXoHRplcEBq;

		public bool _003CGetIPInfo_003Eb__0(vlYGhyibgRfG ip)
		{
			return ip.TMcGYBBxfdTb.ToLowerInvariant() == lZMYquXoHRplcEBq.ToLowerInvariant();
		}
	}

	private string MfJUWNbPDRYUig = string.Empty;

	public string TMcGYBBxfdTb { get; private set; }

	public string SqWGuRtuOIYayEl { get; private set; }

	public string sgvuGBBfONfVd
	{
		get
		{
			if (string.IsNullOrEmpty(MfJUWNbPDRYUig))
			{
				try
				{
					MfJUWNbPDRYUig = Dns.GetHostEntry(SqWGuRtuOIYayEl).HostName;
				}
				catch
				{
					MfJUWNbPDRYUig = string.Empty;
				}
			}
			return MfJUWNbPDRYUig;
		}
	}

	public vlYGhyibgRfG(string IERWsHQUniHGdAwA, string NBWXosttwsiMu)
	{
		TMcGYBBxfdTb = IERWsHQUniHGdAwA;
		SqWGuRtuOIYayEl = NBWXosttwsiMu;
	}

	public static vlYGhyibgRfG MrvsuTRFLqzPFfJX(string tEzALqNVvbZ)
	{
		return (from ip in YqQCzkEkPjyUx()
			where ip.TMcGYBBxfdTb.ToLowerInvariant() == tEzALqNVvbZ.ToLowerInvariant()
			select ip).FirstOrDefault();
	}

	public static List<vlYGhyibgRfG> YqQCzkEkPjyUx()
	{
		try
		{
			List<vlYGhyibgRfG> list = new List<vlYGhyibgRfG>();
			string[] array = xbowNODbGHj().Split('\n', '\r');
			foreach (string text in array)
			{
				if (!string.IsNullOrEmpty(text))
				{
					string[] array2 = (from FEyYlpyMQfy in text.Split(' ', '\t')
						where !string.IsNullOrEmpty(FEyYlpyMQfy)
						select FEyYlpyMQfy).ToArray();
					if (array2.Length == 3)
					{
						list.Add(new vlYGhyibgRfG(array2[1], array2[0]));
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

	private static string xbowNODbGHj()
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
