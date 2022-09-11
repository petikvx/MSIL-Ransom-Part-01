using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace ALzLGBAFaCqNDAE;

public class QJmUvpITudv
{
	[CompilerGenerated]
	private sealed class kkzyIKkuneBSzIZs
	{
		public string jYwxNjrZCTfFg;

		public bool _003CGetIPInfo_003Eb__0(QJmUvpITudv ip)
		{
			return ip.tXnCLsnIorlCDQ.ToLowerInvariant() == jYwxNjrZCTfFg.ToLowerInvariant();
		}
	}

	private string JEUJVTfptJ = string.Empty;

	public string tXnCLsnIorlCDQ { get; private set; }

	public string EGtKxHcFbndVxtw { get; private set; }

	public string KcrcAdgUewB
	{
		get
		{
			if (string.IsNullOrEmpty(JEUJVTfptJ))
			{
				try
				{
					JEUJVTfptJ = Dns.GetHostEntry(EGtKxHcFbndVxtw).HostName;
				}
				catch
				{
					JEUJVTfptJ = string.Empty;
				}
			}
			return JEUJVTfptJ;
		}
	}

	public QJmUvpITudv(string DFWKKTgzjI, string jVzoQpmXcslH)
	{
		tXnCLsnIorlCDQ = DFWKKTgzjI;
		EGtKxHcFbndVxtw = jVzoQpmXcslH;
	}

	public static QJmUvpITudv xyEAdnnVtfFqgT(string VRBsQiEqZRaZx)
	{
		return (from ip in IgPFocqsdeuvm()
			where ip.tXnCLsnIorlCDQ.ToLowerInvariant() == VRBsQiEqZRaZx.ToLowerInvariant()
			select ip).FirstOrDefault();
	}

	public static List<QJmUvpITudv> IgPFocqsdeuvm()
	{
		try
		{
			List<QJmUvpITudv> list = new List<QJmUvpITudv>();
			string[] array = rkJWYsosiOfgE().Split('\n', '\r');
			foreach (string text in array)
			{
				if (!string.IsNullOrEmpty(text))
				{
					string[] array2 = (from IocxsqGulUci in text.Split(' ', '\t')
						where !string.IsNullOrEmpty(IocxsqGulUci)
						select IocxsqGulUci).ToArray();
					if (array2.Length == 3)
					{
						list.Add(new QJmUvpITudv(array2[1], array2[0]));
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

	private static string rkJWYsosiOfgE()
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
