using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace TRIPLE;

internal class lanwatch
{
	[Flags]
	public enum SV_101_TYPES : uint
	{
		SV_TYPE_WORKSTATION = 1u,
		SV_TYPE_SERVER = 2u,
		SV_TYPE_SQLSERVER = 4u,
		SV_TYPE_DOMAIN_CTRL = 8u,
		SV_TYPE_DOMAIN_BAKCTRL = 0x10u,
		SV_TYPE_TIME_SOURCE = 0x20u,
		SV_TYPE_AFP = 0x40u,
		SV_TYPE_NOVELL = 0x80u,
		SV_TYPE_DOMAIN_MEMBER = 0x100u,
		SV_TYPE_PRINTQ_SERVER = 0x200u,
		SV_TYPE_DIALIN_SERVER = 0x400u,
		SV_TYPE_XENIX_SERVER = 0x800u,
		SV_TYPE_SERVER_UNIX = 0x800u,
		SV_TYPE_NT = 0x1000u,
		SV_TYPE_WFW = 0x2000u,
		SV_TYPE_SERVER_MFPN = 0x4000u,
		SV_TYPE_SERVER_NT = 0x8000u,
		SV_TYPE_POTENTIAL_BROWSER = 0x10000u,
		SV_TYPE_BACKUP_BROWSER = 0x20000u,
		SV_TYPE_MASTER_BROWSER = 0x40000u,
		SV_TYPE_DOMAIN_MASTER = 0x80000u,
		SV_TYPE_SERVER_OSF = 0x100000u,
		SV_TYPE_SERVER_VMS = 0x200000u,
		SV_TYPE_WINDOWS = 0x400000u,
		SV_TYPE_DFS = 0x800000u,
		SV_TYPE_CLUSTER_NT = 0x1000000u,
		SV_TYPE_TERMINALSERVER = 0x2000000u,
		SV_TYPE_CLUSTER_VS_NT = 0x4000000u,
		SV_TYPE_DCE = 0x10000000u,
		SV_TYPE_ALTERNATE_XPORT = 0x20000000u,
		SV_TYPE_LOCAL_LIST_ONLY = 0x40000000u,
		SV_TYPE_DOMAIN_ENUM = 0x80000000u,
		SV_TYPE_ALL = uint.MaxValue
	}

	public struct SERVER_INFO_101
	{
		[MarshalAs(UnmanagedType.U4)]
		public uint sv101_platform_id;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string sv101_name;

		[MarshalAs(UnmanagedType.U4)]
		public uint sv101_version_major;

		[MarshalAs(UnmanagedType.U4)]
		public uint sv101_version_minor;

		[MarshalAs(UnmanagedType.U4)]
		public uint sv101_type;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string sv101_comment;
	}

	public enum PLATFORM_ID : uint
	{
		PLATFORM_ID_DOS = 300u,
		PLATFORM_ID_OS2 = 400u,
		PLATFORM_ID_NT = 500u,
		PLATFORM_ID_OSF = 600u,
		PLATFORM_ID_VMS = 700u
	}

	public enum NERR
	{
		NERR_Success = 0,
		ERROR_ACCESS_DENIED = 5,
		ERROR_NOT_ENOUGH_MEMORY = 8,
		ERROR_BAD_NETPATH = 53,
		ERROR_NETWORK_BUSY = 54,
		ERROR_INVALID_PARAMETER = 87,
		ERROR_INVALID_LEVEL = 124,
		ERROR_MORE_DATA = 234,
		ERROR_EXTENDED_ERROR = 1208,
		ERROR_NO_NETWORK = 1222,
		ERROR_INVALID_HANDLE_STATE = 1609,
		ERROR_NO_BROWSER_SERVERS_FOUND = 6118
	}

	[DllImport("netapi32.dll")]
	public static extern NERR NetServerEnum([MarshalAs(UnmanagedType.LPWStr)] string ServerName, int Level, out IntPtr BufPtr, int PrefMaxLen, ref int EntriesRead, ref int TotalEntries, SV_101_TYPES ServerType, [MarshalAs(UnmanagedType.LPWStr)] string Domain, int ResumeHandle);

	[DllImport("netapi32.dll")]
	public static extern NERR NetApiBufferFree(IntPtr Buffer);

	public static ArrayList GetServerList(SV_101_TYPES type)
	{
		IntPtr BufPtr = IntPtr.Zero;
		int EntriesRead = 0;
		int TotalEntries = 0;
		ArrayList arrayList = new ArrayList();
		try
		{
			NERR nERR = NetServerEnum(null, 101, out BufPtr, -1, ref EntriesRead, ref TotalEntries, type, null, 0);
			if ((nERR == NERR.NERR_Success || nERR == NERR.ERROR_MORE_DATA) && BufPtr != IntPtr.Zero)
			{
				int num = BufPtr.ToInt32();
				for (int i = 0; i < EntriesRead; i++)
				{
					SERVER_INFO_101 sERVER_INFO_ = (SERVER_INFO_101)Marshal.PtrToStructure(new IntPtr(num), typeof(SERVER_INFO_101));
					arrayList.Add(sERVER_INFO_.sv101_name);
					num += Marshal.SizeOf((object)sERVER_INFO_);
				}
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			if (BufPtr != IntPtr.Zero)
			{
				NetApiBufferFree(BufPtr);
			}
		}
		return arrayList;
	}
}
