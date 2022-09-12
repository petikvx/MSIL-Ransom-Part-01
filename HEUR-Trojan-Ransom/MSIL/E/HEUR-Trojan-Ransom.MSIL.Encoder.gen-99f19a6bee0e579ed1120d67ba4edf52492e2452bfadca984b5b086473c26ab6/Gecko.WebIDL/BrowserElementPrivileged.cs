namespace Gecko.WebIDL;

public class BrowserElementPrivileged : WebIDLBase
{
	public nsISupports[] AllowedAudioChannels => GetProperty<nsISupports[]>("allowedAudioChannels");

	public BrowserElementPrivileged(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SendMouseEvent(string type, uint x, uint y, uint button, uint clickCount, uint modifiers)
	{
		CallVoidMethod("sendMouseEvent", type, x, y, button, clickCount, modifiers);
	}

	public void SendTouchEvent(string type, uint[] identifiers, int[] x, int[] y, uint[] rx, uint[] ry, float[] rotationAngles, float[] forces, uint count, uint modifiers)
	{
		CallVoidMethod("sendTouchEvent", type, identifiers, x, y, rx, ry, rotationAngles, forces, count, modifiers);
	}

	public void GoBack()
	{
		CallVoidMethod("goBack");
	}

	public void GoForward()
	{
		CallVoidMethod("goForward");
	}

	public void Reload()
	{
		CallVoidMethod("reload");
	}

	public void Reload(bool hardReload)
	{
		CallVoidMethod("reload", hardReload);
	}

	public void Stop()
	{
		CallVoidMethod("stop");
	}

	public nsISupports Download(string url)
	{
		return CallMethod<nsISupports>("download", new object[1] { url });
	}

	public nsISupports Download(string url, object options)
	{
		return CallMethod<nsISupports>("download", new object[2] { url, options });
	}

	public nsISupports PurgeHistory()
	{
		return CallMethod<nsISupports>("purgeHistory", new object[0]);
	}

	public nsISupports GetScreenshot(uint width, uint height)
	{
		return CallMethod<nsISupports>("getScreenshot", new object[2] { width, height });
	}

	public nsISupports GetScreenshot(uint width, uint height, string mimeType)
	{
		return CallMethod<nsISupports>("getScreenshot", new object[3] { width, height, mimeType });
	}

	public void Zoom(float zoom)
	{
		CallVoidMethod("zoom", zoom);
	}

	public nsISupports GetCanGoBack()
	{
		return CallMethod<nsISupports>("getCanGoBack", new object[0]);
	}

	public nsISupports GetCanGoForward()
	{
		return CallMethod<nsISupports>("getCanGoForward", new object[0]);
	}

	public nsISupports GetContentDimensions()
	{
		return CallMethod<nsISupports>("getContentDimensions", new object[0]);
	}

	public nsISupports SetInputMethodActive(bool isActive)
	{
		return CallMethod<nsISupports>("setInputMethodActive", new object[1] { isActive });
	}

	public void SetNFCFocus(bool isFocus)
	{
		CallVoidMethod("setNFCFocus", isFocus);
	}

	public void FindAll(string searchString, BrowserFindCaseSensitivity caseSensitivity)
	{
		CallVoidMethod("findAll", searchString, caseSensitivity);
	}

	public void FindNext(BrowserFindDirection direction)
	{
		CallVoidMethod("findNext", direction);
	}

	public void ClearMatch()
	{
		CallVoidMethod("clearMatch");
	}

	public nsISupports ExecuteScript(string script)
	{
		return CallMethod<nsISupports>("executeScript", new object[1] { script });
	}

	public nsISupports ExecuteScript(string script, object options)
	{
		return CallMethod<nsISupports>("executeScript", new object[2] { script, options });
	}

	public nsISupports GetStructuredData()
	{
		return CallMethod<nsISupports>("getStructuredData", new object[0]);
	}

	public nsISupports GetWebManifest()
	{
		return CallMethod<nsISupports>("getWebManifest", new object[0]);
	}

	public void Mute()
	{
		CallVoidMethod("mute");
	}

	public void Unmute()
	{
		CallVoidMethod("unmute");
	}

	public nsISupports GetMuted()
	{
		return CallMethod<nsISupports>("getMuted", new object[0]);
	}

	public void SetVolume(float volume)
	{
		CallVoidMethod("setVolume", volume);
	}

	public nsISupports GetVolume()
	{
		return CallMethod<nsISupports>("getVolume", new object[0]);
	}
}
