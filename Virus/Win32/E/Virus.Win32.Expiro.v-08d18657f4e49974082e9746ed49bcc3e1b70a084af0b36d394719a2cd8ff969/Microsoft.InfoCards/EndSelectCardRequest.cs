using System;
using System.IO;

namespace Microsoft.InfoCards;

internal class EndSelectCardRequest : UIAgentAsyncEndRequest
{
	public EndSelectCardRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalAsyncOutArgs(BinaryWriter writer)
	{
		int value = (int)base.Result;
		writer.Write(value);
	}
}
