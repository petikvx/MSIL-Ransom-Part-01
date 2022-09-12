using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("ca6bad0c-8a48-48ac-82c7-27bb8f510fbe")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIGIOMimeApp
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCommandAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aCommand);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetExpectsURIsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIUTF8StringEnumerator GetSupportedURISchemesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Launch([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase uri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsDefaultForMimeType([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase mimeType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsDefaultForFileExtensions([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase extensions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsDefaultForURIScheme([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase uriScheme);
}
