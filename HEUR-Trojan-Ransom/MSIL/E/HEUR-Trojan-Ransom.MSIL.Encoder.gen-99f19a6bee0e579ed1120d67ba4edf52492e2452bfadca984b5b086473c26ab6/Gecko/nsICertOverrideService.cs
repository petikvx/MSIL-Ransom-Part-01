using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("be019e47-22fc-4355-9f16-9ab047d6742d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICertOverrideService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void RememberValidityOverride([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHostName, int aPort, [MarshalAs(UnmanagedType.Interface)] nsIX509Cert aCert, uint aOverrideBits, [MarshalAs(UnmanagedType.U1)] bool aTemporary);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasMatchingOverride([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHostName, int aPort, [MarshalAs(UnmanagedType.Interface)] nsIX509Cert aCert, ref uint aOverrideBits, [MarshalAs(UnmanagedType.U1)] ref bool aIsTemporary);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetValidityOverride([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHostName, int aPort, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHashAlg, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aFingerprint, ref uint aOverrideBits, [MarshalAs(UnmanagedType.U1)] ref bool aIsTemporary);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearValidityOverride([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHostName, int aPort);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint IsCertUsedForOverrides([MarshalAs(UnmanagedType.Interface)] nsIX509Cert aCert, [MarshalAs(UnmanagedType.U1)] bool aCheckTemporaries, [MarshalAs(UnmanagedType.U1)] bool aCheckPermanents);
}
