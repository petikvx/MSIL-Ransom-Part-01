using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("10cee02c-f6e0-4d61-ab27-c16572b18c46")]
public interface extIExtension
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetFirstRunAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	extIPreferenceBranch GetPrefsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	extISessionStorage GetStorageAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	extIEvents GetEventsAttribute();
}
