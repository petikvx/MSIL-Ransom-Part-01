using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9f6fdfae-db9a-4bd8-bde1-148758cf1b18")]
public interface mozILivemark : mozILivemarkInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetGuidAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetParentIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetParentGuidAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetDateAddedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetLastModifiedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIURI GetFeedURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIURI GetSiteURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetStatusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reload([MarshalAs(UnmanagedType.U1)] bool aForceUpdate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetNodesForContainer(ref JsVal aContainerNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterForUpdates(ref JsVal aContainerNode, [MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultObserver aResultObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterForUpdates(ref JsVal aContainerNode);
}
