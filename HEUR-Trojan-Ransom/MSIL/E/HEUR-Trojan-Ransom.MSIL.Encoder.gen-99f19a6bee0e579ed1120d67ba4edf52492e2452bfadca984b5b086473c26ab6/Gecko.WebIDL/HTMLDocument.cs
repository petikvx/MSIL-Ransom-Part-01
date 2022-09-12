namespace Gecko.WebIDL;

public class HTMLDocument : WebIDLBase
{
	public string Domain
	{
		get
		{
			return GetProperty<string>("domain");
		}
		set
		{
			SetProperty("domain", value);
		}
	}

	public string Cookie
	{
		get
		{
			return GetProperty<string>("cookie");
		}
		set
		{
			SetProperty("cookie", value);
		}
	}

	public nsISupports Body
	{
		get
		{
			return GetProperty<nsISupports>("body");
		}
		set
		{
			SetProperty("body", value);
		}
	}

	public nsISupports Head => GetProperty<nsISupports>("head");

	public nsISupports Images => GetProperty<nsISupports>("images");

	public nsISupports Embeds => GetProperty<nsISupports>("embeds");

	public nsISupports Plugins => GetProperty<nsISupports>("plugins");

	public nsISupports Links => GetProperty<nsISupports>("links");

	public nsISupports Forms => GetProperty<nsISupports>("forms");

	public nsISupports Scripts => GetProperty<nsISupports>("scripts");

	public string DesignMode
	{
		get
		{
			return GetProperty<string>("designMode");
		}
		set
		{
			SetProperty("designMode", value);
		}
	}

	public string FgColor
	{
		get
		{
			return GetProperty<string>("fgColor");
		}
		set
		{
			SetProperty("fgColor", value);
		}
	}

	public string LinkColor
	{
		get
		{
			return GetProperty<string>("linkColor");
		}
		set
		{
			SetProperty("linkColor", value);
		}
	}

	public string VlinkColor
	{
		get
		{
			return GetProperty<string>("vlinkColor");
		}
		set
		{
			SetProperty("vlinkColor", value);
		}
	}

	public string AlinkColor
	{
		get
		{
			return GetProperty<string>("alinkColor");
		}
		set
		{
			SetProperty("alinkColor", value);
		}
	}

	public string BgColor
	{
		get
		{
			return GetProperty<string>("bgColor");
		}
		set
		{
			SetProperty("bgColor", value);
		}
	}

	public nsISupports Anchors => GetProperty<nsISupports>("anchors");

	public nsISupports Applets => GetProperty<nsISupports>("applets");

	public nsISupports All => GetProperty<nsISupports>("all");

	public int BlockedTrackingNodeCount => GetProperty<int>("blockedTrackingNodeCount");

	public nsISupports BlockedTrackingNodes => GetProperty<nsISupports>("blockedTrackingNodes");

	public HTMLDocument(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetElementsByName(string elementName)
	{
		return CallMethod<nsISupports>("getElementsByName", new object[1] { elementName });
	}

	public nsISupports GetItems()
	{
		return CallMethod<nsISupports>("getItems", new object[0]);
	}

	public nsISupports GetItems(string typeNames)
	{
		return CallMethod<nsISupports>("getItems", new object[1] { typeNames });
	}

	public nsIDOMDocument Open()
	{
		return CallMethod<nsIDOMDocument>("open", new object[0]);
	}

	public nsIDOMDocument Open(string type)
	{
		return CallMethod<nsIDOMDocument>("open", new object[1] { type });
	}

	public nsIDOMDocument Open(string type, string replace)
	{
		return CallMethod<nsIDOMDocument>("open", new object[2] { type, replace });
	}

	public nsIDOMWindow Open(string url, string name, string features)
	{
		return CallMethod<nsIDOMWindow>("open", new object[3] { url, name, features });
	}

	public nsIDOMWindow Open(string url, string name, string features, bool replace)
	{
		return CallMethod<nsIDOMWindow>("open", new object[4] { url, name, features, replace });
	}

	public void Close()
	{
		CallVoidMethod("close");
	}

	public void Write(string text)
	{
		CallVoidMethod("write", text);
	}

	public void Writeln(string text)
	{
		CallVoidMethod("writeln", text);
	}

	public bool ExecCommand(string commandId)
	{
		return CallMethod<bool>("execCommand", new object[1] { commandId });
	}

	public bool ExecCommand(string commandId, bool showUI)
	{
		return CallMethod<bool>("execCommand", new object[2] { commandId, showUI });
	}

	public bool ExecCommand(string commandId, bool showUI, string value)
	{
		return CallMethod<bool>("execCommand", new object[3] { commandId, showUI, value });
	}

	public bool QueryCommandEnabled(string commandId)
	{
		return CallMethod<bool>("queryCommandEnabled", new object[1] { commandId });
	}

	public bool QueryCommandIndeterm(string commandId)
	{
		return CallMethod<bool>("queryCommandIndeterm", new object[1] { commandId });
	}

	public bool QueryCommandState(string commandId)
	{
		return CallMethod<bool>("queryCommandState", new object[1] { commandId });
	}

	public bool QueryCommandSupported(string commandId)
	{
		return CallMethod<bool>("queryCommandSupported", new object[1] { commandId });
	}

	public string QueryCommandValue(string commandId)
	{
		return CallMethod<string>("queryCommandValue", new object[1] { commandId });
	}

	public void Clear()
	{
		CallVoidMethod("clear");
	}

	public nsISelection GetSelection()
	{
		return CallMethod<nsISelection>("getSelection", new object[0]);
	}

	public void CaptureEvents()
	{
		CallVoidMethod("captureEvents");
	}

	public void ReleaseEvents()
	{
		CallVoidMethod("releaseEvents");
	}
}
