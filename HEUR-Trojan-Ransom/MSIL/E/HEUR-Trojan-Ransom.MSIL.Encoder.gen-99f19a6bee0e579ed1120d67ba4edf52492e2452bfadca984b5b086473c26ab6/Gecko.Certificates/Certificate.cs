using System;
using Gecko.Collections;
using Gecko.Interop;

namespace Gecko.Certificates;

public sealed class Certificate : IEquatable<Certificate>
{
	internal ComPtr<nsIX509Cert> _cert;

	public string Nickname => nsString.Get(_cert.Instance.GetNicknameAttribute);

	public string EmailAddress => nsString.Get(_cert.Instance.GetEmailAddressAttribute);

	public string SubjectName => nsString.Get(_cert.Instance.GetSubjectNameAttribute);

	public string CommonName => nsString.Get(_cert.Instance.GetCommonNameAttribute);

	public string Organization => nsString.Get(_cert.Instance.GetOrganizationAttribute);

	public string OrganizationalUnit => nsString.Get(_cert.Instance.GetOrganizationalUnitAttribute);

	public string Sha1Fingerprint => nsString.Get(_cert.Instance.GetSha1FingerprintAttribute);

	public string TokenName => nsString.Get(_cert.Instance.GetTokenNameAttribute);

	public string IssuerName => nsString.Get(_cert.Instance.GetIssuerNameAttribute);

	public string SerialNumber => nsString.Get(_cert.Instance.GetSerialNumberAttribute);

	public string IssuerCommonName => nsString.Get(_cert.Instance.GetIssuerCommonNameAttribute);

	public string IssuerOrganization => nsString.Get(_cert.Instance.GetIssuerOrganizationAttribute);

	public string IssuerOrganizationUnit => nsString.Get(_cert.Instance.GetIssuerOrganizationUnitAttribute);

	public Certificate Issuer => _cert.Instance.GetIssuerAttribute().Wrap(Create);

	public CertificateValidity Validity => new CertificateValidity(_cert.Instance.GetValidityAttribute());

	public string DbKey => _cert.Instance.GetDbKeyAttribute();

	public string WindowTitle => nsString.Get(_cert.Instance.GetWindowTitleAttribute);

	public IGeckoArray<Certificate> Chain => new GeckoArray<Certificate, nsIX509Cert>(_cert.Instance.GetChain(), Create);

	public ASN1Object ASN1Structure => new ASN1Object(_cert.Instance.GetASN1StructureAttribute());

	public uint CertType => _cert.Instance.GetCertTypeAttribute();

	public bool IsSelfSigned => _cert.Instance.GetIsSelfSignedAttribute();

	private Certificate(nsIX509Cert cert)
	{
		_cert = new ComPtr<nsIX509Cert>(cert);
	}

	public void GetEmailAddresses(ref uint length, ref IntPtr[] addresses)
	{
		_cert.Instance.GetEmailAddresses(ref length, ref addresses);
	}

	public bool ContainsEmailAddress(string email)
	{
		return nsString.Pass(_cert.Instance.ContainsEmailAddress, email);
	}

	public void GetUsagesArray(bool localOnly, ref uint verified, ref uint count, ref IntPtr[] usages)
	{
		_cert.Instance.GetUsagesArray(localOnly, ref verified, ref count, ref usages);
	}

	public string GetUsagesString(bool localOnly, ref uint verified)
	{
		string result = null;
		using (nsAString nsAString = new nsAString())
		{
			_cert.Instance.GetUsagesString(localOnly, ref verified, nsAString);
			result = nsAString.ToString();
		}
		return result;
	}

	public void GetRawDER(ref uint length, ref byte[] data)
	{
		_cert.Instance.GetRawDER(ref length, ref data);
	}

	public void MarkForPermDeletion()
	{
		_cert.Instance.MarkForPermDeletion();
	}

	public IntPtr GetCert()
	{
		return _cert.Instance.GetCert();
	}

	public void ExportAsCMS(uint chainMode, ref uint length, ref byte[] data)
	{
		_cert.Instance.ExportAsCMS(chainMode, ref length, ref data);
	}

	public void GetAllTokenNames(ref uint length, ref IntPtr[] tokenNames)
	{
		_cert.Instance.GetAllTokenNames(ref length, ref tokenNames);
	}

	public bool Equals(Certificate other)
	{
		return _cert.Instance.Equals(other._cert.Instance);
	}

	public override bool Equals(object obj)
	{
		if (obj is Certificate)
		{
			return Equals((Certificate)obj);
		}
		if (obj is nsIX509Cert)
		{
			return _cert.Instance.Equals((nsIX509Cert)obj);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return _cert.Instance.GetHashCode();
	}

	public static Certificate Create(nsIX509Cert certificate)
	{
		return new Certificate(certificate);
	}
}
