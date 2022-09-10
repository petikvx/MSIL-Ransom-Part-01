using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Threading;
using Microsoft.InfoCards.Diagnostics;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.InfoCards;

internal abstract class UIAgentAsyncBeginRequest : UIAgentRequest
{
	private SafeWaitHandle m_agentEventHandle;

	private int m_asyncHandle;

	public UIAgentAsyncBeginRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected sealed override void OnMarshalInArgs()
	{
		IntPtr zero = IntPtr.Zero;
		BinaryReader binaryReader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		zero = Utility.ReadHandle(binaryReader);
		using (SafeWaitHandle hRemote = new SafeWaitHandle(zero, ownsHandle: false))
		{
			m_agentEventHandle = Utility.GetLocalHandleFromRemoteHandle(hRemote, base.ParentRequest.UIAgentPid);
		}
		OnMarshalAsyncInArgs(binaryReader);
	}

	protected virtual void OnMarshalAsyncInArgs(BinaryReader reader)
	{
	}

	protected override void OnProcess()
	{
		AsyncParams asyncParams = CreateAsyncParams();
		asyncParams.AsyncResult.CancelCallback = AsyncCancel;
		InfoCardTrace.Assert(null != asyncParams, "Null AsyncParams", new object[0]);
		try
		{
			m_asyncHandle = asyncParams.AsyncResult.Handle;
			InfoCardTrace.Assert(0 != m_asyncHandle, "null async context handle", new object[0]);
			if (!ThreadPool.QueueUserWorkItem(InfoCardTrace.ThunkCallback((WaitCallback)AsyncEntry), asyncParams))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(SR.GetString("UnableToQueueThreadpool")));
			}
		}
		catch
		{
			asyncParams.AsyncResult.Dispose();
			throw;
		}
	}

	protected override void OnMarshalOutArgs()
	{
		BinaryWriter binaryWriter = new BinaryWriter(base.OutArgs, Encoding.Unicode);
		InfoCardTrace.Assert(0 != m_asyncHandle, "null async handle", new object[0]);
		binaryWriter.Write(m_asyncHandle);
	}

	protected override void OnDisposeAsUser()
	{
		if (m_agentEventHandle != null)
		{
			m_agentEventHandle.Dispose();
			m_agentEventHandle = null;
		}
	}

	protected virtual AsyncParams CreateAsyncParams()
	{
		Type type = GetType();
		AsyncParams result = new UIAgentAsyncParams(type.Name, base.ParentRequest, m_agentEventHandle, this);
		m_agentEventHandle = null;
		return result;
	}

	protected abstract object AsyncExecute(AsyncParams asyncParam);

	protected abstract void AsyncCancel();

	private void AsyncEntry(object state)
	{
		AsyncParams asyncParams = (AsyncParams)state;
		try
		{
			if (asyncParams.AsyncResult.IsCanceled)
			{
				asyncParams.AsyncResult.Exception = new Win32Exception(1223);
			}
			else
			{
				asyncParams.AsyncResult.Result = AsyncExecute(asyncParams);
			}
		}
		catch (Exception ex)
		{
			if (InfoCardTrace.IsFatal(ex))
			{
				InfoCardService.Crash(ex);
			}
			asyncParams.AsyncResult.Exception = ex;
		}
		asyncParams.AsyncResult.Complete();
	}
}
