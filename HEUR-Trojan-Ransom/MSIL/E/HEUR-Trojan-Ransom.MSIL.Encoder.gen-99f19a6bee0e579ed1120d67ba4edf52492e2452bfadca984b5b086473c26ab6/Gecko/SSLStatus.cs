using Gecko.Certificates;
using Gecko.Interop;

namespace Gecko;

public sealed class SSLStatus : ComPtr<nsISSLStatus>
{
	public string CipherName => nsString.Get(base.Instance.GetCipherNameAttribute);

	public bool IsDomainMismatch => base.Instance.GetIsDomainMismatchAttribute();

	public bool IsExtendedValidation => base.Instance.GetIsExtendedValidationAttribute();

	public Certificate ServerCert => base.Instance.GetServerCertAttribute().Wrap(Certificate.Create);

	public int SecretKeyLength => (int)base.Instance.GetSecretKeyLengthAttribute();

	public int KeyLength => (int)base.Instance.GetKeyLengthAttribute();

	public bool IsUntrusted => base.Instance.GetIsUntrustedAttribute();

	public bool IsNotValidAtThisTime => base.Instance.GetIsNotValidAtThisTimeAttribute();

	public static SSLStatus Create(nsISSLStatus instance)
	{
		return new SSLStatus(instance);
	}

	public SSLStatus(nsISSLStatus instance)
		: base(instance, releaseRCW: true)
	{
	}
}
