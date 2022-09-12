namespace Gecko.WebIDL;

public class PerformanceCompositeTiming : WebIDLBase
{
	public uint SourceFrameNumber => GetProperty<uint>("sourceFrameNumber");

	public PerformanceCompositeTiming(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
