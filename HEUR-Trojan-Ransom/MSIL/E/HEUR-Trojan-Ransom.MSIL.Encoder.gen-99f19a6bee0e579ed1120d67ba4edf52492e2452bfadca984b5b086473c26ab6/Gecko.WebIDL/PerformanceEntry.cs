namespace Gecko.WebIDL;

public class PerformanceEntry : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public string EntryType => GetProperty<string>("entryType");

	public double StartTime => GetProperty<double>("startTime");

	public double Duration => GetProperty<double>("duration");

	public PerformanceEntry(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
