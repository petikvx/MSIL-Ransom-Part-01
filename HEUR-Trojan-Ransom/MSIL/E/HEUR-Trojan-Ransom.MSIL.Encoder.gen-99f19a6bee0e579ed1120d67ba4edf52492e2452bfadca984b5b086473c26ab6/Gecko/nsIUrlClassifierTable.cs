using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("fd1f8334-1859-472d-b01f-4ac6b1121ce4")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIUrlClassifierTable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetNeedsUpdateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNeedsUpdateAttribute([MarshalAs(UnmanagedType.U1)] bool aNeedsUpdate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Exists([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase key, [MarshalAs(UnmanagedType.Interface)] nsIUrlListManagerCallback cb);
}
