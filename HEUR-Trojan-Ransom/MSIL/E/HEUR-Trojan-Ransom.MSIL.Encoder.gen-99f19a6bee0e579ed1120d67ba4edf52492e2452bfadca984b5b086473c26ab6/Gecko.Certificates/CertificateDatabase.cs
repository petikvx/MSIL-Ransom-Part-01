using Gecko.Interop;

namespace Gecko.Certificates;

public static class CertificateDatabase
{
	private static ComPtr<nsIX509CertDB> _certDb;

	static CertificateDatabase()
	{
		_certDb = Xpcom.GetService2<nsIX509CertDB>("@mozilla.org/security/x509certdb;1");
	}

	public static Certificate ConstructX509FromBase64(string base64)
	{
		return Certificate.Create(_certDb.Instance.ConstructX509FromBase64(base64));
	}

	public static CertificateList GetCerts()
	{
		return new CertificateList(_certDb.Instance.GetCerts());
	}

	public static void AddCertFromBase64(string base64, string trust, string name)
	{
		_certDb.Instance.AddCertFromBase64(base64, trust, name);
	}
}
