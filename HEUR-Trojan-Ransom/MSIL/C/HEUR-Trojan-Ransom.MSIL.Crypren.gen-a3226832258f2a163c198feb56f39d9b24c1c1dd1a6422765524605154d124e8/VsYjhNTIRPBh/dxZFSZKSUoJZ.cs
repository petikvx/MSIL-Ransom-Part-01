using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace VsYjhNTIRPBh;

public class dxZFSZKSUoJZ
{
	[CompilerGenerated]
	private sealed class BwwrBoAUjEnEh
	{
		public string qUpoQHHSNzh;

		public bool _003CGetIPInfo_003Eb__0(dxZFSZKSUoJZ ip)
		{
			return ip.ocfoMLpaQOG.ToLowerInvariant() == qUpoQHHSNzh.ToLowerInvariant();
		}
	}

	private string KxZHdVAWxHqaiyq = string.Empty;

	public string ocfoMLpaQOG { get; private set; }

	public string IWNFVgDTwOXS { get; private set; }

	public string seOrmfibPylkwF
	{
		get
		{
			if (string.IsNullOrEmpty(KxZHdVAWxHqaiyq))
			{
				try
				{
					KxZHdVAWxHqaiyq = Dns.GetHostEntry(IWNFVgDTwOXS).HostName;
				}
				catch
				{
					KxZHdVAWxHqaiyq = string.Empty;
				}
			}
			return KxZHdVAWxHqaiyq;
		}
	}

	public dxZFSZKSUoJZ(string apEbVckiMXVOsn, string PqBALZxTGS)
	{
		ocfoMLpaQOG = apEbVckiMXVOsn;
		IWNFVgDTwOXS = PqBALZxTGS;
	}

	public static dxZFSZKSUoJZ ACTkgRtDFgvx(string iKfBNOkmurccgQW)
	{
		return (from ip in QBIcfPSwIUAKfh()
			where ip.ocfoMLpaQOG.ToLowerInvariant() == iKfBNOkmurccgQW.ToLowerInvariant()
			select ip).FirstOrDefault();
	}

	public static List<dxZFSZKSUoJZ> QBIcfPSwIUAKfh()
	{
		try
		{
			List<dxZFSZKSUoJZ> list = new List<dxZFSZKSUoJZ>();
			string[] array = aGjOSYVUGnNNC().Split('\n', '\r');
			foreach (string text in array)
			{
				if (!string.IsNullOrEmpty(text))
				{
					string[] array2 = (from wpaiclVeBTQJJGk in text.Split(' ', '\t')
						where !string.IsNullOrEmpty(wpaiclVeBTQJJGk)
						select wpaiclVeBTQJJGk).ToArray();
					if (array2.Length == 3)
					{
						list.Add(new dxZFSZKSUoJZ(array2[1], array2[0]));
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

	private static string aGjOSYVUGnNNC()
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
