using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("76EA47B1-C797-49b3-9F18-5E740A688524")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIJumpListLink : nsIJumpListItem
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new short GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool Equals([MarshalAs(UnmanagedType.Interface)] nsIJumpListItem item);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetUriAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUriAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aUri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUriTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUriTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUriTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUriTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUriHashAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aUriHash);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CompareHash([MarshalAs(UnmanagedType.Interface)] nsIURI uri);
}
