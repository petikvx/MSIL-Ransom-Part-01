using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("BC6EA726-AB56-46b6-A21A-AA7B76D6818F")]
public interface nsIPhonetic
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPhoneticAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPhonetic);
}
