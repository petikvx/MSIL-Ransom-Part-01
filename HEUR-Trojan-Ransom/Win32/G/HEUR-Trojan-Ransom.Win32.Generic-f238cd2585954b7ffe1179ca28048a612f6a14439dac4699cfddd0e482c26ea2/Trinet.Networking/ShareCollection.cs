using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;

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

		public ShareType ShareType => (ShareType)(bShareType & 0x7F);
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

		public ShareType ShareType => (ShareType)(bShareType & 0x7FFF);
	}

	protected const int MAX_PATH = 260;

	protected const int NO_ERROR = 0;

	protected const int ERROR_ACCESS_DENIED = 5;

	protected const int ERROR_WRONG_LEVEL = 124;

	protected const int ERROR_MORE_DATA = 234;

	protected const int ERROR_NOT_CONNECTED = 2250;

	protected const int UNIVERSAL_NAME_INFO_LEVEL = 1;

	protected const int MAX_SI50_ENTRIES = 20;

	private static ShareCollection _local;

	private string _server;

	protected static bool IsNT => PlatformID.Win32NT == Environment.OSVersion.Platform;

	protected static bool IsW2KUp
	{
		get
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			if (PlatformID.Win32NT == oSVersion.Platform && oSVersion.Version.Major >= 5)
			{
				return true;
			}
			return false;
		}
	}

	public static ShareCollection LocalShares
	{
		get
		{
			if (_local == null)
			{
				_local = new ShareCollection();
			}
			return _local;
		}
	}

	public string Server => _server;

	public Share this[int index] => (Share)base.InnerList[index];

	public Share this[string path]
	{
		get
		{
			if (path != null && path.Length != 0)
			{
				path = Path.GetFullPath(path);
				if (!IsValidFilePath(path))
				{
					return null;
				}
				Share share = null;
				for (int i = 0; i < base.InnerList.Count; i++)
				{
					Share share2 = (Share)base.InnerList[i];
					if (share2.IsFileSystem && share2.MatchesPath(path))
					{
						if (share == null)
						{
							share = share2;
						}
						else if (share.Path.Length < share2.Path.Length && (share2.ShareType == ShareType.Disk || share.ShareType != 0))
						{
							share = share2;
						}
					}
				}
				return share;
			}
			return null;
		}
	}

	[DllImport("mpr", CharSet = CharSet.Auto)]
	protected static extern int WNetGetUniversalName(string lpLocalPath, int dwInfoLevel, ref UNIVERSAL_NAME_INFO lpBuffer, ref int lpBufferSize);

	[DllImport("mpr", CharSet = CharSet.Auto)]
	protected static extern int WNetGetUniversalName(string lpLocalPath, int dwInfoLevel, IntPtr lpBuffer, ref int lpBufferSize);

	[DllImport("netapi32", CharSet = CharSet.Unicode)]
	protected static extern int NetShareEnum(string lpServerName, int dwLevel, out IntPtr lpBuffer, int dwPrefMaxLen, out int entriesRead, out int totalEntries, ref int hResume);

	[DllImport("svrapi", CharSet = CharSet.Ansi)]
	protected static extern int NetShareEnum([MarshalAs(UnmanagedType.LPTStr)] string lpServerName, int dwLevel, IntPtr lpBuffer, ushort cbBuffer, out ushort entriesRead, out ushort totalEntries);

	[DllImport("netapi32")]
	protected static extern int NetApiBufferFree(IntPtr lpBuffer);

	protected static void EnumerateSharesNT(string server, ShareCollection shares)
	{
		int num = 2;
		int hResume = 0;
		IntPtr lpBuffer = IntPtr.Zero;
		try
		{
			int entriesRead;
			int totalEntries;
			int num2 = NetShareEnum(server, num, out lpBuffer, -1, out entriesRead, out totalEntries, ref hResume);
			if (5 == num2)
			{
				num = 1;
				num2 = NetShareEnum(server, 1, out lpBuffer, -1, out entriesRead, out totalEntries, ref hResume);
			}
			if (num2 != 0 || entriesRead <= 0)
			{
				return;
			}
			Type type = ((2 == num) ? typeof(SHARE_INFO_2) : typeof(SHARE_INFO_1));
			int num3 = Marshal.SizeOf(type);
			int num4 = 0;
			int num5 = lpBuffer.ToInt32();
			while (num4 < entriesRead)
			{
				IntPtr ptr = new IntPtr(num5);
				if (1 == num)
				{
					SHARE_INFO_1 sHARE_INFO_ = (SHARE_INFO_1)Marshal.PtrToStructure(ptr, type);
					shares.Add(sHARE_INFO_.NetName, string.Empty, sHARE_INFO_.ShareType, sHARE_INFO_.Remark);
				}
				else
				{
					SHARE_INFO_2 sHARE_INFO_2 = (SHARE_INFO_2)Marshal.PtrToStructure(ptr, type);
					shares.Add(sHARE_INFO_2.NetName, sHARE_INFO_2.Path, sHARE_INFO_2.ShareType, sHARE_INFO_2.Remark);
				}
				num4++;
				num5 += num3;
			}
		}
		finally
		{
			if (IntPtr.Zero != lpBuffer)
			{
				NetApiBufferFree(lpBuffer);
			}
		}
	}

	protected static void EnumerateShares9x(string server, ShareCollection shares)
	{
		int num = 50;
		int num2 = 0;
		Type typeFromHandle = typeof(SHARE_INFO_50);
		int num3 = Marshal.SizeOf(typeFromHandle);
		ushort num4 = (ushort)(20 * num3);
		IntPtr intPtr = Marshal.AllocHGlobal(num4);
		try
		{
			num2 = NetShareEnum(server, num, intPtr, num4, out var entriesRead, out var totalEntries);
			if (124 == num2)
			{
				num = 1;
				typeFromHandle = typeof(SHARE_INFO_1_9x);
				num3 = Marshal.SizeOf(typeFromHandle);
				num2 = NetShareEnum(server, 1, intPtr, num4, out entriesRead, out totalEntries);
			}
			if (num2 != 0 && 234 != num2)
			{
				Console.WriteLine(num2);
				return;
			}
			int num5 = 0;
			int num6 = intPtr.ToInt32();
			while (num5 < entriesRead)
			{
				IntPtr ptr = new IntPtr(num6);
				if (1 == num)
				{
					SHARE_INFO_1_9x sHARE_INFO_1_9x = (SHARE_INFO_1_9x)Marshal.PtrToStructure(ptr, typeFromHandle);
					shares.Add(sHARE_INFO_1_9x.NetName, string.Empty, sHARE_INFO_1_9x.ShareType, sHARE_INFO_1_9x.Remark);
				}
				else
				{
					SHARE_INFO_50 sHARE_INFO_ = (SHARE_INFO_50)Marshal.PtrToStructure(ptr, typeFromHandle);
					shares.Add(sHARE_INFO_.NetName, sHARE_INFO_.Path, sHARE_INFO_.ShareType, sHARE_INFO_.Remark);
				}
				num5++;
				num6 += num3;
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	protected static void EnumerateShares(string server, ShareCollection shares)
	{
		if (server != null && server.Length != 0 && !IsW2KUp)
		{
			server = server.ToUpper();
			if ('\\' != server[0] || '\\' != server[1])
			{
				server = "\\\\" + server;
			}
		}
		if (IsNT)
		{
			EnumerateSharesNT(server, shares);
		}
		else
		{
			EnumerateShares9x(server, shares);
		}
	}

	public static bool IsValidFilePath(string fileName)
	{
		if (fileName != null && fileName.Length != 0)
		{
			char c = char.ToUpper(fileName[0]);
			if ('A' <= c && c <= 'Z')
			{
				if (Path.VolumeSeparatorChar != fileName[1])
				{
					return false;
				}
				if (Path.DirectorySeparatorChar != fileName[2])
				{
					return false;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public static string PathToUnc(string fileName)
	{
		if (fileName != null && fileName.Length != 0)
		{
			fileName = Path.GetFullPath(fileName);
			if (!IsValidFilePath(fileName))
			{
				return fileName;
			}
			int num = 0;
			UNIVERSAL_NAME_INFO lpBuffer = default(UNIVERSAL_NAME_INFO);
			int lpBufferSize = Marshal.SizeOf((object)lpBuffer);
			num = WNetGetUniversalName(fileName, 1, ref lpBuffer, ref lpBufferSize);
			if (234 == num)
			{
				IntPtr intPtr = Marshal.AllocHGlobal(lpBufferSize);
				try
				{
					num = WNetGetUniversalName(fileName, 1, intPtr, ref lpBufferSize);
					if (num == 0)
					{
						lpBuffer = (UNIVERSAL_NAME_INFO)Marshal.PtrToStructure(intPtr, typeof(UNIVERSAL_NAME_INFO));
					}
				}
				finally
				{
					Marshal.FreeHGlobal(intPtr);
				}
			}
			switch (num)
			{
			default:
				Console.WriteLine("Unknown return value: {0}", num);
				return string.Empty;
			case 2250:
			{
				ShareCollection localShares = LocalShares;
				if (localShares != null)
				{
					Share share = localShares[fileName];
					if (share != null)
					{
						string path = share.Path;
						if (path != null && path.Length != 0)
						{
							int num2 = path.Length;
							if (Path.DirectorySeparatorChar != path[path.Length - 1])
							{
								num2++;
							}
							fileName = ((num2 >= fileName.Length) ? string.Empty : fileName.Substring(num2));
							fileName = Path.Combine(share.ToString(), fileName);
						}
					}
				}
				return fileName;
			}
			case 0:
				return lpBuffer.lpUniversalName;
			}
		}
		return string.Empty;
	}

	public static Share PathToShare(string fileName)
	{
		if (fileName != null && fileName.Length != 0)
		{
			fileName = Path.GetFullPath(fileName);
			if (!IsValidFilePath(fileName))
			{
				return null;
			}
			return LocalShares?[fileName];
		}
		return null;
	}

	public static ShareCollection GetShares(string server)
	{
		return new ShareCollection(server);
	}

	public ShareCollection()
	{
		_server = string.Empty;
		EnumerateShares(_server, this);
	}

	public ShareCollection(string server)
	{
		_server = server;
		EnumerateShares(_server, this);
	}

	protected void Add(Share share)
	{
		base.InnerList.Add(share);
	}

	protected void Add(string netName, string path, ShareType shareType, string remark)
	{
		base.InnerList.Add(new Share(_server, netName, path, shareType, remark));
	}

	public void CopyTo(Share[] array, int index)
	{
		base.InnerList.CopyTo(array, index);
	}
}
