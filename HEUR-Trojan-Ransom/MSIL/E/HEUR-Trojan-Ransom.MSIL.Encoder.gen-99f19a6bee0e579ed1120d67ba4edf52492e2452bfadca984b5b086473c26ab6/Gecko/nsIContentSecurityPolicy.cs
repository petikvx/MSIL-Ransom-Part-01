using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("b3c4c0ae-bd5e-4cad-87e0-8d210dbb3f9f")]
public interface nsIContentSecurityPolicy : nsISerializable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Read([MarshalAs(UnmanagedType.Interface)] nsIObjectInputStream aInputStream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Write([MarshalAs(UnmanagedType.Interface)] nsIObjectOutputStream aOutputStream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPolicy(uint index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetPolicyCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetUpgradeInsecureRequestsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetReferrerPolicy(ref uint policy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AppendPolicy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase policyString, [MarshalAs(UnmanagedType.U1)] bool reportOnly, [MarshalAs(UnmanagedType.U1)] bool deliveredViaMetaTag);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllowsInline(IntPtr aContentPolicyType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNonce, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aContent, uint aLineNumber);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllowsEval([MarshalAs(UnmanagedType.U1)] ref bool shouldReportViolations);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LogViolationDetails(ushort violationType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceFile, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase scriptSample, int lineNum, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase nonce, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase content);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRequestContext([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument aDocument, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool PermitsAncestry([MarshalAs(UnmanagedType.Interface)] nsIDocShell docShell);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Permits([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, IntPtr aDir, [MarshalAs(UnmanagedType.U1)] bool aSpecific);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short ShouldLoad(IntPtr aContentType, [MarshalAs(UnmanagedType.Interface)] nsIURI aContentLocation, [MarshalAs(UnmanagedType.Interface)] nsIURI aRequestOrigin, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeTypeGuess, [MarshalAs(UnmanagedType.Interface)] nsISupports aExtra);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ToJSON([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
}
