namespace Gecko.WebIDL;

public class FontFace : WebIDLBase
{
	public string Family
	{
		get
		{
			return GetProperty<string>("family");
		}
		set
		{
			SetProperty("family", value);
		}
	}

	public string Style
	{
		get
		{
			return GetProperty<string>("style");
		}
		set
		{
			SetProperty("style", value);
		}
	}

	public string Weight
	{
		get
		{
			return GetProperty<string>("weight");
		}
		set
		{
			SetProperty("weight", value);
		}
	}

	public string Stretch
	{
		get
		{
			return GetProperty<string>("stretch");
		}
		set
		{
			SetProperty("stretch", value);
		}
	}

	public string UnicodeRange
	{
		get
		{
			return GetProperty<string>("unicodeRange");
		}
		set
		{
			SetProperty("unicodeRange", value);
		}
	}

	public string Variant
	{
		get
		{
			return GetProperty<string>("variant");
		}
		set
		{
			SetProperty("variant", value);
		}
	}

	public string FeatureSettings
	{
		get
		{
			return GetProperty<string>("featureSettings");
		}
		set
		{
			SetProperty("featureSettings", value);
		}
	}

	public FontFaceLoadStatus Status => GetProperty<FontFaceLoadStatus>("status");

	public Promise<nsISupports> Loaded => GetProperty<Promise<nsISupports>>("loaded");

	public FontFace(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports> Load()
	{
		return CallMethod<Promise<nsISupports>>("load", new object[0]);
	}
}
