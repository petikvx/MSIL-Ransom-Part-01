using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace YzTymtbtgFABHvJvj;

public class CpsHVasgAe
{
	[CompilerGenerated]
	private sealed class WQGgpyYYYriuvcWH
	{
		public string FdDtbvSBEpVmdU;

		public bool _003CGetIPInfo_003Eb__0(CpsHVasgAe ip)
		{
			return ip.EvwSDUcfodVXL.ToLowerInvariant() == FdDtbvSBEpVmdU.ToLowerInvariant();
		}
	}

	private string yVXuglwHrVoOGHI = string.Empty;

	public string EvwSDUcfodVXL { get; private set; }

	public string FFxDkVWJYZOA { get; private set; }

	public string bznXikeBEaus
	{
		get
		{
			if (string.IsNullOrEmpty(yVXuglwHrVoOGHI))
			{
				try
				{
					yVXuglwHrVoOGHI = Dns.GetHostEntry(FFxDkVWJYZOA).HostName;
				}
				catch
				{
					yVXuglwHrVoOGHI = string.Empty;
				}
			}
			return yVXuglwHrVoOGHI;
		}
	}

	public CpsHVasgAe(string xBLLbtTbejdq, string YuZZnzFzbDHpUsL)
	{
		EvwSDUcfodVXL = xBLLbtTbejdq;
		FFxDkVWJYZOA = YuZZnzFzbDHpUsL;
	}

	public static CpsHVasgAe mgvleAtCdFBedWa(string pKXKBYehTCmW)
	{
		return (from ip in cIWmfhpGhkv()
			where ip.EvwSDUcfodVXL.ToLowerInvariant() == pKXKBYehTCmW.ToLowerInvariant()
			select ip).FirstOrDefault();
	}

	public static List<CpsHVasgAe> cIWmfhpGhkv()
	{
		try
		{
			List<CpsHVasgAe> list = new List<CpsHVasgAe>();
			string[] array = BBhrvKMZeogcb().Split('\n', '\r');
			foreach (string text in array)
			{
				if (!string.IsNullOrEmpty(text))
				{
					string[] array2 = (from paGowyZJYWaz in text.Split(' ', '\t')
						where !string.IsNullOrEmpty(paGowyZJYWaz)
						select paGowyZJYWaz).ToArray();
					if (array2.Length == 3)
					{
						list.Add(new CpsHVasgAe(array2[1], array2[0]));
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

	private static string BBhrvKMZeogcb()
	{
		Process process = null;
		string result = string.Empty;
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo("arp", "-a");
			processStartInfo.CreateNoWindow = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.RedirectStandardOutput = true;
			process = Process.Start(processStartInfo);
			result = process.StandardOutput.ReadToEnd();
			process.Close();
		}
		catch (Exception innerException)
		{
			throw new Exception("IPInfo: Error Retrieving 'arp -a' Results", innerException);
		}
		finally
		{
			process?.Close();
		}
		return result;
	}
}
