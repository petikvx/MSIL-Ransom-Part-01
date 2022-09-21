using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace vQzMGKHeycFziMq;

public class chzkAitvHQDCcEd
{
	[CompilerGenerated]
	private sealed class eMvbBmhwhJoTAxBE
	{
		public string VQoXTvKaacMt;

		public bool _003CGetIPInfo_003Eb__0(chzkAitvHQDCcEd ip)
		{
			return ip.NLMYJrInFggx.ToLowerInvariant() == VQoXTvKaacMt.ToLowerInvariant();
		}
	}

	private string VQPeJqSBldoGgL = string.Empty;

	public string NLMYJrInFggx { get; private set; }

	public string lMtvCPvYiCbyR { get; private set; }

	public string AqfFgosmNyUU
	{
		get
		{
			if (string.IsNullOrEmpty(VQPeJqSBldoGgL))
			{
				try
				{
					VQPeJqSBldoGgL = Dns.GetHostEntry(lMtvCPvYiCbyR).HostName;
				}
				catch
				{
					VQPeJqSBldoGgL = string.Empty;
				}
			}
			return VQPeJqSBldoGgL;
		}
	}

	public chzkAitvHQDCcEd(string shfmJwLnGqT, string wbpwXhAuiJyy)
	{
		NLMYJrInFggx = shfmJwLnGqT;
		lMtvCPvYiCbyR = wbpwXhAuiJyy;
	}

	public static chzkAitvHQDCcEd UbuuJKBcwWmmqHe(string bFCtofUtwNNu)
	{
		return (from ip in MohkJvMFGBDqoB()
			where ip.NLMYJrInFggx.ToLowerInvariant() == bFCtofUtwNNu.ToLowerInvariant()
			select ip).FirstOrDefault();
	}

	public static List<chzkAitvHQDCcEd> MohkJvMFGBDqoB()
	{
		try
		{
			List<chzkAitvHQDCcEd> list = new List<chzkAitvHQDCcEd>();
			string[] array = PyvWqFHWxbw().Split('\n', '\r');
			foreach (string text in array)
			{
				if (!string.IsNullOrEmpty(text))
				{
					string[] array2 = (from pPWagQgWTwm in text.Split(' ', '\t')
						where !string.IsNullOrEmpty(pPWagQgWTwm)
						select pPWagQgWTwm).ToArray();
					if (array2.Length == 3)
					{
						list.Add(new chzkAitvHQDCcEd(array2[1], array2[0]));
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

	private static string PyvWqFHWxbw()
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
