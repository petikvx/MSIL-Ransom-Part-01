using System.Collections;
using System.ServiceModel.Channels;
using System.Threading;

namespace System.ServiceModel.Activation;

internal class ActivatedMessageQueue : MessageQueue, IActivatedMessageQueue
{
	private enum QueueState
	{
		Faulted,
		PendingOpen,
		OpenedPendingConnect,
		Connected
	}

	private const int ThrottlingMaxSkewInMilliseconds = 5000;

	private static TimeSpan FailureThrottlingTimeout = TimeSpan.FromSeconds(15.0);

	private App app;

	private bool enabled;

	private ListenerAdapter listenerAdapter;

	private static int listenerChannelIdCounter;

	private static Hashtable listenerChannelIds = new Hashtable();

	private ListenerChannelContext listenerChannelContext;

	private QueueState queueState;

	private object syncRoot = new object();

	private int listenerChannelFailCount;

	private IOThreadTimer throttlingTimer;

	public App App => app;

	public ListenerChannelContext ListenerChannelContext => listenerChannelContext;

	private object ThisLock => syncRoot;

	protected override bool CanShare => true;

	internal override bool CanDispatch
	{
		get
		{
			if (base.CanDispatch && enabled && queueState != 0 && listenerAdapter.CanDispatch && ((base.TransportType == TransportType.Tcp && !SMSvcHost.IsTcpActivationPaused) || (base.TransportType == TransportType.NamedPipe && !SMSvcHost.IsNamedPipeActivationPaused)))
			{
				return app.AppPool.Enabled;
			}
			return false;
		}
	}

	bool IActivatedMessageQueue.HasStartedQueueInstances => queueState == QueueState.Connected;

	internal ActivatedMessageQueue(ListenerAdapter listenerAdapter, App app)
	{
		this.listenerAdapter = listenerAdapter;
		this.app = app;
		queueState = QueueState.PendingOpen;
		CreateListenerChannelContext();
	}

	private void CreateListenerChannelContext()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		listenerChannelContext = new ListenerChannelContext(app.AppKey, Interlocked.Increment(ref listenerChannelIdCounter), Guid.NewGuid());
		listenerChannelIds[listenerChannelContext.get_ListenerChannelId()] = this;
	}

	public void Delete()
	{
		SetEnabledState(enabled: false);
		Close();
	}

	internal static ActivatedMessageQueue Find(int listenerChannelId)
	{
		return listenerChannelIds[listenerChannelId] as ActivatedMessageQueue;
	}

	private bool OnListenerChannelFailed()
	{
		lock (ThisLock)
		{
			listenerChannelFailCount++;
			if (listenerChannelFailCount <= 6)
			{
				return false;
			}
			listenerChannelFailCount = 0;
		}
		FaultMessageQueueOnFailure();
		return true;
	}

	private void FaultMessageQueueOnFailure()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		lock (ThisLock)
		{
			queueState = QueueState.Faulted;
			DropPendingMessages(sendFault: true);
			if (throttlingTimer == null)
			{
				throttlingTimer = new IOThreadTimer((WaitCallback)ThrottlingCallback, (object)this, true, 5000);
			}
			throttlingTimer.Set(FailureThrottlingTimeout);
		}
	}

	private void ThrottlingCallback(object state)
	{
		lock (ThisLock)
		{
			queueState = QueueState.PendingOpen;
			listenerChannelFailCount = 0;
		}
	}

	public void LaunchQueueInstance()
	{
		lock (ThisLock)
		{
			if (queueState == QueueState.Faulted || (queueState == QueueState.OpenedPendingConnect && OnListenerChannelFailed()))
			{
				return;
			}
			queueState = QueueState.PendingOpen;
		}
		if (base.PendingCount > 0)
		{
			EnsureListenerChannelInstanceOpened();
		}
	}

	internal static ListenerExceptionStatus Register(int listenerChannelId, Guid token, WorkerProcess worker)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		ActivatedMessageQueue activatedMessageQueue = null;
		lock (listenerChannelIds)
		{
			activatedMessageQueue = Find(listenerChannelId);
			if (activatedMessageQueue == null)
			{
				return (ListenerExceptionStatus)7;
			}
			if (!token.Equals(activatedMessageQueue.listenerChannelContext.get_Token()))
			{
				return (ListenerExceptionStatus)7;
			}
		}
		activatedMessageQueue.OnListenerChannelConnected();
		activatedMessageQueue.OnNewWorkerAvailable(worker);
		return (ListenerExceptionStatus)0;
	}

	private void OnListenerChannelConnected()
	{
		lock (ThisLock)
		{
			listenerChannelFailCount = 0;
			queueState = QueueState.Connected;
		}
	}

	public void SetEnabledState(bool enabled)
	{
		if (this.enabled != enabled)
		{
			this.enabled = enabled;
			if (enabled)
			{
				IncrementRegistrationsActiveCounters();
				return;
			}
			DecrementRegistrationsActiveCounters();
			DropPendingMessages(sendFault: true);
		}
	}

	protected override void OnSessionEnqueued()
	{
		EnsureListenerChannelInstanceOpened();
	}

	protected override void OnRegisterCompleted()
	{
		queueState = QueueState.PendingOpen;
	}

	protected override void OnUnregisterCompleted()
	{
		queueState = QueueState.PendingOpen;
	}

	private void EnsureListenerChannelInstanceOpened()
	{
		lock (ThisLock)
		{
			if (queueState != QueueState.PendingOpen)
			{
				return;
			}
			queueState = QueueState.OpenedPendingConnect;
		}
		if (!listenerAdapter.OpenListenerChannelInstance(this))
		{
			FaultMessageQueueOnFailure();
		}
	}

	void IActivatedMessageQueue.OnQueueInstancesStopped()
	{
		lock (ThisLock)
		{
			queueState = QueueState.PendingOpen;
		}
	}

	protected override void OnUnregisterLastWorker()
	{
	}

	ListenerExceptionStatus IActivatedMessageQueue.Register(BaseUriWithWildcard url)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return Register(url);
	}

	void IActivatedMessageQueue.UnregisterAll()
	{
		UnregisterAll();
	}
}
