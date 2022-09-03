using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[ClassInterface(0)]
[TypeLibType(2)]
[Guid("E2085F28-FEB7-404A-B8E7-E659BDEAAA02")]
public class UPnPDeviceFinderClass : UPnPDeviceFinder, IUPnPDeviceFinder, IUPnPAddressFamilyControl, IUPnPHttpHeaderControl
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern UPnPDeviceFinderClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610744809)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern UPnPDevices FindByType([In][MarshalAs(UnmanagedType.BStr)] string string_0, [In] uint uint_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610744812)]
	public virtual extern int CreateAsyncFind([In][MarshalAs(UnmanagedType.BStr)] string string_0, [In] uint uint_0, [In][MarshalAs(UnmanagedType.IUnknown)] object object_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610744813)]
	public virtual extern void StartAsyncFind([In] int int_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610744814)]
	public virtual extern void CancelAsyncFind([In] int int_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610744811)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern UPnPDevice FindByUDN([In][MarshalAs(UnmanagedType.BStr)] string string_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void SetAddressFamily([In] int int_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void GetAddressFamily(out int int_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void AddRequestHeaders([In][MarshalAs(UnmanagedType.BStr)] string string_0);
}
