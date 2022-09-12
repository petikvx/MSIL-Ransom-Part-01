using Gecko.Interop;

namespace Gecko;

public sealed class WritableVariant : Variant
{
	private ComPtr<nsIWritableVariant> _writableVariant;

	public bool Writable
	{
		get
		{
			return _writableVariant.Instance.GetWritableAttribute();
		}
		set
		{
			_writableVariant.Instance.SetWritableAttribute(value);
		}
	}

	internal WritableVariant(nsIWritableVariant writableVariant)
		: base(writableVariant)
	{
		_writableVariant = new ComPtr<nsIWritableVariant>(writableVariant);
	}

	public void SetString(string value)
	{
		_writableVariant.Instance.SetAsWString(value);
	}

	public static WritableVariant Create()
	{
		return new WritableVariant(Xpcom.CreateInstance<nsIWritableVariant>("@mozilla.org/variant;1"));
	}
}
