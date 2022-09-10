using System.Collections.Generic;
using System.Security.Principal;

namespace System.ServiceModel.Activation;

internal class AppManager
{
	private Dictionary<string, App> apps;

	private Dictionary<string, AppPool> pools;

	public int AppsCount => apps.Count;

	public Dictionary<string, App> Apps => apps;

	public Dictionary<string, AppPool> AppPools => pools;

	public AppManager()
	{
		apps = new Dictionary<string, App>();
		pools = new Dictionary<string, AppPool>();
	}

	public void CreateAppPool(string appPoolId, SecurityIdentifier sid)
	{
		AppPool value = new AppPool(appPoolId, enabled: false, sid);
		pools.Add(appPoolId, value);
	}

	public App CreateApp(string appKey, string path, int siteId, string appPoolId, bool requestsBlocked)
	{
		AppPool appPool = AppPools[appPoolId];
		App app = new App(appKey, path, siteId, appPool, requestsBlocked);
		apps.Add(appKey, app);
		appPool.AddApp(app);
		return app;
	}

	public void DeleteAppPool(string appPoolId)
	{
		if (!pools.TryGetValue(appPoolId, out var value) || value == null)
		{
			return;
		}
		foreach (App item in value.SnapshotApps())
		{
			DeleteApp(item, appPoolDeleted: true);
		}
		pools.Remove(appPoolId);
		value.OnDeleted();
	}

	public void DeleteApp(App app, bool appPoolDeleted)
	{
		app.AppPool.RemoveApp(app);
		apps.Remove(app.AppKey);
		app.OnDeleted(appPoolDeleted);
	}

	public void Clear()
	{
		foreach (App value in apps.Values)
		{
			value.OnDeleted(appPoolDeleted: false);
		}
		apps.Clear();
		pools.Clear();
	}
}
