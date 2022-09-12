namespace Gecko.DOM;

public class GeckoCanvasElement : GeckoHtmlElement
{
	private nsIDOMHTMLCanvasElement DOMHTMLElement;

	public uint Width
	{
		get
		{
			return DOMHTMLElement.GetWidthAttribute();
		}
		set
		{
			DOMHTMLElement.SetWidthAttribute(value);
		}
	}

	public uint Height
	{
		get
		{
			return DOMHTMLElement.GetHeightAttribute();
		}
		set
		{
			DOMHTMLElement.SetHeightAttribute(value);
		}
	}

	internal GeckoCanvasElement(nsIDOMHTMLCanvasElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoCanvasElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLCanvasElement;
	}

	public string ToDataURL(string type)
	{
		using AutoJSContext autoJSContext = new AutoJSContext(AutoJSContext.SafeJSContext);
		using nsAString nsAString = new nsAString();
		using nsAString type2 = new nsAString(type);
		JsVal @params = default(JsVal);
		DOMHTMLElement.ToDataURL(type2, ref @params, autoJSContext.ContextPointer, nsAString);
		return nsAString.ToString();
	}
}
