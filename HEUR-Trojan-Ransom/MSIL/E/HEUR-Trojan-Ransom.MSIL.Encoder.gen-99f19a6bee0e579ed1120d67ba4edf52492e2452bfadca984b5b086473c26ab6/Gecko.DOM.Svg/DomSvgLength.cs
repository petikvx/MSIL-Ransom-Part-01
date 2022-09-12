using Gecko.Interop;

namespace Gecko.DOM.Svg;

public class DomSvgLength
{
	private ComPtr<nsIDOMSVGLength> _domSvgLength;

	public SvgLengthType UnitType => (SvgLengthType)_domSvgLength.Instance.GetUnitTypeAttribute();

	public float Value
	{
		get
		{
			return _domSvgLength.Instance.GetValueAttribute();
		}
		set
		{
			_domSvgLength.Instance.SetValueAttribute(value);
		}
	}

	public float ValueInSpecifiedUnits
	{
		get
		{
			return _domSvgLength.Instance.GetValueInSpecifiedUnitsAttribute();
		}
		set
		{
			_domSvgLength.Instance.SetValueInSpecifiedUnitsAttribute(value);
		}
	}

	public string ValueAsString
	{
		get
		{
			return nsString.Get(_domSvgLength.Instance.GetValueAsStringAttribute);
		}
		set
		{
			nsString.Set(_domSvgLength.Instance.SetValueAsStringAttribute, value);
		}
	}

	private DomSvgLength(nsIDOMSVGLength domSvgLength)
	{
		_domSvgLength = new ComPtr<nsIDOMSVGLength>(domSvgLength);
	}

	public static DomSvgLength Create(nsIDOMSVGLength domSvgLength)
	{
		return new DomSvgLength(domSvgLength);
	}

	public void NewValueSpecifiedUnits(SvgLengthType unitType, float valueInSpecifiedUnits)
	{
		_domSvgLength.Instance.NewValueSpecifiedUnits((ushort)unitType, valueInSpecifiedUnits);
	}

	public void ConvertToSpecifiedUnits(SvgLengthType unitType)
	{
		_domSvgLength.Instance.ConvertToSpecifiedUnits((ushort)unitType);
	}
}
