namespace Gecko.WebIDL;

public class PopupBoxObject : WebIDLBase
{
	public bool AutoPosition
	{
		get
		{
			return GetProperty<bool>("autoPosition");
		}
		set
		{
			SetProperty("autoPosition", value);
		}
	}

	public string PopupState => GetProperty<string>("popupState");

	public nsIDOMNode TriggerNode => GetProperty<nsIDOMNode>("triggerNode");

	public nsIDOMElement AnchorNode => GetProperty<nsIDOMElement>("anchorNode");

	public string AlignmentPosition => GetProperty<string>("alignmentPosition");

	public int AlignmentOffset => GetProperty<int>("alignmentOffset");

	public PopupBoxObject(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void ShowPopup(nsIDOMElement srcContent, nsIDOMElement popupContent, int xpos, int ypos)
	{
		CallVoidMethod("showPopup", srcContent, popupContent, xpos, ypos);
	}

	public void ShowPopup(nsIDOMElement srcContent, nsIDOMElement popupContent, int xpos, int ypos, string popupType)
	{
		CallVoidMethod("showPopup", srcContent, popupContent, xpos, ypos, popupType);
	}

	public void ShowPopup(nsIDOMElement srcContent, nsIDOMElement popupContent, int xpos, int ypos, string popupType, string anchorAlignment)
	{
		CallVoidMethod("showPopup", srcContent, popupContent, xpos, ypos, popupType, anchorAlignment);
	}

	public void ShowPopup(nsIDOMElement srcContent, nsIDOMElement popupContent, int xpos, int ypos, string popupType, string anchorAlignment, string popupAlignment)
	{
		CallVoidMethod("showPopup", srcContent, popupContent, xpos, ypos, popupType, anchorAlignment, popupAlignment);
	}

	public void HidePopup()
	{
		CallVoidMethod("hidePopup");
	}

	public void HidePopup(bool cancel)
	{
		CallVoidMethod("hidePopup", cancel);
	}

	public void EnableKeyboardNavigator(bool enableKeyboardNavigator)
	{
		CallVoidMethod("enableKeyboardNavigator", enableKeyboardNavigator);
	}

	public void EnableRollup(bool enableRollup)
	{
		CallVoidMethod("enableRollup", enableRollup);
	}

	public void SetConsumeRollupEvent(uint consume)
	{
		CallVoidMethod("setConsumeRollupEvent", consume);
	}

	public void SizeTo(int width, int height)
	{
		CallVoidMethod("sizeTo", width, height);
	}

	public void MoveTo(int left, int top)
	{
		CallVoidMethod("moveTo", left, top);
	}

	public void OpenPopup(nsIDOMElement anchorElement)
	{
		CallVoidMethod("openPopup", anchorElement);
	}

	public void OpenPopup(nsIDOMElement anchorElement, string position)
	{
		CallVoidMethod("openPopup", anchorElement, position);
	}

	public void OpenPopup(nsIDOMElement anchorElement, string position, int x)
	{
		CallVoidMethod("openPopup", anchorElement, position, x);
	}

	public void OpenPopup(nsIDOMElement anchorElement, string position, int x, int y)
	{
		CallVoidMethod("openPopup", anchorElement, position, x, y);
	}

	public void OpenPopup(nsIDOMElement anchorElement, string position, int x, int y, bool isContextMenu)
	{
		CallVoidMethod("openPopup", anchorElement, position, x, y, isContextMenu);
	}

	public void OpenPopup(nsIDOMElement anchorElement, string position, int x, int y, bool isContextMenu, bool attributesOverride)
	{
		CallVoidMethod("openPopup", anchorElement, position, x, y, isContextMenu, attributesOverride);
	}

	public void OpenPopup(nsIDOMElement anchorElement, string position, int x, int y, bool isContextMenu, bool attributesOverride, nsIDOMEvent triggerEvent)
	{
		CallVoidMethod("openPopup", anchorElement, position, x, y, isContextMenu, attributesOverride, triggerEvent);
	}

	public void OpenPopupAtScreen(int x, int y, bool isContextMenu, nsIDOMEvent triggerEvent)
	{
		CallVoidMethod("openPopupAtScreen", x, y, isContextMenu, triggerEvent);
	}

	public void OpenPopupAtScreenRect()
	{
		CallVoidMethod("openPopupAtScreenRect");
	}

	public void OpenPopupAtScreenRect(string position)
	{
		CallVoidMethod("openPopupAtScreenRect", position);
	}

	public void OpenPopupAtScreenRect(string position, int x)
	{
		CallVoidMethod("openPopupAtScreenRect", position, x);
	}

	public void OpenPopupAtScreenRect(string position, int x, int y)
	{
		CallVoidMethod("openPopupAtScreenRect", position, x, y);
	}

	public void OpenPopupAtScreenRect(string position, int x, int y, int width)
	{
		CallVoidMethod("openPopupAtScreenRect", position, x, y, width);
	}

	public void OpenPopupAtScreenRect(string position, int x, int y, int width, int height)
	{
		CallVoidMethod("openPopupAtScreenRect", position, x, y, width, height);
	}

	public void OpenPopupAtScreenRect(string position, int x, int y, int width, int height, bool isContextMenu)
	{
		CallVoidMethod("openPopupAtScreenRect", position, x, y, width, height, isContextMenu);
	}

	public void OpenPopupAtScreenRect(string position, int x, int y, int width, int height, bool isContextMenu, bool attributesOverride)
	{
		CallVoidMethod("openPopupAtScreenRect", position, x, y, width, height, isContextMenu, attributesOverride);
	}

	public void OpenPopupAtScreenRect(string position, int x, int y, int width, int height, bool isContextMenu, bool attributesOverride, nsIDOMEvent triggerEvent)
	{
		CallVoidMethod("openPopupAtScreenRect", position, x, y, width, height, isContextMenu, attributesOverride, triggerEvent);
	}

	public nsISupports GetOuterScreenRect()
	{
		return CallMethod<nsISupports>("getOuterScreenRect", new object[0]);
	}

	public void MoveToAnchor(nsIDOMElement anchorElement)
	{
		CallVoidMethod("moveToAnchor", anchorElement);
	}

	public void MoveToAnchor(nsIDOMElement anchorElement, string position)
	{
		CallVoidMethod("moveToAnchor", anchorElement, position);
	}

	public void MoveToAnchor(nsIDOMElement anchorElement, string position, int x)
	{
		CallVoidMethod("moveToAnchor", anchorElement, position, x);
	}

	public void MoveToAnchor(nsIDOMElement anchorElement, string position, int x, int y)
	{
		CallVoidMethod("moveToAnchor", anchorElement, position, x, y);
	}

	public void MoveToAnchor(nsIDOMElement anchorElement, string position, int x, int y, bool attributesOverride)
	{
		CallVoidMethod("moveToAnchor", anchorElement, position, x, y, attributesOverride);
	}
}
