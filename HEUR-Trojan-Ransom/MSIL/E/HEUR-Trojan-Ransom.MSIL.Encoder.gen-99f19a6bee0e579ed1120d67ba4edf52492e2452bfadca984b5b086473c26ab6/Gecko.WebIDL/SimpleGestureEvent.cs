namespace Gecko.WebIDL;

public class SimpleGestureEvent : WebIDLBase
{
	public uint AllowedDirections
	{
		get
		{
			return GetProperty<uint>("allowedDirections");
		}
		set
		{
			SetProperty("allowedDirections", value);
		}
	}

	public uint Direction => GetProperty<uint>("direction");

	public double Delta => GetProperty<double>("delta");

	public uint ClickCount => GetProperty<uint>("clickCount");

	public SimpleGestureEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void InitSimpleGestureEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, ushort buttonArg, nsISupports relatedTargetArg, uint allowedDirectionsArg, uint directionArg, double deltaArg, uint clickCount)
	{
		CallVoidMethod("initSimpleGestureEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg, allowedDirectionsArg, directionArg, deltaArg, clickCount);
	}
}
