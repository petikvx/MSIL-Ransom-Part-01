using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("e7b3e826-bb85-49b2-a2f1-70af46c47733")]
public interface nsILteCellInfo : nsICellInfo
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
	int GetCidAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPcidAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetTacAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetSignalStrengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRsrpAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRsrqAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRssnrAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCqiAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetTimingAdvanceAttribute();
}
