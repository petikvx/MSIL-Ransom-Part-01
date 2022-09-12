namespace Gecko.WebIDL;

public class PerformanceRenderTiming : WebIDLBase
{
	public uint SourceFrameNumber => GetProperty<uint>("sourceFrameNumber");

	public PerformanceRenderTiming(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
