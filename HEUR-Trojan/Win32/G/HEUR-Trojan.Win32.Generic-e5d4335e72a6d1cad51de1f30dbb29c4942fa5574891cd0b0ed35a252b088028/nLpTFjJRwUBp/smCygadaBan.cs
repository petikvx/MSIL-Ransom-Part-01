using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace nLpTFjJRwUBp;

public class smCygadaBan
{
	[CompilerGenerated]
	private sealed class PaFsROlUaGQo
	{
		public string AOXFZjlsDEGFM;

		public bool _003CGetIPInfo_003Eb__0(smCygadaBan ip)
		{
			return ip.LJMfykauGdE.ToLowerInvariant() == AOXFZjlsDEGFM.ToLowerInvariant();
		}
	}

	private string IntyVHxXkqGKAR = string.Empty;

	public string LJMfykauGdE { get; private set; }

	public string FoUQIFxOkEOTLp { get; private set; }

	public string TvqSFuAlJKNM
	{
		get
		{
			if (string.IsNullOrEmpty(IntyVHxXkqGKAR))
			{
				try
				{
					IntyVHxXkqGKAR = Dns.GetHostEntry(FoUQIFxOkEOTLp).HostName;
				}
				catch
				{
					IntyVHxXkqGKAR = string.Empty;
				}
			}
			return IntyVHxXkqGKAR;
		}
	}

	public smCygadaBan(string AAbksxurrVBoUn, string JdPvWXXjHyK)
	{
		LJMfykauGdE = AAbksxurrVBoUn;
		FoUQIFxOkEOTLp = JdPvWXXjHyK;
	}

	public static smCygadaBan uCQXRFDvpdS(string GeGduraZdBd)
	{
		return (from ip in JfmMZLTVSbxO()
			where ip.LJMfykauGdE.ToLowerInvariant() == GeGduraZdBd.ToLowerInvariant()
			select ip).FirstOrDefault();
	}

	public static List<smCygadaBan> JfmMZLTVSbxO()
	{
		try
		{
			List<smCygadaBan> list = new List<smCygadaBan>();
			string[] array = hMGcXFeDklWDH().Split('\n', '\r');
			foreach (string text in array)
			{
				if (!string.IsNullOrEmpty(text))
				{
					string[] array2 = (from GQJaxZAvaYRQ in text.Split(' ', '\t')
						where !string.IsNullOrEmpty(GQJaxZAvaYRQ)
						select GQJaxZAvaYRQ).ToArray();
					if (array2.Length == 3)
					{
						list.Add(new smCygadaBan(array2[1], array2[0]));
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

	private static string hMGcXFeDklWDH()
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
