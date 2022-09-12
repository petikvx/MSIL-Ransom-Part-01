using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8face46e-0c96-470f-af40-0037dcd797bd")]
public interface nsIURIClassifierCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnClassifyComplete(int aErrorCode);
}
