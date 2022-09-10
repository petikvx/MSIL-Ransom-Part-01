namespace System.ServiceModel.Activation;

internal class App
{
	private string appKey;

	private AppPool appPool;

	private int siteId;

	private IActivatedMessageQueue messageQueue;

	private string path;

	private bool requestBlocked;

	private bool hasInvalidBinding;

	private AppAction pendingAction;

	internal AppAction PendingAction => pendingAction;

	internal string AppKey => appKey;

	internal AppPool AppPool => appPool;

	internal int SiteId => siteId;

	internal IActivatedMessageQueue MessageQueue => messageQueue;

	internal string Path
	{
		get
		{
			return path;
		}
		set
		{
			path = value;
		}
	}

	internal bool IsEnabled
	{
		get
		{
			if (appPool.IsEnabled && !requestBlocked)
			{
				return !hasInvalidBinding;
			}
			return false;
		}
	}

	internal App(string appKey, string path, int siteId, AppPool appPool, bool requestsBlocked)
	{
		this.appKey = appKey;
		this.path = path;
		this.appPool = appPool;
		this.siteId = siteId;
		requestBlocked = requestsBlocked;
	}

	internal void SetPendingAction(AppAction action)
	{
		pendingAction = action;
	}

	internal void RegisterQueue(IActivatedMessageQueue messageQueue)
	{
		if (this.messageQueue != null)
		{
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperInternal(false);
		}
		this.messageQueue = messageQueue;
	}

	internal void OnAppPoolChanged(AppPool newAppPool)
	{
		appPool = newAppPool;
	}

	internal void SetRequestBlocked(bool requestBlocked)
	{
		if (this.requestBlocked != requestBlocked)
		{
			this.requestBlocked = requestBlocked;
			OnStateChanged();
		}
	}

	internal void OnAppPoolStateChanged()
	{
		OnStateChanged();
	}

	internal void OnDeleted(bool appPoolDeleted)
	{
		messageQueue.Delete();
	}

	internal void OnInvalidBinding(bool hasInvalidBinding)
	{
		this.hasInvalidBinding = hasInvalidBinding;
		OnStateChanged();
	}

	private void OnStateChanged()
	{
		messageQueue.SetEnabledState(IsEnabled);
	}
}
