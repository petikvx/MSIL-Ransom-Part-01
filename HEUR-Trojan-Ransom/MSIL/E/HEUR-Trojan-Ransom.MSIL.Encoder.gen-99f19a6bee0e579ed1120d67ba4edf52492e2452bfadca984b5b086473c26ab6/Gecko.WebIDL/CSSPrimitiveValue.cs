namespace Gecko.WebIDL;

public class CSSPrimitiveValue : WebIDLBase
{
	public ushort PrimitiveType => GetProperty<ushort>("primitiveType");

	public CSSPrimitiveValue(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SetFloatValue(ushort unitType, float floatValue)
	{
		CallVoidMethod("setFloatValue", unitType, floatValue);
	}

	public float GetFloatValue(ushort unitType)
	{
		return CallMethod<float>("getFloatValue", new object[1] { unitType });
	}

	public void SetStringValue(ushort stringType, string stringValue)
	{
		CallVoidMethod("setStringValue", stringType, stringValue);
	}

	public string GetStringValue()
	{
		return CallMethod<string>("getStringValue", new object[0]);
	}

	public nsISupports GetCounterValue()
	{
		return CallMethod<nsISupports>("getCounterValue", new object[0]);
	}

	public nsISupports GetRectValue()
	{
		return CallMethod<nsISupports>("getRectValue", new object[0]);
	}

	public nsISupports GetRGBColorValue()
	{
		return CallMethod<nsISupports>("getRGBColorValue", new object[0]);
	}
}
