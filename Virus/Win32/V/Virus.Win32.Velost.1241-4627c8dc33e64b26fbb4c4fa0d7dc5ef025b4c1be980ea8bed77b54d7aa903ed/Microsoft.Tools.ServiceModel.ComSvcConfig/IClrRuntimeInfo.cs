using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

[ComImport]
[Guid("BD39D1D2-BA2F-486A-89B0-B4B0CB466891")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IClrRuntimeInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetVersionString([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder buffer, [In][Out][MarshalAs(UnmanagedType.U4)] ref int bufferLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRuntimeDirectory([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder buffer, [In][Out][MarshalAs(UnmanagedType.U4)] ref int bufferLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Bool)]
	bool IsLoaded([In] IntPtr processHandle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[LCIDConversion(3)]
	void LoadErrorString([In][MarshalAs(UnmanagedType.U4)] int resourceId, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder buffer, [In][Out][MarshalAs(UnmanagedType.U4)] ref int bufferLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr LoadLibrary([In][MarshalAs(UnmanagedType.LPWStr)] string dllName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetProcAddress([In][MarshalAs(UnmanagedType.LPStr)] string procName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	object GetInterface([In][MarshalAs(UnmanagedType.LPStruct)] Guid coClassId, [In][MarshalAs(UnmanagedType.LPStruct)] Guid interfaceId);
}
