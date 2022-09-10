using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.InfoCards;

internal class X509CertificateTokenFactoryCredential : TokenFactoryCredential
{
	private X509Certificate2 m_cert;

	private string m_contextKey;

	private string m_portName;

	private UIAgentRequest m_request;

	private bool m_disposed;

	private object m_sync = new object();

	public string ContextKey => m_contextKey;

	public string PortName => m_portName;

	public X509Certificate2 Certificate => m_cert;

	public X509CertificateTokenFactoryCredential(UIAgentRequest request)
		: base(TokenFactoryCredentialType.X509CertificateCredential)
	{
		m_request = request;
	}

	protected override void DeserializeData(BinaryReader reader)
	{
		m_portName = Utility.DeserializeString(reader);
		m_contextKey = Utility.DeserializeString(reader);
		byte[] array = new byte[reader.ReadInt32()];
		reader.Read(array, 0, array.Length);
		m_cert = new X509Certificate2(array);
		m_cert.PrivateKey = new RemoteCryptoRsaServiceProvider(this, m_request);
	}

	public override void Dispose(bool disposing)
	{
		if (m_disposed)
		{
			return;
		}
		lock (m_sync)
		{
			if (m_disposed)
			{
				return;
			}
			try
			{
				if (disposing)
				{
					m_cert.PrivateKey!.Clear();
					m_cert.PublicKey.Key.Clear();
				}
				m_disposed = true;
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
	}
}
