using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("d5f97827-622a-488f-be08-d850432ac8ec")]
public interface nsIVerifySignedDirectoryCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void VerifySignedDirectoryFinished(int rv, [MarshalAs(UnmanagedType.Interface)] nsIX509Cert aSignerCert);
}
