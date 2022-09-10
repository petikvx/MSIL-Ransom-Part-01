using System.Collections.Generic;
using System.Security.Principal;

namespace System.ServiceModel.Activation;

internal class AppPool
{
	private string appPoolId;

	private List<App> apps;

	private bool enabled;

	private SecurityIdentifier securityIdentifier;

	internal string AppPoolId => appPoolId;

	internal bool Enabled => enabled;

	internal bool IsEnabled => enabled;

	internal AppPool(string appPoolId, bool enabled, SecurityIdentifier securityIdentifier)
	{
		apps = new List<App>();
		this.appPoolId = appPoolId;
		this.enabled = enabled;
		this.securityIdentifier = securityIdentifier;
	}

	internal void AddApp(App app)
	{
		lock (apps)
		{
			apps.Add(app);
		}
	}

	internal void RemoveApp(App app)
	{
		lock (apps)
		{
			apps.Remove(app);
		}
	}

	internal IEnumerable<App> SnapshotApps()
	{
		lock (apps)
		{
			return new List<App>(apps);
		}
	}

	internal void OnDeleted()
	{
		enabled = false;
	}

	internal void SetEnabledState(bool enabled)
	{
		if (this.enabled == enabled)
		{
			return;
		}
		this.enabled = enabled;
		foreach (App app in apps)
		{
			app.OnAppPoolStateChanged();
		}
	}

	internal void SetIdentity(SecurityIdentifier securityIdentifier)
	{
		this.securityIdentifier = securityIdentifier;
	}
}
