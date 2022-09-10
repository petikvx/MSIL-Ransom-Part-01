using System;
using System.Threading;
using Microsoft.InfoCards.Diagnostics;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.InfoCards;

internal class RpcAsyncResult : IAsyncResult, IDisposable
{
	public delegate void AsyncCancelCallback();

	private class RpcAsyncHandleDictionary : HandleDictionary<RpcAsyncResult>
	{
	}

	private static RpcAsyncHandleDictionary s_handles = new RpcAsyncHandleDictionary();

	private static object s_syncRoot = new object();

	private ClientRequest m_request;

	private ManualResetEvent m_externEvent;

	private bool m_isCompleted;

	private bool m_isCanceled;

	private bool m_isResultPickedUp;

	private bool m_isDisposed;

	private object m_result;

	private string m_opType;

	private ManualResetEvent m_event;

	private int m_handle;

	private object m_syncRoot;

	private Exception m_exception;

	private AsyncCancelCallback m_cancelCallback;

	public AsyncCancelCallback CancelCallback
	{
		get
		{
			return m_cancelCallback;
		}
		set
		{
			m_cancelCallback = value;
		}
	}

	public WaitHandle AsyncWaitHandle => m_event;

	public bool CompletedSynchronously => false;

	public object AsyncState => null;

	public object Result
	{
		get
		{
			return m_result;
		}
		set
		{
			m_result = value;
		}
	}

	public bool IsCompleted => m_isCompleted;

	public bool IsCanceled => m_isCanceled;

	public int Handle => m_handle;

	public Exception Exception
	{
		get
		{
			return m_exception;
		}
		set
		{
			m_exception = value;
		}
	}

	public RpcAsyncResult(ClientRequest request, string opType, SafeWaitHandle externEvent)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(null == request, "request");
		m_syncRoot = new object();
		m_request = request;
		m_opType = opType;
		if (externEvent != null)
		{
			m_externEvent = new ManualResetEvent(initialState: false);
			m_externEvent.SafeWaitHandle = externEvent;
		}
		m_event = new ManualResetEvent(initialState: false);
		lock (s_syncRoot)
		{
			int num = 0;
			try
			{
				num = s_handles.GetNewHandle();
			}
			catch (IndexOutOfRangeException inner)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ServiceBusyException(SR.GetString("ServiceTooManyAsyncOperations", new object[1] { s_handles.MaxSize }), inner));
			}
			m_handle = num;
			s_handles[m_handle] = this;
		}
		m_request.AddAsyncOp(this);
	}

	public void Complete()
	{
		lock (m_syncRoot)
		{
			if (!m_isCompleted)
			{
				m_isCompleted = true;
				if (!m_isCanceled)
				{
					AlertWaiters();
				}
				MaybeDispose();
			}
		}
	}

	public void Cancel()
	{
		lock (m_syncRoot)
		{
			InternalCancel();
		}
	}

	private void InternalCancel()
	{
		if (!m_isCanceled && !m_isCompleted)
		{
			if (CancelCallback != null)
			{
				CancelCallback();
			}
			m_isCanceled = true;
			AlertWaiters();
		}
	}

	private void AlertWaiters()
	{
		m_event.Set();
		if (m_externEvent != null)
		{
			m_externEvent.Set();
		}
	}

	private void MaybeDispose()
	{
		if (m_isCompleted && m_isResultPickedUp)
		{
			DisposeInternal();
		}
	}

	public void Dispose()
	{
		if (m_isResultPickedUp)
		{
			return;
		}
		lock (m_syncRoot)
		{
			InternalCancel();
			m_isResultPickedUp = true;
			MaybeDispose();
		}
	}

	private void DisposeInternal()
	{
		if (!m_isDisposed)
		{
			m_isDisposed = true;
			m_request.RemoveAsyncOp(Handle);
			m_request = null;
			if (m_externEvent != null)
			{
				m_externEvent.Close();
			}
			m_event.Close();
			lock (s_syncRoot)
			{
				s_handles.Remove(Handle);
			}
		}
	}
}
