using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("f938f5ba-7093-42cd-a559-af8039d99204")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPluginHost
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReloadPlugins();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetPluginTags(ref uint aPluginCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearSiteData([MarshalAs(UnmanagedType.Interface)] nsIPluginTag plugin, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase domain, ulong flags, long maxAge, [MarshalAs(UnmanagedType.Interface)] nsIClearSiteDataCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SiteHasData([MarshalAs(UnmanagedType.Interface)] nsIPluginTag plugin, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase domain);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPermissionStringForType([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase mimeType, uint excludeFlags, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPluginTag GetPluginTagForType([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase mimeType, uint excludeFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetStateForType([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase mimeType, uint excludeFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetBlocklistStateForType([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aMimeType, uint excludeFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFakePluginTag RegisterFakePlugin(ref JsVal initDictionary, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFakePluginTag GetFakePlugin([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase mimeType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterFakePlugin([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase handlerURI);
}
