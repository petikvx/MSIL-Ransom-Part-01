using System.IO;

namespace Microsoft.InfoCards;

internal class UserNameTokenFactoryCredential : TokenFactoryCredential
{
	private string m_userName;

	private string m_password;

	public string UserName => m_userName;

	public string Password => m_password;

	public UserNameTokenFactoryCredential()
		: base(TokenFactoryCredentialType.UserNamePasswordCredential)
	{
	}

	protected override void DeserializeData(BinaryReader reader)
	{
		m_userName = Utility.DeserializeString(reader);
		m_password = Utility.DeserializeString(reader);
	}
}
