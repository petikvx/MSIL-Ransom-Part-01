using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3a3c5e8f-ec4a-4086-ae0a-d16420d30c9f")]
public interface mozILivemarkInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetGuidAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetParentIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetParentGuidAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetDateAddedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetLastModifiedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetFeedURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetSiteURIAttribute();
}
