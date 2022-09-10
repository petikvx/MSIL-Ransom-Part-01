using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Vestris.ResourceLib;

public class GenericResource : Resource
{
	protected byte[] _data;

	public byte[] Data
	{
		get
		{
			return _data;
		}
		set
		{
			_data = value;
		}
	}

	public GenericResource(IntPtr hModule, IntPtr hResource, ResourceId type, ResourceId name, ushort language, int size)
		: base(hModule, hResource, type, name, language, size)
	{
	}

	public GenericResource(ResourceId type, ResourceId name, ushort language)
	{
		_type = type;
		_name = name;
		_language = language;
	}

	internal override IntPtr Read(IntPtr hModule, IntPtr lpRes)
	{
		if (_size > 0)
		{
			_data = new byte[_size];
			Marshal.Copy(lpRes, _data, 0, _data.Length);
		}
		return new IntPtr(lpRes.ToInt32() + _size);
	}

	internal override void Write(BinaryWriter w)
	{
		w.Write(_data);
	}
}
