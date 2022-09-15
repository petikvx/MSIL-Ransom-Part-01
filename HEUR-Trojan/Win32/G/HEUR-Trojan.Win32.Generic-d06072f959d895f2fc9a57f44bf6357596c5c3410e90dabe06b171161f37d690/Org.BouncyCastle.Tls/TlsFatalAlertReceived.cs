namespace Org.BouncyCastle.Tls;

public class TlsFatalAlertReceived : TlsException
{
	protected readonly short m_alertDescription;

	public virtual short AlertDescription => m_alertDescription;

	public TlsFatalAlertReceived(short alertDescription)
		: base(Org.BouncyCastle.Tls.AlertDescription.GetText(alertDescription))
	{
		m_alertDescription = alertDescription;
	}
}
