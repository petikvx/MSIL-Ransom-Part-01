using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("a36c45fb-f7b5-423e-a0f7-ea1eb4fd60b5")]
public interface nsIX509CertDB
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIX509Cert FindCertByNickname([MarshalAs(UnmanagedType.Interface)] nsISupports aToken, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNickname);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIX509Cert FindCertByDBKey([MarshalAs(UnmanagedType.LPStr)] string aDBkey, [MarshalAs(UnmanagedType.Interface)] nsISupports aToken);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FindCertNicknames([MarshalAs(UnmanagedType.Interface)] nsISupports aToken, uint aType, ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ref IntPtr[] certNameList);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIX509Cert FindEmailEncryptionCert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNickname);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIX509Cert FindEmailSigningCert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNickname);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIX509Cert FindCertByEmailAddress([MarshalAs(UnmanagedType.Interface)] nsISupports aToken, [MarshalAs(UnmanagedType.LPStr)] string aEmailAddress);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ImportCertificates([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] data, uint length, uint type, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ImportEmailCertificate([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] data, uint length, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ImportServerCertificate([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] data, uint length, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ImportUserCertificate([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] data, uint length, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteCertificate([MarshalAs(UnmanagedType.Interface)] nsIX509Cert aCert);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCertTrust([MarshalAs(UnmanagedType.Interface)] nsIX509Cert cert, uint type, uint trust);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCertTrustFromString([MarshalAs(UnmanagedType.Interface)] nsIX509Cert cert, [MarshalAs(UnmanagedType.LPStr)] string trustString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsCertTrusted([MarshalAs(UnmanagedType.Interface)] nsIX509Cert cert, uint certType, uint trustType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ImportCertsFromFile([MarshalAs(UnmanagedType.Interface)] nsISupports aToken, [MarshalAs(UnmanagedType.Interface)] nsIFile aFile, uint aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ImportPKCS12File([MarshalAs(UnmanagedType.Interface)] nsISupports aToken, [MarshalAs(UnmanagedType.Interface)] nsIFile aFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ExportPKCS12File([MarshalAs(UnmanagedType.Interface)] nsISupports aToken, [MarshalAs(UnmanagedType.Interface)] nsIFile aFile, uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] nsIX509Cert[] aCerts);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIX509Cert ConstructX509FromBase64([MarshalAs(UnmanagedType.LPStr)] string base64);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIX509Cert ConstructX509([MarshalAs(UnmanagedType.LPStr)] string certDER, uint length);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenSignedAppFileAsync(uint trustedRoot, [MarshalAs(UnmanagedType.Interface)] nsIFile aJarFile, [MarshalAs(UnmanagedType.Interface)] nsIOpenSignedAppFileCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void VerifySignedDirectoryAsync(uint trustedRoot, [MarshalAs(UnmanagedType.Interface)] nsIFile aUnpackedDir, [MarshalAs(UnmanagedType.Interface)] nsIVerifySignedDirectoryCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void VerifySignedManifestAsync(uint trustedRoot, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aManifestStream, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aSignatureStream, [MarshalAs(UnmanagedType.Interface)] nsIVerifySignedManifestCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddCert([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase certDER, [MarshalAs(UnmanagedType.LPStr)] string aTrust, [MarshalAs(UnmanagedType.LPStr)] string aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int VerifyCertAtTime([MarshalAs(UnmanagedType.Interface)] nsIX509Cert aCert, long aUsage, uint aFlags, [MarshalAs(UnmanagedType.LPStr)] string aHostname, ulong aTime, [MarshalAs(UnmanagedType.Interface)] ref nsIX509CertList aVerifiedChain, [MarshalAs(UnmanagedType.U1)] ref bool aHasEVPolicy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int VerifyCertNow([MarshalAs(UnmanagedType.Interface)] nsIX509Cert aCert, long aUsage, uint aFlags, [MarshalAs(UnmanagedType.LPStr)] string aHostname, [MarshalAs(UnmanagedType.Interface)] ref nsIX509CertList aVerifiedChain, [MarshalAs(UnmanagedType.U1)] ref bool aHasEVPolicy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearOCSPCache();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddCertFromBase64([MarshalAs(UnmanagedType.LPStr)] string base64, [MarshalAs(UnmanagedType.LPStr)] string aTrust, [MarshalAs(UnmanagedType.LPStr)] string aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIX509CertList GetCerts();
}
