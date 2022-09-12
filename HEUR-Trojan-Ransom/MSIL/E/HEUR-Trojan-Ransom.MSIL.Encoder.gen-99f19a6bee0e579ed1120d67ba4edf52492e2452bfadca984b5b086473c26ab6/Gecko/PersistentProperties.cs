namespace Gecko;

public class PersistentProperties : Properties
{
	private nsIPersistentProperties _persistentProperties;

	internal PersistentProperties(nsIPersistentProperties persistentProperties)
		: base(persistentProperties)
	{
		_persistentProperties = persistentProperties;
	}
}
