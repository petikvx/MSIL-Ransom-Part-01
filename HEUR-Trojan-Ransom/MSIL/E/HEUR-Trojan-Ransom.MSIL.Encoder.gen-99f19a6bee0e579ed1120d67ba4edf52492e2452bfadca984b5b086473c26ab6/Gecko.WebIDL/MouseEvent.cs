namespace Gecko.WebIDL;

public class MouseEvent : WebIDLBase
{
	public int ScreenX => GetProperty<int>("screenX");

	public int ScreenY => GetProperty<int>("screenY");

	public int ClientX => GetProperty<int>("clientX");

	public int ClientY => GetProperty<int>("clientY");

	public int OffsetX => GetProperty<int>("offsetX");

	public int OffsetY => GetProperty<int>("offsetY");

	public bool CtrlKey => GetProperty<bool>("ctrlKey");

	public bool ShiftKey => GetProperty<bool>("shiftKey");

	public bool AltKey => GetProperty<bool>("altKey");

	public bool MetaKey => GetProperty<bool>("metaKey");

	public short Button => GetProperty<short>("button");

	public ushort Buttons => GetProperty<ushort>("buttons");

	public nsISupports RelatedTarget => GetProperty<nsISupports>("relatedTarget");

	public string Region => GetProperty<string>("region");

	public int MovementX => GetProperty<int>("movementX");

	public int MovementY => GetProperty<int>("movementY");

	public int MozMovementX => GetProperty<int>("mozMovementX");

	public int MozMovementY => GetProperty<int>("mozMovementY");

	public float MozPressure => GetProperty<float>("mozPressure");

	public ushort MozInputSource => GetProperty<ushort>("mozInputSource");

	public bool HitCluster => GetProperty<bool>("hitCluster");

	public MouseEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void InitMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, short buttonArg, nsISupports relatedTargetArg)
	{
		CallVoidMethod("initMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg);
	}

	public bool GetModifierState(string keyArg)
	{
		return CallMethod<bool>("getModifierState", new object[1] { keyArg });
	}

	public void InitNSMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, short buttonArg, nsISupports relatedTargetArg, float pressure, ushort inputSourceArg)
	{
		CallVoidMethod("initNSMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg, pressure, inputSourceArg);
	}
}
