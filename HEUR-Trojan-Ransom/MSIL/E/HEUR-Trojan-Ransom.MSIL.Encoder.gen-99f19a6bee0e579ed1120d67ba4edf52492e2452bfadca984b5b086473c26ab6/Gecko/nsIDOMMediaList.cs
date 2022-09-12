using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9b0c2ed7-111c-4824-adf9-ef0da6dad371")]
public interface nsIDOMMediaList
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMediaTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMediaText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMediaTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMediaText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Item(uint index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteMedium([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase oldMedium);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AppendMedium([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase newMedium);
}
