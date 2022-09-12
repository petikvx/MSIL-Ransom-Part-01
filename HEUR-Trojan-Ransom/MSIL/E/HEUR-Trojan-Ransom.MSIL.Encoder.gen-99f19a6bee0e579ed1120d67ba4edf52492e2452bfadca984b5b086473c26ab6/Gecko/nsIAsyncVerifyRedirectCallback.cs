using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8d171460-a716-41f1-92be-8c659db39b45")]
public interface nsIAsyncVerifyRedirectCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnRedirectVerifyCallback(int result);
}
