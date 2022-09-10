using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceModel.Activation.Diagnostics;
using System.ServiceModel.Channels;
using System.ServiceModel.Diagnostics;
using System.Threading;

namespace System.ServiceModel.Activation;

internal class MessageQueue
{
	private static WaitCallback dispatchToNewWorkerCallback = DispatchToNewWorkerCallback;

	private static WaitCallback dispatchSessionCallback = DispatchSessionCallback;

	private static Dictionary<BaseUriWithWildcard, MessageQueue> registry = new Dictionary<BaseUriWithWildcard, MessageQueue>();

	private static List<MessageQueue> instances = new List<MessageQueue>();

	private AsyncCallback dispatchSessionCompletedCallback;

	private List<BaseUriWithWildcard> paths;

	private Queue<ListenerSessionConnection> sessionMessages;

	private Queue<WorkerProcess> sessionWorkers;

	private int maxQueueSize;

	private TransportType transportType;

	private List<WorkerProcess> workers;

	internal virtual bool CanDispatch
	{
		get
		{
			if (TransportType == TransportType.Tcp)
			{
				return !SMSvcHost.IsTcpPortSharingPaused;
			}
			return true;
		}
	}

	internal TransportType TransportType => transportType;

	private object SessionLock => sessionWorkers;

	protected int PendingCount
	{
		get
		{
			lock (SessionLock)
			{
				return sessionMessages.Count;
			}
		}
	}

	protected virtual bool CanShare => false;

	internal MessageQueue()
	{
		transportType = TransportType.Unsupported;
		paths = new List<BaseUriWithWildcard>();
		workers = new List<WorkerProcess>();
		sessionWorkers = new Queue<WorkerProcess>();
		sessionMessages = new Queue<ListenerSessionConnection>();
		dispatchSessionCompletedCallback = DiagnosticUtility.ThunkAsyncCallback(DispatchSessionCompletedCallback);
		lock (instances)
		{
			instances.Add(this);
		}
	}

	internal static void CloseAll(TransportType transportType)
	{
		MessageQueue[] array;
		lock (instances)
		{
			array = instances.ToArray();
			instances.Clear();
		}
		MessageQueue[] array2 = array;
		foreach (MessageQueue messageQueue in array2)
		{
			if (messageQueue.TransportType == transportType)
			{
				messageQueue.CloseCore();
			}
		}
	}

