using System;
using System.Runtime.InteropServices;
using System.Security;

namespace ns0;

internal static class Class9
{
	[Serializable]
	internal enum ConfigId
	{
		None,
		MachinePolicyLevel,
		UserPolicyLevel,
		EnterprisePolicyLevel
	}

	[Serializable]
	[Flags]
	internal enum QuickCacheEntryType
	{
		FullTrustZoneMyComputer = 0x1000000,
		FullTrustZoneIntranet = 0x2000000,
		FullTrustZoneInternet = 0x4000000,
		FullTrustZoneTrusted = 0x8000000,
		FullTrustZoneUntrusted = 0x10000000,
		FullTrustAll = 0x20000000
	}

	private static volatile string string_0;

	private static volatile string string_1;

	internal static string String_0
	{
		[SecurityCritical]
		get
		{
			smethod_0();
			return string_0;
		}
	}

	internal static string String_1
	{
		[SecurityCritical]
		get
		{
			smethod_0();
			return string_1;
		}
	}

	[SecurityCritical]
	private static void smethod_0()
	{
		if (string_0 == null)
		{
			string text = null;
			GetMachineDirectory(Class8.smethod_0(ref text));
			string_0 = text;
		}
		if (string_1 == null)
		{
			string text2 = null;
			GetUserDirectory(Class8.smethod_0(ref text2));
			string_1 = text2;
		}
	}

	[DllImport(" ", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	internal static extern int SaveDataByte(string string_2, [In] byte[] byte_0, int int_0);

	[DllImport(" ", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	internal static extern bool RecoverData(ConfigId configId_0);

	[DllImport(" ", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	internal static extern void SetQuickCache(ConfigId configId_0, QuickCacheEntryType quickCacheEntryType_0);

	[DllImport("  ", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	private static extern bool GetCacheEntry(ConfigId configId_0, int int_0, [In] byte[] byte_0, int int_1, Class8.Struct1 struct1_0);

	[SecurityCritical]
	internal static bool smethod_1(ConfigId configId_0, int int_0, byte[] byte_0, out byte[] byte_1)
	{
		byte[] gparam_ = null;
		bool cacheEntry = GetCacheEntry(configId_0, int_0, byte_0, byte_0.Length, Class8.smethod_1(ref gparam_));
		byte_1 = gparam_;
		return cacheEntry;
	}

	[DllImport(" ", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void AddCacheEntry(ConfigId configId_0, int int_0, [In] byte[] byte_0, int int_1, byte[] byte_1, int int_2);

	[SecurityCritical]
	internal static void smethod_2(ConfigId configId_0, int int_0, byte[] byte_0, byte[] byte_1)
	{
		AddCacheEntry(configId_0, int_0, byte_0, byte_0.Length, byte_1, byte_1.Length);
	}

	[DllImport(" ", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	internal static extern void ResetCacheData(ConfigId configId_0);

	[DllImport(" ", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	private static extern void GetMachineDirectory(Class8.Struct2 struct2_0);

	[DllImport(" ", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	private static extern void GetUserDirectory(Class8.Struct2 struct2_0);

	[DllImport(" ", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern bool WriteToEventLog(string string_2);
}
