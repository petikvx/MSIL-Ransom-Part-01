namespace PreEmptive.Analytics.Common.Tags;

public struct Attribute
{
	public string Name;

	public string Value;

	public Attribute(string name, string value)
	{
		Name = name;
		Value = value;
	}
}
