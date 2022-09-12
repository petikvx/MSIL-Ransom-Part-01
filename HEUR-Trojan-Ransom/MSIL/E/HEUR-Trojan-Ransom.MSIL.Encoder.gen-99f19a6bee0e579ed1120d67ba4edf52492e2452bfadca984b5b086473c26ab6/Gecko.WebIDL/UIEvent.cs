namespace Gecko.WebIDL;

public class UIEvent : WebIDLBase
{
	public nsIDOMWindow View => GetProperty<nsIDOMWindow>("view");

	public int Detail => GetProperty<int>("detail");

	public int LayerX => GetProperty<int>("layerX");

	public int LayerY => GetProperty<int>("layerY");

	public int PageX => GetProperty<int>("pageX");

	public int PageY => GetProperty<int>("pageY");

	public uint Which => GetProperty<uint>("which");

	public nsIDOMNode RangeParent => GetProperty<nsIDOMNode>("rangeParent");

	public int RangeOffset => GetProperty<int>("rangeOffset");

	public bool CancelBubble
	{
		get
		{
			return GetProperty<bool>("cancelBubble");
		}
		set
		{
			SetProperty("cancelBubble", value);
		}
	}

	public bool IsChar => GetProperty<bool>("isChar");

	public UIEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void InitUIEvent(string aType, bool aCanBubble, bool aCancelable, nsIDOMWindow aView, int aDetail)
	{
		CallVoidMethod("initUIEvent", aType, aCanBubble, aCancelable, aView, aDetail);
	}
}
