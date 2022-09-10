using System;
using System.Runtime.InteropServices;
using System.Text;

namespace MsGac.Fusion.Native;

[ComImport]
[Guid("CD193BC0-B4BC-11D2-9833-00C04FC31D2E")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IAssemblyName
{
	[PreserveSig]
	int SetProperty(ASM_NAME PropertyId, IntPtr pvProperty, uint cbProperty);

	[PreserveSig]
	int GetProperty(ASM_NAME PropertyId, IntPtr pvProperty, ref uint pcbProperty);

	[PreserveSig]
	int Finalize();

	[PreserveSig]
	int GetDisplayName([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder szDisplayName, ref uint pccDisplayName, ASM_DISPLAY_FLAGS dwDisplayFlags);

	[PreserveSig]
	int BindToObject(ref Guid refIID, [MarshalAs(UnmanagedType.IUnknown)] object pUnkSink, [MarshalAs(UnmanagedType.IUnknown)] object pUnkContext, [MarshalAs(UnmanagedType.LPWStr)] string szCodeBase, long llFlags, IntPtr pvReserved, uint cbReserved, out IntPtr ppv);

	[PreserveSig]
	int GetName(ref uint lpcwBuffer, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwzName);

	[PreserveSig]
	int GetVersion(out uint pdwVersionHi, out uint pdwVersionLow);

	[PreserveSig]
	int IsEqual(IAssemblyName pName, ASM_CMP_FLAGS dwCmpFlags);

	[PreserveSig]
	int Clone(out IAssemblyName pName);
}
