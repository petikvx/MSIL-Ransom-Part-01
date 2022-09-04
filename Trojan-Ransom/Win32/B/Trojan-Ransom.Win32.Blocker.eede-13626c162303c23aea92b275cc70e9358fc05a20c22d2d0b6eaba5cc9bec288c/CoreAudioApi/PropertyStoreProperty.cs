namespace CoreAudioApi;

public class PropertyStoreProperty
{
	private PropertyKey _PropertyKey;

	private PropVariant _PropValue;

	public PropertyKey Key => _PropertyKey;

	public object Value => _PropValue.Value;

	internal PropertyStoreProperty(PropertyKey key, PropVariant value)
	{
		_PropertyKey = key;
		_PropValue = value;
	}
}
