namespace Gecko.WebIDL;

public class DOMApplicationsManager : WebIDLBase
{
	public DOMApplicationsManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetAll()
	{
		return CallMethod<nsISupports>("getAll", new object[0]);
	}

	public nsISupports GetNotInstalled()
	{
		return CallMethod<nsISupports>("getNotInstalled", new object[0]);
	}

	public void ApplyDownload(nsISupports app)
	{
		CallVoidMethod("applyDownload", app);
	}

	public nsISupports Uninstall(nsISupports app)
	{
		return CallMethod<nsISupports>("uninstall", new object[1] { app });
	}

	public Promise<nsISupports> Import(nsIDOMBlob blob)
	{
		return CallMethod<Promise<nsISupports>>("import", new object[1] { blob });
	}

	public Promise<object> ExtractManifest(nsIDOMBlob blob)
	{
		return CallMethod<Promise<object>>("extractManifest", new object[1] { blob });
	}

	public void SetEnabled(nsISupports app, bool state)
	{
		CallVoidMethod("setEnabled", app, state);
	}

	public Promise<nsIDOMBlob> GetIcon(nsISupports app, string iconID)
	{
		return CallMethod<Promise<nsIDOMBlob>>("getIcon", new object[2] { app, iconID });
	}

	public Promise<nsIDOMBlob> GetIcon(nsISupports app, string iconID, string entryPoint)
	{
		return CallMethod<Promise<nsIDOMBlob>>("getIcon", new object[3] { app, iconID, entryPoint });
	}
}
