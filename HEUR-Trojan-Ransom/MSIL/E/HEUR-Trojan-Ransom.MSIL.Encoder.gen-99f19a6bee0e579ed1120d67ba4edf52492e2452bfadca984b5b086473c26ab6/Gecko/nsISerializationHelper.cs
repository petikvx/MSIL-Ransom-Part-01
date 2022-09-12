using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("31654c0f-35f3-44c6-b31e-37a11516e6bc")]
public interface nsISerializationHelper
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SerializeToString([MarshalAs(UnmanagedType.Interface)] nsISerializable serializable, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports DeserializeObject([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase input);
}
