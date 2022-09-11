using System;
using System.Collections;
using System.Runtime.InteropServices;
using N5EooLYT8PCyFWebIj;

namespace Trinet.Networking;

public class ShareCollection : ReadOnlyCollectionBase
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	protected struct UNIVERSAL_NAME_INFO
	{
		[MarshalAs(UnmanagedType.LPTStr)]
		public string lpUniversalName;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	protected struct SHARE_INFO_2
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string NetName;

		public ShareType ShareType;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string Remark;

		public int Permissions;

		public int MaxUsers;

		public int CurrentUsers;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string Path;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string Password;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	protected struct SHARE_INFO_1
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string NetName;

		public ShareType ShareType;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string Remark;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	protected struct SHARE_INFO_50
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public string NetName;

		public byte bShareType;

		public ushort Flags;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string Remark;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string Path;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public string PasswordRW;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public string PasswordRO;

		internal static object LrX4mn6ZAxFIceLCK5c;

		public ShareType ShareType => (ShareType)(object)null;

		static SHARE_INFO_50()
		{
			uGoIvNQFsJ3OnGY78d.nIq4V2sach();
			kZOHfy6Oc6LmPQraZi9();
		}

		internal static bool Xx9ZUb6onnIBjxAfIYt()
		{
			return true;
		}

		internal static object r1A7Ej6lJZcZFJnHEVO()
		{
			return null;
		}

		internal static void kZOHfy6Oc6LmPQraZi9()
		{
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	protected struct SHARE_INFO_1_9x
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public string NetName;

		public byte Padding;

		public ushort bShareType;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string Remark;

		internal static object M55OgJ6c9Kl99AXqjmI;

		public ShareType ShareType => (ShareType)(object)null;

		static SHARE_INFO_1_9x()
		{
			uGoIvNQFsJ3OnGY78d.nIq4V2sach();
			uGoIvNQFsJ3OnGY78d.PLK4lkeQh3();
		}

		internal static bool seqyIw6ro47n4HNw0NU()
		{
			return true;
		}

		internal static object dgehsb64WM1f380M9iI()
		{
			return null;
		}
	}

	protected const int MAX_PATH = 260;

	protected const int NO_ERROR = 0;

	protected const int ERROR_ACCESS_DENIED = 5;

	protected const int ERROR_WRONG_LEVEL = 124;

	protected const int ERROR_MORE_DATA = 234;

	protected const int ERROR_NOT_CONNECTED = 2250;

	protected const int UNIVERSAL_NAME_INFO_LEVEL = 1;

	protected const int MAX_SI50_ENTRIES = 20;

	private static ShareCollection yP818a3eZ;

	private string oxk5M9I38;

	internal static ShareCollection E5lWu2L7s5lSxNDjHl;

	protected static bool IsNT => true;

	protected static bool IsW2KUp => true;

	public static ShareCollection LocalShares => null;

	public string Server => null;

	public Share this[int index] => null;

	public Share this[string path] => null;

	[DllImport("mpr", CharSet = CharSet.Auto)]
	protected static extern int WNetGetUniversalName(string lpLocalPath, int dwInfoLevel, ref UNIVERSAL_NAME_INFO lpBuffer, ref int lpBufferSize);

	[DllImport("mpr", CharSet = CharSet.Auto)]
	protected static extern int WNetGetUniversalName(string lpLocalPath, int dwInfoLevel, IntPtr lpBuffer, ref int lpBufferSize);

	[DllImport("Netapi32", CharSet = CharSet.Unicode)]
	protected static extern int NetShareEnum(string lpServerName, int dwLevel, out IntPtr lpBuffer, int dwPrefMaxLen, out int entriesRead, out int totalEntries, ref int hResume);

	[DllImport("svrapi", CharSet = CharSet.Ansi)]
	protected static extern int NetShareEnum([MarshalAs(UnmanagedType.LPTStr)] string lpServerName, int dwLevel, IntPtr lpBuffer, ushort cbBuffer, out ushort entriesRead, out ushort totalEntries);

	[DllImport("Netapi32")]
	protected static extern int NetApiBufferFree(IntPtr lpBuffer);

	protected static void EnumerateSharesNT(string server, ShareCollection shares)
	{
	}

	protected static void EnumerateShares9x(string server, ShareCollection shares)
	{
	}

	protected static void EnumerateShares(string server, ShareCollection shares)
	{
	}

	public static bool IsValidFilePath(string fileName)
	{
		return true;
	}

	public static string PathToUnc(string fileName)
	{
		return null;
	}

	public static Share PathToShare(string fileName)
	{
		return null;
	}

	public static ShareCollection GetShares(string server)
	{
		return null;
	}

	public ShareCollection()
	{
	}

	public ShareCollection(string server)
	{
	}

	protected void Add(Share share)
	{
	}

	protected void Add(string netName, string path, ShareType shareType, string remark)
	{
	}

	public void CopyTo(Share[] array, int index)
	{
	}

	static ShareCollection()
	{
		uGoIvNQFsJ3OnGY78d.nIq4V2sach();
		D72Atl69RNSovtJC4aT();
		M9VBBQ660KqkScMYQp1();
		QUo7bgCuQBdZMP3xkk();
	}

	internal static bool z58pZEmSoYGG6qj6U0()
	{
		return true;
	}

	internal static ShareCollection MUnLuoPEOKd872CHQd()
	{
		return null;
	}

	internal static void ewipv0XTfS8MEeZVSU(object object_0, object object_1, object object_2, ShareType shareType, object object_3)
	{
	}

	internal static bool qtlyFA07RZ3rj6swOy()
	{
		return true;
	}

	internal static object h2HAVIeMBEmvxpUrJu(int int_0)
	{
		return null;
	}

	internal static void zToQvSGJ4W5WkN7eHq(object object_0, object object_1)
	{
	}

	internal static bool pb0ugg3cMUb0SXOhil(object object_0)
	{
		return true;
	}

	internal static object vRb6t4TTAcCXl8lwGu()
	{
		return null;
	}

	internal static object gpUlsDI6u8e8Zf5V6S(object object_0, object object_1)
	{
		return null;
	}

	internal static void QUo7bgCuQBdZMP3xkk()
	{
	}

	internal static void BeK2PEhGt5QUW03tma(object object_0, object object_1)
	{
	}

	internal static bool wfVGlRkMBC1HQiN3Ul(object object_0)
	{
		return true;
	}

	internal static bool ySVFCKBjuZtHDpZKao(object object_0, object object_1)
	{
		return true;
	}

	internal static object mb3h1Qa8rmuRf2exxC(object object_0)
	{
		return null;
	}

	internal static ShareType qeqhhgz8xxvqGaCvgY(object object_0)
	{
		return (ShareType)(object)null;
	}

	internal static void D72Atl69RNSovtJC4aT()
	{
	}

	internal static void M9VBBQ660KqkScMYQp1()
	{
	}
}
