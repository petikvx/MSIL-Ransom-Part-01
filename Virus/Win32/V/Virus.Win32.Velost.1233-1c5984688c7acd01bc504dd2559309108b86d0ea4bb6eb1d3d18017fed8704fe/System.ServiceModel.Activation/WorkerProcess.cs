using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Reflection;
using System.Security.AccessControl;
using System.ServiceModel.Activation.Diagnostics;
using System.ServiceModel.Channels;
using System.ServiceModel.Diagnostics;
using System.Threading;

namespace System.ServiceModel.Activation;

[ServiceBehavior(/*Could not decode attribute arguments.*/)]
internal abstract class WorkerProcess : IConnectionRegister
{
	private class DispatchSessionAsyncResult : AsyncResult
	{
		private ListenerSessionConnection session;

		private bool duplicateSucceeded;

		private static AsyncCallback dispatchSessionCallback = DiagnosticUtility.ThunkAsyncCallback(DispatchSessionCompletedCallback);

		public bool DuplicateSucceeded => duplicateSucceeded;

		public DispatchSessionAsyncResult(ListenerSessionConnection session, AsyncCallback callback, object state)
			: base(callback, state)
		{
			this.session = session;
			DuplicateContext val = session.WorkerProcess.DuplicateConnection(session);
			if (val == null)
			{
				((AsyncResult)this).Complete(true);
			}
			IAsyncResult asyncResult = this.session.WorkerProcess.ConnectionDuplicator.BeginDuplicate(val, dispatchSessionCallback, (object)this);
			if (asyncResult.CompletedSynchronously)
			{
				CompleteDuplicateSession(asyncResult);
				((AsyncResult)this).Complete(true);
			}
		}

		private static void DispatchSessionCompletedCallback(IAsyncResult result)
		{
			if (result.CompletedSynchronously)
			{
				return;
			}
			DispatchSessionAsyncResult dispatchSessionAsyncResult = (DispatchSessionAsyncResult)result.AsyncState;
			Exception ex = null;
			try
			{
				dispatchSessionAsyncResult.CompleteDuplicateSession(result);
			}
			catch (Exception ex2)
			{
				if (DiagnosticUtility.IsFatal(ex2))
				{
					throw;
				}
				ex = ex2;
			}
			((AsyncResult)dispatchSessionAsyncResult).Complete(false, ex);
		}

		private void CompleteDuplicateSession(IAsyncResult result)
		{
			session.WorkerProcess.ConnectionDuplicator.EndDuplicate(result);
			duplicateSucceeded = true;
		}

		public static DispatchSessionAsyncResult End(IAsyncResult result)
		{
			return AsyncResult.End<DispatchSessionAsyncResult>(result);
		}
	}

	private int isUnregistered;

	private int processId;

	private MessageQueue queue;

	private int queueId;

	private IConnectionDuplicator connectionDuplicator;

	public bool IsRegistered => isUnregistered == 0;

	public MessageQueue Queue
	{
		get
		{
			return queue;
		}
		set
		{
			queue = value;
		}
	}

	public int ProcessId => processId;

	protected abstract TransportType TransportType { get; }

	internal IConnectionDuplicator ConnectionDuplicator => connectionDuplicator;

	internal void Close()
	{
		if (Interlocked.Increment(ref isUnregistered) == 1 && queue != null)
		{
			queue.Unregister(this);
		}
	}

	protected abstract DuplicateContext DuplicateConnection(ListenerSessionConnection session);

	protected abstract void OnDispatchSuccess();

	internal IAsyncResult BeginDispatchSession(ListenerSessionConnection session, AsyncCallback callback, object state)
	{
		return (IAsyncResult)new DispatchSessionAsyncResult(session, callback, state);
	}

