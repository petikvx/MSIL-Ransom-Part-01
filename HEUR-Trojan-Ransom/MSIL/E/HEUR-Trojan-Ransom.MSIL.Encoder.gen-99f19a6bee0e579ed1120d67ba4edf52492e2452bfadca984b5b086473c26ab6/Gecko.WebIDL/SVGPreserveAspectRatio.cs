namespace Gecko.WebIDL;

public class SVGPreserveAspectRatio : WebIDLBase
{
	public ushort Align
	{
		get
		{
			return GetProperty<ushort>("align");
		}
		set
		{
			SetProperty("align", value);
		}
	}

	public ushort MeetOrSlice
	{
		get
		{
			return GetProperty<ushort>("meetOrSlice");
		}
		set
		{
			SetProperty("meetOrSlice", value);
		}
	}

	public SVGPreserveAspectRatio(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
