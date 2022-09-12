using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("672387b7-a75d-4e8f-9b49-5c1dcbfff46b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface mozIAsyncLivemarks
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal AddLivemark(ref JsVal aLivemarkInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal RemoveLivemark(ref JsVal aLivemarkInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetLivemark(ref JsVal aLivemarkInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReloadLivemarks([MarshalAs(UnmanagedType.U1)] bool aForceUpdate);
}
