using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("ebea0230-36fa-41b7-8e31-760806057965")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIXULTemplateResult
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsContainerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsEmptyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetMayProcessChildrenAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFResource GetResourceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBindingFor([MarshalAs(UnmanagedType.Interface)] nsIAtom aVar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetBindingObjectFor([MarshalAs(UnmanagedType.Interface)] nsIAtom aVar);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RuleMatched([MarshalAs(UnmanagedType.Interface)] nsISupports aQuery, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aRuleNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HasBeenRemoved();
}
