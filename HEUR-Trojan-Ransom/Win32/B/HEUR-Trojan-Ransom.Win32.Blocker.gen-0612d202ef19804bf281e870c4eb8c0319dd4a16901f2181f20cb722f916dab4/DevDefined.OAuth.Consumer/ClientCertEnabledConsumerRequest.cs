using System.Net;
using System.Security.Cryptography.X509Certificates;
using DevDefined.OAuth.Framework;

namespace DevDefined.OAuth.Consumer;

public class ClientCertEnabledConsumerRequest : ConsumerRequest
{
	private readonly ICertificateFactory _certificateFactory;

	public ClientCertEnabledConsumerRequest(ICertificateFactory certificateFactory, IOAuthContext context, IOAuthConsumerContext consumerContext, IToken token)
		: base(context, consumerContext, token)
	{
		_certificateFactory = certificateFactory;
	}

	public override HttpWebRequest ToWebRequest()
	{
		HttpWebRequest httpWebRequest = base.ToWebRequest();
		X509Certificate2 x509Certificate = _certificateFactory.CreateCertificate();
		if (x509Certificate != null)
		{
			httpWebRequest.ClientCertificates.Add(x509Certificate);
		}
		return httpWebRequest;
	}
}
