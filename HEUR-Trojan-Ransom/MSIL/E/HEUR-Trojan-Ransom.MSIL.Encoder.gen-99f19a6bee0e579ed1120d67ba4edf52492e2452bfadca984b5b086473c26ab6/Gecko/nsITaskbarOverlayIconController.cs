using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("b1858889-a698-428a-a14b-b5d60cff6de2")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITaskbarOverlayIconController
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOverlayIcon(imgIContainer statusIcon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase statusDescription);
}
