using System;
using System.Collections.Generic;
using System.IO;

namespace fLaSh.Dissembler;

public class VarFileInfo : ResourceTable
{
	private Dictionary<string, VarTable> dictionary_0;

	public Dictionary<string, VarTable> Vars => dictionary_0;

	public VarTable Default
	{
		get
		{
			Dictionary<string, VarTable>.Enumerator enumerator = dictionary_0.GetEnumerator();
			if (enumerator.MoveNext())
			{
				return enumerator.Current.Value;
			}
			return null;
		}
	}

	public ushort this[ushort language]
	{
		get
		{
			return Default[language];
		}
		set
		{
			Default[language] = value;
		}
	}

	public VarFileInfo(IntPtr lpRes)
	{
		Read(lpRes);
	}

	public override IntPtr Read(IntPtr lpRes)
	{
		dictionary_0 = new Dictionary<string, VarTable>();
		IntPtr lpRes2 = base.Read(lpRes);
		while (lpRes2.ToInt32() < lpRes.ToInt32() + _header.wLength)
		{
			VarTable varTable = new VarTable(lpRes2);
			dictionary_0.Add(varTable.Key, varTable);
			lpRes2 = ResourceUtil.Align(lpRes2.ToInt32() + varTable.Header.wLength);
		}
		return new IntPtr(lpRes.ToInt32() + _header.wLength);
	}

	public override void Write(BinaryWriter w)
	{
		long position = w.BaseStream.Position;
		base.Write(w);
		Dictionary<string, VarTable>.Enumerator enumerator = dictionary_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value.Write(w);
		}
		ResourceUtil.WriteAt(w, w.BaseStream.Position - position, position);
	}
}
