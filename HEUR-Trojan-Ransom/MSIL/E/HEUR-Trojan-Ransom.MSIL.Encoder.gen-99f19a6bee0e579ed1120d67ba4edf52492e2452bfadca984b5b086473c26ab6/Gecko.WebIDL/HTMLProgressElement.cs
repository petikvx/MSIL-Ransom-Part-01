namespace Gecko.WebIDL;

public class HTMLProgressElement : WebIDLBase
{
	public double Value
	{
		get
		{
			return GetProperty<double>("value");
		}
		set
		{
			SetProperty("value", value);
		}
	}

	public double Max
	{
		get
		{
			return GetProperty<double>("max");
		}
		set
		{
			SetProperty("max", value);
		}
	}

	public double Position => GetProperty<double>("position");

	public HTMLProgressElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
