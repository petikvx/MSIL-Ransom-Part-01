namespace Business.Data;

public struct DataParameter
{
	public string Name { get; private set; }

	public object Value { get; private set; }

	public DataParameter(string name, object value)
	{
		Name = name;
		Value = value;
	}
}
