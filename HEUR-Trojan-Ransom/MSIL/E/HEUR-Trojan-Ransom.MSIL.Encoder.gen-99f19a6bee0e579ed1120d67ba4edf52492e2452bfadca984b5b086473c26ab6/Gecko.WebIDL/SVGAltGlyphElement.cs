namespace Gecko.WebIDL;

public class SVGAltGlyphElement : WebIDLBase
{
	public string GlyphRef
	{
		get
		{
			return GetProperty<string>("glyphRef");
		}
		set
		{
			SetProperty("glyphRef", value);
		}
	}

	public string Format
	{
		get
		{
			return GetProperty<string>("format");
		}
		set
		{
			SetProperty("format", value);
		}
	}

	public SVGAltGlyphElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
