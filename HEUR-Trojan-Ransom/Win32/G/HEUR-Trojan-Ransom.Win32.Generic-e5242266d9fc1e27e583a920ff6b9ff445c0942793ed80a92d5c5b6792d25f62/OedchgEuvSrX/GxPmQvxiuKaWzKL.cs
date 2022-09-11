using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace OedchgEuvSrX;

public class GxPmQvxiuKaWzKL
{
	[CompilerGenerated]
	private sealed class mzTugPXpKXCQ
	{
		public string OalOOgUNmME;

		public bool _003CGetIPInfo_003Eb__0(GxPmQvxiuKaWzKL ip)
		{
			return ip.hKKDBRnaSuqPfiM.ToLowerInvariant() == OalOOgUNmME.ToLowerInvariant();
		}
	}

	private string gaKKJaCAaljl = string.Empty;

	public string hKKDBRnaSuqPfiM { get; private set; }

	public string RXAKbhnlOUHnX { get; private set; }

	public string JkaGfvrcsFJgD
	{
		get
		{
			if (string.IsNullOrEmpty(gaKKJaCAaljl))
			{
				try
				{
					gaKKJaCAaljl = Dns.GetHostEntry(RXAKbhnlOUHnX).HostName;
				}
				catch
				{
					gaKKJaCAaljl = string.Empty;
				}
			}
			return gaKKJaCAaljl;
		}
	}

	public GxPmQvxiuKaWzKL(string INMKFJFbzzQXf, string qMMwWbElwrOSeN)
	{
		hKKDBRnaSuqPfiM = INMKFJFbzzQXf;
		RXAKbhnlOUHnX = qMMwWbElwrOSeN;
	}

	public static GxPmQvxiuKaWzKL IAAAuDdkKJyWca(string WuqLCTxtbii)
	{
		return (from ip in ovuRjJUphuPTErU()
			where ip.hKKDBRnaSuqPfiM.ToLowerInvariant() == WuqLCTxtbii.ToLowerInvariant()
			select ip).FirstOrDefault();
	}

	public static List<GxPmQvxiuKaWzKL> ovuRjJUphuPTErU()
	{
		try
		{
			List<GxPmQvxiuKaWzKL> list = new List<GxPmQvxiuKaWzKL>();
			string[] array = nlnmxxGFyHA().Split('\n', '\r');
			foreach (string text in array)
			{
				if (!string.IsNullOrEmpty(text))
				{
					string[] array2 = (from RqoKvrgIOGRBiMPs in text.Split(' ', '\t')
						where !string.IsNullOrEmpty(RqoKvrgIOGRBiMPs)
						select RqoKvrgIOGRBiMPs).ToArray();
					if (array2.Length == 3)
					{
						list.Add(new GxPmQvxiuKaWzKL(array2[1], array2[0]));
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

	private static string nlnmxxGFyHA()
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
