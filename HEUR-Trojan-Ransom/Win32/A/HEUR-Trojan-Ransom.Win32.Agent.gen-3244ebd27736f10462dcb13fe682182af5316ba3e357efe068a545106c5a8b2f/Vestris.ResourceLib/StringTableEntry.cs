using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Vestris.ResourceLib;

public class StringTableEntry
{
	private Kernel32.RESOURCE_HEADER _header;

	private string _key;

	private string _value;

	public Kernel32.RESOURCE_HEADER Header => _header;

	public string Key => _key;

	public string StringValue
	{
		get
		{
			if (_value == null)
			{
				return _value;
			}
			return _value.Substring(0, _value.Length - 1);
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
			if (value == null)
			{
				_value = null;
				_header.wValueLength = 0;
				return;
			}
			if (value.Length != 0 && value[value.Length - 1] == '\0')
			{
				_value = value;
			}
			else
			{
				_value = value + '\0';
			}
			_header.wValueLength = (ushort)_value.Length;
		}
	}

	public StringTableEntry(string key)
	{
		_key = key;
		_header.wType = 1;
		_header.wLength = 0;
		_header.wValueLength = 0;
	}

	internal StringTableEntry(IntPtr lpRes)
	{
		Read(lpRes);
	}

	internal void Read(IntPtr lpRes)
	{
		_header = (Kernel32.RESOURCE_HEADER)Marshal.PtrToStructure(lpRes, typeof(Kernel32.RESOURCE_HEADER));
		IntPtr ptr = new IntPtr(lpRes.ToInt32() + Marshal.SizeOf((object)_header));
		_key = Marshal.PtrToStringUni(ptr);
		IntPtr ptr2 = ResourceUtil.Align(ptr.ToInt32() + (_key.Length + 1) * Marshal.SystemDefaultCharSize);
		_value = ((_header.wValueLength > 0) ? Marshal.PtrToStringUni(ptr2, _header.wValueLength) : null);
	}

	internal void Write(BinaryWriter w)
	{
		long position = w.BaseStream.Position;
		w.Write(_header.wLength);
		w.Write(_header.wValueLength);
		w.Write(_header.wType);
		w.Write(Encoding.Unicode.GetBytes(_key));
		w.Write((ushort)0);
		ResourceUtil.PadToDWORD(w);
		long position2 = w.BaseStream.Position;
		if (_value != null)
		{
			w.Write(Encoding.Unicode.GetBytes(_value));
		}
		ResourceUtil.WriteAt(w, (w.BaseStream.Position - position2) / Marshal.SystemDefaultCharSize, position + 2L);
		ResourceUtil.WriteAt(w, w.BaseStream.Position - position, position);
	}
}
