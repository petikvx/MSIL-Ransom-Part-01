namespace Gecko.WebIDL;

public class PerformanceEntryEvent : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public string EntryType => GetProperty<string>("entryType");

	public double StartTime => GetProperty<double>("startTime");

	public double Duration => GetProperty<double>("duration");

	public double Epoch => GetProperty<double>("epoch");

	public string Origin => GetProperty<string>("origin");

	public PerformanceEntryEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
