using System;
using System.IO;

namespace Microsoft.InfoCards;

internal class EndCreateSecurityTokenRequest : UIAgentAsyncEndRequest
{
	public EndCreateSecurityTokenRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalAsyncOutArgs(BinaryWriter writer)
	{
		((GetTokenRequest)base.ParentRequest).Token.DisplayToken.Serialize(writer);
	}
}
