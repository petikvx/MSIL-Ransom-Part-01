using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3716eb86-166b-445b-a94a-9b522fee96e6")]
public interface nsIXBLAccessible
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAccessibleNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAccessibleName);
}
