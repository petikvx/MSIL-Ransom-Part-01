using System;
using System.IO;
using System.Text;

namespace Microsoft.InfoCards;

internal class GetIsBrowserClientRequest : UIAgentRequest
{
	public GetIsBrowserClientRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalInArgs()
	{
	}

	protected override void OnProcess()
	{
	}

	protected override void OnMarshalOutArgs()
	{
		BinaryWriter binaryWriter = new BinaryWriter(base.OutArgs, Encoding.Unicode);
		binaryWriter.Write(base.ParentRequest is GetBrowserTokenRequest);
	}
}
