namespace Gecko.WebIDL;

public class SVGLength : WebIDLBase
{
	public ushort UnitType => GetProperty<ushort>("unitType");

	public float Value
	{
		get
		{
			return GetProperty<float>("value");
		}
		set
		{
			SetProperty("value", value);
		}
	}

	public float ValueInSpecifiedUnits
	{
		get
		{
			return GetProperty<float>("valueInSpecifiedUnits");
		}
		set
		{
			SetProperty("valueInSpecifiedUnits", value);
		}
	}

	public string ValueAsString
	{
		get
		{
			return GetProperty<string>("valueAsString");
		}
		set
		{
			SetProperty("valueAsString", value);
		}
	}

	public SVGLength(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void NewValueSpecifiedUnits(ushort unitType, float valueInSpecifiedUnits)
	{
		CallVoidMethod("newValueSpecifiedUnits", unitType, valueInSpecifiedUnits);
	}

	public void ConvertToSpecifiedUnits(ushort unitType)
	{
		CallVoidMethod("convertToSpecifiedUnits", unitType);
	}
}
