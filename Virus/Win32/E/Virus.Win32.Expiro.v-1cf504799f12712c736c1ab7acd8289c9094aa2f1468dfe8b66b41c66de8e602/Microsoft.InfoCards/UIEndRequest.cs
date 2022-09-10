using System;
using System.IO;
using System.Text;

namespace Microsoft.InfoCards;

internal class UIEndRequest : UIAgentRequest
{
	private ClientUIRequest.RequestResult m_result;

	public UIEndRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		m_result = (ClientUIRequest.RequestResult)binaryReader.ReadInt32();
	}

	protected override void OnProcess()
	{
		base.UIAgent.SetUIStatus(m_result);
	}

	protected override void OnMarshalOutArgs()
	{
	}
}
