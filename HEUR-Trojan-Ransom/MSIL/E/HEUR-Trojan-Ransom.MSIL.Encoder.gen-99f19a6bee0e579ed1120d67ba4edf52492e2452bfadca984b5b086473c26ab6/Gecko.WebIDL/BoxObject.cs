namespace Gecko.WebIDL;

public class BoxObject : WebIDLBase
{
	public nsIDOMElement Element => GetProperty<nsIDOMElement>("element");

	public int X => GetProperty<int>("x");

	public int Y => GetProperty<int>("y");

	public int ScreenX => GetProperty<int>("screenX");

	public int ScreenY => GetProperty<int>("screenY");

	public int Width => GetProperty<int>("width");

	public int Height => GetProperty<int>("height");

	public nsIDOMElement ParentBox => GetProperty<nsIDOMElement>("parentBox");

	public nsIDOMElement FirstChild => GetProperty<nsIDOMElement>("firstChild");

	public nsIDOMElement LastChild => GetProperty<nsIDOMElement>("lastChild");

	public nsIDOMElement NextSibling => GetProperty<nsIDOMElement>("nextSibling");

	public nsIDOMElement PreviousSibling => GetProperty<nsIDOMElement>("previousSibling");

	public BoxObject(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetPropertyAsSupports(string propertyName)
	{
		return CallMethod<nsISupports>("getPropertyAsSupports", new object[1] { propertyName });
	}

	public void SetPropertyAsSupports(string propertyName, nsISupports value)
	{
		CallVoidMethod("setPropertyAsSupports", propertyName, value);
	}

	public string GetProperty(string propertyName)
	{
		return CallMethod<string>("getProperty", new object[1] { propertyName });
	}

	public void SetProperty(string propertyName, string propertyValue)
	{
		CallVoidMethod("setProperty", propertyName, propertyValue);
	}

	public void RemoveProperty(string propertyName)
	{
		CallVoidMethod("removeProperty", propertyName);
	}
}
