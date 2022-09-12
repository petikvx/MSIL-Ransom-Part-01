using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("9e631b1d-7a07-4925-a47e-697c6edaf408")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIIMEPicker
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Show();
}
