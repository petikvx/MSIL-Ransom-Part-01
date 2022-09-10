using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Messaging;
using System.ServiceModel.Activation.Diagnostics;
using System.ServiceModel.Channels;
using System.ServiceModel.Diagnostics;
using System.ServiceProcess;
using System.Threading;

namespace System.ServiceModel.Activation;

internal class MsmqActivation : ServiceBase
{
	private class BindingsManager
	{
		private Dictionary<string, MsmqBindingMonitor> bindingMonitors;

		private object thisLock = new object();

		public BindingsManager()
		{
			bindingMonitors = new Dictionary<string, MsmqBindingMonitor>(StringComparer.OrdinalIgnoreCase);
		}

		public void RegisterBindingFilterIfNecessary(string host, MsmqBindingFilter filter)
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			lock (thisLock)
			{
				if (!bindingMonitors.TryGetValue(host, out var value))
				{
					value = new MsmqBindingMonitor(host);
					bindingMonitors.Add(host, value);
					value.Open();
				}
				if (!value.ContainsFilter(filter))
				{
					value.AddFilter(filter);
				}
			}
		}

		public void UnregisterBindingFilter(MsmqBindingFilter filter)
		{
			lock (thisLock)
			{
				foreach (MsmqBindingMonitor value in bindingMonitors.Values)
				{
					value.RemoveFilter(filter);
				}
			}
		}
	}

	private class ActivationService : IActivationService
	{
		private Dictionary<int, QueueMonitorGroup> groups;

		private string protocol;

		private BindingsManager bindings;

		private object thisLock = new object();

		private ServiceBase service;

		private bool paused;

		public bool Paused
		{
			get
			{
				return paused;
			}
			set
			{
				lock (this)
				{
					if (paused == value)
					{
						return;
					}
					paused = value;
					if (paused)
					{
						return;
					}
					foreach (QueueMonitorGroup value2 in groups.Values)
					{
						value2.Start();
					}
				}
			}
		}

		public BindingsManager Bindings => bindings;

		public string ActivationServiceName => service.get_ServiceName();

		public string ProtocolName => protocol;

		public ActivationService(MsmqActivation service, string protocol)
		{
			this.protocol = protocol;
			bindings = service.bindings;
			this.service = (ServiceBase)(object)service;
			paused = false;
			groups = new Dictionary<int, QueueMonitorGroup>();
		}

		public IActivatedMessageQueue CreateQueue(ListenerAdapter la, App app)
		{
			QueueMonitorGroup queueMonitorGroup = new QueueMonitorGroup(this, la, app);
			lock (thisLock)
			{
				groups[queueMonitorGroup.ListenerChannelContext.get_ListenerChannelId()] = queueMonitorGroup;
				return queueMonitorGroup;
			}
		}

		public IActivatedMessageQueue FindQueue(int queueId)
		{
			lock (thisLock)
			{
				groups.TryGetValue(queueId, out var value);
				return value;
			}
		}

		public void StopService()
		{
			service.Stop();
		}

		public void QueueMonitorGroupClosed(QueueMonitorGroup qmg)
		{
			lock (thisLock)
			{
				groups.Remove(qmg.ListenerChannelContext.get_ListenerChannelId());
			}
		}
	}

	private class QueueMonitorGroup : IActivatedMessageQueue
	{
		private class ActivationBindingFilter : MsmqBindingFilter
		{
			private QueueMonitorGroup group;

			public ActivationBindingFilter(QueueMonitorGroup group, string path)
				: base(path, MsmqUri.get_NetMsmqAddressTranslator())
			{
				this.group = group;
			}

			public override object MatchFound(string host, string name, bool isPrivate)
			{
				MsmqDiagnostics.MatchedApplicationFound(host, name, isPrivate, ((MsmqBindingFilter)this).get_CanonicalPrefix());
				return group.AddQueueToGroup(((MsmqBindingFilter)this).CreateServiceUri(host, name, isPrivate));
			}

			public override void MatchLost(string host, string name, bool isPrivate, object callbackState)
			{
				group.RemoveQueueFromGroup(callbackState);
			}
		}

		private static int queueIdCounter = 0;

		private static readonly TimeSpan RetryMonitorInterval = TimeSpan.FromMinutes(5.0);

		private ActivationService activationService;

		private App app;

		private ActivationBindingFilter filter;

		private ListenerAdapter listenerAdapter;

		private int startQueueInstanceCount;

		private ListenerChannelContext listenerChannelContext;

		private List<QueueMonitor> monitors = new List<QueueMonitor>();

		private List<QueueMonitor> failedMonitors = new List<QueueMonitor>();

		private bool enabled;

		private int pendingNotificationCount;

		private IOThreadTimer retryTimer;

		private bool retryScheduled;

		private bool hasStartedQueueInstances;

		public bool CanDispatch
		{
			get
			{
				if (enabled)
				{
					return !activationService.Paused;
				}
				return false;
			}
		}

		public App App => app;

		public ListenerChannelContext ListenerChannelContext => listenerChannelContext;

		bool IActivatedMessageQueue.HasStartedQueueInstances => hasStartedQueueInstances;

		public QueueMonitorGroup(ActivationService activationService, ListenerAdapter la, App app)
		{
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected O, but got Unknown
			this.activationService = activationService;
			listenerAdapter = la;
			this.app = app;
			startQueueInstanceCount = 1;
			listenerChannelContext = new ListenerChannelContext(app.AppKey, Interlocked.Increment(ref queueIdCounter), Guid.Empty);
			pendingNotificationCount = 0;
			filter = new ActivationBindingFilter(this, app.Path);
			retryTimer = new IOThreadTimer((WaitCallback)OnRetryTimer, (object)null, false);
		}

		void IActivatedMessageQueue.OnQueueInstancesStopped()
		{
			hasStartedQueueInstances = false;
		}

		public void Delete()
		{
			activationService.QueueMonitorGroupClosed(this);
			UnregisterAll();
		}

		public void LaunchQueueInstance()
		{
			bool flag = false;
			lock (this)
			{
				if (pendingNotificationCount > 0)
				{
					pendingNotificationCount--;
					flag = true;
				}
				else
				{
					startQueueInstanceCount++;
					foreach (QueueMonitor monitor in monitors)
					{
						monitor.Start();
					}
				}
			}
			if (flag && listenerAdapter.OpenListenerChannelInstance(this))
			{
				hasStartedQueueInstances = true;
			}
		}

		public ListenerExceptionStatus Register(BaseUriWithWildcard url)
		{
			activationService.Bindings.RegisterBindingFilterIfNecessary(url.get_BaseAddress().Host, (MsmqBindingFilter)(object)filter);
			return (ListenerExceptionStatus)0;
		}

		public void Start()
		{
			lock (this)
			{
				if (!CanDispatch)
				{
					return;
				}
				foreach (QueueMonitor monitor in monitors)
				{
					monitor.Start();
				}
			}
		}

		public void SetEnabledState(bool enabled)
		{
			lock (this)
			{
				if (this.enabled != enabled)
				{
					this.enabled = enabled;
					Start();
				}
			}
		}

		public void UnregisterAll()
		{
			lock (this)
			{
				foreach (QueueMonitor monitor in monitors)
				{
					monitor.Dispose();
				}
				monitors.Clear();
				activationService.Bindings.UnregisterBindingFilter((MsmqBindingFilter)(object)filter);
			}
		}

		public bool NotifyMessageAvailable()
		{
			bool flag = false;
			bool result = false;
			lock (this)
			{
				if (!CanDispatch)
				{
					pendingNotificationCount++;
				}
				else if (startQueueInstanceCount == 0)
				{
					pendingNotificationCount++;
				}
				else
				{
					startQueueInstanceCount--;
					flag = true;
					result = startQueueInstanceCount > 0;
				}
			}
			if (flag)
			{
				MsmqDiagnostics.StartingApplication(app.Path);
				listenerAdapter.OpenListenerChannelInstance(this);
				hasStartedQueueInstances = true;
			}
			return result;
		}

		public void ScheduleRetry(QueueMonitor monitor)
		{
			lock (this)
			{
				failedMonitors.Add(monitor);
				if (!retryScheduled)
				{
					retryTimer.Set(RetryMonitorInterval);
					retryScheduled = true;
				}
			}
		}

		private object AddQueueToGroup(Uri queue)
		{
			QueueMonitor queueMonitor = null;
			lock (this)
			{
				queueMonitor = new QueueMonitor(queue, this);
				monitors.Add(queueMonitor);
				if (enabled)
				{
					queueMonitor.Start();
					return queueMonitor;
				}
				return queueMonitor;
			}
		}

		private void OnRetryTimer(object state)
		{
			lock (this)
			{
				if (enabled)
				{
					foreach (QueueMonitor failedMonitor in failedMonitors)
					{
						if (monitors.Contains(failedMonitor))
						{
							failedMonitor.Start();
						}
					}
				}
				failedMonitors.Clear();
			}
		}

		private void RemoveQueueFromGroup(object state)
		{
			QueueMonitor queueMonitor = (QueueMonitor)state;
			lock (this)
			{
				monitors.Remove(queueMonitor);
				queueMonitor.Dispose();
			}
		}
	}

	private class QueueMonitor : IDisposable
	{
		private static readonly TimeSpan InfiniteTimeout = TimeSpan.FromMilliseconds(4294967295.0);

		private bool disposed;

		private QueueMonitorGroup group;

		private bool peeking;

		private string queueName;

		private MessageQueue queue;

		public QueueMonitor(Uri uri, QueueMonitorGroup group)
		{
			this.group = group;
			queueName = MsmqFormatName.ToSystemMessagingQueueName(MsmqUri.UriToFormatNameByScheme(uri));
			peeking = false;
		}

		public void Start()
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			lock (this)
			{
				try
				{
					if (queue == null)
					{
						queue = new MessageQueue(queueName);
						queue.get_MessageReadPropertyFilter().ClearAll();
						queue.get_MessageReadPropertyFilter().set_LookupId(true);
					}
					if (!peeking)
					{
						peeking = true;
						queue.BeginPeek(InfiniteTimeout, (object)null, DiagnosticUtility.ThunkAsyncCallback(OnPeekCompleted));
					}
				}
				catch (MessageQueueException)
				{
					group.ScheduleRetry(this);
				}
			}
		}

		public void Dispose()
		{
			lock (this)
			{
				disposed = true;
				if (queue != null)
				{
					((Component)(object)queue).Dispose();
				}
			}
		}

		private void OnPeekCompleted(IAsyncResult result)
		{
			//IL_001e: Expected O, but got Unknown
			bool flag = true;
			try
			{
				queue.EndPeek(result);
				flag = group.NotifyMessageAvailable();
			}
			catch (MessageQueueException val)
			{
				MessageQueueException val2 = val;
				MsmqDiagnostics.CannotPeekOnQueue(queue.get_FormatName(), (Exception)(object)val2);
				group.ScheduleRetry(this);
				return;
			}
			catch (Exception ex)
			{
				if (DiagnosticUtility.ShouldTraceError)
				{
					DiagnosticUtility.ExceptionUtility.TraceHandledException(ex, TraceEventType.Error);
				}
				if (!DiagnosticUtility.IsFatal(ex))
				{
					group.ScheduleRetry(this);
				}
				throw;
			}
			lock (this)
			{
				if (!disposed && flag)
				{
					queue.BeginPeek(InfiniteTimeout, (object)null, DiagnosticUtility.ThunkAsyncCallback(OnPeekCompleted));
				}
				else
				{
					peeking = false;
				}
			}
		}
	}

	private BindingsManager bindings;

	private ActivationService integrationActivationService;

	private ListenerAdapter integrationListenerAdapter;

	private ActivationService transportActivationService;

	private ListenerAdapter transportListenerAdapter;

	public MsmqActivation()
	{
		((ServiceBase)this).set_ServiceName("NetMsmqActivator");
		((ServiceBase)this).set_CanHandlePowerEvent(false);
		((ServiceBase)this).set_AutoLog(false);
		((ServiceBase)this).set_CanStop(true);
		((ServiceBase)this).set_CanPauseAndContinue(true);
		((ServiceBase)this).set_CanShutdown(true);
		bindings = new BindingsManager();
		integrationActivationService = new ActivationService(this, MsmqUri.get_FormatNameAddressTranslator().get_Scheme());
		transportActivationService = new ActivationService(this, MsmqUri.get_NetMsmqAddressTranslator().get_Scheme());
	}

	protected override void OnStart(string[] args)
	{
		try
		{
			if (DiagnosticUtility.ShouldTraceInformation)
			{
				ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589845, this);
			}
			Start();
		}
		catch (Exception ex)
		{
			ListenerTraceUtility.EventLog.LogEvent(TraceEventType.Error, (EventLogCategory)14, (EventLogEventId)(-1073479673), false, new string[1] { ex.ToString() });
			throw;
		}
	}

	protected override void OnStop()
	{
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589847, this);
		}
		Shutdown();
	}

	protected override void OnContinue()
	{
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589841, this);
		}
		integrationActivationService.Paused = false;
		transportActivationService.Paused = false;
	}

	protected override void OnPause()
	{
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589842, this);
		}
		integrationActivationService.Paused = true;
		transportActivationService.Paused = true;
	}

	protected override void OnShutdown()
	{
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589843, this);
		}
		Shutdown();
		((ServiceBase)this).Stop();
	}

	private void Start()
	{
		if (!SMSvcHost.IsWebhostSupported)
		{
			((ServiceBase)this).set_ExitCode(50);
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new NotSupportedException(SR.GetString("ServiceRequiresWas")));
		}
		integrationListenerAdapter = new ListenerAdapter(integrationActivationService);
		transportListenerAdapter = new ListenerAdapter(transportActivationService);
		integrationListenerAdapter.Open();
		transportListenerAdapter.Open();
	}

	private void Shutdown()
	{
		integrationListenerAdapter.Close();
		transportListenerAdapter.Close();
	}
}
