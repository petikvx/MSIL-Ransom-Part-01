using System;
using System.IO;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal abstract class UIAgentAsyncEndRequest : UIAgentRequest
{
	private int m_asyncHandle;

	private bool m_isCompleted;

	private object m_result;

	private bool m_isCancelled;

	public object Result
	{
		get
		{
			InfoCardTrace.Assert(m_isCompleted, "Attempt to pick up async result before completion.", new object[0]);
			return m_result;
		}
	}

	public bool IsCancelled
	{
		get
		{
			InfoCardTrace.Assert(m_isCompleted, "Attempt to pick up async result before completion.", new object[0]);
			return m_isCancelled;
		}
	}

	public UIAgentAsyncEndRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		m_asyncHandle = binaryReader.ReadInt32();
		InfoCardTrace.Assert(0 != m_asyncHandle, "null async handle", new object[0]);
	}

	protected override void OnProcess()
	{
		using (RpcAsyncResult rpcAsyncResult = base.ParentRequest.WaitForAsyncCompletion(m_asyncHandle))
		{
			m_isCancelled = rpcAsyncResult.IsCanceled;
			if (!m_isCancelled)
			{
				m_result = rpcAsyncResult.Result;
			}
		}
		m_isCompleted = true;
	}

	protected sealed override void OnMarshalOutArgs()
	{
		BinaryWriter binaryWriter = new BinaryWriter(base.OutArgs, Encoding.Unicode);
		binaryWriter.Write(IsCancelled);
		if (!IsCancelled)
		{
			OnMarshalAsyncOutArgs(binaryWriter);
		}
	}

	protected virtual void OnMarshalAsyncOutArgs(BinaryWriter writer)
	{
	}
}
