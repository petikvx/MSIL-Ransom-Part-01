using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Security.Principal;
using System.ServiceModel.Activation.Diagnostics;
using System.ServiceModel.Channels;
using System.ServiceModel.Diagnostics;
using System.Threading;

namespace System.ServiceModel.Activation;

internal class ListenerAdapter : ListenerAdapterBase
{
	private const string SiteRootPath = "/";

	private IActivationService activationService;

	private bool canDispatch;

	private bool isOpen;

	private AutoResetEvent wasConnected;

	private AutoResetEvent cleanupComplete;

	private AppManager appManager;

	private ManualResetEvent initCompleted;

	private WaitCallback closeAllListenerChannelInstancesCallback;

	private WaitCallback launchQueueInstanceCallback;

	private object ThisLock => this;

	internal bool CanDispatch => canDispatch;

	internal ListenerAdapter(IActivationService activationService)
		: base(activationService.ProtocolName)
	{
		this.activationService = activationService;
		appManager = new AppManager();
	}

	internal override void Open()
	{
		if (isOpen)
		{
			return;
		}
		lock (ThisLock)
		{
			if (!isOpen)
			{
				initCompleted = new ManualResetEvent(initialState: false);
				base.Open();
				initCompleted.WaitOne();
				initCompleted.Close();
				initCompleted = null;
				isOpen = true;
			}
		}
	}

	internal new void Close()
	{
		if (!isOpen)
		{
			return;
		}
		lock (ThisLock)
		{
			if (isOpen)
			{
				isOpen = false;
				cleanupComplete = new AutoResetEvent(initialState: false);
				if (!Cleanup(closeInstances: true))
				{
					cleanupComplete.WaitOne(30000, exitContext: false);
				}
				base.Close();
			}
		}
	}

	private bool Cleanup(bool closeInstances)
	{
		canDispatch = false;
		bool result = true;
		if (closeInstances)
		{
			List<App> list = new List<App>();
			List<App> list2 = new List<App>();
			List<App> list3 = new List<App>();
			lock (appManager)
			{
				if (appManager.AppsCount != 0)
				{
					list.AddRange(appManager.Apps.Values);
					foreach (App item in list)
					{
						if (item.MessageQueue.HasStartedQueueInstances)
						{
							list3.Add(item);
						}
						else
						{
							list2.Add(item);
						}
					}
					list.Clear();
				}
			}
			if (list2.Count != 0)
			{
				foreach (App item2 in list2)
				{
					RemoveApp(item2);
				}
			}
			if (list3.Count != 0)
			{
				foreach (App item3 in list3)
				{
					if (item3.PendingAction != null)
					{
						item3.PendingAction.MergeFromDeletedAction();
						continue;
					}
					item3.SetPendingAction(AppAction.CreateDeletedAction());
					CloseAllListenerChannelInstances(item3);
				}
				result = false;
			}
			return result;
		}
		lock (appManager)
		{
			appManager.Clear();
			return result;
		}
	}

