using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace fLaSh.Dissembler;

public class ResourceTable
{
	protected Kernel32.RESOURCE_HEADER _header;

	protected string _key;

	public string Key => _key;

	public Kernel32.RESOURCE_HEADER Header => _header;

	public ResourceTable()
	{
	}

	public ResourceTable(IntPtr lpRes)
	{
		Read(lpRes);
	}

	public virtual IntPtr Read(IntPtr lpRes)
	{
		_header = (Kernel32.RESOURCE_HEADER)Marshal.PtrToStructure(lpRes, typeof(Kernel32.RESOURCE_HEADER));
		IntPtr ptr = new IntPtr(lpRes.ToInt32() + Marshal.SizeOf((object)_header));
		_key = Marshal.PtrToStringUni(ptr);
		return ResourceUtil.Align(ptr.ToInt32() + (_key.Length + 1) * 2);
	}

	public virtual void Write(BinaryWriter w)
	{
		w.Write(_header.wLength);
		w.Write(_header.wValueLength);
		w.Write(_header.wType);
		w.Write(Encoding.Unicode.GetBytes(_key));
		w.Write((ushort)0);
		ResourceUtil.smethod_1(w);
	}
}
