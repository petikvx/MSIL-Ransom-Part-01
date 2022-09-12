using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2f977d44-5485-11d4-87e2-0010a4e75ef2")]
public interface nsIWebBrowserFind
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool FindNext();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetSearchStringAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSearchStringAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aSearchString);

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

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetSearchFramesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSearchFramesAttribute([MarshalAs(UnmanagedType.U1)] bool aSearchFrames);
}
