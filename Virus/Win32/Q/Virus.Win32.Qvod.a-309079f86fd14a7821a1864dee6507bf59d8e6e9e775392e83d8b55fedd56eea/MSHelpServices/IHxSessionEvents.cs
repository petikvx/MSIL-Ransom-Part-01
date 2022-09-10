using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[InterfaceType(2)]
[Guid("314111ED-A502-11D2-BBCA-00C04F8EC294")]
[TypeLibType(4096)]
public interface IHxSessionEvents
{
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(65800)]
	void QueryCancel([In][MarshalAs(UnmanagedType.IDispatch)] object pSession, [In][MarshalAs(UnmanagedType.IDispatch)] object pCancel, [In] int status);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(65801)]
	void IndexMergeStatus([In][MarshalAs(UnmanagedType.IDispatch)] object pSession, [In][MarshalAs(UnmanagedType.IDispatch)] object pCancel, [In] int status);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(65802)]
	void PrintMergeStatus([In][MarshalAs(UnmanagedType.IDispatch)] object pSession, [In][MarshalAs(UnmanagedType.IDispatch)] object pCancel, [In] int status);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(65804)]
	void MergeIndexFileName([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In][MarshalAs(UnmanagedType.BStr)] string bstrFile);
}
