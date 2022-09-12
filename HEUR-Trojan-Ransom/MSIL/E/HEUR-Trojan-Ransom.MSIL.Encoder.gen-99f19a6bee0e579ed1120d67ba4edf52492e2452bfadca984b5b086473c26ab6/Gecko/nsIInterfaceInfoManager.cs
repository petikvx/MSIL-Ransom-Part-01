using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("1d53d8d9-1d92-428f-b5cc-198b55e897d7")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIInterfaceInfoManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInterfaceInfo GetInfoForIID(Guid iid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInterfaceInfo GetInfoForName([MarshalAs(UnmanagedType.LPStr)] string name);

	Guid GetIIDForName([MarshalAs(UnmanagedType.LPStr)] string name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string GetNameForIID(Guid iid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AutoRegisterInterfaces();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIEnumerator EnumerateInterfacesWhoseNamesStartWith([MarshalAs(UnmanagedType.LPStr)] string prefix);
}
