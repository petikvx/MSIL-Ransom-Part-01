using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("f8ed8364-ced9-4c6e-86ba-48af53c393e6")]
public interface nsIX509Cert
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNicknameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNickname);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetEmailAddressAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aEmailAddress);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetEmailAddresses(ref uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref IntPtr[] addresses);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ContainsEmailAddress([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aEmailAddress);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSubjectNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSubjectName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCommonNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCommonName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetOrganizationAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aOrganization);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetOrganizationalUnitAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aOrganizationalUnit);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSha256FingerprintAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSha256Fingerprint);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSha1FingerprintAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSha1Fingerprint);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTokenNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTokenName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetIssuerNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIssuerName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSerialNumberAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSerialNumber);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetIssuerCommonNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIssuerCommonName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetIssuerOrganizationAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIssuerOrganization);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetIssuerOrganizationUnitAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIssuerOrganizationUnit);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIX509Cert GetIssuerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIX509CertValidity GetValidityAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetDbKeyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetWindowTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aWindowTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetCertTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsSelfSignedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetChain();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUsagesArray([MarshalAs(UnmanagedType.U1)] bool localOnly, ref uint verified, ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ref IntPtr[] usages);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RequestUsagesArrayAsync([MarshalAs(UnmanagedType.Interface)] nsICertVerificationListener cvl);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUsagesString([MarshalAs(UnmanagedType.U1)] bool localOnly, ref uint verified, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase usages);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIASN1Object GetASN1StructureAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRawDER(ref uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref byte[] data);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Equals([MarshalAs(UnmanagedType.Interface)] nsIX509Cert other);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSha256SubjectPublicKeyInfoDigestAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aSha256SubjectPublicKeyInfoDigest);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ExportAsCMS(uint chainMode, ref uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref byte[] data);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetCert();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAllTokenNames(ref uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref IntPtr[] tokenNames);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MarkForPermDeletion();
}
