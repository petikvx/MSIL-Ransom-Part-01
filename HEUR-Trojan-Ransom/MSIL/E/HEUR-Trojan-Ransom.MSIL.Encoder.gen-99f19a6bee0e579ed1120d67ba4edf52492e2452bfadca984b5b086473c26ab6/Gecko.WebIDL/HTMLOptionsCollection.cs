namespace Gecko.WebIDL;

public class HTMLOptionsCollection : WebIDLBase
{
	public uint Length
	{
		get
		{
			return GetProperty<uint>("length");
		}
		set
		{
			SetProperty("length", value);
		}
	}

	public int SelectedIndex
	{
		get
		{
			return GetProperty<int>("selectedIndex");
		}
		set
		{
			SetProperty("selectedIndex", value);
		}
	}

	public HTMLOptionsCollection(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
