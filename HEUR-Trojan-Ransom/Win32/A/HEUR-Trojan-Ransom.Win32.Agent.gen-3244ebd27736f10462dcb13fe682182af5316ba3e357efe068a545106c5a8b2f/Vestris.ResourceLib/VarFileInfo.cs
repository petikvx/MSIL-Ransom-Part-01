using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Vestris.ResourceLib;

public class VarFileInfo : ResourceTableHeader
{
	private Dictionary<string, VarTable> _vars = new Dictionary<string, VarTable>();

	public Dictionary<string, VarTable> Vars => _vars;

	public VarTable Default
	{
		get
		{
			Dictionary<string, VarTable>.Enumerator enumerator = _vars.GetEnumerator();
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

	public VarFileInfo()
		: base("VarFileInfo")
	{
		_header.wType = 1;
	}

	internal VarFileInfo(IntPtr lpRes)
	{
		Read(lpRes);
	}

	internal override IntPtr Read(IntPtr lpRes)
	{
		_vars.Clear();
		IntPtr lpRes2 = base.Read(lpRes);
		while (lpRes2.ToInt32() < lpRes.ToInt32() + _header.wLength)
		{
			VarTable varTable = new VarTable(lpRes2);
			_vars.Add(varTable.Key, varTable);
			lpRes2 = ResourceUtil.Align(lpRes2.ToInt32() + varTable.Header.wLength);
		}
		return new IntPtr(lpRes.ToInt32() + _header.wLength);
	}

	internal override void Write(BinaryWriter w)
	{
		long position = w.BaseStream.Position;
		base.Write(w);
		Dictionary<string, VarTable>.Enumerator enumerator = _vars.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value.Write(w);
		}
		ResourceUtil.WriteAt(w, w.BaseStream.Position - position, position);
	}

	public override string ToString(int indent)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"{new string(' ', indent)}BEGIN");
		foreach (VarTable value in _vars.Values)
		{
			stringBuilder.Append(value.ToString(indent + 1));
		}
		stringBuilder.AppendLine($"{new string(' ', indent)}END");
		return stringBuilder.ToString();
	}
}
