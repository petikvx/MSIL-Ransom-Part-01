using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2C7462E2-72C2-4473-9007-0E6AE71E23CA")]
public interface extIPreference
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIVariant GetValueAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetValueAttribute([MarshalAs(UnmanagedType.Interface)] nsIVariant aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetLockedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLockedAttribute([MarshalAs(UnmanagedType.U1)] bool aLocked);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetModifiedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	extIPreferenceBranch GetBranchAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	extIEvents GetEventsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reset();
}
