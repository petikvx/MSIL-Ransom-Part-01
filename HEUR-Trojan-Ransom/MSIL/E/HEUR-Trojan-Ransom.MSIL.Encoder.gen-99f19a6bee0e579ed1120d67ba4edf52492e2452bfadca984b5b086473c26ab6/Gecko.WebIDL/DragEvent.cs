namespace Gecko.WebIDL;

public class DragEvent : WebIDLBase
{
	public nsISupports DataTransfer => GetProperty<nsISupports>("dataTransfer");

	public DragEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void InitDragEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow aView, int aDetail, int aScreenX, int aScreenY, int aClientX, int aClientY, bool aCtrlKey, bool aAltKey, bool aShiftKey, bool aMetaKey, ushort aButton, nsISupports aRelatedTarget, nsISupports aDataTransfer)
	{
		CallVoidMethod("initDragEvent", type, canBubble, cancelable, aView, aDetail, aScreenX, aScreenY, aClientX, aClientY, aCtrlKey, aAltKey, aShiftKey, aMetaKey, aButton, aRelatedTarget, aDataTransfer);
	}
}
