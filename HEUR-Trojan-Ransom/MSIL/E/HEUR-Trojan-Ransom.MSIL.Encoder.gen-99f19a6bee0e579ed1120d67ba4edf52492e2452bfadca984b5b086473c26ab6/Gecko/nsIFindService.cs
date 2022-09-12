using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("5060b801-340e-11d5-be5b-b3e063ec6a3c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFindService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSearchStringAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSearchString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSearchStringAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSearchString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetReplaceStringAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aReplaceString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetReplaceStringAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aReplaceString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetFindBackwardsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFindBackwardsAttribute([MarshalAs(UnmanagedType.U1)] bool aFindBackwards);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetWrapFindAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWrapFindAttribute([MarshalAs(UnmanagedType.U1)] bool aWrapFind);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetEntireWordAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEntireWordAttribute([MarshalAs(UnmanagedType.U1)] bool aEntireWord);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetMatchCaseAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMatchCaseAttribute([MarshalAs(UnmanagedType.U1)] bool aMatchCase);
}
