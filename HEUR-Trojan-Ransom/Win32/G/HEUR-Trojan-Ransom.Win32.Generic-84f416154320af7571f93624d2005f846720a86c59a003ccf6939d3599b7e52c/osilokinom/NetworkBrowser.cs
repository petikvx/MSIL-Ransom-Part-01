using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security;
using N5EooLYT8PCyFWebIj;

namespace osilokinom;

public sealed class NetworkBrowser
{
	public struct _SERVER_INFO_100
	{
		internal int KxFqlBfM6;

		[MarshalAs(UnmanagedType.LPWStr)]
		internal string ivSwBtj2u;
	}

	private static NetworkBrowser bMLsGAnFYMwhfapPxk;

	[DllImport("Netapi32", CharSet = CharSet.Auto, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int NetServerEnum(string ServerNane, int dwLevel, ref IntPtr pBuf, int dwPrefMaxLen, out int dwEntriesRead, out int dwTotalEntries, int dwServerType, string domain, out int dwResumeHandle);

	[DllImport("Netapi32", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int NetApiBufferFree(IntPtr pBuf);

	public ArrayList getNetworkComputers()
	{
		return null;
	}

	static NetworkBrowser()
	{
		uGoIvNQFsJ3OnGY78d.nIq4V2sach();
		BscOc71uUKIOmZ8u2U();
	}

	internal static void RsKEVHVhE02T1UHPjn()
	{
	}

	internal static void kPWqX5UwDm87HeIpUS()
	{
	}

	internal static bool j9S1KIQGoKuv0xOoYI()
	{
		return true;
	}

	internal static NetworkBrowser L8NiKn7CVXlvFUDad7()
	{
		return null;
	}

	internal static object KXaI6udckTO8rmlLVe(int int_0)
	{
		return null;
	}

	internal static void BscOc71uUKIOmZ8u2U()
	{
	}
}
