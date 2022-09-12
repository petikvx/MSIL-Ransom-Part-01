using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("12f60021-e14b-4020-99d1-ed2c795be66a")]
public interface nsINSSErrorsService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsNSSErrorCode(int aNSPRCode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetXPCOMFromNSSError(int aNSPRCode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetErrorMessage(int aXPCOMErrorCode, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetErrorClass(int aXPCOMErrorCode);
}
