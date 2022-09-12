using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

internal class Class17
{
	private const int int_0 = 0;

	private const int int_1 = 5;

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern void BlockInput([In][MarshalAs(UnmanagedType.Bool)] bool bool_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool AllocConsole();

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr intptr_0, int int_2);

	public static void smethod_0()
	{
		_003CModule_003E.Class0.smethod_0();
		IntPtr consoleWindow = GetConsoleWindow();
		if (consoleWindow == IntPtr.Zero)
		{
			AllocConsole();
		}
		else
		{
			ShowWindow(consoleWindow, 5);
		}
	}

	public static void smethod_1()
	{
		_003CModule_003E.Class0.smethod_0();
		IntPtr consoleWindow = GetConsoleWindow();
		ShowWindow(consoleWindow, 0);
	}

	public static void smethod_2()
	{
		_003CModule_003E.Class0.smethod_0();
		IntPtr consoleWindow = GetConsoleWindow();
		ShowWindow(consoleWindow, 5);
	}

	private static void Main(string[] args)
	{
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		if (Class29.smethod_8() == "Enabled")
		{
			Console.WriteLine("This application is in freemode reirecting!");
		}
		Console.Title = "Swift Spoofer v1.3";
		Console.ForegroundColor = ConsoleColor.White;
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
		Console.WriteLine("                      ▄▄▄▄▄ ▄▄     ▄▄ ▄▄▄ ▄▄▄▄▄ ▄▄▄▄▄   ▄▄▄▄▄ ▄▄▄▄▄ ▄▄▄▄ ▄▄▄▄ ▄▄▄▄▄ ▄▄▄▄▄ ▄▄▄▄");
		Console.WriteLine("                     █─▄▄▄▄█▄─█▀▀▀█─▄█▄─▄█▄─▄▄─█─▄─▄─███─▄▄▄▄█▄─▄▄─█─▄▄─█─▄▄─█▄─▄▄─█▄─▄▄─█▄─▄▄▀█");
		Console.WriteLine("                     █▄▄▄▄─██─█─█─█─███─███─▄█████─█████▄▄▄▄─██─▄▄▄█─██─█─██─██─▄████─▄█▀██─▄─▄█");
		Console.WriteLine("                     ▀▄▄▄▄▄▀▀▄▄▄▀▄▄▄▀▀▄▄▄▀▄▄▄▀▀▀▀▄▄▄▀▀▀▀▄▄▄▄▄▀▄▄▄▀▀▀▄▄▄▄▀▄▄▄▄▀▄▄▄▀▀▀▄▄▄▄▄▀▄▄▀▄▄▀");
		Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
		Console.WriteLine();
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("[*] Choose an option from below:");
		Console.WriteLine();
		Console.WriteLine("[1] Login");
		Console.WriteLine("[2] Register");
		Console.ForegroundColor = ConsoleColor.Cyan;
		string text = Console.ReadLine();
		if (text == "4")
		{
			Console.Clear();
			Console.WriteLine("[*] Key:");
			if (Class21.smethod_6(Console.ReadLine()))
			{
				Console.WriteLine("[*] Key is valid!");
			}
			else
			{
				Console.WriteLine("[*] Key is invalid!");
			}
		}
		switch (text)
		{
		case "1":
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
			Console.WriteLine("                      ▄▄▄▄▄ ▄▄     ▄▄ ▄▄▄ ▄▄▄▄▄ ▄▄▄▄▄   ▄▄▄▄▄ ▄▄▄▄▄ ▄▄▄▄ ▄▄▄▄ ▄▄▄▄▄ ▄▄▄▄▄ ▄▄▄▄");
			Console.WriteLine("                     █─▄▄▄▄█▄─█▀▀▀█─▄█▄─▄█▄─▄▄─█─▄─▄─███─▄▄▄▄█▄─▄▄─█─▄▄─█─▄▄─█▄─▄▄─█▄─▄▄─█▄─▄▄▀█");
			Console.WriteLine("                     █▄▄▄▄─██─█─█─█─███─███─▄█████─█████▄▄▄▄─██─▄▄▄█─██─█─██─██─▄████─▄█▀██─▄─▄█");
			Console.WriteLine("                     ▀▄▄▄▄▄▀▀▄▄▄▀▄▄▄▀▀▄▄▄▀▄▄▄▀▀▀▀▄▄▄▀▀▀▀▄▄▄▄▄▀▄▄▄▀▀▀▄▄▄▄▀▄▄▄▄▀▄▄▄▀▀▀▄▄▄▄▄▀▄▄▀▄▄▀");
			Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("[*] Username:");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.ReadLine();
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("[*] Password:");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.ReadLine();
			MessageBox.Show("Cracked by Aptitude#2684 | GLOBALFALL.XYZ");
			smethod_3();
			break;
		case "2":
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
			Console.WriteLine("                      ▄▄▄▄▄ ▄▄     ▄▄ ▄▄▄ ▄▄▄▄▄ ▄▄▄▄▄   ▄▄▄▄▄ ▄▄▄▄▄ ▄▄▄▄ ▄▄▄▄ ▄▄▄▄▄ ▄▄▄▄▄ ▄▄▄▄");
			Console.WriteLine("                     █─▄▄▄▄█▄─█▀▀▀█─▄█▄─▄█▄─▄▄─█─▄─▄─███─▄▄▄▄█▄─▄▄─█─▄▄─█─▄▄─█▄─▄▄─█▄─▄▄─█▄─▄▄▀█");
			Console.WriteLine("                     █▄▄▄▄─██─█─█─█─███─███─▄█████─█████▄▄▄▄─██─▄▄▄█─██─█─██─██─▄████─▄█▀██─▄─▄█");
			Console.WriteLine("                     ▀▄▄▄▄▄▀▀▄▄▄▀▄▄▄▀▀▄▄▄▀▄▄▄▀▀▀▀▄▄▄▀▀▀▀▄▄▄▄▄▀▄▄▄▀▀▀▄▄▄▄▀▄▄▄▄▀▄▄▄▀▀▀▄▄▄▄▄▀▄▄▀▄▄▀");
			Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("[*] Username:");
			Console.ForegroundColor = ConsoleColor.Cyan;
			string? string_4 = Console.ReadLine();
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("[*] Password:");
			Console.ForegroundColor = ConsoleColor.Cyan;
			string string_5 = Console.ReadLine();
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("[*] Email:");
			Console.ForegroundColor = ConsoleColor.Cyan;
			string string_6 = Console.ReadLine();
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("[*] License");
			Console.ForegroundColor = ConsoleColor.Cyan;
			string string_7 = Console.ReadLine();
			if (Class21.smethod_5(string_4, string_5, string_6, string_7))
			{
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("[*] Successfully registered!");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Read();
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("[*] Failed to register!");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Read();
			}
			break;
		}
		default:
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("[*] Please choose a valid option, loader closing in 3 seconds...");
			Thread.Sleep(3000);
			Process.GetCurrentProcess().Kill();
			break;
		case "3":
		{
			Console.Clear();
			Console.WriteLine("[*] Username:");
			string? string_ = Console.ReadLine();
			Console.WriteLine("[*] Password:");
			string string_2 = Console.ReadLine();
			Console.WriteLine("[*] License:");
			string string_3 = Console.ReadLine();
			if (Class21.smethod_7(string_, string_2, string_3))
			{
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("[*] Successfully redeemed license & extended subscription!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.Read();
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("[*] Failed to redeem license!");
				Console.Read();
			}
			break;
		}
		}
	}

