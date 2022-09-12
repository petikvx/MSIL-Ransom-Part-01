using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("da16de40-df26-414d-bde7-c4faf4504868")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIUrlClassifierHashCompleterCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Completion([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase hash, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase table, uint chunkId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CompletionFinished(int status);
}
