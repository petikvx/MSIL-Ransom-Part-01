using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4173cc53-30f6-4d12-a770-981ba53164e2")]
public interface nsIDOMHTMLOptionsCollection
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLengthAttribute(uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode Item(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode NamedItem([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetSelectedIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectedIndexAttribute(int aSelectedIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOption(uint index, [MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLOptionElement option);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMHTMLSelectElement GetSelectAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Add([MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLOptionElement option, [MarshalAs(UnmanagedType.Interface)] nsIVariant before);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Remove(int index);
}
