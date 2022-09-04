using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;

namespace fLaSh.Dissembler;

public class VersionResource : Resource
{
	private ResourceTable resourceTable_0 = new ResourceTable();

	private Kernel32.VS_FIXEDFILEINFO vs_FIXEDFILEINFO_0;

	private Dictionary<string, ResourceTable> dictionary_0;

	public ResourceTable Header => resourceTable_0;

	public Dictionary<string, ResourceTable> Resources => dictionary_0;

	public string FileVersion
	{
		get
		{
			return $"{(vs_FIXEDFILEINFO_0.dwFileVersionMS & 0xFFFF0000u) >> 16}.{vs_FIXEDFILEINFO_0.dwFileVersionMS & 0xFFFFu}.{(vs_FIXEDFILEINFO_0.dwFileVersionLS & 0xFFFF0000u) >> 16}.{vs_FIXEDFILEINFO_0.dwFileVersionLS & 0xFFFFu}";
		}
		set
		{
			uint num = 0u;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 0u;
			string[] array = value.Split(".".ToCharArray(), 4);
			if (array.Length >= 1)
			{
				num = uint.Parse(array[0]);
			}
			if (array.Length >= 2)
			{
				num2 = uint.Parse(array[1]);
			}
			if (array.Length >= 3)
			{
				num3 = uint.Parse(array[2]);
			}
			if (array.Length >= 4)
			{
				num4 = uint.Parse(array[3]);
			}
			vs_FIXEDFILEINFO_0.dwFileVersionMS = (num << 16) + num2;
			vs_FIXEDFILEINFO_0.dwFileVersionLS = (num3 << 16) + num4;
		}
	}

	public string ProductVersion
	{
		get
		{
			return $"{(vs_FIXEDFILEINFO_0.dwProductVersionMS & 0xFFFF0000u) >> 16}.{vs_FIXEDFILEINFO_0.dwProductVersionMS & 0xFFFFu}.{(vs_FIXEDFILEINFO_0.dwProductVersionLS & 0xFFFF0000u) >> 16}.{vs_FIXEDFILEINFO_0.dwProductVersionLS & 0xFFFFu}";
		}
		set
		{
			uint num = 0u;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 0u;
			string[] array = value.Split(".".ToCharArray(), 4);
			if (array.Length >= 1)
			{
				num = uint.Parse(array[0]);
			}
			if (array.Length >= 2)
			{
				num2 = uint.Parse(array[1]);
			}
			if (array.Length >= 3)
			{
				num3 = uint.Parse(array[2]);
			}
			if (array.Length >= 4)
			{
				num4 = uint.Parse(array[3]);
			}
			vs_FIXEDFILEINFO_0.dwProductVersionMS = (num << 16) + num2;
			vs_FIXEDFILEINFO_0.dwProductVersionLS = (num3 << 16) + num4;
		}
	}

	public ResourceTable this[string key]
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

	public VersionResource(IntPtr hModule, IntPtr hResource, IntPtr type, IntPtr name, ushort ushort_0, int size)
		: base(hModule, hResource, type, name, ushort_0, size)
	{
		IntPtr intPtr = Kernel32.LockResource(hResource);
		if (intPtr == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		Read(hModule, intPtr);
	}

	public VersionResource()
	{
	}

	public void LoadFrom(string filename)
	{
		LoadFrom(filename, Marshal.StringToHGlobalUni("#1"), new IntPtr(16L));
	}

	public static byte[] LoadBytesFrom(string filename)
	{
		return Resource.LoadBytesFrom(filename, Marshal.StringToHGlobalUni("#1"), new IntPtr(16L));
	}

	public override IntPtr Read(IntPtr hModule, IntPtr lpRes)
	{
		dictionary_0 = new Dictionary<string, ResourceTable>();
		IntPtr ptr = resourceTable_0.Read(lpRes);
		vs_FIXEDFILEINFO_0 = (Kernel32.VS_FIXEDFILEINFO)Marshal.PtrToStructure(ptr, typeof(Kernel32.VS_FIXEDFILEINFO));
		IntPtr lpRes2 = ResourceUtil.Align(ptr.ToInt32() + resourceTable_0.Header.wValueLength);
		while (lpRes2.ToInt32() < lpRes.ToInt32() + resourceTable_0.Header.wLength)
		{
			ResourceTable resourceTable = new ResourceTable(lpRes2);
			string key;
			resourceTable = (((key = resourceTable.Key) == null || !(key == "StringFileInfo")) ? ((ResourceTable)new VarFileInfo(lpRes2)) : ((ResourceTable)new StringFileInfo(lpRes2)));
			dictionary_0.Add(resourceTable.Key, resourceTable);
			lpRes2 = ResourceUtil.Align(lpRes2.ToInt32() + resourceTable.Header.wLength);
		}
		return new IntPtr(lpRes.ToInt32() + resourceTable_0.Header.wLength);
	}

	public override void Write(BinaryWriter w)
	{
		long position = w.BaseStream.Position;
		resourceTable_0.Write(w);
		w.Write(ResourceUtil.GetByts(vs_FIXEDFILEINFO_0));
		ResourceUtil.smethod_1(w);
		Dictionary<string, ResourceTable>.Enumerator enumerator = dictionary_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value.Write(w);
		}
		ResourceUtil.WriteAt(w, w.BaseStream.Position - position, position);
	}

	public static void SaveTo(string filename, byte[] data)
	{
		Resource.SaveTo(filename, new IntPtr(1), new IntPtr(16L), (ushort)ResourceUtil.NEUTRALLANGID, data);
	}

	public void SaveTo(string filename)
	{
		SaveTo(filename, new IntPtr(1), new IntPtr(16L), (ushort)ResourceUtil.NEUTRALLANGID);
	}
}
