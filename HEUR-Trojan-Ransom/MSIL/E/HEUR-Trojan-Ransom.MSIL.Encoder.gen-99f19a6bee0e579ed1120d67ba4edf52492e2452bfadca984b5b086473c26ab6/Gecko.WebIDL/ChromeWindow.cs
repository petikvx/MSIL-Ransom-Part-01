namespace Gecko.WebIDL;

public class ChromeWindow : WebIDLBase
{
	public ushort WindowState => GetProperty<ushort>("windowState");

	public nsIBrowserDOMWindow BrowserDOMWindow
	{
		get
		{
			return GetProperty<nsIBrowserDOMWindow>("browserDOMWindow");
		}
		set
		{
			SetProperty("browserDOMWindow", value);
		}
	}

	public nsISupports MessageManager => GetProperty<nsISupports>("messageManager");

	public ChromeWindow(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void GetAttention()
	{
		CallVoidMethod("getAttention");
	}

	public void GetAttentionWithCycleCount(int aCycleCount)
	{
		CallVoidMethod("getAttentionWithCycleCount", aCycleCount);
	}

	public void SetCursor(string cursor)
	{
		CallVoidMethod("setCursor", cursor);
	}

	public void Maximize()
	{
		CallVoidMethod("maximize");
	}

	public void Minimize()
	{
		CallVoidMethod("minimize");
	}

	public void Restore()
	{
		CallVoidMethod("restore");
	}

	public void NotifyDefaultButtonLoaded(nsIDOMElement defaultButton)
	{
		CallVoidMethod("notifyDefaultButtonLoaded", defaultButton);
	}

	public nsISupports GetGroupMessageManager(string aGroup)
	{
		return CallMethod<nsISupports>("getGroupMessageManager", new object[1] { aGroup });
	}

	public void BeginWindowMove(nsIDOMEvent mouseDownEvent)
	{
		CallVoidMethod("beginWindowMove", mouseDownEvent);
	}

	public void BeginWindowMove(nsIDOMEvent mouseDownEvent, nsIDOMElement panel)
	{
		CallVoidMethod("beginWindowMove", mouseDownEvent, panel);
	}
}
