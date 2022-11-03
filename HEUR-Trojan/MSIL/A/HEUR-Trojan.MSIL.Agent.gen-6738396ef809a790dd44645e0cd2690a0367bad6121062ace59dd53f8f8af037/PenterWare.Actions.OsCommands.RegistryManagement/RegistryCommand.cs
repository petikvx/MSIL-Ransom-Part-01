namespace PenterWare.Actions.OsCommands.RegistryManagement;

public class RegistryCommand
{
	private string _path;

	private string _key;

	private string _type;

	private string _value;

	private bool _create;

	public bool Create
	{
		get
		{
			return _create;
		}
		set
		{
			_create = value;
		}
	}

	public string Path
	{
		get
		{
			return _path;
		}
		set
		{
			_path = value;
		}
	}

	public string Key
	{
		get
		{
			return _key;
		}
		set
		{
			_key = value;
		}
	}

	public string Type
	{
		get
		{
			return _type;
		}
		set
		{
			_type = value;
		}
	}

	public string Value
	{
		get
		{
			return _value;
		}
		set
		{
			_value = value;
		}
	}

	public RegistryCommand(string path = null, string key = null, string type = null, string value = null, bool create = false)
	{
		_path = path;
		_key = key;
		_type = type;
		_value = value;
		_create = create;
	}
}
