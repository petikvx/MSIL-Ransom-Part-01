using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("216112d3-28bc-4671-b057-f98cc09ba1ea")]
public interface nsITransportSecurityInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSecurityStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetErrorMessageAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetErrorCodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIX509CertList GetFailedCertChainAttribute();
}
