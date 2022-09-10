using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Vestris.ResourceLib;

public class VersionResource : Resource
{
	private ResourceTableHeader _header = new ResourceTableHeader("VS_VERSION_INFO");

	private FixedFileInfo _fixedfileinfo = new FixedFileInfo();

	private Dictionary<string, ResourceTableHeader> _resources = new Dictionary<string, ResourceTableHeader>();

	public ResourceTableHeader Header => _header;

	public Dictionary<string, ResourceTableHeader> Resources => _resources;

	public string FileVersion
	{
		get
		{
			return _fixedfileinfo.FileVersion;
		}
		set
		{
			_fixedfileinfo.FileVersion = value;
		}
	}

	public string ProductVersion
	{
		get
		{
			return _fixedfileinfo.ProductVersion;
		}
		set
		{
			_fixedfileinfo.ProductVersion = value;
		}
	}

	public FixedFileInfo FixedFileInfo => _fixedfileinfo;

	public ResourceTableHeader this[string key]
	{
		get
		{
			return Resources[key];
		}
		set
		{
			Resources[key] = value;
		}
	}

	public VersionResource(IntPtr hModule, IntPtr hResource, ResourceId type, ResourceId name, ushort language, int size)
		: base(hModule, hResource, type, name, language, size)
	{
	}

	public VersionResource()
		: base(IntPtr.Zero, IntPtr.Zero, new ResourceId(Kernel32.ResourceTypes.RT_VERSION), new ResourceId(1u), ResourceUtil.USENGLISHLANGID, 0)
	{
		_header.Header = new Kernel32.RESOURCE_HEADER(_fixedfileinfo.Size);
	}

	internal override IntPtr Read(IntPtr hModule, IntPtr lpRes)
	{
		_resources.Clear();
		IntPtr lpRes2 = _header.Read(lpRes);
		if (_header.Header.wValueLength != 0)
		{
			_fixedfileinfo = new FixedFileInfo();
			_fixedfileinfo.Read(lpRes2);
		}
		IntPtr lpRes3 = ResourceUtil.Align(lpRes2.ToInt32() + _header.Header.wValueLength);
		while (lpRes3.ToInt32() < lpRes.ToInt32() + _header.Header.wLength)
		{
			ResourceTableHeader resourceTableHeader = new ResourceTableHeader(lpRes3);
			string key;
			if ((key = resourceTableHeader.Key) != null && key == "StringFileInfo")
			{
				StringFileInfo stringFileInfo = new StringFileInfo(lpRes3);
				resourceTableHeader = stringFileInfo;
			}
			else
			{
				resourceTableHeader = new VarFileInfo(lpRes3);
			}
			_resources.Add(resourceTableHeader.Key, resourceTableHeader);
			lpRes3 = ResourceUtil.Align(lpRes3.ToInt32() + resourceTableHeader.Header.wLength);
		}
		return new IntPtr(lpRes.ToInt32() + _header.Header.wLength);
	}

	internal override void Write(BinaryWriter w)
	{
		long position = w.BaseStream.Position;
		_header.Write(w);
		if (_fixedfileinfo != null)
		{
			_fixedfileinfo.Write(w);
		}
		Dictionary<string, ResourceTableHeader>.Enumerator enumerator = _resources.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value.Write(w);
		}
		ResourceUtil.WriteAt(w, w.BaseStream.Position - position, position);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (_fixedfileinfo != null)
		{
			stringBuilder.Append(_fixedfileinfo.ToString());
		}
		stringBuilder.AppendLine("BEGIN");
		Dictionary<string, ResourceTableHeader>.Enumerator enumerator = _resources.GetEnumerator();
		while (enumerator.MoveNext())
		{
			stringBuilder.Append(enumerator.Current.Value.ToString(1));
		}
		stringBuilder.AppendLine("END");
		return stringBuilder.ToString();
	}
}
