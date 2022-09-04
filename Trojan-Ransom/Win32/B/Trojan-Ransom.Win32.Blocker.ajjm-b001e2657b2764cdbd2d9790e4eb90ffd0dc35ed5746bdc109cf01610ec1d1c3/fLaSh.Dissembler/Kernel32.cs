using System;
using System.Runtime.InteropServices;

namespace fLaSh.Dissembler;

public abstract class Kernel32
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct RESOURCE_HEADER
	{
		public ushort wLength;

		public ushort wValueLength;

		public ushort wType;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct VAR_HEADER
	{
		public ushort wLanguageIDMS;

		public ushort wCodePageIBM;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct VS_FIXEDFILEINFO
	{
		public uint dwSignature;

		public uint dwStrucVersion;

		public uint dwFileVersionMS;

		public uint dwFileVersionLS;

		public uint dwProductVersionMS;

		public uint dwProductVersionLS;

		public uint dwFileFlagsMask;

		public uint dwFileFlags;

		public uint dwFileOS;

		public uint dwFileType;

		public uint dwFileSubtype;

		public uint dwFileDateMS;

		public uint dwFileDateLS;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct GRPICONDIR
	{
		public ushort wReserved;

		public ushort wType;

		public ushort wImageCount;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct GRPICONDIRENTRY
	{
		public byte bWidth;

		public byte bHeight;

		public byte bColors;

		public byte bReserved;

		public ushort wPlanes;

		public ushort wBitsPerPixel;

		public uint dwImageSize;

		public ushort nID;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct FILEGRPICONDIRENTRY
	{
		public byte bWidth;

		public byte bHeight;

		public byte bColors;

		public byte bReserved;

		public ushort wPlanes;

		public ushort wBitsPerPixel;

		public uint dwImageSize;

		public uint dwFileOffset;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct FILEGRPICONDIR
	{
		public ushort wReserved;

		public ushort wType;

		public ushort wCount;
	}

	public enum ResourceTypes
	{
		RT_CURSOR = 1,
		RT_BITMAP = 2,
		RT_ICON = 3,
		RT_MENU = 4,
		RT_DIALOG = 5,
		RT_STRING = 6,
		RT_FONTDIR = 7,
		RT_FONT = 8,
		RT_ACCELERATOR = 9,
		RT_RCDATA = 10,
		RT_MESSAGETABLE = 11,
		RT_GROUP_CURSOR = 12,
		RT_GROUP_ICON = 14,
		RT_VERSION = 16,
		RT_DLGINCLUDE = 17,
		RT_PLUGPLAY = 19,
		RT_VXD = 20,
		RT_ANICURSOR = 21,
		RT_ANIICON = 22,
		RT_HTML = 23
	}

	public delegate bool EnumResourceTypesDelegate(IntPtr hModule, IntPtr lpszType, IntPtr lParam);

	public delegate bool EnumResourceNamesDelegate(IntPtr hModule, IntPtr lpszType, IntPtr lpszName, IntPtr lParam);

	public delegate bool EnumResourceLanguagesDelegate(IntPtr hModule, IntPtr lpszType, IntPtr lpszName, ushort ushort_0, IntPtr lParam);

	public const uint LOAD_LIBRARY_AS_DATAFILE = 2u;

	public const uint DONT_RESOLVE_DLL_REFERENCES = 1u;

	public const uint LOAD_WITH_ALTERED_SEARCH_PATH = 8u;

	public const uint LOAD_IGNORE_CODE_AUTHZ_LEVEL = 16u;

	public const ushort LANG_NEUTRAL = 0;

	public const ushort SUBLANG_NEUTRAL = 0;

	[DllImport("kernel32.dll")]
	public static extern IntPtr LoadLibraryEx(string lpFileName, IntPtr hFile, uint dwFlags);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool FreeLibrary(IntPtr hModule);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool EnumResourceTypesW(IntPtr hModule, EnumResourceTypesDelegate lpEnumFunc, IntPtr lParam);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool EnumResourceNamesW(IntPtr hModule, IntPtr lpszType, EnumResourceNamesDelegate lpEnumFunc, IntPtr lParam);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool EnumResourceLanguagesW(IntPtr hModule, IntPtr lpszType, IntPtr lpszName, EnumResourceLanguagesDelegate lpEnumFunc, IntPtr lParam);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern IntPtr FindResource(IntPtr hModule, IntPtr lpszName, IntPtr lpszType);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern IntPtr FindResourceExW(IntPtr hModule, IntPtr lpszType, IntPtr lpszName, long wLanguage);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr LockResource(IntPtr hResData);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResData);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern int SizeofResource(IntPtr hInstance, IntPtr hResInfo);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool CloseHandle(IntPtr hHandle);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr BeginUpdateResourceW(string pFileName, bool bDeleteExistingResources);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern bool UpdateResourceW(IntPtr hUpdate, IntPtr lpType, IntPtr lpName, ushort wLanguage, byte[] lpData, uint cbData);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern bool EndUpdateResourceW(IntPtr hUpdate, bool fDiscard);
}
