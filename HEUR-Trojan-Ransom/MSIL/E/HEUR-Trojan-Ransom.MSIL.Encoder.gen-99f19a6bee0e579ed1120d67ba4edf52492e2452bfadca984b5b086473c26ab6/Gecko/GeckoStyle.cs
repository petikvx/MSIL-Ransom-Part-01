namespace Gecko;

public class GeckoStyle
{
	private nsIDOMCSSStyleDeclaration StyleDelcaration;

	public string CssText
	{
		get
		{
			return nsString.Get(StyleDelcaration.GetCssTextAttribute);
		}
		set
		{
			nsString.Set(StyleDelcaration.SetCssTextAttribute, value);
		}
	}

	public uint Length => StyleDelcaration.GetLengthAttribute();

	public string this[int index]
	{
		get
		{
			nsAString nsAString2 = new nsAString();
			StyleDelcaration.Item((uint)index, nsAString2);
			return nsAString2.ToString();
		}
	}

	internal GeckoStyle(nsIDOMCSSStyleDeclaration styleDeclaration)
	{
		StyleDelcaration = styleDeclaration;
	}

	internal static GeckoStyle Create(nsIDOMCSSStyleDeclaration styleDeclaration)
	{
		return (styleDeclaration == null) ? null : new GeckoStyle(styleDeclaration);
	}

	public string GetPropertyValue(string propertyName)
	{
		nsAString nsAString2 = new nsAString();
		StyleDelcaration.GetPropertyValue(new nsAString(propertyName), nsAString2);
		return nsAString2.ToString();
	}

	public void SetPropertyValue(string propertyName, string value)
	{
		StyleDelcaration.SetProperty(new nsAString(propertyName), new nsAString(value), new nsAString());
	}

	public void SetPropertyValue(string propertyName, string value, string priority)
	{
		StyleDelcaration.SetProperty(new nsAString(propertyName), new nsAString(value), new nsAString(priority));
	}
}
