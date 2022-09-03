using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[TypeLibType(256)]
[Guid("E3BF6178-694E-459F-A5A6-191EA0FFA1C7")]
[InterfaceType(1)]
public interface IUPnPAddressFamilyControl
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAddressFamily([In] int int_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAddressFamily(out int int_0);
}