	protected void Close()
	{
		lock (instances)
		{
			instances.Remove(this);
		}
		CloseCore();
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589832, this);
		}
	}

	protected void DropPendingMessages(bool sendFault)
	{
		lock (SessionLock)
		{
			ListenerSessionConnection[] array = sessionMessages.ToArray();
			foreach (ListenerSessionConnection listenerSessionConnection in array)
			{
				if (listenerSessionConnection != null)
				{
					if (sendFault)
					{
						TransportListener.SendFault(listenerSessionConnection.Connection, "http://schemas.microsoft.com/ws/2006/05/framing/faults/EndpointUnavailable");
					}
					else
					{
						listenerSessionConnection.Connection.Abort();
					}
				}
			}
			sessionMessages.Clear();
		}
	}

	private void CloseCore()
	{
		UnregisterAll();
		DropPendingMessages(sendFault: false);
		lock (registry)
		{
			WorkerProcess[] array = workers.ToArray();
			foreach (WorkerProcess workerProcess in array)
			{
				workerProcess.Close();
			}
			workers.Clear();
		}
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589832, this);
		}
	}

	internal void EnqueueSessionAndDispatch(ListenerSessionConnection session)
	{
		lock (SessionLock)
		{
			if (!CanDispatch)
			{
				TransportListener.SendFault(session.Connection, "http://schemas.microsoft.com/ws/2006/05/framing/faults/EndpointUnavailable");
				OnDispatchFailure(transportType);
				return;
			}
			if (sessionMessages.Count >= maxQueueSize)
			{
				session.Connection.Abort();
				OnDispatchFailure(transportType);
				return;
			}
			sessionMessages.Enqueue(session);
		}
		OnSessionEnqueued();
		DispatchSession();
	}

	private void EnqueueWorkerAndDispatch(WorkerProcess worker, bool canDispatchOnThisThread)
	{
		lock (SessionLock)
		{
			sessionWorkers.Enqueue(worker);
		}
		if (canDispatchOnThisThread)
		{
			DispatchSession();
		}
		else
		{
			IOThreadScheduler.ScheduleCallback(dispatchSessionCallback, (object)this);
		}
	}

	private static void DispatchSessionCallback(object state)
	{
		MessageQueue messageQueue = (MessageQueue)state;
		messageQueue.DispatchSession();
	}

	private void DispatchSession()
	{
		while (true)
		{
			ListenerSessionConnection listenerSessionConnection = null;
			lock (SessionLock)
			{
				if (sessionMessages.Count > 0)
				{
					WorkerProcess workerProcess = null;
					while (sessionWorkers.Count > 0)
					{
						workerProcess = sessionWorkers.Dequeue();
						if (workerProcess.IsRegistered)
						{
							break;
						}
						workerProcess = null;
					}
					if (workerProcess == null)
					{
						break;
					}
					listenerSessionConnection = sessionMessages.Dequeue();
					listenerSessionConnection.WorkerProcess = workerProcess;
				}
			}
			if (listenerSessionConnection != null)
			{
				StartDispatchSession(listenerSessionConnection);
				continue;
			}
			break;
		}
	}

	private void StartDispatchSession(ListenerSessionConnection session)
	{
		IAsyncResult asyncResult = null;
		try
		{
			asyncResult = session.WorkerProcess.BeginDispatchSession(session, dispatchSessionCompletedCallback, session);
		}
		catch (Exception ex)
		{
			if (DiagnosticUtility.IsFatal(ex))
			{
				throw;
			}
			if (DiagnosticUtility.ShouldTraceWarning)
			{
				DiagnosticUtility.ExceptionUtility.TraceHandledException(ex, TraceEventType.Warning);
			}
			if (session.WorkerProcess.IsRegistered)
			{
				EnqueueWorkerAndDispatch(session.WorkerProcess, canDispatchOnThisThread: false);
			}
		}
		if (asyncResult != null && asyncResult.CompletedSynchronously)
		{
			CompleteDispatchSession(asyncResult);
		}
	}

	private void DispatchSessionCompletedCallback(IAsyncResult result)
	{
		if (!result.CompletedSynchronously)
		{
			CompleteDispatchSession(result);
		}
	}

	private void CompleteDispatchSession(IAsyncResult result)
	{
		ListenerSessionConnection listenerSessionConnection = (ListenerSessionConnection)result.AsyncState;
		if (!listenerSessionConnection.WorkerProcess.EndDispatchSession(result))
		{
			OnConnectionDispatchFailed(listenerSessionConnection.Connection);
		}
		EnqueueWorkerAndDispatch(listenerSessionConnection.WorkerProcess, !result.CompletedSynchronously);
	}

	internal static void OnDispatchFailure(TransportType transportType)
	{
		switch (transportType)
		{
		case TransportType.Tcp:
			ListenerPerfCounters.IncrementDispatchFailuresTcp();
			break;
		case TransportType.NamedPipe:
			ListenerPerfCounters.IncrementDispatchFailuresNamedPipe();
			break;
		}
	}

	private bool OnConnectionDispatchFailed(IConnection connection)
	{
		TransportListener.SendFault(connection, "http://schemas.microsoft.com/ws/2006/05/framing/faults/ConnectionDispatchFailed");
		return false;
	}

	protected void OnNewWorkerAvailable(WorkerProcess worker)
	{
		lock (workers)
		{
			worker.Queue = this;
			workers.Add(worker);
			IOThreadScheduler.ScheduleCallback(dispatchToNewWorkerCallback, (object)worker);
		}
	}

	private static void DispatchToNewWorkerCallback(object state)
	{
		WorkerProcess workerProcess = state as WorkerProcess;
		workerProcess.Queue.EnqueueWorkerAndDispatch(workerProcess, canDispatchOnThisThread: true);
	}

	public ListenerExceptionStatus Register(BaseUriWithWildcard path)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (path.get_BaseAddress().Scheme == Uri.UriSchemeNetTcp)
		{
			if (transportType == TransportType.NamedPipe)
			{
				return (ListenerExceptionStatus)3;
			}
			maxQueueSize = ListenerConfig.NetTcp.MaxPendingConnections;
			transportType = TransportType.Tcp;
		}
		else
		{
			if (!(path.get_BaseAddress().Scheme == Uri.UriSchemeNetPipe))
			{
				return (ListenerExceptionStatus)3;
			}
			if (transportType == TransportType.Tcp)
			{
				return (ListenerExceptionStatus)3;
			}
			maxQueueSize = ListenerConfig.NetPipe.MaxPendingConnections;
			transportType = TransportType.NamedPipe;
		}
		ListenerExceptionStatus val = RoutingTable.Start(this, path);
		if ((int)val == 0)
		{
			paths.Add(path);
			IncrementUrisRegisteredCounters();
			OnRegisterCompleted();
		}
		return val;
	}

	internal static ListenerExceptionStatus Register(BaseUriWithWildcard path, WorkerProcess worker)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		MessageQueue value = null;
		lock (registry)
		{
			if (registry.TryGetValue(path, out value))
			{
				if (!value.CanShare)
				{
					return (ListenerExceptionStatus)4;
				}
			}
			else
			{
				value = new MessageQueue();
				ListenerExceptionStatus val = (ListenerExceptionStatus)5;
				try
				{
					val = value.Register(path);
				}
				catch (Exception exception)
				{
					if (DiagnosticUtility.IsFatal(exception))
					{
						throw;
					}
					if (DiagnosticUtility.ShouldTraceError)
					{
						ListenerTraceUtility.TraceEvent(TraceEventType.Error, (TraceCode)655368, (TraceRecord)new StringTraceRecord("Path", ((object)path).ToString()), null, exception);
					}
				}
				if ((int)val != 0)
				{
					return val;
				}
				registry.Add(path, value);
			}
		}
		value.OnNewWorkerAvailable(worker);
		return (ListenerExceptionStatus)0;
	}

	protected virtual void OnSessionEnqueued()
	{
	}

	public void UnregisterAll()
	{
		while (paths.Count > 0)
		{
			Unregister(paths[0]);
		}
	}

	private void Unregister(BaseUriWithWildcard path)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589837, (TraceRecord)new StringTraceRecord("Path", ((object)path).ToString()), this, null);
		}
		RoutingTable.Stop(this, path);
		IncrementUrisUnregisteredCounters();
		OnUnregisterCompleted();
		registry.Remove(path);
		paths.Remove(path);
	}

	protected virtual void OnUnregisterLastWorker()
	{
		Close();
	}

	internal virtual void Unregister(WorkerProcess worker)
	{
		lock (registry)
		{
			workers.Remove(worker);
			if (workers.Count == 0)
			{
				OnUnregisterLastWorker();
			}
		}
	}

	protected virtual void OnRegisterCompleted()
	{
		IncrementRegistrationsActiveCounters();
	}

	protected virtual void OnUnregisterCompleted()
	{
		DecrementRegistrationsActiveCounters();
	}

	protected void IncrementRegistrationsActiveCounters()
	{
		if (TransportType == TransportType.Tcp)
		{
			ListenerPerfCounters.IncrementRegistrationsActiveTcp();
		}
		else
		{
			ListenerPerfCounters.IncrementRegistrationsActiveNamedPipe();
		}
	}

	protected void DecrementRegistrationsActiveCounters()
	{
		if (TransportType == TransportType.Tcp)
		{
			ListenerPerfCounters.DecrementRegistrationsActiveTcp();
		}
		else
		{
			ListenerPerfCounters.DecrementRegistrationsActiveNamedPipe();
		}
	}

	private void IncrementUrisUnregisteredCounters()
	{
		if (TransportType == TransportType.Tcp)
		{
			ListenerPerfCounters.IncrementUrisUnregisteredTcp();
		}
		else
		{
			ListenerPerfCounters.IncrementUrisUnregisteredNamedPipe();
		}
	}

	private void IncrementUrisRegisteredCounters()
	{
		if (TransportType == TransportType.Tcp)
		{
			ListenerPerfCounters.IncrementUrisRegisteredTcp();
		}
		else
		{
			ListenerPerfCounters.IncrementUrisRegisteredNamedPipe();
		}
	}
}
