namespace Microsoft.InfoCards;

internal interface ITokenFactory
{
	void Abort();

	TokenDescriptor CreateToken(InfoCard card, TokenFactoryCredential credential, InfoCardPolicy policy, bool discloseOptional);
}