	public static void smethod_3()
	{
		Console.Clear();
		Class13.smethod_2();
		smethod_5();
		Console.WriteLine();
		Console.WriteLine();
		Console.ForegroundColor = ConsoleColor.DarkYellow;
		Console.WriteLine("\n\n   SwiftSpoofer (Modded) Started | GLOBALFALL.XYZ");
		Console.WriteLine();
		Console.WriteLine();
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("\n\n   [*] Hit (Enter) to start spoofing!");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine();
		Console.ReadKey();
		Class16.smethod_2();
		Class16.smethod_1();
		Console.Clear();
		smethod_5();
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("[+] Please do not interact with your computer as this proccess moves forward...");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("[*] Mapping Kernel Driver...");
		Class16.smethod_5();
		Class16.smethod_4();
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("[+] Kernel Driver Mapped");
		Console.ForegroundColor = ConsoleColor.White;
		Class15.smethod_0();
		Class15.smethod_5();
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("[*] Cleaning Registry...");
		Class20.smethod_0();
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("[+] Registry Cleaned");
		Thread.Sleep(2000);
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("[*] Removing Tracking Files...");
		Class20.smethod_3();
		Class20.smethod_1();
		Console.ForegroundColor = ConsoleColor.Cyan;
		Class20.smethod_4();
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("[+] Removed Tracking Files");
		Thread.Sleep(2000);
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("[*] Spoofing Bios...");
		Class18.smethod_1();
		Class18.smethod_2();
		Class18.smethod_0();
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("[+] Changed Bios Serials");
		Thread.Sleep(2000);
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("[*] Spoofing Volume ID...");
		Class12.smethod_3();
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("[+] Changed Volume ID Serials");
		Thread.Sleep(2000);
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("[*] Spoofing Mac Address");
		Class16.smethod_3();
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("[+] Changed Mac Address Serials...");
		File.Delete("C:\\Windows\\Speech\\MAC.exe");
		Thread.Sleep(2000);
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("[*] Spoof Complete!");
		Thread.Sleep(2000);
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("[+] Please close the spoofer!");
	}

