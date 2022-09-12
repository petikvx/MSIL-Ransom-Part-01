using Gecko.Interop;

namespace Gecko;

public class Variant
{
	private ComPtr<nsIVariant> _variant;

	public object Value => GetValue();

	internal Variant()
	{
	}

	internal Variant(nsIVariant variant)
	{
		_variant = new ComPtr<nsIVariant>(variant);
	}

	public static Variant Create(nsIVariant variant)
	{
		nsIWritableVariant nsIWritableVariant2 = Xpcom.QueryInterface<nsIWritableVariant>(variant);
		return (nsIWritableVariant2 != null) ? new WritableVariant(nsIWritableVariant2) : new Variant(variant);
	}

	protected object GetValue()
	{
		return _variant.Instance.GetDataTypeAttribute() switch
		{
			0 => _variant.Instance.GetAsInt8(), 
			1 => _variant.Instance.GetAsInt16(), 
			2 => _variant.Instance.GetAsInt32(), 
			3 => _variant.Instance.GetAsInt64(), 
			_ => null, 
		};
	}

	public sbyte GetAsInt8()
	{
		return (sbyte)_variant.Instance.GetAsInt8();
	}
}
