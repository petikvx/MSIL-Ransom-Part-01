namespace Gecko.WebIDL;

public class SVGTextContentElement : WebIDLBase
{
	public nsISupports TextLength => GetProperty<nsISupports>("textLength");

	public nsISupports LengthAdjust => GetProperty<nsISupports>("lengthAdjust");

	public SVGTextContentElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public int GetNumberOfChars()
	{
		return CallMethod<int>("getNumberOfChars", new object[0]);
	}

	public float GetComputedTextLength()
	{
		return CallMethod<float>("getComputedTextLength", new object[0]);
	}

	public float GetSubStringLength(uint charnum, uint nchars)
	{
		return CallMethod<float>("getSubStringLength", new object[2] { charnum, nchars });
	}

	public nsISupports GetStartPositionOfChar(uint charnum)
	{
		return CallMethod<nsISupports>("getStartPositionOfChar", new object[1] { charnum });
	}

	public nsISupports GetEndPositionOfChar(uint charnum)
	{
		return CallMethod<nsISupports>("getEndPositionOfChar", new object[1] { charnum });
	}

	public nsISupports GetExtentOfChar(uint charnum)
	{
		return CallMethod<nsISupports>("getExtentOfChar", new object[1] { charnum });
	}

	public float GetRotationOfChar(uint charnum)
	{
		return CallMethod<float>("getRotationOfChar", new object[1] { charnum });
	}

	public int GetCharNumAtPosition(nsISupports point)
	{
		return CallMethod<int>("getCharNumAtPosition", new object[1] { point });
	}

	public void SelectSubString(uint charnum, uint nchars)
	{
		CallVoidMethod("selectSubString", charnum, nchars);
	}
}
