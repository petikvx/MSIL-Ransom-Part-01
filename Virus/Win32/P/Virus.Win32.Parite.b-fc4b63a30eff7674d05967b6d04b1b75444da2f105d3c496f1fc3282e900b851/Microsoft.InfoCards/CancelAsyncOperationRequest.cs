using System;
using System.IO;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class CancelAsyncOperationRequest : UIAgentRequest
{
	private int m_asyncHandle;

	public CancelAsyncOperationRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		m_asyncHandle = binaryReader.ReadInt32();
		InfoCardTrace.ThrowInvalidArgumentConditional(0 == m_asyncHandle, "asyncHandle");
	}

	protected override void OnMarshalOutArgs()
	{
	}

	protected override void OnProcess()
	{
		base.ParentRequest.CancelAsyncOp(m_asyncHandle);
	}
}
