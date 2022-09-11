using System;

namespace Complex.NTFSDirect;

public class FileEntry
{
	private string _name;

	private ulong _parentFrn;

	public string Name
	{
		get
		{
			return _name;
		}
		set
		{
			_name = value;
		}
	}

	public ulong ParentFrn
	{
		get
		{
			return _parentFrn;
		}
		set
		{
			_parentFrn = value;
		}
	}

	public FileEntry(string name, ulong parentFrn)
	{
		if (name == null || name.Length <= 0)
		{
			throw new ArgumentException("Invalid argument: null or Length = zero", "name");
		}
		_name = name;
		_parentFrn = parentFrn;
	}
}
