using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Vestris.ResourceLib;

public class ResourceTableHeader
{
	protected Kernel32.RESOURCE_HEADER _header;

	protected string _key;

	public string Key => _key;

	public Kernel32.RESOURCE_HEADER Header
	{
		get
		{
			return _header;
		}
		set
		{
			_header = value;
		}
	}

	public ResourceTableHeader()
	{
	}

	public ResourceTableHeader(string key)
	{
		_key = key;
	}

	internal ResourceTableHeader(IntPtr lpRes)
	{
		Read(lpRes);
	}

	internal virtual IntPtr Read(IntPtr lpRes)
	{
		_header = (Kernel32.RESOURCE_HEADER)Marshal.PtrToStructure(lpRes, typeof(Kernel32.RESOURCE_HEADER));
		IntPtr ptr = new IntPtr(lpRes.ToInt32() + Marshal.SizeOf((object)_header));
		_key = Marshal.PtrToStringUni(ptr);
		return ResourceUtil.Align(ptr.ToInt32() + (_key.Length + 1) * Marshal.SystemDefaultCharSize);
	}

	internal virtual void Write(BinaryWriter w)
	{
		w.Write(_header.wLength);
		w.Write(_header.wValueLength);
		w.Write(_header.wType);
		w.Write(Encoding.Unicode.GetBytes(_key));
		w.Write((ushort)0);
		ResourceUtil.PadToDWORD(w);
	}

	public override string ToString()
	{
		return ToString(0);
	}

	public virtual string ToString(int indent)
	{
		return base.ToString();
	}
}
