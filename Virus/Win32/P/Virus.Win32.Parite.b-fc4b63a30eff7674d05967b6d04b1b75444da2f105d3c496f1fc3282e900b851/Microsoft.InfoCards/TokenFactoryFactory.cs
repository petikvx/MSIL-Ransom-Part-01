using System.Net;
using System.ServiceModel.Description;

namespace Microsoft.InfoCards;

internal sealed class TokenFactoryFactory
{
	private TokenFactoryFactory()
	{
	}

	public static ITokenFactory Create(InfoCard infoCard, TokenCreationParameter parameter, ServiceEndpoint endPoint, IWebProxy proxy)
	{
		ITokenFactory tokenFactory = null;
		if (infoCard.IsSelfIssued)
		{
			return new SelfIssuedSamlTokenFactory();
		}
		return new RemoteTokenFactory(endPoint, proxy);
	}
}
