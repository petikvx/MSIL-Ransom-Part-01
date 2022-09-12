using Gecko.Interop;

namespace Gecko.Certificates;

public sealed class CertificateValidity
{
	private ComPtr<nsIX509CertValidity> _validity;

	public long NotBefore => _validity.Instance.GetNotBeforeAttribute();

	public string NotBeforeLocalTime => nsString.Get(_validity.Instance.GetNotBeforeLocalTimeAttribute);

	public string NotBeforeLocalDay => nsString.Get(_validity.Instance.GetNotBeforeLocalDayAttribute);

	public string NotBeforeGMT => nsString.Get(_validity.Instance.GetNotBeforeGMTAttribute);

	public long NotAfter => _validity.Instance.GetNotAfterAttribute();

	public string NotAfterLocalTime => nsString.Get(_validity.Instance.GetNotAfterLocalTimeAttribute);

	public string NotAfterLocalDay => nsString.Get(_validity.Instance.GetNotAfterLocalDayAttribute);

	public string NotAfterGMT => nsString.Get(_validity.Instance.GetNotAfterGMTAttribute);

	internal CertificateValidity(nsIX509CertValidity validity)
	{
		_validity = new ComPtr<nsIX509CertValidity>(validity);
	}
}
