namespace Gecko.WebIDL;

public class TimeRanges : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public TimeRanges(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public double Start(uint index)
	{
		return CallMethod<double>("start", new object[1] { index });
	}

	public double End(uint index)
	{
		return CallMethod<double>("end", new object[1] { index });
	}
}
