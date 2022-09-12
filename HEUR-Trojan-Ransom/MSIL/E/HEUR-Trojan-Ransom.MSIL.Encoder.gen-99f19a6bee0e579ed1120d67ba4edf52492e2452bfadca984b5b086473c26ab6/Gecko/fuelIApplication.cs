using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("fe74cf80-aa2d-11db-abbd-0800200c9a66")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface fuelIApplication : extIApplication
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new extIConsole GetConsoleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetExtensions(extIExtensionsCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new extIPreferenceBranch GetPrefsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new extISessionStorage GetStorageAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new extIEvents GetEventsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool Quit();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool Restart();

	[MethodImpl(MethodImplOptions.InternalCall)]
	fuelIBookmarkRoots GetBookmarksAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIVariant GetWindowsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	fuelIWindow GetActiveWindowAttribute();
}
