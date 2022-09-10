using System.IO;

namespace Microsoft.InfoCards;

internal class KerberosTokenFactoryCredential : TokenFactoryCredential
{
	public KerberosTokenFactoryCredential()
		: base(TokenFactoryCredentialType.KerberosCredential)
	{
	}

	protected override void DeserializeData(BinaryReader reader)
	{
	}
}
