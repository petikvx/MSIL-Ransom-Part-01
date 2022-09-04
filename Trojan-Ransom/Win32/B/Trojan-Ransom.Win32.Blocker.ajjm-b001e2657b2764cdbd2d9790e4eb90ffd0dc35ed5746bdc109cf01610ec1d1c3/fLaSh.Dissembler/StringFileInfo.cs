using System;
using System.Collections.Generic;
using System.IO;

namespace fLaSh.Dissembler;

public class StringFileInfo : ResourceTable
{
	private Dictionary<string, StringTable> dictionary_0;

	public Dictionary<string, StringTable> Strings => dictionary_0;

	public StringTable Default
	{
		get
		{
			Dictionary<string, StringTable>.Enumerator enumerator = dictionary_0.GetEnumerator();
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

	public StringFileInfo(IntPtr lpRes)
	{
		Read(lpRes);
	}

	public override IntPtr Read(IntPtr lpRes)
	{
		dictionary_0 = new Dictionary<string, StringTable>();
		IntPtr lpRes2 = base.Read(lpRes);
		while (lpRes2.ToInt32() < lpRes.ToInt32() + _header.wLength)
		{
			StringTable stringTable = new StringTable(lpRes2);
			dictionary_0.Add(stringTable.Key, stringTable);
			lpRes2 = ResourceUtil.Align(lpRes2.ToInt32() + stringTable.Header.wLength);
		}
		return new IntPtr(lpRes.ToInt32() + _header.wLength);
	}

	public override void Write(BinaryWriter w)
	{
		long position = w.BaseStream.Position;
		base.Write(w);
		Dictionary<string, StringTable>.Enumerator enumerator = dictionary_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value.Write(w);
		}
		ResourceUtil.WriteAt(w, w.BaseStream.Position - position, position);
	}
}
