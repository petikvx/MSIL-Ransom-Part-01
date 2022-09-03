using System;
using System.Runtime.InteropServices;
using System.Text;

internal sealed class Class8
{
	public enum Enum1 : uint
	{

	}

	public enum Enum2 : uint
	{

	}

	[Flags]
	public enum Enum3 : uint
	{
		SFGAO_CANCOPY = 1u,
		SFGAO_CANMOVE = 2u,
		SFGAO_CANLINK = 4u,
		SFGAO_STORAGE = 8u,
		SFGAO_CANRENAME = 0x10u,
		SFGAO_CANDELETE = 0x20u,
		SFGAO_HASPROPSHEET = 0x40u,
		SFGAO_DROPTARGET = 0x100u,
		SFGAO_CAPABILITYMASK = 0x177u,
		SFGAO_ENCRYPTED = 0x2000u,
		SFGAO_ISSLOW = 0x4000u,
		SFGAO_GHOSTED = 0x8000u,
		SFGAO_LINK = 0x10000u,
		SFGAO_SHARE = 0x20000u,
		SFGAO_READONLY = 0x40000u,
		SFGAO_HIDDEN = 0x80000u,
		SFGAO_DISPLAYATTRMASK = 0xFC000u,
		SFGAO_FILESYSANCESTOR = 0x10000000u,
		SFGAO_FOLDER = 0x20000000u,
		SFGAO_FILESYSTEM = 0x40000000u,
		SFGAO_HASSUBFOLDER = 0x80000000u,
		SFGAO_CONTENTSMASK = 0x80000000u,
		SFGAO_VALIDATE = 0x1000000u,
		SFGAO_REMOVABLE = 0x2000000u,
		SFGAO_COMPRESSED = 0x4000000u,
		SFGAO_BROWSABLE = 0x8000000u,
		SFGAO_NONENUMERATED = 0x100000u,
		SFGAO_NEWCONTENT = 0x200000u,
		SFGAO_CANMONIKER = 0x400000u,
		SFGAO_HASSTORAGE = 0x400000u,
		SFGAO_STREAM = 0x400000u,
		SFGAO_STORAGEANCESTOR = 0x800000u,
		SFGAO_STORAGECAPMASK = 0x70C50008u
	}

	public enum Enum4
	{

	}

	public enum Enum5 : uint
	{

	}

	public enum Enum6 : uint
	{

	}

	public struct Struct1
	{
		public IntPtr intptr_0;

		public int int_0;

		public uint uint_0;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_0;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
		public string string_1;
	}

	[ComImport]
	[Guid("000214F2-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IEnumIDList
	{
		[PreserveSig]
		uint Next(uint celt, out IntPtr rgelt, out int pceltFetched);

		[PreserveSig]
		uint Skip(uint celt);

		[PreserveSig]
		uint Reset();

		[PreserveSig]
		uint Clone(out IEnumIDList ppenum);
	}

	[ComImport]
	[Guid("000214E6-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IShellFolder
	{
		[PreserveSig]
		uint ParseDisplayName(IntPtr hwnd, IntPtr pbc, [In][MarshalAs(UnmanagedType.LPWStr)] string pszDisplayName, out uint pchEaten, out IntPtr ppidl, ref uint pdwAttributes);

		[PreserveSig]
		uint EnumObjects(IntPtr hwnd, Enum2 grfFlags, out IEnumIDList ppenumIDList);

		[PreserveSig]
		uint BindToObject(IntPtr pidl, IntPtr pbc, [In] ref Guid riid, out IShellFolder ppv);

		[PreserveSig]
		uint BindToStorage(IntPtr pidl, IntPtr pbc, [In] ref Guid riid, [MarshalAs(UnmanagedType.Interface)] out object ppv);

		[PreserveSig]
		int CompareIDs(int lParam, IntPtr pidl1, IntPtr pidl2);

		[PreserveSig]
		uint CreateViewObject(IntPtr hwndOwner, [In] ref Guid riid, [MarshalAs(UnmanagedType.Interface)] out object ppv);

		[PreserveSig]
		uint GetAttributesOf(int cidl, out IntPtr apidl, out Enum3 rgfInOut);

		[PreserveSig]
		uint GetUIObjectOf(IntPtr hwndOwner, int cidl, [In][MarshalAs(UnmanagedType.LPArray, SizeConst = 0)] IntPtr[] apidl, [In] ref Guid riid, IntPtr rgfReserved, [MarshalAs(UnmanagedType.Interface)] out object ppv);

		[PreserveSig]
		uint GetDisplayNameOf(IntPtr pidl, Enum1 uFlags, out Enum5 pName);

		[PreserveSig]
		uint SetNameOf(IntPtr hwnd, IntPtr pidl, [In][MarshalAs(UnmanagedType.LPWStr)] string pszName, Enum1 uFlags, out IntPtr ppidlOut);
	}

	public static Guid guid_0 = new Guid("000214E6-0000-0000-C000-000000000046");

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr intptr_0, uint uint_0, uint uint_1, IntPtr intptr_1);

	[DllImport("shell32.dll")]
	public static extern int SHGetDesktopFolder(ref IShellFolder ishellFolder_0);

	[DllImport("shell32.dll")]
	public static extern IntPtr SHGetFileInfo(string string_0, uint uint_0, out Struct1 struct1_0, uint uint_1, Enum4 enum4_0);

	[DllImport("shell32.dll", EntryPoint = "SHGetFileInfo")]
	public static extern IntPtr SHGetFileInfo_1(IntPtr intptr_0, uint uint_0, out Struct1 struct1_0, uint uint_1, Enum4 enum4_0);

	[DllImport("shell32.dll")]
	public static extern int SHGetSpecialFolderLocation(IntPtr intptr_0, Enum6 enum6_0, ref IntPtr intptr_1);

	[DllImport("shell32.dll")]
	public static extern IntPtr ILCombine(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("shell32.dll")]
	public static extern int SHGetPathFromIDList(IntPtr intptr_0, StringBuilder stringBuilder_0);
}
