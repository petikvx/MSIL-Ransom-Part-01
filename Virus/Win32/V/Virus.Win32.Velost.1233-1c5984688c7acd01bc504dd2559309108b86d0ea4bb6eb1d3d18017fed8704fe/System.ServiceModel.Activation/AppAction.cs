namespace System.ServiceModel.Activation;

internal class AppAction
{
	private AppActionType actionType;

	private string path;

	private string appPoolId;

	private bool? requestsBlocked;

	private string[] bindings;

	public AppActionType ActionType => actionType;

	public string Path => path;

	public string AppPoolId => appPoolId;

	public string[] Bindings => bindings;

	public bool? RequestsBlocked => requestsBlocked;

	private AppAction(AppActionType actionType)
	{
		this.actionType = actionType;
	}

	public static AppAction CreateDeletedAction()
	{
		return new AppAction(AppActionType.Deleted);
	}

	public static AppAction CreateBindingsChangedAction(string[] bindings)
	{
		AppAction appAction = new AppAction(AppActionType.SettingsChanged);
		appAction.bindings = bindings;
		return appAction;
	}

	public static AppAction CreateAppPoolChangedAction(string appPoolId)
	{
		AppAction appAction = new AppAction(AppActionType.SettingsChanged);
		appAction.appPoolId = appPoolId;
		return appAction;
	}

	public void MergeFromCreatedAction(string path, int siteId, string appPoolId, bool requestsBlocked, string[] bindings)
	{
		actionType = AppActionType.SettingsChanged;
		SetSettings(path, appPoolId, requestsBlocked, bindings);
	}

	public void MergeFromDeletedAction()
	{
		actionType = AppActionType.Deleted;
	}

	public void MergeFromBindingChangedAction(string[] bindings)
	{
		this.bindings = bindings;
	}

	public void MergeFromAppPoolChangedAction(string appPoolId)
	{
		this.appPoolId = appPoolId;
	}

	public void MergeFromRequestsBlockedAction(bool requestsBlocked)
	{
		this.requestsBlocked = requestsBlocked;
	}

	private void SetSettings(string path, string appPoolId, bool requestsBlocked, string[] bindings)
	{
		this.path = path;
		this.appPoolId = appPoolId;
		this.requestsBlocked = requestsBlocked;
		this.bindings = bindings;
	}
}
