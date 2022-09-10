using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

[ComImport]
[Guid("D332DB9E-B9B3-4125-8207-A14884F53216")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IClrMetaHost
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	object GetRuntime([In][MarshalAs(UnmanagedType.LPWStr)] string version, [In][MarshalAs(UnmanagedType.LPStruct)] Guid interfaceId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetVersionFromFile([In][MarshalAs(UnmanagedType.LPWStr)] string filePath, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder buffer, [In][Out][MarshalAs(UnmanagedType.U4)] ref int bufferLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEnumUnknown EnumerateInstalledRuntimes();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEnumUnknown EnumerateLoadedRuntimes([In] IntPtr processHandle);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	int Reserved01([In] IntPtr reserved1);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	object QueryLegacyV2RuntimeBinding([In][MarshalAs(UnmanagedType.LPStruct)] Guid interfaceId);
}
