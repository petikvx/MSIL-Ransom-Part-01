using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("5b3675a1-02db-4f8f-a560-b34736635f47")]
public interface nsIMIMEService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIMIMEInfo GetFromTypeAndExtension([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMIMEType, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFileExt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeFromExtension([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFileExt, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeFromURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeFromFile([MarshalAs(UnmanagedType.Interface)] nsIFile aFile, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPrimaryExtension([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMIMEType, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFileExt, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
}
