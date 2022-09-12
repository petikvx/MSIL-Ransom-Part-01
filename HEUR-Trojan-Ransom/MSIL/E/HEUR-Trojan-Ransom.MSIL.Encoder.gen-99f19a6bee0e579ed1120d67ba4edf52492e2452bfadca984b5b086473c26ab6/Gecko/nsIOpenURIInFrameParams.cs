using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("e774db14-79ac-4156-a7a3-aa3fd0a22c10")]
public interface nsIOpenURIInFrameParams
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetReferrerAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aReferrer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetReferrerAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aReferrer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsPrivateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsPrivateAttribute([MarshalAs(UnmanagedType.U1)] bool aIsPrivate);
}
