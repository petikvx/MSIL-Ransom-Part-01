using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("e3f772f3-023f-4b32-b074-36cf0fd5d414")]
public interface nsIContentPrefService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIVariant GetPref([MarshalAs(UnmanagedType.Interface)] nsIVariant aGroup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.Interface)] nsILoadContext aPrivacyContext, IntPtr aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPref([MarshalAs(UnmanagedType.Interface)] nsIVariant aGroup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.Interface)] nsIVariant aValue, [MarshalAs(UnmanagedType.Interface)] nsILoadContext aPrivacyContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasPref([MarshalAs(UnmanagedType.Interface)] nsIVariant aGroup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.Interface)] nsILoadContext aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasCachedPref([MarshalAs(UnmanagedType.Interface)] nsIVariant aGroup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.Interface)] nsILoadContext aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemovePref([MarshalAs(UnmanagedType.Interface)] nsIVariant aGroup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.Interface)] nsILoadContext aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveGroupedPrefs([MarshalAs(UnmanagedType.Interface)] nsILoadContext aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemovePrefsByName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.Interface)] nsILoadContext aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPropertyBag2 GetPrefs([MarshalAs(UnmanagedType.Interface)] nsIVariant aGroup, [MarshalAs(UnmanagedType.Interface)] nsILoadContext aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPropertyBag2 GetPrefsByName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.Interface)] nsILoadContext aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddObserver([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, IntPtr aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveObserver([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, IntPtr aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetGrouperAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStorageConnection GetDBConnectionAttribute();
}
