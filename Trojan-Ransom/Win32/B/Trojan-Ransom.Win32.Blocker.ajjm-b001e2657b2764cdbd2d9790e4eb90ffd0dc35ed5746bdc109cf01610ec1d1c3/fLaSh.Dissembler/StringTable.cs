using System;
using System.Collections.Generic;
using System.IO;

namespace fLaSh.Dissembler;

public class StringTable : ResourceTable
{
	private Dictionary<string, StringResource> dictionary_0;

	public Dictionary<string, StringResource> Strings => dictionary_0;

	public string this[string key]
	{
		get
		{
			return dictionary_0[key].Value;
		}
		set
		{
			StringResource value2 = null;
			if (!dictionary_0.TryGetValue(key, out value2))
			{
				value2 = new StringResource(key);
				dictionary_0.Add(key, value2);
			}
			value2.Value = value;
		}
	}

	public StringTable(IntPtr lpRes)
	{
		Read(lpRes);
	}

	public override IntPtr Read(IntPtr lpRes)
	{
		dictionary_0 = new Dictionary<string, StringResource>();
		IntPtr lpRes2 = base.Read(lpRes);
		while (lpRes2.ToInt32() < lpRes.ToInt32() + _header.wLength)
		{
			StringResource stringResource = new StringResource(lpRes2);
			dictionary_0.Add(stringResource.Key, stringResource);
			lpRes2 = ResourceUtil.Align(lpRes2.ToInt32() + stringResource.Header.wLength);
		}
		return new IntPtr(lpRes.ToInt32() + _header.wLength);
	}

	public override void Write(BinaryWriter w)
	{
		long position = w.BaseStream.Position;
		base.Write(w);
		Dictionary<string, StringResource>.Enumerator enumerator = dictionary_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value.Write(w);
		}
		ResourceUtil.smethod_1(w);
		ResourceUtil.WriteAt(w, w.BaseStream.Position - position, position);
	}
}
