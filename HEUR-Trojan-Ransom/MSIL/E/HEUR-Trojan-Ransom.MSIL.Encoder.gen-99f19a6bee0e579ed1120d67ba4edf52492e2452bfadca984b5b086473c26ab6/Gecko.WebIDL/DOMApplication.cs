namespace Gecko.WebIDL;

public class DOMApplication : WebIDLBase
{
	public object Manifest => GetProperty<object>("manifest");

	public object UpdateManifest => GetProperty<object>("updateManifest");

	public string ManifestURL => GetProperty<string>("manifestURL");

	public string Origin => GetProperty<string>("origin");

	public string InstallOrigin => GetProperty<string>("installOrigin");

	public nsISupports InstallTime => GetProperty<nsISupports>("installTime");

	public bool Removable => GetProperty<bool>("removable");

	public bool Enabled => GetProperty<bool>("enabled");

	public string[] Receipts => GetProperty<string[]>("receipts");

	public double Progress => GetProperty<double>("progress");

	public string InstallState => GetProperty<string>("installState");

	public nsISupports LastUpdateCheck => GetProperty<nsISupports>("lastUpdateCheck");

	public nsISupports UpdateTime => GetProperty<nsISupports>("updateTime");

	public bool DownloadAvailable => GetProperty<bool>("downloadAvailable");

	public bool Downloading => GetProperty<bool>("downloading");

	public bool ReadyToApplyDownload => GetProperty<bool>("readyToApplyDownload");

	public int DownloadSize => GetProperty<int>("downloadSize");

	public nsISupports DownloadError => GetProperty<nsISupports>("downloadError");

	public DOMApplication(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Download()
	{
		CallVoidMethod("download");
	}

	public void CancelDownload()
	{
		CallVoidMethod("cancelDownload");
	}

	public nsISupports Launch()
	{
		return CallMethod<nsISupports>("launch", new object[0]);
	}

	public nsISupports Launch(string url)
	{
		return CallMethod<nsISupports>("launch", new object[1] { url });
	}

	public nsISupports ClearBrowserData()
	{
		return CallMethod<nsISupports>("clearBrowserData", new object[0]);
	}

	public nsISupports CheckForUpdate()
	{
		return CallMethod<nsISupports>("checkForUpdate", new object[0]);
	}

	public Promise<nsISupports> Connect(string keyword)
	{
		return CallMethod<Promise<nsISupports>>("connect", new object[1] { keyword });
	}

	public Promise<nsISupports> Connect(string keyword, object rules)
	{
		return CallMethod<Promise<nsISupports>>("connect", new object[2] { keyword, rules });
	}

	public Promise<nsISupports[]> GetConnections()
	{
		return CallMethod<Promise<nsISupports[]>>("getConnections", new object[0]);
	}

	public nsISupports AddReceipt()
	{
		return CallMethod<nsISupports>("addReceipt", new object[0]);
	}

	public nsISupports AddReceipt(string receipt)
	{
		return CallMethod<nsISupports>("addReceipt", new object[1] { receipt });
	}

	public nsISupports RemoveReceipt()
	{
		return CallMethod<nsISupports>("removeReceipt", new object[0]);
	}

	public nsISupports RemoveReceipt(string receipt)
	{
		return CallMethod<nsISupports>("removeReceipt", new object[1] { receipt });
	}

	public nsISupports ReplaceReceipt()
	{
		return CallMethod<nsISupports>("replaceReceipt", new object[0]);
	}

	public nsISupports ReplaceReceipt(string oldReceipt)
	{
		return CallMethod<nsISupports>("replaceReceipt", new object[1] { oldReceipt });
	}

	public nsISupports ReplaceReceipt(string oldReceipt, string newReceipt)
	{
		return CallMethod<nsISupports>("replaceReceipt", new object[2] { oldReceipt, newReceipt });
	}

	public Promise<nsIDOMBlob> Export()
	{
		return CallMethod<Promise<nsIDOMBlob>>("export", new object[0]);
	}

	public Promise<string> GetLocalizedValue(string property, string locale)
	{
		return CallMethod<Promise<string>>("getLocalizedValue", new object[2] { property, locale });
	}

	public Promise<string> GetLocalizedValue(string property, string locale, string entryPoint)
	{
		return CallMethod<Promise<string>>("getLocalizedValue", new object[3] { property, locale, entryPoint });
	}
}
