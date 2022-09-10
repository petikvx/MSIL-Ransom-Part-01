using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Vestris.ResourceLib;

public class StringResource : Resource
{
	private Dictionary<ushort, string> _strings = new Dictionary<ushort, string>();

	public Dictionary<ushort, string> Strings
	{
		get
		{
			return _strings;
		}
		set
		{
			_strings = value;
		}
	}

	public string this[ushort id]
	{
		get
		{
			return _strings[id];
		}
		set
		{
			_strings[id] = value;
		}
	}

	public ushort BlockId
	{
		get
		{
			return (ushort)base.Name.Id.ToInt32();
		}
		set
		{
			base.Name = new ResourceId(value);
		}
	}

	public StringResource()
		: base(IntPtr.Zero, IntPtr.Zero, new ResourceId(Kernel32.ResourceTypes.RT_STRING), null, ResourceUtil.NEUTRALLANGID, 0)
	{
	}

	public StringResource(ResourceId blockId)
		: base(IntPtr.Zero, IntPtr.Zero, new ResourceId(Kernel32.ResourceTypes.RT_STRING), blockId, ResourceUtil.NEUTRALLANGID, 0)
	{
	}

	public StringResource(ushort blockId)
		: this(new ResourceId(blockId))
	{
	}

	public StringResource(IntPtr hModule, IntPtr hResource, ResourceId type, ResourceId name, ushort language, int size)
		: base(hModule, hResource, type, name, language, size)
	{
	}

	public static ushort GetBlockId(int stringId)
	{
		return (ushort)(stringId / 16 + 1);
	}

	internal override IntPtr Read(IntPtr hModule, IntPtr lpRes)
	{
		for (int i = 0; i < 16; i++)
		{
			ushort num = (ushort)Marshal.ReadInt16(lpRes);
			if (num != 0)
			{
				ushort key = (ushort)((BlockId - 1) * 16 + i);
				IntPtr ptr = new IntPtr(lpRes.ToInt32() + 2);
				string value = Marshal.PtrToStringUni(ptr, num);
				_strings.Add(key, value);
			}
			lpRes = new IntPtr(lpRes.ToInt32() + 2 + num * Marshal.SystemDefaultCharSize);
		}
		return lpRes;
	}

	internal override void Write(BinaryWriter w)
	{
		for (int i = 0; i < 16; i++)
		{
			ushort key = (ushort)((BlockId - 1) * 16 + i);
			string value = null;
			if (_strings.TryGetValue(key, out value))
			{
				w.Write((ushort)value.Length);
				w.Write(Encoding.Unicode.GetBytes(value));
			}
			else
			{
				w.Write((ushort)0);
			}
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("STRINGTABLE");
		stringBuilder.AppendLine("BEGIN");
		Dictionary<ushort, string>.Enumerator enumerator = _strings.GetEnumerator();
		while (enumerator.MoveNext())
		{
			stringBuilder.AppendLine($" {enumerator.Current.Key} {enumerator.Current.Value}");
		}
		stringBuilder.AppendLine("END");
		return stringBuilder.ToString();
	}
}
