namespace Gecko.WebIDL;

public class CSSStyleDeclaration : WebIDLBase
{
	public string CssText
	{
		get
		{
			return GetProperty<string>("cssText");
		}
		set
		{
			SetProperty("cssText", value);
		}
	}

	public uint Length => GetProperty<uint>("length");

	public nsISupports ParentRule => GetProperty<nsISupports>("parentRule");

	public CSSStyleDeclaration(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public string GetPropertyValue(string property)
	{
		return CallMethod<string>("getPropertyValue", new object[1] { property });
	}

	public nsISupports GetPropertyCSSValue(string property)
	{
		return CallMethod<nsISupports>("getPropertyCSSValue", new object[1] { property });
	}

	public string GetPropertyPriority(string property)
	{
		return CallMethod<string>("getPropertyPriority", new object[1] { property });
	}

	public void SetProperty(string property, string value)
	{
		CallVoidMethod("setProperty", property, value);
	}

	public void SetProperty(string property, string value, string priority)
	{
		CallVoidMethod("setProperty", property, value, priority);
	}

	public string RemoveProperty(string property)
	{
		return CallMethod<string>("removeProperty", new object[1] { property });
	}

	public string GetAuthoredPropertyValue(string property)
	{
		return CallMethod<string>("getAuthoredPropertyValue", new object[1] { property });
	}
}
