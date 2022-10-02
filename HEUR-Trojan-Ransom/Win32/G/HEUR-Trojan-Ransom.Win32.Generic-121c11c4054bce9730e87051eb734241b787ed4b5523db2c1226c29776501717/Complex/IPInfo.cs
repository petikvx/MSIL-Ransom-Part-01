using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;

namespace Complex;

public class IPInfo
{
	private string _HostName = string.Empty;

	public string MacAddress { get; private set; }

	public string IPAddress { get; private set; }

	public string HostName
	{
		get
		{
			if (string.IsNullOrEmpty(_HostName))
			{
				try
				{
					_HostName = Dns.GetHostEntry(IPAddress).HostName;
				}
				catch
				{
					_HostName = string.Empty;
				}
			}
			return _HostName;
		}
	}

	public IPInfo(string macAddress, string ipAddress)
	{
		MacAddress = macAddress;
		IPAddress = ipAddress;
	}

	public static IPInfo GetIPInfo(string macAddress)
	{
		return (from ip in GetIPInfo()
			where ip.MacAddress.ToLowerInvariant() == macAddress.ToLowerInvariant()
			select ip).FirstOrDefault();
	}

	public static List<IPInfo> GetIPInfo()
	{
		try
		{
			List<IPInfo> list = new List<IPInfo>();
			string[] array = GetARPResult().Split('\n', '\r');
			foreach (string text in array)
			{
				if (!string.IsNullOrEmpty(text))
				{
					string[] array2 = (from piece in text.Split(' ', '\t')
						where !string.IsNullOrEmpty(piece)
						select piece).ToArray();
					if (array2.Length == 3)
					{
						list.Add(new IPInfo(array2[1], array2[0]));
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

	private static string GetARPResult()
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
