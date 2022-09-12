using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("16784db0-fcb1-4352-b0c9-6a3a67e3cf79")]
public interface nsIHttpAuthenticator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ChallengeReceived([MarshalAs(UnmanagedType.Interface)] nsIHttpAuthenticableChannel aChannel, [MarshalAs(UnmanagedType.LPStr)] string aChallenge, [MarshalAs(UnmanagedType.U1)] bool aProxyAuth, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aSessionState, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aContinuationState, [MarshalAs(UnmanagedType.U1)] ref bool aInvalidatesIdentity);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string GenerateCredentials([MarshalAs(UnmanagedType.Interface)] nsIHttpAuthenticableChannel aChannel, [MarshalAs(UnmanagedType.LPStr)] string aChallenge, [MarshalAs(UnmanagedType.U1)] bool aProxyAuth, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aDomain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aUser, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPassword, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aSessionState, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aContinuationState, ref uint aFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetAuthFlagsAttribute();
}
