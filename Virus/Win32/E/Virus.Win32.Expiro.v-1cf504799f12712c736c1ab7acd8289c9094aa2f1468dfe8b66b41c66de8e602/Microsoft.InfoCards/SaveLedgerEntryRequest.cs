using System;
using System.IO;

namespace Microsoft.InfoCards;

internal class SaveLedgerEntryRequest : UIAgentRequest
{
	public SaveLedgerEntryRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalInArgs()
	{
	}

	protected override void OnProcess()
	{
		((GetTokenRequest)base.ParentRequest).SaveLedgerEntry();
	}

	protected override void OnMarshalOutArgs()
	{
	}
}
