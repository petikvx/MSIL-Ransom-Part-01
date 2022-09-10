using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Vestris.ResourceLib;

public class StringFileInfo : ResourceTableHeader
{
	private Dictionary<string, StringTable> _strings = new Dictionary<string, StringTable>();

	public Dictionary<string, StringTable> Strings => _strings;

	public StringTable Default
	{
		get
		{
			Dictionary<string, StringTable>.Enumerator enumerator = _strings.GetEnumerator();
			if (enumerator.MoveNext())
			{
				return enumerator.Current.Value;
			}
			return null;
		}
	}

	public string this[string key]
	{
		get
		{
			return Default[key];
		}
		set
		{
			Default[key] = value;
		}
	}

	public StringFileInfo()
		: base("StringFileInfo")
	{
		_header.wType = 1;
	}

	internal StringFileInfo(IntPtr lpRes)
	{
		Read(lpRes);
	}

	internal override IntPtr Read(IntPtr lpRes)
	{
		_strings.Clear();
		IntPtr lpRes2 = base.Read(lpRes);
		while (lpRes2.ToInt32() < lpRes.ToInt32() + _header.wLength)
		{
			StringTable stringTable = new StringTable(lpRes2);
			_strings.Add(stringTable.Key, stringTable);
			lpRes2 = ResourceUtil.Align(lpRes2.ToInt32() + stringTable.Header.wLength);
		}
		return new IntPtr(lpRes.ToInt32() + _header.wLength);
	}

	internal override void Write(BinaryWriter w)
	{
		long position = w.BaseStream.Position;
		base.Write(w);
		Dictionary<string, StringTable>.Enumerator enumerator = _strings.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value.Write(w);
		}
		ResourceUtil.WriteAt(w, w.BaseStream.Position - position, position);
		ResourceUtil.PadToDWORD(w);
	}

	public override string ToString(int indent)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"{new string(' ', indent)}BEGIN");
		stringBuilder.AppendLine($"{new string(' ', indent + 1)}BLOCK \"{_key}\"");
		foreach (StringTable value in _strings.Values)
		{
			stringBuilder.Append(value.ToString(indent + 1));
		}
		stringBuilder.AppendLine($"{new string(' ', indent)}END");
		return stringBuilder.ToString();
	}
}
