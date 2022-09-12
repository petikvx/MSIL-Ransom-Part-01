using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("D5FA765B-2448-4686-B7C1-5FF13ACB0FC9")]
public interface inISearchProcess
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsActiveAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetResultCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHoldResultsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHoldResultsAttribute([MarshalAs(UnmanagedType.U1)] bool aHoldResults);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SearchSync();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SearchAsync(inISearchObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SearchStop();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SearchStep();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetStringResultAt(int aIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetIntResultAt(int aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetUIntResultAt(int aIndex);
}
