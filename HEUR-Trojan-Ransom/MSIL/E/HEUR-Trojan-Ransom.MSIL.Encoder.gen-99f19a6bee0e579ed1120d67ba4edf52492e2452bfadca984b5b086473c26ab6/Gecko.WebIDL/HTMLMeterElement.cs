namespace Gecko.WebIDL;

public class HTMLMeterElement : WebIDLBase
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

	public double Min
	{
		get
		{
			return GetProperty<double>("min");
		}
		set
		{
			SetProperty("min", value);
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

	public double Low
	{
		get
		{
			return GetProperty<double>("low");
		}
		set
		{
			SetProperty("low", value);
		}
	}

	public double High
	{
		get
		{
			return GetProperty<double>("high");
		}
		set
		{
			SetProperty("high", value);
		}
	}

	public double Optimum
	{
		get
		{
			return GetProperty<double>("optimum");
		}
		set
		{
			SetProperty("optimum", value);
		}
	}

	public HTMLMeterElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
