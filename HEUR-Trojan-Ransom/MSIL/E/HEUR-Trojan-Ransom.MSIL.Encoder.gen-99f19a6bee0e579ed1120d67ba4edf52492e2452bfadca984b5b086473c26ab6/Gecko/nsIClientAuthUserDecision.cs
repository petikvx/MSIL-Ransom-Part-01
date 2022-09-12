using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("95c4373e-bdd4-4a63-b431-f5b000367721")]
public interface nsIClientAuthUserDecision
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetRememberClientAuthCertificateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRememberClientAuthCertificateAttribute([MarshalAs(UnmanagedType.U1)] bool aRememberClientAuthCertificate);
}
