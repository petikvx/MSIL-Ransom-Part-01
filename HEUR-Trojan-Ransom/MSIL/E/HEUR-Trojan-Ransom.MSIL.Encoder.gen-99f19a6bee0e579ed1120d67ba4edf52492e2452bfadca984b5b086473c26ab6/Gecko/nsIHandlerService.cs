using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("53f0ad17-ec62-46a1-adbc-efccc06babcd")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIHandlerService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator Enumerate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FillHandlerInfo([MarshalAs(UnmanagedType.Interface)] nsIHandlerInfo aHandlerInfo, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aOverrideType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Store([MarshalAs(UnmanagedType.Interface)] nsIHandlerInfo aHandlerInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Exists([MarshalAs(UnmanagedType.Interface)] nsIHandlerInfo aHandlerInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Remove([MarshalAs(UnmanagedType.Interface)] nsIHandlerInfo aHandlerInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeFromExtension([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aFileExtension, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
}
