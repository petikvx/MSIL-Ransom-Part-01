using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2be87909-0817-4292-acfa-fc39be53be3f")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface extIApplication
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	extIConsole GetConsoleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetExtensions(extIExtensionsCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	extIPreferenceBranch GetPrefsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	extISessionStorage GetStorageAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	extIEvents GetEventsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Quit();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Restart();
}
