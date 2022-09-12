namespace Gecko.WebIDL;

public class VTTCue : WebIDLBase
{
	public nsISupports Region
	{
		get
		{
			return GetProperty<nsISupports>("region");
		}
		set
		{
			SetProperty("region", value);
		}
	}

	public DirectionSetting Vertical
	{
		get
		{
			return GetProperty<DirectionSetting>("vertical");
		}
		set
		{
			SetProperty("vertical", value);
		}
	}

	public bool SnapToLines
	{
		get
		{
			return GetProperty<bool>("snapToLines");
		}
		set
		{
			SetProperty("snapToLines", value);
		}
	}

	public WebIDLUnion<int, AutoKeyword> Line
	{
		get
		{
			return GetProperty<WebIDLUnion<int, AutoKeyword>>("line");
		}
		set
		{
			SetProperty("line", value);
		}
	}

	public AlignSetting LineAlign
	{
		get
		{
			return GetProperty<AlignSetting>("lineAlign");
		}
		set
		{
			SetProperty("lineAlign", value);
		}
	}

	public int Position
	{
		get
		{
			return GetProperty<int>("position");
		}
		set
		{
			SetProperty("position", value);
		}
	}

	public AlignSetting PositionAlign
	{
		get
		{
			return GetProperty<AlignSetting>("positionAlign");
		}
		set
		{
			SetProperty("positionAlign", value);
		}
	}

	public int Size
	{
		get
		{
			return GetProperty<int>("size");
		}
		set
		{
			SetProperty("size", value);
		}
	}

	public AlignSetting Align
	{
		get
		{
			return GetProperty<AlignSetting>("align");
		}
		set
		{
			SetProperty("align", value);
		}
	}

	public string Text
	{
		get
		{
			return GetProperty<string>("text");
		}
		set
		{
			SetProperty("text", value);
		}
	}

	public nsISupports DisplayState
	{
		get
		{
			return GetProperty<nsISupports>("displayState");
		}
		set
		{
			SetProperty("displayState", value);
		}
	}

	public bool HasBeenReset => GetProperty<bool>("hasBeenReset");

	public VTTCue(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetCueAsHTML()
	{
		return CallMethod<nsISupports>("getCueAsHTML", new object[0]);
	}
}
