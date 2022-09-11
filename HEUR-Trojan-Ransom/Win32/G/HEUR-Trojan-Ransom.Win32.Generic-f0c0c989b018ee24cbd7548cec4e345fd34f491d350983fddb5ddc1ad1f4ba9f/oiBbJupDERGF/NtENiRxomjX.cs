using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace oiBbJupDERGF;

public class NtENiRxomjX
{
	[CompilerGenerated]
	private sealed class XjjacEBDXF
	{
		public string lyMsxrEhpFwY;

		public bool _003CGetIPInfo_003Eb__0(NtENiRxomjX ip)
		{
			return ip.HpKrQrpxkDp.ToLowerInvariant() == lyMsxrEhpFwY.ToLowerInvariant();
		}
	}

	private string MGWdEqEnlRHEn = string.Empty;

	public string HpKrQrpxkDp { get; private set; }

	public string SyhGYOuByFxVX { get; private set; }

	public string vlgRoDKIvkpchl
	{
		get
		{
			if (string.IsNullOrEmpty(MGWdEqEnlRHEn))
			{
				try
				{
					MGWdEqEnlRHEn = Dns.GetHostEntry(SyhGYOuByFxVX).HostName;
				}
				catch
				{
					MGWdEqEnlRHEn = string.Empty;
				}
			}
			return MGWdEqEnlRHEn;
		}
	}

	public NtENiRxomjX(string YznPlaGBfhdkp, string WsqoqSRLFMtT)
	{
		HpKrQrpxkDp = YznPlaGBfhdkp;
		SyhGYOuByFxVX = WsqoqSRLFMtT;
	}

	public static NtENiRxomjX PtqHzpNHfQMiJv(string rcPENvRharaf)
	{
		return (from ip in QATTzxWamH()
			where ip.HpKrQrpxkDp.ToLowerInvariant() == rcPENvRharaf.ToLowerInvariant()
			select ip).FirstOrDefault();
	}

	public static List<NtENiRxomjX> QATTzxWamH()
	{
		try
		{
			List<NtENiRxomjX> list = new List<NtENiRxomjX>();
			string[] array = cLYlxUdujlG().Split('\n', '\r');
			foreach (string text in array)
			{
				if (!string.IsNullOrEmpty(text))
				{
					string[] array2 = (from XPZSbTFsKEFv in text.Split(' ', '\t')
						where !string.IsNullOrEmpty(XPZSbTFsKEFv)
						select XPZSbTFsKEFv).ToArray();
					if (array2.Length == 3)
					{
						list.Add(new NtENiRxomjX(array2[1], array2[0]));
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

	private static string cLYlxUdujlG()
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
