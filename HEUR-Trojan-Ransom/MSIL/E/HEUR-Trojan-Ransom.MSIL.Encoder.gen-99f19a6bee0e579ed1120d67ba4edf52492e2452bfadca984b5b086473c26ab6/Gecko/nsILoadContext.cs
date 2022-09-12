using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("c71ef717-8fb9-425e-98ef-aef5894890f8")]
public interface nsILoadContext
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetAssociatedWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetTopWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetTopFrameElementAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetNestedFrameIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsAppOfType(uint appType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsContentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetUsePrivateBrowsingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUsePrivateBrowsingAttribute([MarshalAs(UnmanagedType.U1)] bool aUsePrivateBrowsing);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetUseRemoteTabsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPrivateBrowsing([MarshalAs(UnmanagedType.U1)] bool aInPrivateBrowsing);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRemoteTabs([MarshalAs(UnmanagedType.U1)] bool aUseRemoteTabs);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsInBrowserElementAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetAppIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetOriginAttributesAttribute();
}
