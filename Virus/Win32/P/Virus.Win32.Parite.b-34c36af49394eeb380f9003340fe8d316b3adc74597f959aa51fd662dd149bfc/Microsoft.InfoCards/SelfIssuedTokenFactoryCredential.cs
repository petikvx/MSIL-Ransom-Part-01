using System.IO;

namespace Microsoft.InfoCards;

internal class SelfIssuedTokenFactoryCredential : TokenFactoryCredential
{
	private InfoCard m_localCard;

	public InfoCard LocalCard => m_localCard;

	public SelfIssuedTokenFactoryCredential()
		: base(TokenFactoryCredentialType.SelfIssuedCredential)
	{
	}

	protected override void DeserializeData(BinaryReader reader)
	{
		m_localCard = new InfoCard(reader.BaseStream);
	}
}
