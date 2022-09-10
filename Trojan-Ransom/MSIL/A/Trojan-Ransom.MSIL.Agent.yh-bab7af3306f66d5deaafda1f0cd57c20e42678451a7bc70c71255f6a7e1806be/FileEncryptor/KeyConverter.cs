using System;
using System.Runtime.InteropServices;

namespace FileEncryptor;

public class KeyConverter
{
	[DllImport("crypt32.dll", SetLastError = true)]
	public static extern IntPtr CertCreateSelfSignCertificate(IntPtr hProv, ref CERT_NAME_BLOB pSubjectIssuerBlob, uint dwFlagsm, ref CRYPT_KEY_PROV_INFO pKeyProvInfo, IntPtr pSignatureAlgorithm, IntPtr pStartTime, IntPtr pEndTime, IntPtr other);

	[DllImport("crypt32.dll", SetLastError = true)]
	public static extern bool CertStrToName(uint dwCertEncodingType, string pszX500, uint dwStrType, IntPtr pvReserved, [In][Out] byte[] pbEncoded, ref uint pcbEncoded, IntPtr other);

	[DllImport("crypt32.dll", SetLastError = true)]
	public static extern bool CertFreeCertificateContext(IntPtr hCertStore);
}
