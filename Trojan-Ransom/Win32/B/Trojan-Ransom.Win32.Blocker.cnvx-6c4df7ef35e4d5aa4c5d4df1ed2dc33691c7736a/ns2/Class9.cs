using System;
using System.Runtime.InteropServices;

namespace ns2;

internal sealed class Class9
{
	public struct Struct6
	{
		public int int_0;

		public int int_1;
	}

	public struct Struct7
	{
		public Struct6 struct6_0;

		public long long_0;

		public Guid guid_0;

		public Struct6 struct6_1;

		public int int_0;

		public int int_1;

		public int int_2;

		public Struct6 struct6_2;

		public string string_0;

		public int int_3;

		public int int_4;
	}

	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0000000c-0000-0000-C000-000000000046")]
	public interface Interface0
	{
		void imethod_0(IntPtr pv, uint cb, out uint pcbRead);

		void imethod_1(IntPtr pv, uint cb, out uint pcbWritten);

		void imethod_2(long dlibMove, uint dwOrigin, out ulong plibNewPosition);

		void imethod_3(ulong libNewSize);

		void imethod_4(Interface0 pstm, ulong cb, out ulong pcbRead, out ulong pcbWritten);

		void imethod_5(uint grfCommitFlags);

		void imethod_6();

		void imethod_7(ulong libOffset, ulong cb, uint dwLockType);

		void imethod_8(ulong libOffset, ulong cb, uint dwLockType);

		void imethod_9(out Struct7 pstatstg, uint grfStatFlag);

		void imethod_10(out Interface0 ppstm);
	}

	[ComImport]
	[Guid("7c23ff90-33af-11d3-95da-00a024a85b51")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface Interface1
	{
		void imethod_0(Interface2 pName);

		void imethod_1(out Interface2 ppName);

		void imethod_2([MarshalAs(UnmanagedType.LPWStr)] string szName, int pvValue, uint cbValue, uint dwFlags);

		void imethod_3([MarshalAs(UnmanagedType.LPWStr)] string szName, out int pvValue, ref uint pcbValue, uint dwFlags);

		void imethod_4(out int wzDynamicDir, ref uint pdwSize);
	}

	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("CD193BC0-B4BC-11d2-9833-00C04FC31D2E")]
	internal interface Interface2
	{
		[PreserveSig]
		int imethod_0(uint PropertyId, IntPtr pvProperty, uint cbProperty);

		[PreserveSig]
		int imethod_1(uint PropertyId, IntPtr pvProperty, ref uint pcbProperty);

		[PreserveSig]
		int imethod_2();

		[PreserveSig]
		int imethod_3(IntPtr szDisplayName, ref uint pccDisplayName, uint dwDisplayFlags);

		[PreserveSig]
		int imethod_4(object refIID, object pAsmBindSink, Interface1 pApplicationContext, [MarshalAs(UnmanagedType.LPWStr)] string szCodeBase, long llFlags, int pvReserved, uint cbReserved, out int ppv);

		[PreserveSig]
		int imethod_5(out uint lpcwBuffer, out int pwzName);

		[PreserveSig]
		int imethod_6(out uint pdwVersionHi, out uint pdwVersionLow);

		[PreserveSig]
		int imethod_7(Interface2 pName, uint dwCmpFlags);

		[PreserveSig]
		int imethod_8(out Interface2 pName);
	}

	[ComImport]
	[Guid("9e3aaeb4-d1cd-11d2-bab9-00c04f8eceae")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface Interface3
	{
		void imethod_0([MarshalAs(UnmanagedType.LPWStr)] string pszName, uint dwFormat, uint dwFlags, uint dwMaxSize, out Interface0 ppStream);

		void imethod_1(Interface2 pName);

		void imethod_2(uint dwFlags);

		void imethod_3(uint dwFlags);
	}

	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e707dcde-d1cd-11d2-bab9-00c04f8eceae")]
	internal interface Interface4
	{
		[PreserveSig]
		int imethod_0(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, IntPtr pvReserved, out uint pulDisposition);

		[PreserveSig]
		int imethod_1(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, IntPtr pAsmInfo);

		[PreserveSig]
		int imethod_2(uint dwFlags, IntPtr pvReserved, out Interface3 ppAsmItem, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName);

		[PreserveSig]
		int imethod_3(out object ppAsmScavenger);

		[PreserveSig]
		int imethod_4(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszManifestFilePath, IntPtr pvReserved);
	}

	[DllImport("fusion", CharSet = CharSet.Auto)]
	internal static extern int CreateAssemblyCache(out Interface4 ppAsmCache, uint uint_0);

	public static bool smethod_0(string string_0)
	{
		Interface4 ppAsmCache = null;
		if (CreateAssemblyCache(out ppAsmCache, 0u) != 0)
		{
			return false;
		}
		if (ppAsmCache.imethod_4(0u, string_0, IntPtr.Zero) != 0)
		{
			return false;
		}
		return true;
	}
}
