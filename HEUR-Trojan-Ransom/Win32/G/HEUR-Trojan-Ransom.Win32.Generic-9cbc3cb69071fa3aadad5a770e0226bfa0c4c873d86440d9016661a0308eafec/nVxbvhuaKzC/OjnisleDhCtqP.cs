using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nVxbvhuaKzC;

public sealed class OjnisleDhCtqP
{
	private string MgBDaDiIpGRFWp = string.Empty;

	private string _003CMacAddress_003Ek__BackingField;

	private string _003CIPAddress_003Ek__BackingField;

	private static Func<string, bool> CS_0024_003C_003E9__CachedAnonymousMethodDelegate4;

	[NonSerialized]
	internal static GetString getString_0;

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

	public OjnisleDhCtqP(string string_0, string string_1)
	{
		MacAddress = string_0;
		IPAddress = string_1;
	}

	public static List<OjnisleDhCtqP> XRIvuWSIGVLO()
	{
		try
		{
			List<OjnisleDhCtqP> list = new List<OjnisleDhCtqP>();
			string[] array = yZlUEQETZNZfT().Split('\n', '\r');
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
					list.Add(new OjnisleDhCtqP(array2[1], array2[0]));
				}
			}
			return list;
		}
		catch (Exception innerException)
		{
			throw new Exception(getString_0(107408709), innerException);
		}
	}

	private static string yZlUEQETZNZfT()
	{
		Process process = null;
		string result = string.Empty;
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(getString_0(107408656), getString_0(107408651));
			processStartInfo.CreateNoWindow = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.RedirectStandardOutput = true;
			process = Process.Start(processStartInfo);
			result = process.StandardOutput.ReadToEnd();
			process.Close();
		}
		catch (Exception innerException)
		{
			throw new Exception(getString_0(107408646), innerException);
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

	static OjnisleDhCtqP()
	{
		Strings.CreateGetStringDelegate(typeof(OjnisleDhCtqP));
	}
}
