namespace Gecko.WebIDL;

public class MenuBoxObject : WebIDLBase
{
	public nsIDOMElement ActiveChild
	{
		get
		{
			return GetProperty<nsIDOMElement>("activeChild");
		}
		set
		{
			SetProperty("activeChild", value);
		}
	}

	public bool OpenedWithKey => GetProperty<bool>("openedWithKey");

	public MenuBoxObject(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void OpenMenu(bool openFlag)
	{
		CallVoidMethod("openMenu", openFlag);
	}

	public bool HandleKeyPress(nsISupports keyEvent)
	{
		return CallMethod<bool>("handleKeyPress", new object[1] { keyEvent });
	}
}
