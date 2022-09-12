using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("004efdc5-1989-4874-8a7a-345bf2fa33af")]
public interface nsIAutoCompleteSimpleResultListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnValueRemoved([MarshalAs(UnmanagedType.Interface)] nsIAutoCompleteSimpleResult aResult, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue, [MarshalAs(UnmanagedType.U1)] bool aRemoveFromDb);
}
