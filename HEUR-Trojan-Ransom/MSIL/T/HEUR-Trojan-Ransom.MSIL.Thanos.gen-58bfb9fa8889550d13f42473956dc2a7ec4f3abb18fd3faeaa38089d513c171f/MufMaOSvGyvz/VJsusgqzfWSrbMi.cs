using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MufMaOSvGyvz;

public class VJsusgqzfWSrbMi
{
	private string MIVThsKTpvf = string.Empty;

	private string _003CMacAddress_003Ek__BackingField;

	private string _003CIPAddress_003Ek__BackingField;

	private static Func<string, bool> CS_0024_003C_003E9__CachedAnonymousMethodDelegate4;

	public string MacAddress
	{
		get
		{
			return _003CMacAddress_003Ek__BackingField;
		}
		private set
		{
			_003CMacAddress_003Ek__BackingField = value;
		}
	}

	public string IPAddress
	{
		get
		{
			return _003CIPAddress_003Ek__BackingField;
		}
		private set
		{
			_003CIPAddress_003Ek__BackingField = value;
		}
	}

	public VJsusgqzfWSrbMi(string string_0, string string_1)
	{
		MacAddress = string_0;
		IPAddress = string_1;
	}

	public static List<VJsusgqzfWSrbMi> waPssoquJEsup()
	{
		try
		{
			List<VJsusgqzfWSrbMi> list = new List<VJsusgqzfWSrbMi>();
			string[] array = DlYLhXnJueaptK().Split('\n', '\r');
			foreach (string text in array)
			{
				if (string.IsNullOrEmpty(text))
				{
					continue;
				}
				string[] source = text.Split(' ', '\t');
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate4 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate4 = (string string_0) => !string.IsNullOrEmpty(string_0);
				}
				string[] array2 = source.Where(CS_0024_003C_003E9__CachedAnonymousMethodDelegate4).ToArray();
				if (array2.Length == 3)
				{
					list.Add(new VJsusgqzfWSrbMi(array2[1], array2[0]));
				}
			}
			return list;
		}
		catch (Exception innerException)
		{
			throw new Exception("IPInfo: Error Parsing 'arp -a' results", innerException);
		}
	}

	private static string DlYLhXnJueaptK()
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

	private static bool _003CGetIPInfo_003Eb__3(string string_0)
	{
		return !string.IsNullOrEmpty(string_0);
	}
}
