using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace fLaSh.Dissembler;

public class StringResource
{
	private Kernel32.RESOURCE_HEADER resource_HEADER_0;

	private string string_0;

	private string string_1;

	public Kernel32.RESOURCE_HEADER Header => resource_HEADER_0;

	public string Key => string_0;

	public string StringValue
	{
		get
		{
			if (string_1 == null)
			{
				return null;
			}
			return string_1.Trim("\0".ToCharArray());
		}
	}

	public string Value
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}

	public StringResource(string key)
	{
		string_0 = key;
		resource_HEADER_0.wType = 1;
		resource_HEADER_0.wLength = 0;
		resource_HEADER_0.wValueLength = 0;
	}

	public StringResource(IntPtr lpRes)
	{
		Read(lpRes);
	}

	public void Read(IntPtr lpRes)
	{
		resource_HEADER_0 = (Kernel32.RESOURCE_HEADER)Marshal.PtrToStructure(lpRes, typeof(Kernel32.RESOURCE_HEADER));
		IntPtr ptr = new IntPtr(lpRes.ToInt32() + Marshal.SizeOf((object)resource_HEADER_0));
		string_0 = Marshal.PtrToStringUni(ptr);
		IntPtr ptr2 = ResourceUtil.Align(ptr.ToInt32() + (string_0.Length + 1) * 2);
		string_1 = ((resource_HEADER_0.wValueLength > 0) ? Marshal.PtrToStringUni(ptr2, resource_HEADER_0.wValueLength) : null);
	}

	public void Write(BinaryWriter w)
	{
		long position = w.BaseStream.Position;
		w.Write(resource_HEADER_0.wLength);
		w.Write(resource_HEADER_0.wValueLength);
		w.Write(resource_HEADER_0.wType);
		w.Write(Encoding.Unicode.GetBytes(string_0));
		w.Write((ushort)0);
		ResourceUtil.smethod_1(w);
		long position2 = w.BaseStream.Position;
		if (string_1 != null)
		{
			w.Write(Encoding.Unicode.GetBytes(string_1));
		}
		ResourceUtil.WriteAt(w, (w.BaseStream.Position - position2) / 2L, position + 2L);
		ResourceUtil.smethod_1(w);
		ResourceUtil.WriteAt(w, w.BaseStream.Position - position, position);
	}
}
