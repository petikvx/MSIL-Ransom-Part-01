using System;

namespace Gecko.WebIDL;

public class Navigator : WebIDLBase
{
	public nsISupports Permissions => GetProperty<nsISupports>("permissions");

	public nsISupports MimeTypes => GetProperty<nsISupports>("mimeTypes");

	public nsISupports Plugins => GetProperty<nsISupports>("plugins");

	public string DoNotTrack => GetProperty<string>("doNotTrack");

	public nsISupports Battery => GetProperty<nsISupports>("battery");

	public int MaxTouchPoints => GetProperty<int>("maxTouchPoints");

	public string Oscpu => GetProperty<string>("oscpu");

	public string Vendor => GetProperty<string>("vendor");

	public string VendorSub => GetProperty<string>("vendorSub");

	public string ProductSub => GetProperty<string>("productSub");

	public bool CookieEnabled => GetProperty<bool>("cookieEnabled");

	public string BuildID => GetProperty<string>("buildID");

	public nsISupports MozPower => GetProperty<nsISupports>("mozPower");

	public nsISupports DeviceStorageAreaListener => GetProperty<nsISupports>("deviceStorageAreaListener");

	public nsISupports MozNotification => GetProperty<nsISupports>("mozNotification");

	public nsISupports Connection => GetProperty<nsISupports>("connection");

	public nsISupports MozCameras => GetProperty<nsISupports>("mozCameras");

	public nsISupports ServiceWorker => GetProperty<nsISupports>("serviceWorker");

	public nsISupports Tv => GetProperty<nsISupports>("tv");

	public nsISupports InputPortManager => GetProperty<nsISupports>("inputPortManager");

	public nsISupports Presentation => GetProperty<nsISupports>("presentation");

	public nsISupports MozTCPSocket => GetProperty<nsISupports>("mozTCPSocket");

	public Navigator(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports> GetBattery()
	{
		return CallMethod<Promise<nsISupports>>("getBattery", new object[0]);
	}

	public bool Vibrate(uint duration)
	{
		return CallMethod<bool>("vibrate", new object[1] { duration });
	}

	public bool Vibrate(uint[] pattern)
	{
		return CallMethod<bool>("vibrate", new object[1] { pattern });
	}

	public bool JavaEnabled()
	{
		return CallMethod<bool>("javaEnabled", new object[0]);
	}

	public void AddIdleObserver(nsISupports aIdleObserver)
	{
		CallVoidMethod("addIdleObserver", aIdleObserver);
	}

	public void RemoveIdleObserver(nsISupports aIdleObserver)
	{
		CallVoidMethod("removeIdleObserver", aIdleObserver);
	}

	public nsISupports RequestWakeLock(string aTopic)
	{
		return CallMethod<nsISupports>("requestWakeLock", new object[1] { aTopic });
	}

	public nsISupports GetDeviceStorage(string type)
	{
		return CallMethod<nsISupports>("getDeviceStorage", new object[1] { type });
	}

	public nsISupports[] GetDeviceStorages(string type)
	{
		return CallMethod<nsISupports[]>("getDeviceStorages", new object[1] { type });
	}

	public nsISupports GetDeviceStorageByNameAndType(string name, string type)
	{
		return CallMethod<nsISupports>("getDeviceStorageByNameAndType", new object[2] { name, type });
	}

	public bool MozHasPendingMessage(string type)
	{
		return CallMethod<bool>("mozHasPendingMessage", new object[1] { type });
	}

	public void MozSetMessageHandlerPromise(Promise<object> promise)
	{
		CallVoidMethod("mozSetMessageHandlerPromise", promise);
	}

	public Promise<nsISupports[]> GetVRDevices()
	{
		return CallMethod<Promise<nsISupports[]>>("getVRDevices", new object[0]);
	}

	public bool SendBeacon(string url)
	{
		return CallMethod<bool>("sendBeacon", new object[1] { url });
	}

	public bool SendBeacon(string url, WebIDLUnion<IntPtr, nsIDOMBlob, string, nsIDOMFormData> data)
	{
		return CallMethod<bool>("sendBeacon", new object[2] { url, data });
	}
}
