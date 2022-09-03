using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[TypeLibType(4288)]
[Guid("ADDA3D55-6F72-4319-BFF9-18600A539B10")]
public interface IUPnPDeviceFinder
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610744809)]
	[return: MarshalAs(UnmanagedType.Interface)]
	UPnPDevices FindByType([In][MarshalAs(UnmanagedType.BStr)] string string_0, [In] uint uint_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610744812)]
	int CreateAsyncFind([In][MarshalAs(UnmanagedType.BStr)] string string_0, [In] uint uint_0, [In][MarshalAs(UnmanagedType.IUnknown)] object object_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610744813)]
	void StartAsyncFind([In] int int_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610744814)]
	void CancelAsyncFind([In] int int_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610744811)]
	[return: MarshalAs(UnmanagedType.Interface)]
	UPnPDevice FindByUDN([In][MarshalAs(UnmanagedType.BStr)] string string_0);
}
