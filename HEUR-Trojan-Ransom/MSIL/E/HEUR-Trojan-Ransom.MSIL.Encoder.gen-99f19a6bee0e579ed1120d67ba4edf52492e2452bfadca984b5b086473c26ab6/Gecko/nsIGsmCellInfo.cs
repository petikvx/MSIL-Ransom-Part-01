using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("cc476ded-350f-4c25-9a57-6a876e32f092")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIGsmCellInfo : nsICellInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetRegisteredAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetTimestampTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetTimestampAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetMccAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetMncAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLacAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCidAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetSignalStrengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetBitErrorRateAttribute();
}
