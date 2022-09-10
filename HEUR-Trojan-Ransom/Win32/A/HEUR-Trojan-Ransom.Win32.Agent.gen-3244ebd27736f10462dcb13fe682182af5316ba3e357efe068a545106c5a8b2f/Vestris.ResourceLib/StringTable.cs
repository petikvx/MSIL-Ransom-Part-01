using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Vestris.ResourceLib;

public class StringTable : ResourceTableHeader
{
	private Dictionary<string, StringTableEntry> _strings = new Dictionary<string, StringTableEntry>();

	public Dictionary<string, StringTableEntry> Strings => _strings;

	public ushort LanguageID
	{
		get
		{
			if (string.IsNullOrEmpty(_key))
			{
				return 0;
			}
			return Convert.ToUInt16(_key.Substring(0, 4), 16);
		}
		set
		{
			_key = $"{value:x4}{CodePage:x4}";
		}
	}

	public ushort CodePage
	{
		get
		{
			if (string.IsNullOrEmpty(_key))
			{
				return 0;
			}
			return Convert.ToUInt16(_key.Substring(4, 4), 16);
		}
		set
		{
			_key = $"{LanguageID:x4}{value:x4}";
		}
	}

	public string this[string key]
	{
		get
		{
			return _strings[key].Value;
		}
		set
		{
			StringTableEntry value2 = null;
			if (!_strings.TryGetValue(key, out value2))
			{
				value2 = new StringTableEntry(key);
				_strings.Add(key, value2);
			}
			value2.Value = value;
		}
	}

	public StringTable()
	{
	}

	public StringTable(string key)
		: base(key)
	{
		_header.wType = 1;
	}

	internal StringTable(IntPtr lpRes)
	{
		Read(lpRes);
	}

	internal override IntPtr Read(IntPtr lpRes)
	{
		_strings.Clear();
		IntPtr lpRes2 = base.Read(lpRes);
		while (lpRes2.ToInt32() < lpRes.ToInt32() + _header.wLength)
		{
			StringTableEntry stringTableEntry = new StringTableEntry(lpRes2);
			_strings.Add(stringTableEntry.Key, stringTableEntry);
			lpRes2 = ResourceUtil.Align(lpRes2.ToInt32() + stringTableEntry.Header.wLength);
		}
		return new IntPtr(lpRes.ToInt32() + _header.wLength);
	}

	internal override void Write(BinaryWriter w)
	{
		long position = w.BaseStream.Position;
		base.Write(w);
		int num = _strings.Count;
		Dictionary<string, StringTableEntry>.Enumerator enumerator = _strings.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value.Write(w);
			ResourceUtil.WriteAt(w, w.BaseStream.Position - position, position);
			if (--num != 0)
			{
				ResourceUtil.PadToDWORD(w);
			}
		}
	}

	public override string ToString(int indent)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"{new string(' ', indent)}BEGIN");
		stringBuilder.AppendLine($"{new string(' ', indent + 1)}BLOCK \"{_key}\"");
		stringBuilder.AppendLine($"{new string(' ', indent + 1)}BEGIN");
		foreach (StringTableEntry value in _strings.Values)
		{
			stringBuilder.AppendLine($"{new string(' ', indent + 2)}VALUE \"{value.Key}\", \"{value.StringValue}\"");
		}
		stringBuilder.AppendLine($"{new string(' ', indent + 1)}END");
		stringBuilder.AppendLine($"{new string(' ', indent)}END");
		return stringBuilder.ToString();
	}
}
