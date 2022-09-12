using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("AAAB6710-0F2C-11d5-A53B-0010A401EB10")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICookieManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveAll();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetEnumeratorAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Remove([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aName, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPath, [MarshalAs(UnmanagedType.U1)] bool aBlocked);
}
