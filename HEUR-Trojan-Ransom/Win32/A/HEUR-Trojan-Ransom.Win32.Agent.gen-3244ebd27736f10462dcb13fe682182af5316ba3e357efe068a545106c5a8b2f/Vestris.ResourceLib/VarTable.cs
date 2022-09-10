using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Vestris.ResourceLib;

public class VarTable : ResourceTableHeader
{
	private Dictionary<ushort, ushort> _languages = new Dictionary<ushort, ushort>();

	public Dictionary<ushort, ushort> Languages => _languages;

	public ushort this[ushort key]
	{
		get
		{
			return _languages[key];
		}
		set
		{
			_languages[key] = value;
		}
	}

	public VarTable()
	{
	}

	public VarTable(string key)
		: base(key)
	{
	}

	internal VarTable(IntPtr lpRes)
	{
		Read(lpRes);
	}

	internal override IntPtr Read(IntPtr lpRes)
	{
		_languages.Clear();
		IntPtr ptr = base.Read(lpRes);
		while (ptr.ToInt32() < lpRes.ToInt32() + _header.wLength)
		{
			Kernel32.VAR_HEADER vAR_HEADER = (Kernel32.VAR_HEADER)Marshal.PtrToStructure(ptr, typeof(Kernel32.VAR_HEADER));
			_languages.Add(vAR_HEADER.wLanguageIDMS, vAR_HEADER.wCodePageIBM);
			ptr = new IntPtr(ptr.ToInt32() + Marshal.SizeOf((object)vAR_HEADER));
		}
		return new IntPtr(lpRes.ToInt32() + _header.wLength);
	}

	internal override void Write(BinaryWriter w)
	{
		long position = w.BaseStream.Position;
		base.Write(w);
		Dictionary<ushort, ushort>.Enumerator enumerator = _languages.GetEnumerator();
		long position2 = w.BaseStream.Position;
		while (enumerator.MoveNext())
		{
			w.Write(enumerator.Current.Key);
			w.Write(enumerator.Current.Value);
		}
		ResourceUtil.WriteAt(w, w.BaseStream.Position - position2, position + 2L);
		ResourceUtil.PadToDWORD(w);
		ResourceUtil.WriteAt(w, w.BaseStream.Position - position, position);
	}

	public override string ToString(int indent)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"{new string(' ', indent)}BEGIN");
		Dictionary<ushort, ushort>.Enumerator enumerator = _languages.GetEnumerator();
		while (enumerator.MoveNext())
		{
			stringBuilder.AppendLine($"{new string(' ', indent + 1)}VALUE \"Translation\", 0x{enumerator.Current.Key:x}, 0x{enumerator.Current.Value:x}");
		}
		stringBuilder.AppendLine($"{new string(' ', indent)}END");
		return stringBuilder.ToString();
	}
}
