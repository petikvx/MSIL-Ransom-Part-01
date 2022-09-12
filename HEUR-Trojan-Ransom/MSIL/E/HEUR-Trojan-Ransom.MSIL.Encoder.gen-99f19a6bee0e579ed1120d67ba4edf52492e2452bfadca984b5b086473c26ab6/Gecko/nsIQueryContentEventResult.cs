using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("e2c39e0e-345f-451a-a7b2-e0230d555847")]
public interface nsIQueryContentEventResult
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetOffsetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTentativeCaretOffsetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetReversedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLeftAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetTopAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetWidthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetHeightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetSucceededAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetNotFoundAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetTentativeCaretOffsetNotFoundAttribute();
}
