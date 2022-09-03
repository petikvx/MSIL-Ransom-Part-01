using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[TypeLibType(4288)]
[Guid("A295019C-DC65-47DD-90DC-7FE918A1AB44")]
public interface IUPnPService
{
	[DispId(1610746311)]
	string ServiceTypeIdentifier
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610746311)]
		get;
	}

	[DispId(1610746313)]
	string Id
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610746313)]
		get;
	}

	[DispId(1610746314)]
	int LastTransportStatus
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610746314)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610746309)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object QueryStateVariable([In][MarshalAs(UnmanagedType.BStr)] string string_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610746310)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object InvokeAction([In][MarshalAs(UnmanagedType.BStr)] string string_0, [In][MarshalAs(UnmanagedType.Struct)] object object_0, [In][Out][MarshalAs(UnmanagedType.Struct)] ref object object_1);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610746312)]
	void AddCallback([In][MarshalAs(UnmanagedType.IUnknown)] object object_0);
}
