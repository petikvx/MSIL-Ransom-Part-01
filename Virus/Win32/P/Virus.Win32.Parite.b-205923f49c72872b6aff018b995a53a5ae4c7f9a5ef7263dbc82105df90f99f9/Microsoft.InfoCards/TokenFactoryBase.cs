namespace Microsoft.InfoCards;

internal abstract class TokenFactoryBase : ITokenFactory
{
	private bool m_aborted;

	public bool IsAborted => m_aborted;

	public TokenDescriptor CreateToken(InfoCard infoCard, TokenFactoryCredential credential, InfoCardPolicy policy, bool discloseOptional)
	{
		TokenCreationParameter parameters = null;
		if (credential != null && -1 != credential.ParameterIndex)
		{
			parameters = infoCard.CreationParameters[credential.ParameterIndex];
		}
		return ProduceToken(infoCard, parameters, credential, policy, discloseOptional);
	}

	public void Abort()
	{
		OnAbort();
		m_aborted = true;
	}

	protected abstract TokenDescriptor ProduceToken(InfoCard card, TokenCreationParameter parameters, TokenFactoryCredential credential, InfoCardPolicy policy, bool discloseOptional);

	protected virtual void OnAbort()
	{
	}
}
