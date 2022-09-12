using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("75125d55-37ee-4575-b9b5-f33bfa68c2a1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFind
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetFindBackwardsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFindBackwardsAttribute([MarshalAs(UnmanagedType.U1)] bool aFindBackwards);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCaseSensitiveAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCaseSensitiveAttribute([MarshalAs(UnmanagedType.U1)] bool aCaseSensitive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetWordBreakerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWordBreakerAttribute(IntPtr aWordBreaker);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMRange Find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPatText, [MarshalAs(UnmanagedType.Interface)] nsIDOMRange aSearchRange, [MarshalAs(UnmanagedType.Interface)] nsIDOMRange aStartPoint, [MarshalAs(UnmanagedType.Interface)] nsIDOMRange aEndPoint);
}
