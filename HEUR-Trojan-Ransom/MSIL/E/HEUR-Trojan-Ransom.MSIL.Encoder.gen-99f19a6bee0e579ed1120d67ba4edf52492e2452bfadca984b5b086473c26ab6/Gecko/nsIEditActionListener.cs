using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("b22907b1-ee93-11d2-8d50-000064657374")]
public interface nsIEditActionListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void WillCreateNode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTag, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aParent, int aPosition);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DidCreateNode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTag, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aParent, int aPosition, int aResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WillInsertNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aParent, int aPosition);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DidInsertNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aParent, int aPosition, int aResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WillDeleteNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aChild);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DidDeleteNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aChild, int aResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WillSplitNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aExistingRightNode, int aOffset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DidSplitNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aExistingRightNode, int aOffset, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNewLeftNode, int aResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WillJoinNodes([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aLeftNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aRightNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aParent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DidJoinNodes([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aLeftNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aRightNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aParent, int aResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WillInsertText([MarshalAs(UnmanagedType.Interface)] nsIDOMCharacterData aTextNode, int aOffset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DidInsertText([MarshalAs(UnmanagedType.Interface)] nsIDOMCharacterData aTextNode, int aOffset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aString, int aResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WillDeleteText([MarshalAs(UnmanagedType.Interface)] nsIDOMCharacterData aTextNode, int aOffset, int aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DidDeleteText([MarshalAs(UnmanagedType.Interface)] nsIDOMCharacterData aTextNode, int aOffset, int aLength, int aResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WillDeleteSelection([MarshalAs(UnmanagedType.Interface)] nsISelection aSelection);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DidDeleteSelection([MarshalAs(UnmanagedType.Interface)] nsISelection aSelection);
}