	internal bool EndDispatchSession(IAsyncResult result)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DispatchSessionAsyncResult dispatchSessionAsyncResult = DispatchSessionAsyncResult.End(result);
			if (dispatchSessionAsyncResult.DuplicateSucceeded)
			{
				OnDispatchSuccess();
				return true;
			}
		}
		catch (Exception ex)
		{
			EventLogEventId val = (EventLogEventId)(-1073479672);
			if (TransportType == TransportType.NamedPipe)
			{
				val = (EventLogEventId)(-1073479671);
			}
			DiagnosticUtility.EventLog.LogEvent(TraceEventType.Error, (EventLogCategory)13, val, new string[3]
			{
				ProcessId.ToString(NumberFormatInfo.InvariantInfo),
				DiagnosticTrace.CreateSourceString((object)this),
				ex.ToString()
			});
			if (DiagnosticUtility.IsFatal(ex))
			{
				throw;
			}
			Close();
			((ICommunicationObject)(IChannel)connectionDuplicator).Abort();
			if (!ShouldRecoverFromProxyCall(ex))
			{
				throw;
			}
		}
		return false;
	}

	private void WorkerProcess_Closed(object sender, EventArgs e)
	{
		Close();
	}

	private void WorkerProcess_Faulted(object sender, EventArgs e)
	{
		Close();
	}

	ListenerExceptionStatus IConnectionRegister.Register(Version version, int processId, BaseUriWithWildcard path, int queueId, Guid token, string eventName)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589838, (TraceRecord)new StringTraceRecord("Path", ((object)path).ToString()), this, null);
		}
		connectionDuplicator = OperationContext.get_Current().GetCallbackChannel<IConnectionDuplicator>();
		ListenerExceptionStatus val = (ListenerExceptionStatus)0;
		bool flag = false;
		if (path != null && eventName != null)
		{
			if (OSEnvironmentHelper.get_IsVistaOrGreater())
			{
				val = (ListenerExceptionStatus)7;
				object obj = OperationContext.get_Current().get_IncomingMessage().get_Properties()
					.get_Item(ConnectionMessageProperty.get_Name());
				IConnection val2 = (IConnection)((obj is IConnection) ? obj : null);
				object coreTransport = val2.GetCoreTransport();
				PipeHandle val3 = (PipeHandle)((coreTransport is PipeHandle) ? coreTransport : null);
				if (processId != val3.GetClientPid())
				{
					val = (ListenerExceptionStatus)7;
					flag = true;
					goto IL_01d5;
				}
			}
			Version version2 = Assembly.GetExecutingAssembly().GetName().Version;
			if (version > version2)
			{
				val = (ListenerExceptionStatus)6;
			}
			else if (queueId == 0 && path == null)
			{
				val = (ListenerExceptionStatus)7;
				flag = true;
			}
			else
			{
				this.processId = processId;
				this.queueId = 0;
				if (queueId != 0)
				{
					this.queueId = queueId;
					val = ActivatedMessageQueue.Register(queueId, token, this);
				}
				else
				{
					val = MessageQueue.Register(path, this);
				}
				if ((int)val == 0)
				{
					foreach (IChannel incomingChannel in OperationContext.get_Current().get_InstanceContext().get_IncomingChannels())
					{
						((ICommunicationObject)incomingChannel).add_Faulted((EventHandler)WorkerProcess_Faulted);
						((ICommunicationObject)incomingChannel).add_Closed((EventHandler)WorkerProcess_Closed);
					}
					try
					{
						using EventWaitHandle eventWaitHandle = EventWaitHandle.OpenExisting("Global\\" + eventName, (EventWaitHandleRights)2);
						eventWaitHandle.Set();
					}
					catch (Exception ex)
					{
						if (DiagnosticUtility.IsFatal(ex))
						{
							throw;
						}
						if (DiagnosticUtility.ShouldTraceError)
						{
							DiagnosticUtility.ExceptionUtility.TraceHandledException(ex, TraceEventType.Error);
						}
						val = (ListenerExceptionStatus)7;
						flag = true;
					}
				}
				if ((int)val == 0 && DiagnosticUtility.ShouldTraceInformation)
				{
					ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589839, (TraceRecord)new StringTraceRecord("Path", ((object)path).ToString()), this, null);
				}
			}
		}
		else
		{
			val = (ListenerExceptionStatus)7;
			flag = true;
		}
		goto IL_01d5;
		IL_01d5:
		if (flag)
		{
			if (DiagnosticUtility.ShouldTraceError)
			{
				ListenerTraceUtility.TraceEvent(TraceEventType.Error, (TraceCode)589840, (TraceRecord)new StringTraceRecord("Register", SR.GetString("SharingRegistrationFailedAndAbort", ((object)val).ToString())), this, null);
			}
			AbortServiceInstance();
		}
		else if ((int)val != 0)
		{
			if (DiagnosticUtility.ShouldTraceError)
			{
				ListenerTraceUtility.TraceEvent(TraceEventType.Error, (TraceCode)589840, (TraceRecord)new StringTraceRecord("Register", SR.GetString("SharingRegistrationFailed", ((object)val).ToString())), this, null);
			}
			InitiateClosingServiceInstance();
		}
		return val;
	}

	bool IConnectionRegister.ValidateUriRoute(Uri uri, IPAddress address, int port)
	{
		if (queue == null)
		{
			AbortServiceInstance();
			return false;
		}
		MessageQueue objA = RoutingTable.Lookup(uri, address, port);
		return object.ReferenceEquals(objA, queue);
	}

	void IConnectionRegister.Unregister()
	{
		Close();
	}

	private static bool ShouldRecoverFromProxyCall(Exception exception)
	{
		if (!(exception is CommunicationException) && !(exception is ObjectDisposedException))
		{
			return exception is TimeoutException;
		}
		return true;
	}

	private void AbortServiceInstance()
	{
		((CommunicationObject)OperationContext.get_Current().get_InstanceContext()).Abort();
	}

	private void InitiateClosingServiceInstance()
	{
		InstanceContext instanceContext = OperationContext.get_Current().get_InstanceContext();
		((CommunicationObject)instanceContext).BeginClose(ListenerConstants.RegistrationCloseTimeout, DiagnosticUtility.ThunkAsyncCallback(CloseCallback), (object)instanceContext);
	}

	private static void CloseCallback(IAsyncResult asyncResult)
	{
		//IL_0016: Expected O, but got Unknown
		object? asyncState = asyncResult.AsyncState;
		InstanceContext val = (InstanceContext)((asyncState is InstanceContext) ? asyncState : null);
		try
		{
			((CommunicationObject)val).EndClose(asyncResult);
		}
		catch (CommunicationException val2)
		{
			CommunicationException val3 = val2;
			if (DiagnosticUtility.ShouldTraceInformation)
			{
				DiagnosticUtility.ExceptionUtility.TraceHandledException((Exception)(object)val3, TraceEventType.Information);
			}
		}
		catch (TimeoutException ex)
		{
			if (DiagnosticUtility.ShouldTraceInformation)
			{
				DiagnosticUtility.ExceptionUtility.TraceHandledException((Exception)ex, TraceEventType.Information);
			}
		}
	}
}
