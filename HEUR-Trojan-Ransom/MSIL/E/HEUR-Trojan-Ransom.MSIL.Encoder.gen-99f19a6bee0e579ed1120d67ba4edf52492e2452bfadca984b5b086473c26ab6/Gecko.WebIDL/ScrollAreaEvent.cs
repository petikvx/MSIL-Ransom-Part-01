namespace Gecko.WebIDL;

public class ScrollAreaEvent : WebIDLBase
{
	public float X => GetProperty<float>("x");

	public float Y => GetProperty<float>("y");

	public float Width => GetProperty<float>("width");

	public float Height => GetProperty<float>("height");

	public ScrollAreaEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void InitScrollAreaEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, float x, float y, float width, float height)
	{
		CallVoidMethod("initScrollAreaEvent", type, canBubble, cancelable, view, detail, x, y, width, height);
	}
}