	private void CloseAllListenerChannelInstances(App app)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		int num = CloseAllListenerChannelInstances(app.AppPool.AppPoolId, app.MessageQueue.ListenerChannelContext.get_ListenerChannelId());
		if (num == 0)
		{
			if (DiagnosticUtility.ShouldTraceInformation)
			{
				ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)655379, this);
			}
		}
		else if (DiagnosticUtility.ShouldTraceError)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Error, (TraceCode)655380, (TraceRecord)new StringTraceRecord("HRESULT", SR.GetString("TraceCodeWasWebHostAPIFailed", "WebhostCloseAllListenerChannelInstances", num.ToString(CultureInfo.CurrentCulture))), this, null);
		}
	}

	protected override void OnApplicationAppPoolChanged(string appKey, string appPoolId)
	{
		try
		{
			App value = null;
			lock (appManager)
			{
				if (!appManager.Apps.TryGetValue(appKey, out value))
				{
					return;
				}
			}
			if (value.PendingAction != null)
			{
				value.PendingAction.MergeFromAppPoolChangedAction(appPoolId);
			}
			else if (value.MessageQueue.HasStartedQueueInstances)
			{
				value.SetPendingAction(AppAction.CreateAppPoolChangedAction(appPoolId));
				ScheduleClosingListenerChannelInstances(value);
			}
			else
			{
				CompleteAppPoolChange(value, appPoolId);
			}
		}
		catch (Exception exception)
		{
			HandleUnknownError(exception);
		}
	}

	internal void CompleteAppPoolChange(App app, string appPoolId)
	{
		lock (appManager)
		{
			if (appManager.AppPools.TryGetValue(appPoolId, out var value) && value != app.AppPool)
			{
				app.AppPool.RemoveApp(app);
				value.AddApp(app);
				app.OnAppPoolChanged(value);
			}
		}
	}

	protected override void OnApplicationDeleted(string appKey)
	{
		try
		{
			App app = null;
			lock (appManager)
			{
				app = appManager.Apps[appKey];
			}
			if (app.PendingAction != null)
			{
				app.PendingAction.MergeFromDeletedAction();
			}
			else if (app.MessageQueue.HasStartedQueueInstances)
			{
				app.SetPendingAction(AppAction.CreateDeletedAction());
				ScheduleClosingListenerChannelInstances(app);
			}
			else
			{
				CompleteDeleteApp(app);
			}
		}
		catch (Exception exception)
		{
			HandleUnknownError(exception);
		}
	}

	internal void CompleteDeleteApp(App app)
	{
		RemoveApp(app);
	}

	private void CompleteAppSettingsChanged(App app)
	{
		if (app.PendingAction.AppPoolId != null)
		{
			CompleteAppPoolChange(app, app.PendingAction.AppPoolId);
		}
		if (app.PendingAction.Path != null)
		{
			app.Path = app.PendingAction.Path;
		}
		if (app.PendingAction.Bindings != null)
		{
			RegisterNewBindings(app, app.PendingAction.Bindings);
		}
		if (app.PendingAction.RequestsBlocked.HasValue)
		{
			app.SetRequestBlocked(app.PendingAction.RequestsBlocked.Value);
		}
	}

	private void RemoveApp(App app)
	{
		lock (appManager)
		{
			if (appManager.Apps.ContainsKey(app.AppKey))
			{
				appManager.DeleteApp(app, appPoolDeleted: false);
			}
		}
	}

	protected override void OnApplicationBindingsChanged(string appKey, IntPtr bindingsMultiSz, int numberOfBindings)
	{
		string[] array = null;
		try
		{
			array = ParseBindings(bindingsMultiSz, numberOfBindings);
		}
		catch (ArgumentException ex)
		{
			if (DiagnosticUtility.ShouldTraceError)
			{
				DiagnosticUtility.ExceptionUtility.TraceHandledException((Exception)ex, TraceEventType.Error);
			}
			return;
		}
		App value = null;
		lock (appManager)
		{
			if (!appManager.Apps.TryGetValue(appKey, out value))
			{
				return;
			}
		}
		try
		{
			if (value.PendingAction != null)
			{
				value.PendingAction.MergeFromBindingChangedAction(array);
			}
			else if (value.MessageQueue.HasStartedQueueInstances)
			{
				value.SetPendingAction(AppAction.CreateBindingsChangedAction(array));
				ScheduleClosingListenerChannelInstances(value);
			}
			else
			{
				RegisterNewBindings(value, array);
			}
		}
		catch (Exception exception)
		{
			HandleUnknownError(exception);
		}
	}

	internal void RegisterNewBindings(App app, string[] bindings)
	{
		app.MessageQueue.UnregisterAll();
		bool flag = RegisterBindings(app.MessageQueue, app.SiteId, bindings, app.Path);
		app.OnInvalidBinding(!flag);
	}

	protected override void OnApplicationCreated(string appKey, string path, int siteId, string appPoolId, IntPtr bindingsMultiSz, int numberOfBindings, bool requestsBlocked)
	{
		string[] array = null;
		try
		{
			array = ParseBindings(bindingsMultiSz, numberOfBindings);
		}
		catch (ArgumentException ex)
		{
			if (DiagnosticUtility.ShouldTraceError)
			{
				DiagnosticUtility.ExceptionUtility.TraceHandledException((Exception)ex, TraceEventType.Error);
			}
			return;
		}
		try
		{
			bool flag = true;
			App value = null;
			lock (appManager)
			{
				if (!appManager.Apps.TryGetValue(appKey, out value))
				{
					flag = false;
					value = appManager.CreateApp(appKey, path, siteId, appPoolId, requestsBlocked);
				}
			}
			if (flag)
			{
				value.PendingAction.MergeFromCreatedAction(path, siteId, appPoolId, requestsBlocked, array);
			}
			else
			{
				CompleteAppCreation(value, array);
			}
		}
		catch (Exception exception)
		{
			HandleUnknownError(exception);
		}
	}

	private void CompleteAppCreation(App app, string[] bindings)
	{
		IActivatedMessageQueue messageQueue = activationService.CreateQueue(this, app);
		app.RegisterQueue(messageQueue);
		bool flag = RegisterBindings(app.MessageQueue, app.SiteId, bindings, app.Path);
		app.OnInvalidBinding(!flag);
	}

	private bool RegisterBindings(IActivatedMessageQueue queue, int siteId, string[] bindings, string path)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		BaseUriWithWildcard[] array = (BaseUriWithWildcard[])(object)new BaseUriWithWildcard[bindings.Length];
		int num = 0;
		string text2;
		while (true)
		{
			if (num < bindings.Length)
			{
				string text = bindings[num];
				int num2 = text.IndexOf(':');
				text2 = text.Substring(0, num2);
				if (string.Compare(protocolName, text2, StringComparison.OrdinalIgnoreCase) != 0)
				{
					break;
				}
				text = text.Substring(num2 + 1);
				try
				{
					array[num] = BaseUriWithWildcard.CreateUri(protocolName, text, path);
				}
				catch (UriFormatException ex)
				{
					if (DiagnosticUtility.ShouldTraceError)
					{
						DiagnosticUtility.ExceptionUtility.TraceHandledException((Exception)ex, TraceEventType.Error);
					}
					if (string.Compare(path, "/", StringComparison.OrdinalIgnoreCase) == 0)
					{
						DiagnosticUtility.EventLog.LogEvent(TraceEventType.Error, (EventLogCategory)14, (EventLogEventId)(-1073479678), new string[6]
						{
							text2,
							text,
							siteId.ToString(NumberFormatInfo.CurrentInfo),
							bindings[num],
							DiagnosticTrace.CreateSourceString((object)this),
							ex.ToString()
						});
					}
					return false;
				}
				num++;
				continue;
			}
			int num3 = 0;
			ListenerExceptionStatus val;
			Exception ex2;
			while (true)
			{
				if (num3 < bindings.Length)
				{
					val = (ListenerExceptionStatus)5;
					ex2 = null;
					try
					{
						val = queue.Register(array[num3]);
					}
					catch (Exception ex3)
					{
						if (DiagnosticUtility.IsFatal(ex3))
						{
							throw;
						}
						if (DiagnosticUtility.ShouldTraceError)
						{
							DiagnosticUtility.ExceptionUtility.TraceHandledException(ex2, TraceEventType.Error);
						}
						ex2 = ex3;
					}
					if ((int)val == 0)
					{
						num3++;
						continue;
					}
					break;
				}
				return true;
			}
			if (string.Compare(path, "/", StringComparison.OrdinalIgnoreCase) == 0)
			{
				DiagnosticUtility.EventLog.LogEvent(TraceEventType.Error, (EventLogCategory)14, (EventLogEventId)(-1073479677), new string[6]
				{
					activationService.ActivationServiceName,
					protocolName,
					siteId.ToString(NumberFormatInfo.CurrentInfo),
					((object)array[num3]).ToString(),
					((object)val).ToString(),
					(ex2 == null) ? string.Empty : ex2.ToString()
				});
			}
			queue.UnregisterAll();
			return false;
		}
		throw DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("LAProtocolMismatch", text2, path, protocolName)));
	}

	protected override void OnApplicationPoolAllQueueInstancesStopped(string appPoolId, int queueId)
	{
		try
		{
			AppPool value = null;
			lock (appManager)
			{
				if (!appManager.AppPools.TryGetValue(appPoolId, out value))
				{
					return;
				}
			}
			IActivatedMessageQueue activatedMessageQueue = activationService.FindQueue(queueId);
			if (activatedMessageQueue == null)
			{
				return;
			}
			activatedMessageQueue.OnQueueInstancesStopped();
			App app = activatedMessageQueue.App;
			try
			{
				if (app.PendingAction.ActionType == AppActionType.Deleted)
				{
					CompleteDeleteApp(app);
					SignalCleanupForNoApps();
				}
				else if (app.PendingAction.ActionType == AppActionType.SettingsChanged)
				{
					CompleteAppSettingsChanged(app);
				}
			}
			finally
			{
				app.SetPendingAction(null);
			}
		}
		catch (Exception exception)
		{
			HandleUnknownError(exception);
		}
	}

	protected override void OnApplicationPoolCanLaunchQueueInstance(string appPoolId, int queueId)
	{
		try
		{
			IActivatedMessageQueue activatedMessageQueue = activationService.FindQueue(queueId);
			if (activatedMessageQueue != null)
			{
				if (activatedMessageQueue.App.AppPool.AppPoolId != appPoolId)
				{
					throw DiagnosticUtility.ExceptionUtility.ThrowHelperInternal(false);
				}
				ScheduleLaunchingQueueInstance(activatedMessageQueue);
			}
		}
		catch (Exception exception)
		{
			HandleUnknownError(exception);
		}
	}

	protected override void OnApplicationPoolCreated(string appPoolId, SecurityIdentifier sid)
	{
		try
		{
			lock (appManager)
			{
				appManager.CreateAppPool(appPoolId, sid);
			}
		}
		catch (Exception exception)
		{
			HandleUnknownError(exception);
		}
	}

	protected override void OnApplicationPoolDeleted(string appPoolId)
	{
		try
		{
			lock (appManager)
			{
				appManager.DeleteAppPool(appPoolId);
			}
			SignalCleanupForNoApps();
		}
		catch (Exception exception)
		{
			HandleUnknownError(exception);
		}
	}

	protected override void OnApplicationPoolIdentityChanged(string appPoolId, SecurityIdentifier sid)
	{
		try
		{
			AppPool value = null;
			lock (appManager)
			{
				if (appManager.AppPools.TryGetValue(appPoolId, out value))
				{
					value.SetIdentity(sid);
				}
			}
		}
		catch (Exception exception)
		{
			HandleUnknownError(exception);
		}
	}

	protected override void OnApplicationPoolStateChanged(string appPoolId, bool isEnabled)
	{
		try
		{
			AppPool value = null;
			lock (appManager)
			{
				if (appManager.AppPools.TryGetValue(appPoolId, out value))
				{
					value.SetEnabledState(isEnabled);
				}
			}
		}
		catch (Exception exception)
		{
			HandleUnknownError(exception);
		}
	}

	protected override void OnApplicationRequestsBlockedChanged(string appKey, bool requestsBlocked)
	{
		try
		{
			App value = null;
			lock (appManager)
			{
				if (!appManager.Apps.TryGetValue(appKey, out value))
				{
					return;
				}
			}
			if (value.PendingAction != null)
			{
				value.PendingAction.MergeFromRequestsBlockedAction(requestsBlocked);
			}
			else
			{
				value.SetRequestBlocked(requestsBlocked);
			}
		}
		catch (Exception exception)
		{
			HandleUnknownError(exception);
		}
	}

	protected override void OnConfigManagerConnected()
	{
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)655381, this);
		}
		if (wasConnected != null)
		{
			wasConnected.Set();
		}
	}

	protected override void OnConfigManagerDisconnected(int hresult)
	{
		if (isOpen)
		{
			DiagnosticUtility.EventLog.LogEvent(TraceEventType.Warning, (EventLogCategory)14, (EventLogEventId)(-1073479675), new string[1] { hresult.ToString(CultureInfo.InvariantCulture) });
			Cleanup(closeInstances: false);
			wasConnected = new AutoResetEvent(initialState: false);
			ThreadPool.UnsafeRegisterWaitForSingleObject(wasConnected, DiagnosticUtility.Utility.ThunkCallback((WaitOrTimerCallback)WasConnected), null, ListenerConstants.WasConnectTimeout, executeOnlyOnce: true);
		}
	}

	private void WasConnected(object state, bool timedOut)
	{
		if (timedOut)
		{
			DiagnosticUtility.EventLog.LogEvent(TraceEventType.Warning, (EventLogCategory)14, (EventLogEventId)(-1073479674), new string[0]);
			activationService.StopService();
		}
		wasConnected.Close();
		wasConnected = null;
	}

	protected override void OnConfigManagerInitializationCompleted()
	{
		canDispatch = true;
		initCompleted?.Set();
	}

	internal bool OpenListenerChannelInstance(IActivatedMessageQueue queue)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		byte[] queueBlob = queue.ListenerChannelContext.Dehydrate();
		int num = OpenListenerChannelInstance(queue.App.AppPool.AppPoolId, queue.ListenerChannelContext.get_ListenerChannelId(), queueBlob);
		if (num != 0)
		{
			if (DiagnosticUtility.ShouldTraceError)
			{
				ListenerTraceUtility.TraceEvent(TraceEventType.Error, (TraceCode)655380, (TraceRecord)new StringTraceRecord("HRESULT", SR.GetString("TraceCodeWasWebHostAPIFailed", "WebhostOpenListenerChannelInstance", num.ToString(CultureInfo.CurrentCulture))), this, null);
			}
			return false;
		}
		return true;
	}

	private void ScheduleClosingListenerChannelInstances(App app)
	{
		if (closeAllListenerChannelInstancesCallback == null)
		{
			closeAllListenerChannelInstancesCallback = OnCloseAllListenerChannelInstances;
		}
		IOThreadScheduler.ScheduleCallback(closeAllListenerChannelInstancesCallback, (object)app);
	}

	private void OnCloseAllListenerChannelInstances(object state)
	{
		App app = state as App;
		CloseAllListenerChannelInstances(app);
	}

	private void ScheduleLaunchingQueueInstance(IActivatedMessageQueue queue)
	{
		if (launchQueueInstanceCallback == null)
		{
			launchQueueInstanceCallback = OnLaunchQueueInstance;
		}
		IOThreadScheduler.ScheduleCallback(launchQueueInstanceCallback, (object)queue);
	}

	private void OnLaunchQueueInstance(object state)
	{
		IActivatedMessageQueue activatedMessageQueue = state as IActivatedMessageQueue;
		activatedMessageQueue.LaunchQueueInstance();
	}

	private void HandleUnknownError(Exception exception)
	{
		DiagnosticUtility.EventLog.LogEvent(TraceEventType.Error, (EventLogCategory)14, (EventLogEventId)(-1073479676), new string[2]
		{
			protocolName,
			exception.ToString()
		});
		DiagnosticUtility.InvokeFinalHandler(exception);
	}

	private void SignalCleanupForNoApps()
	{
		if (cleanupComplete == null)
		{
			return;
		}
		lock (appManager)
		{
			if (appManager.AppsCount == 0)
			{
				appManager.Clear();
				cleanupComplete.Set();
			}
		}
	}
}
