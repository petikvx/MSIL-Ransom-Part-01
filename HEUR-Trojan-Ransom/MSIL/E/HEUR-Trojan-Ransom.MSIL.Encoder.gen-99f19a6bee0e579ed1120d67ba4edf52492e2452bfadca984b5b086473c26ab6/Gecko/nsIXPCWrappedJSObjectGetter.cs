using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("254bb2e0-6439-11d4-8fe0-0010a4e73d9a")]
public interface nsIXPCWrappedJSObjectGetter
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetNeverCalledAttribute();
}
