using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("46226D9B-E398-4106-8D9B-225D4D0589F5")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface inISearchObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnSearchStart(inISearchProcess aModule);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnSearchResult(inISearchProcess aModule);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnSearchEnd(inISearchProcess aModule, short aResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnSearchError(inISearchProcess aModule, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMessage);
}
