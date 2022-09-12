using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("aa52647b-38dd-487c-be36-b46ed2e99554")]
public interface nsIWcdmaCellInfo : nsICellInfo
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
	int GetPscAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetSignalStrengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetBitErrorRateAttribute();
}
