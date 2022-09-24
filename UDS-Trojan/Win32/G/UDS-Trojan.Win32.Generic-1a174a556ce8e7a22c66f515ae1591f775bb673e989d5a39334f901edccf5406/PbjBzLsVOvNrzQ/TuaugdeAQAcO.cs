using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace PbjBzLsVOvNrzQ;

public class TuaugdeAQAcO
{
	[CompilerGenerated]
	private sealed class CWilYstvrK
	{
		public string oLnyBjadRufMXPMB;

		public bool _003CGetIPInfo_003Eb__0(TuaugdeAQAcO ip)
		{
			return ip.qJCUfkkRoCoLs.ToLowerInvariant() == oLnyBjadRufMXPMB.ToLowerInvariant();
		}
	}

	private string npyQOyHuIfTz = string.Empty;

	public string qJCUfkkRoCoLs { get; private set; }

	public string UqULQkNkqbpV { get; private set; }

	public string GPhPhRQwvhZPuQlsB
	{
		get
		{
			if (string.IsNullOrEmpty(npyQOyHuIfTz))
			{
				try
				{
					npyQOyHuIfTz = Dns.GetHostEntry(UqULQkNkqbpV).HostName;
				}
				catch
				{
					npyQOyHuIfTz = string.Empty;
				}
			}
			return npyQOyHuIfTz;
		}
	}

	public TuaugdeAQAcO(string riMEbTYsbreZBP, string DLDwZJLWPSpVMUWw)
	{
		qJCUfkkRoCoLs = riMEbTYsbreZBP;
		UqULQkNkqbpV = DLDwZJLWPSpVMUWw;
	}

	public static TuaugdeAQAcO MGCnPXEAxV(string NjvZGVnszzDErzbK)
	{
		return (from ip in MDDWbyxZUMiY()
			where ip.qJCUfkkRoCoLs.ToLowerInvariant() == NjvZGVnszzDErzbK.ToLowerInvariant()
			select ip).FirstOrDefault();
	}

	public static List<TuaugdeAQAcO> MDDWbyxZUMiY()
	{
		try
		{
			List<TuaugdeAQAcO> list = new List<TuaugdeAQAcO>();
			string[] array = IiwZbfwnjbbDpNXi().Split('\n', '\r');
			foreach (string text in array)
			{
				if (!string.IsNullOrEmpty(text))
				{
					string[] array2 = (from EZcinTqzAEYNI in text.Split(' ', '\t')
						where !string.IsNullOrEmpty(EZcinTqzAEYNI)
						select EZcinTqzAEYNI).ToArray();
					if (array2.Length == 3)
					{
						list.Add(new TuaugdeAQAcO(array2[1], array2[0]));
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

	private static string IiwZbfwnjbbDpNXi()
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
