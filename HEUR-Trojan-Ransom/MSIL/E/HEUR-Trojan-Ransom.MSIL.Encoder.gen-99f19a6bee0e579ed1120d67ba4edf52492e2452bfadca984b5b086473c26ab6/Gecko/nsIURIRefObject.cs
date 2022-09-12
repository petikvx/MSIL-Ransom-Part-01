using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2226927e-1dd2-11b2-b57f-faab47288563")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIURIRefObject
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetNodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNodeAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reset();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNextURI([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RewriteAllURIs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aOldPat, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNewPat, [MarshalAs(UnmanagedType.U1)] bool aMakeRel);
}
