using System;
using System.IO;

namespace Microsoft.InfoCards;

internal class BeginCreateSecurityTokenRequest : UIAgentAsyncBeginRequest
{
	private bool m_discloseOptional;

	private TokenFactoryCredential m_credential;

	public BeginCreateSecurityTokenRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalAsyncInArgs(BinaryReader reader)
	{
		m_discloseOptional = reader.ReadBoolean();
		m_credential = TokenFactoryCredential.CreateFrom(reader, this, base.ParentRequest.UserLanguage);
	}

	protected override object AsyncExecute(AsyncParams asyncParam)
	{
		return ((GetTokenRequest)base.ParentRequest).CreateSecurityToken(m_credential, m_discloseOptional);
	}

	protected override void AsyncCancel()
	{
		((GetTokenRequest)base.ParentRequest).CancelCreateSecurityToken();
	}
}
