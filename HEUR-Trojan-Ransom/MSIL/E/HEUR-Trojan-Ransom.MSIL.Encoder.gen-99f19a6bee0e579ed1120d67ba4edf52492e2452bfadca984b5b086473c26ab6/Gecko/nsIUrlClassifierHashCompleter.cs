using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("231fb2ad-ea8a-4e63-a331-eafc3b434811")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIUrlClassifierHashCompleter
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Complete([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase partialHash, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase gethashUrl, [MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierHashCompleterCallback callback);
}
