using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace fLaSh.Dissembler;

public class VarTable : ResourceTable
{
	private Dictionary<ushort, ushort> dictionary_0;

	public Dictionary<ushort, ushort> Languages => dictionary_0;

	public ushort this[ushort key]
	{
		get
		{
			return dictionary_0[key];
		}
		set
		{
			dictionary_0[key] = value;
		}
	}

	public VarTable(IntPtr lpRes)
	{
		Read(lpRes);
	}

	public override IntPtr Read(IntPtr lpRes)
	{
		dictionary_0 = new Dictionary<ushort, ushort>();
		IntPtr ptr = base.Read(lpRes);
		while (ptr.ToInt32() < lpRes.ToInt32() + _header.wLength)
		{
			Kernel32.VAR_HEADER vAR_HEADER = (Kernel32.VAR_HEADER)Marshal.PtrToStructure(ptr, typeof(Kernel32.VAR_HEADER));
			dictionary_0.Add(vAR_HEADER.wLanguageIDMS, vAR_HEADER.wCodePageIBM);
			ptr = new IntPtr(ptr.ToInt32() + Marshal.SizeOf((object)vAR_HEADER));
		}
		return new IntPtr(lpRes.ToInt32() + _header.wLength);
	}

	public override void Write(BinaryWriter w)
	{
		long position = w.BaseStream.Position;
		base.Write(w);
		Dictionary<ushort, ushort>.Enumerator enumerator = dictionary_0.GetEnumerator();
		long position2 = w.BaseStream.Position;
		while (enumerator.MoveNext())
		{
			w.Write(enumerator.Current.Key);
			w.Write(enumerator.Current.Value);
		}
		ResourceUtil.WriteAt(w, w.BaseStream.Position - position2, position + 2L);
		ResourceUtil.smethod_1(w);
		ResourceUtil.WriteAt(w, w.BaseStream.Position - position, position);
	}
}
