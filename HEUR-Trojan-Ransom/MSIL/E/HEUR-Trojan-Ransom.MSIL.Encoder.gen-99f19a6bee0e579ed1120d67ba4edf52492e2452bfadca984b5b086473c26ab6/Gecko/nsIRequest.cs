using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("ef6bfbd2-fd46-48d8-96b7-9f8f0fd387fe")]
public interface nsIRequest
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsPending();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetStatusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Cancel(int aStatus);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Suspend();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Resume();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsILoadGroup GetLoadGroupAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLoadGroupAttribute([MarshalAs(UnmanagedType.Interface)] nsILoadGroup aLoadGroup);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLoadFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLoadFlagsAttribute(uint aLoadFlags);
}
