using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("4f18ada2-0ddc-11d5-9d3a-0060b0f8baff")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsPIEditorTransaction
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTxnDescriptionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTxnDescription);
}
