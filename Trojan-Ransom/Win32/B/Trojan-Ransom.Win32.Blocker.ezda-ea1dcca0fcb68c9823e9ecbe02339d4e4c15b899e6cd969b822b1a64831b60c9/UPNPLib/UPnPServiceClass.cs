using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[Guid("C624BA95-FBCB-4409-8C03-8CCEEC533EF1")]
[ClassInterface(0)]
[TypeLibType(2)]
public class UPnPServiceClass : IUPnPService, UPnPService
{
	[DispId(1610746311)]
	public virtual extern string ServiceTypeIdentifier
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610746311)]
		get;
	}

	[DispId(1610746313)]
	public virtual extern string Id
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610746313)]
		get;
	}

	[DispId(1610746314)]
	public virtual extern int LastTransportStatus
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610746314)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern UPnPServiceClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610746309)]
	[return: MarshalAs(UnmanagedType.Struct)]
	public virtual extern object QueryStateVariable([In][MarshalAs(UnmanagedType.BStr)] string string_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610746310)]
	[return: MarshalAs(UnmanagedType.Struct)]
	public virtual extern object InvokeAction([In][MarshalAs(UnmanagedType.BStr)] string string_0, [In][MarshalAs(UnmanagedType.Struct)] object object_0, [In][Out][MarshalAs(UnmanagedType.Struct)] ref object object_1);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610746312)]
	public virtual extern void AddCallback([In][MarshalAs(UnmanagedType.IUnknown)] object object_0);
}
