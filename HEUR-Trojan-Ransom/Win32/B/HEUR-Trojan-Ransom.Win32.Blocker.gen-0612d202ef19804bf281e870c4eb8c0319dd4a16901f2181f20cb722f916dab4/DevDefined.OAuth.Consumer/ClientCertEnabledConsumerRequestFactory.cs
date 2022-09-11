using DevDefined.OAuth.Framework;

namespace DevDefined.OAuth.Consumer;

public class ClientCertEnabledConsumerRequestFactory : IConsumerRequestFactory
{
	private readonly ICertificateFactory _certificateFactory;

	public ClientCertEnabledConsumerRequestFactory(ICertificateFactory certificateFactory)
	{
		_certificateFactory = certificateFactory;
	}

	public IConsumerRequest CreateConsumerRequest(IOAuthContext context, IOAuthConsumerContext consumerContext, IToken token)
	{
		return new ClientCertEnabledConsumerRequest(_certificateFactory, context, consumerContext, token);
	}
}
