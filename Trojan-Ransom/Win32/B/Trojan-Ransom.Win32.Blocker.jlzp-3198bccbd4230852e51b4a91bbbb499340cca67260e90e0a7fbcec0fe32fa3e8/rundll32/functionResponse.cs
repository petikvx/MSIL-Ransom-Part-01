namespace rundll32;

public class functionResponse
{
	private string _name;

	private functionVariable[] _arguments;

	public string Name => _name;

	public functionVariable[] Arguments => _arguments;

	public functionResponse(string Name, functionVariable[] Arguments)
	{
		_name = Name;
		_arguments = Arguments;
	}
}
