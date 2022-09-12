using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("3d6a9c87-5c5f-46fc-9410-96da6092f0f2")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIVerifySignedManifestCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void VerifySignedManifestFinished(int rv, [MarshalAs(UnmanagedType.Interface)] nsIX509Cert aSignerCert);
}
