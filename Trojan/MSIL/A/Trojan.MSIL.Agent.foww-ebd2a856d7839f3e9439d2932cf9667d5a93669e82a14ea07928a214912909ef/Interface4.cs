using System;
using System.Runtime.InteropServices;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("56A86895-0AD4-11CE-B03A-0020AF0BA770")]
internal interface Interface4
{
	[PreserveSig]
	int GetClassID(out Guid ClassID);

	[PreserveSig]
	int Stop();

	[PreserveSig]
	int Pause();

	[PreserveSig]
	int Run(long start);

	[PreserveSig]
	int GetState(int milliSecsTimeout, out int filterState);

	[PreserveSig]
	int SetSyncSource([In] IntPtr clock);

	[PreserveSig]
	int GetSyncSource(out IntPtr clock);

	[PreserveSig]
	int EnumPins(out Interface8 enumPins);

	[PreserveSig]
	int FindPin([In][MarshalAs(UnmanagedType.LPWStr)] string id, out Interface14 pin);

	[PreserveSig]
	int QueryFilterInfo(out Struct14 filterInfo);

	[PreserveSig]
	int JoinFilterGraph([In] Interface9 graph, [In][MarshalAs(UnmanagedType.LPWStr)] string name);

	[PreserveSig]
	int QueryVendorInfo([MarshalAs(UnmanagedType.LPWStr)] out string vendorInfo);
}
