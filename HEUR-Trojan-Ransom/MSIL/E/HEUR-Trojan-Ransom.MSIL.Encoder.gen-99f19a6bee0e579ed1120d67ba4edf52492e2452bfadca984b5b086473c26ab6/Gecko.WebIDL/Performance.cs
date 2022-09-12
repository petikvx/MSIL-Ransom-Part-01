namespace Gecko.WebIDL;

public class Performance : WebIDLBase
{
	public nsISupports Timing => GetProperty<nsISupports>("timing");

	public nsISupports Navigation => GetProperty<nsISupports>("navigation");

	public object MozMemory => GetProperty<object>("mozMemory");

	public Performance(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public double Now()
	{
		return CallMethod<double>("now", new object[0]);
	}

	public double TranslateTime(double time, WebIDLUnion<nsIDOMWindow, nsISupports, nsISupports, nsISupports> timeSource)
	{
		return CallMethod<double>("translateTime", new object[2] { time, timeSource });
	}

	public nsISupports[] GetEntries()
	{
		return CallMethod<nsISupports[]>("getEntries", new object[0]);
	}

	public nsISupports[] GetEntriesByType(string entryType)
	{
		return CallMethod<nsISupports[]>("getEntriesByType", new object[1] { entryType });
	}

	public nsISupports[] GetEntriesByName(string name)
	{
		return CallMethod<nsISupports[]>("getEntriesByName", new object[1] { name });
	}

	public nsISupports[] GetEntriesByName(string name, string entryType)
	{
		return CallMethod<nsISupports[]>("getEntriesByName", new object[2] { name, entryType });
	}

	public void ClearResourceTimings()
	{
		CallVoidMethod("clearResourceTimings");
	}

	public void SetResourceTimingBufferSize(uint maxSize)
	{
		CallVoidMethod("setResourceTimingBufferSize", maxSize);
	}

	public void Mark(string markName)
	{
		CallVoidMethod("mark", markName);
	}

	public void ClearMarks()
	{
		CallVoidMethod("clearMarks");
	}

	public void ClearMarks(string markName)
	{
		CallVoidMethod("clearMarks", markName);
	}

	public void Measure(string measureName)
	{
		CallVoidMethod("measure", measureName);
	}

	public void Measure(string measureName, string startMark)
	{
		CallVoidMethod("measure", measureName, startMark);
	}

	public void Measure(string measureName, string startMark, string endMark)
	{
		CallVoidMethod("measure", measureName, startMark, endMark);
	}

	public void ClearMeasures()
	{
		CallVoidMethod("clearMeasures");
	}

	public void ClearMeasures(string measureName)
	{
		CallVoidMethod("clearMeasures", measureName);
	}
}