	private static void smethod_4(string string_0)
	{
		_003CModule_003E.Class0.smethod_0();
		throw new NotImplementedException();
	}

	public static void smethod_5()
	{
	}

	public static void smethod_6()
	{
		_003CModule_003E.Class0.smethod_0();
		List<string> list = new List<string>();
		list.Add("MSI A320M PRO - E");
		list.Add("Asus Prime A320M-C R2.0");
		list.Add("Gigabyte GA - A320M - H");
		list.Add("ASRock Z390 Phantom Gaming SLI");
		list.Add("Asus ROG Rampage VI Extreme Omega");
		list.Add("Asus Prime H310I - Plus R2.0");
		list.Add("Asus ROG Zenith Extreme Alpha X399");
		list.Add("MSI MEG X299 Creation");
		list.Add("Asus P11C - X");
		list.Add("ASRock AB350M - HDV R3.0");
		list.Add("MSI B450M Pro-VDH V2");
		list.Add("MSI B450M Bazooka V2");
		list.Add("Asus Prime B450M - A / CSM");
		list.Add("Asus Prime H310I - Plus R2.0 / CSM");
		list.Add("Gigabyte GA-AB350M-DS3H V2 (rev. 1.1)");
		list.Add("Gigabyte B360 M AORUS PRO");
		list.Add("Gigabyte X299-WU8");
		list.Add("MSI MAG Z390M Mortar");
		Random random = new Random();
		int index = random.Next(list.Count);
		string value = list[index];
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue("BaseBoardProduct", value, RegistryValueKind.String);
			registryKey.Close();
		}
		List<string> list2 = new List<string>();
		list2.Add("1.0");
		list2.Add("2.0");
		list2.Add("3.0");
		list2.Add("4.0");
		list2.Add("5.0");
		list2.Add("6.0");
		list2.Add("7.0");
		list2.Add("8.0");
		list2.Add("9.0");
		list2.Add("1.1");
		list2.Add("1.2");
		list2.Add("1.3");
		list2.Add("1.4");
		list2.Add("1.5");
		list2.Add("1.6");
		Random random2 = new Random();
		int index2 = random2.Next(list2.Count);
		string value2 = list2[index2];
		RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", writable: true);
		if (registryKey2 != null)
		{
			registryKey2.SetValue("BaseBoardVersion", value2, RegistryValueKind.String);
			registryKey2.Close();
		}
		List<string> list3 = new List<string>();
		list3.Add("MSI");
		list3.Add("Asus");
		list3.Add("Gigabyte");
		list3.Add("ASRock");
		list3.Add("Biostar");
		list3.Add("EVGA");
		Random random3 = new Random();
		int index3 = random3.Next(list3.Count);
		string value3 = list3[index3];
		RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", writable: true);
		if (registryKey3 != null)
		{
			registryKey3.SetValue("BaseBoardManufacturer", value3, RegistryValueKind.String);
			registryKey3.Close();
		}
		RegistryKey registryKey4 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", writable: true);
		if (registryKey4 != null)
		{
			registryKey4.SetValue("SystemVersion", value2, RegistryValueKind.String);
			registryKey4.Close();
		}
		RegistryKey registryKey5 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", writable: true);
		if (registryKey5 != null)
		{
			registryKey5.SetValue("SystemManufacturer", value3, RegistryValueKind.String);
			registryKey5.Close();
		}
		List<string> list4 = new List<string>();
		list4.Add("01/02/2016");
		list4.Add("01/04/2016");
		list4.Add("01/03/2016");
		list4.Add("01/05/2016");
		list4.Add("02/05/2016");
		list4.Add("03/05/2016");
		Random random4 = new Random();
		int index4 = random4.Next(list4.Count);
		string value4 = list4[index4];
		RegistryKey registryKey6 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", writable: true);
		if (registryKey6 != null)
		{
			registryKey6.SetValue("BIOSReleaseDate", value4, RegistryValueKind.String);
			registryKey6.Close();
		}
		List<string> list5 = new List<string>();
		list5.Add("PL-7A37");
		list5.Add("PL-7A87");
		list5.Add("PL-8A37");
		list5.Add("PL-7A39");
		list5.Add("PL-3A37");
		list5.Add("PL-7A47");
		list5.Add("PL-7A35");
		list5.Add("PL-7A66");
		list5.Add("PL-6A67");
		list5.Add("PL-7B37");
		list5.Add("PL-7C37");
		list5.Add("PL-7D37");
		list5.Add("PL-7AE1");
		list5.Add("PL-7A17");
		list5.Add("PL-71E7");
		list5.Add("PL-1AE7");
		list5.Add("PL-7A77");
		list5.Add("PL-7A62");
		list5.Add("PL-7A33");
		list5.Add("PL-7A19");
		Random random5 = new Random();
		int index5 = random5.Next(list5.Count);
		string value5 = list5[index5];
		RegistryKey registryKey7 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", writable: true);
		if (registryKey7 != null)
		{
			registryKey7.SetValue("SystemProductName", value5, RegistryValueKind.String);
			registryKey7.Close();
		}
		List<string> list6 = new List<string>();
		list6.Add("A.04");
		list6.Add("A.09");
		list6.Add("A.60");
		list6.Add("A.54");
		list6.Add("A.23");
		list6.Add("A.62");
		list6.Add("A.13");
		list6.Add("A.11");
		list6.Add("A.22");
		list6.Add("A.33");
		list6.Add("A.44");
		list6.Add("A.55");
		list6.Add("A.56");
		list6.Add("A.57");
		list6.Add("A.93");
		list6.Add("A.69");
		Random random6 = new Random();
		int index6 = random6.Next(list6.Count);
		string value6 = list6[index6];
		RegistryKey registryKey8 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", writable: true);
		if (registryKey8 != null)
		{
			registryKey8.SetValue("BIOSVersion", value6, RegistryValueKind.String);
			registryKey8.Close();
		}
		List<string> list7 = new List<string>();
		list7.Add("American Megatrends Inc.");
		list7.Add("Dell Inc.");
		list7.Add("Phoenix Technologies, Ltd");
		list7.Add("Lenovo");
		list7.Add("Packard Bell");
		list7.Add("Award Software, Inc.");
		list7.Add("Acer");
		list7.Add("Insyde Corp.");
		list7.Add("TOSHIBA");
		list7.Add("Intel Corporation");
		list7.Add("IBM");
		list7.Add("innotek GmbH");
		list7.Add("Gateway");
		list7.Add("Sun Microsystems");
		Random random7 = new Random();
		int index7 = random7.Next(list7.Count);
		string value7 = list7[index7];
		RegistryKey registryKey9 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", writable: true);
		if (registryKey9 != null)
		{
			registryKey9.SetValue("BIOSVendor", value7, RegistryValueKind.String);
			registryKey9.Close();
		}
		RegistryKey registryKey10 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", writable: true);
		if (registryKey10 != null)
		{
			registryKey10.SetValue("BIOSVendor", value7, RegistryValueKind.String);
			registryKey10.Close();
		}
		RegistryKey registryKey11 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", writable: true);
		if (registryKey11 != null)
		{
			registryKey11.SetValue("BIOSVersion", value6, RegistryValueKind.String);
			registryKey11.Close();
		}
		RegistryKey registryKey12 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", writable: true);
		if (registryKey12 != null)
		{
			registryKey12.SetValue("SystemProductName", value5, RegistryValueKind.String);
			registryKey12.Close();
		}
		RegistryKey registryKey13 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", writable: true);
		if (registryKey13 != null)
		{
			registryKey13.SetValue("BIOSReleaseDate", value4, RegistryValueKind.String);
			registryKey13.Close();
		}
		RegistryKey registryKey14 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", writable: true);
		if (registryKey14 != null)
		{
			registryKey14.SetValue("SystemManufacturer", value3, RegistryValueKind.String);
			registryKey14.Close();
		}
		RegistryKey registryKey15 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", writable: true);
		if (registryKey15 != null)
		{
			registryKey15.SetValue("BaseBoardManufacturer", value3, RegistryValueKind.String);
			registryKey15.Close();
		}
		RegistryKey registryKey16 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", writable: true);
		if (registryKey16 != null)
		{
			registryKey16.SetValue("SystemVersion", value2, RegistryValueKind.String);
			registryKey16.Close();
		}
		RegistryKey registryKey17 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", writable: true);
		if (registryKey17 != null)
		{
			registryKey17.SetValue("BaseBoardVersion", value2, RegistryValueKind.String);
			registryKey17.Close();
		}
		RegistryKey registryKey18 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", writable: true);
		if (registryKey18 != null)
		{
			registryKey18.SetValue("BaseBoardProduct", value, RegistryValueKind.String);
			registryKey18.Close();
		}
		Guid guid = Guid.NewGuid();
		RegistryKey registryKey19 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\SystemInformation", writable: true);
		if (registryKey19 != null)
		{
			Guid guid2 = guid;
			registryKey19.SetValue("ComputerHardwareId", "{" + guid2.ToString() + "}", RegistryValueKind.String);
			registryKey19.Close();
		}
		string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		char[] array = new char[3];
		Random random8 = new Random();
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = text[random8.Next(text.Length)];
		}
		string text2 = new string(array);
		string text3 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		char[] array2 = new char[30];
		Random random9 = new Random();
		for (int j = 0; j < array2.Length; j++)
		{
			array2[j] = text3[random9.Next(text3.Length)];
		}
		string text4 = new string(array2);
		string text5 = "abcdefghijklmnopqrstuvwxyz0123456789";
		char[] array3 = new char[8];
		Random random10 = new Random();
		for (int k = 0; k < array3.Length; k++)
		{
			array3[k] = text5[random10.Next(text5.Length)];
		}
		string text6 = new string(array3);
		string text7 = "0123456789";
		char[] array4 = new char[11];
		Random random11 = new Random();
		for (int l = 0; l < array4.Length; l++)
		{
			array4[l] = text7[random11.Next(text7.Length)];
		}
		string text8 = new string(array4);
		RegistryKey registryKey20 = Registry.CurrentUser.OpenSubKey("Software\\Epic Games\\Unreal Engine\\Identifiers", writable: true);
		if (registryKey20 != null)
		{
			registryKey20.SetValue("MachineId", text2 + text4, RegistryValueKind.String);
			registryKey20.Close();
		}
		RegistryKey registryKey21 = Registry.CurrentUser.OpenSubKey("Software\\Epic Games\\Unreal Engine\\Identifiers", writable: true);
		if (registryKey21 != null)
		{
			registryKey21.SetValue("AccountId", text6 + text6 + text6, RegistryValueKind.String);
			registryKey21.Close();
		}
		RegistryKey registryKey22 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\0", writable: true);
		if (registryKey22 != null)
		{
			registryKey22.SetValue("Identifier", text6 + "-A", RegistryValueKind.String);
			registryKey22.Close();
		}
		RegistryKey registryKey23 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\1", writable: true);
		if (registryKey23 != null)
		{
			registryKey23.SetValue("Identifier", text6 + "-A", RegistryValueKind.String);
			registryKey23.Close();
		}
		Guid guid3 = Guid.NewGuid();
		RegistryKey registryKey24 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Feeds", writable: true);
		if (registryKey24 != null)
		{
			registryKey24.SetValue("BackgroundSync", guid3, RegistryValueKind.String);
			registryKey24.Close();
		}
		try
		{
			RegistryKey registryKey25 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\IdentityCRL\\ExtendedProperties", writable: true);
			if (registryKey25 != null)
			{
				registryKey25.SetValue("LID", text8 + "BE123", RegistryValueKind.String);
				registryKey25.Close();
			}
		}
		catch
		{
		}
		Random random12 = new Random();
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\Connected", "GUID", Guid.NewGuid().ToString());
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\Disconnected", "GUID", Guid.NewGuid().ToString());
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\EmailImage", "GUID", Guid.NewGuid().ToString());
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\FaxImage", "GUID", Guid.NewGuid().ToString());
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\PrintImage", "GUID", Guid.NewGuid().ToString());
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\ScanButton", "GUID", Guid.NewGuid().ToString());
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\STIproxyEvent", "GUID", Guid.NewGuid().ToString());
		Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\IdentityCRL\\ExtendedProperties", "LID", random12.Next(10000, 99999) + random12.Next(100000, 999999) + "BE123");
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Feeds", "BackgroundSync", Convert.ToString(Guid.NewGuid()));
		Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\0", "Identifier", Class18.smethod_3(8) + "-A");
		Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\1", "Identifier", Class18.smethod_3(8) + "-A");
		List<string> list8 = new List<string>();
		list8.Add("MSI A320M PRO - E");
		list8.Add("Asus Prime A320M-C R2.0");
		list8.Add("Gigabyte GA - A320M - H");
		list8.Add("ASRock Z390 Phantom Gaming SLI");
		list8.Add("Asus ROG Rampage VI Extreme Omega");
		list8.Add("Asus Prime H310I - Plus R2.0");
		list8.Add("Asus ROG Zenith Extreme Alpha X399");
		list8.Add("MSI MEG X299 Creation");
		list8.Add("Asus P11C - X");
		list8.Add("ASRock AB350M - HDV R3.0");
		list8.Add("MSI B450M Pro-VDH V2");
		list8.Add("MSI B450M Bazooka V2");
		list8.Add("Asus Prime B450M - A / CSM");
		list8.Add("Asus Prime H310I - Plus R2.0 / CSM");
		list8.Add("Gigabyte GA-AB350M-DS3H V2 (rev. 1.1)");
		list8.Add("Gigabyte B360 M AORUS PRO");
		list8.Add("Gigabyte X299-WU8");
		list8.Add("MSI MAG Z390M Mortar");
		Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\BIOS", "BaseBoardProduct", Class18.smethod_3(20));
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography", "MachineGuid", "{" + Guid.NewGuid().ToString() + "}");
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\IDConfigDB\\Hardware Profiles\\0001", "HwProfileGuid", "{" + Guid.NewGuid().ToString() + "}");
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig\\{b30417c0-53bd-11e5-8727-305a3ae502fe}", "SystemFamily", "{" + Guid.NewGuid().ToString() + "}");
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig", "LastConfig", "{" + Guid.NewGuid().ToString() + "}");
		Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\0", "Identifier", "{" + Guid.NewGuid().ToString() + "}");
		Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\1", "Identifier", "{" + Guid.NewGuid().ToString() + "}");
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\MediaPlayer\\Preferences\\DMR", "SerialNumber", "{" + Guid.NewGuid().ToString() + "}");
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\MediaPlayer\\Preferences\\DMR", "UDN", "{" + Guid.NewGuid().ToString() + "}");
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows Media\\WMSDK\\General", "UniqueID", "{" + Guid.NewGuid().ToString() + "}");
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\SQMClient", "MachineId", "{" + Guid.NewGuid().ToString() + "}");
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig", "LastConfig", Guid.NewGuid().ToString());
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware", "HwProfileGuid", Guid.NewGuid().ToString());
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsNT\\CurrentVersion", "BuildGUID", Guid.NewGuid().ToString());
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography", "MachineGuid", Guid.NewGuid().ToString());
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\SystemInformation", "ComputerHardwareId", "{" + Convert.ToString(Guid.NewGuid()) + "}");
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\SystemInformation", "ComputerHardwareIds", "{" + Convert.ToString(Guid.NewGuid()) + "}" + Environment.NewLine + "{" + Convert.ToString(Guid.NewGuid()) + "}" + Environment.NewLine + "{" + Convert.ToString(Guid.NewGuid()) + "}" + Environment.NewLine + "{" + Convert.ToString(Guid.NewGuid()) + "}" + Environment.NewLine + "{" + Convert.ToString(Guid.NewGuid()) + "}" + Environment.NewLine + "{" + Convert.ToString(Guid.NewGuid()) + "}" + Environment.NewLine + "{" + Convert.ToString(Guid.NewGuid()) + "}" + Environment.NewLine + "{" + Convert.ToString(Guid.NewGuid()) + "}" + Environment.NewLine + "{" + Convert.ToString(Guid.NewGuid()) + "}" + Environment.NewLine + "{" + Convert.ToString(Guid.NewGuid()) + "}");
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\Class\\{4d36e965-e325-11ce-bfc1-08002be10318}\\Configuration\\Variables\\BusDeviceDesc", "PropertyGuid", Convert.ToString(Guid.NewGuid()));
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\Configuration\\Variables\\DeviceDesc", "PropertyGuid", Convert.ToString(Guid.NewGuid()));
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\Configuration\\Variables\\Driver", "PropertyGuid", Convert.ToString(Guid.NewGuid()));
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\WMI\\Autologger\\AppModel", "GUID", Convert.ToString(Guid.NewGuid()));
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\SYSTEM\\HardwareConfig", "LastConfig", Convert.ToString(Guid.NewGuid()));
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography", "MachineGuid", "{" + Guid.NewGuid().ToString() + "}");
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\IDConfigDB\\Hardware Profiles\\0001", "HwProfileGuid", "{" + Guid.NewGuid().ToString() + "}");
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig\\{b30417c0-53bd-11e5-8727-305a3ae502fe}", "SystemFamily", "{" + Guid.NewGuid().ToString() + "}");
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig\\{b30417c0-53bd-11e5-8727-305a3ae502fe}", "BaseBoardProduct", "{" + Guid.NewGuid().ToString() + "}");
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig", "LastConfig", "{" + Guid.NewGuid().ToString() + "}");
		Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\0", "Identifier", "{" + Guid.NewGuid().ToString() + "}");
		Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\1", "Identifier", "{" + Guid.NewGuid().ToString() + "}");
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\MediaPlayer\\Preferences\\DMR", "SerialNumber", "{" + Guid.NewGuid().ToString() + "}");
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\MediaPlayer\\Preferences\\DMR", "UDN", "{" + Guid.NewGuid().ToString() + "}");
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows Media\\WMSDK\\General", "UniqueID", "{" + Guid.NewGuid().ToString() + "}");
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\SQMClient", "MachineId", "{" + Guid.NewGuid().ToString() + "}");
		string text9 = "Sanity-" + random.Next(10000, 99999);
		Process.Start("cmd.exe", "/c wmic useraccount where caption='" + text9 + "' rename " + text9);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName", "ComputerName", text9);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", "ComputerName", text9);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\services\\Tcpip\\Parameters", "NV Hostname", text9);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\services\\Tcpip\\Parameters", "Hostname", text9);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "RegisteCyanOwner", text9);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "RegisteCyanOrganization", text9);
	}

	public Class17()
	{
		_003CModule_003E.Class0.smethod_0();
		base._002Ector();
	}

	static void smethod_8()
	{
		Class21.smethod_2();
	}

	static string smethod_9()
	{
		return Class29.smethod_8();
	}

	static void smethod_12(string string_0)
	{
		Console.Title = string_0;
	}

	static string smethod_15()
	{
		return Console.ReadLine();
	}

	static void smethod_16()
	{
		Console.Clear();
	}

	static bool smethod_17(string string_0)
	{
		return Class21.smethod_6(string_0);
	}

	static bool smethod_18(string string_0, string string_1)
	{
		return Class21.smethod_4(string_0, string_1);
	}

	static void smethod_20(string string_0, string string_1)
	{
		Class21.smethod_3(string_0, string_1);
	}

	static string smethod_21()
	{
		return Class31.smethod_14();
	}

	static int smethod_24()
	{
		return Console.Read();
	}

	static bool smethod_25(string string_0, string string_1, string string_2, string string_3)
	{
		return Class21.smethod_5(string_0, string_1, string_2, string_3);
	}

	static bool smethod_26(string string_0, string string_1, string string_2)
	{
		return Class21.smethod_7(string_0, string_1, string_2);
	}

	static object smethod_28()
	{
		return Process.GetCurrentProcess();
	}

	static void smethod_29(object object_0)
	{
		((Process)object_0).Kill();
	}

	static object smethod_52()
	{
		return new Random();
	}
}
