using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace fLaSh.Dissembler;

public class ResourceInfo : IDisposable
{
	private IntPtr intptr_0 = IntPtr.Zero;

	private Dictionary<string, List<Resource>> dictionary_0;

	private List<string> list_0;

	public Dictionary<string, List<Resource>> Resources => dictionary_0;

	public List<string> ResourceTypes => list_0;

	public void Unload()
	{
		if (intptr_0 != IntPtr.Zero)
		{
			Kernel32.FreeLibrary(intptr_0);
			intptr_0 = IntPtr.Zero;
		}
	}

	public void Load(string filename)
	{
		Unload();
		list_0 = new List<string>();
		dictionary_0 = new Dictionary<string, List<Resource>>();
		intptr_0 = Kernel32.LoadLibraryEx(filename, IntPtr.Zero, 3u);
		if (IntPtr.Zero == intptr_0)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		if (!Kernel32.EnumResourceTypesW(intptr_0, method_0, IntPtr.Zero))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
	}

	private bool method_0(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3)
	{
		string resourceName = ResourceUtil.GetResourceName(intptr_2);
		list_0.Add(resourceName);
		if (!Kernel32.EnumResourceNamesW(intptr_1, intptr_2, method_1, IntPtr.Zero))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		return true;
	}

	private bool method_1(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		if (!Kernel32.EnumResourceLanguagesW(intptr_1, intptr_2, intptr_3, method_2, IntPtr.Zero))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		return true;
	}

	private bool method_2(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, ushort ushort_0, IntPtr intptr_4)
	{
		string resourceName = ResourceUtil.GetResourceName(intptr_2);
		List<Resource> value = null;
		if (!dictionary_0.TryGetValue(resourceName, out value))
		{
			value = new List<Resource>();
			dictionary_0[resourceName] = value;
		}
		IntPtr intPtr = Kernel32.FindResourceExW(intptr_1, intptr_2, intptr_3, ushort_0);
		IntPtr hResource = Kernel32.LoadResource(intptr_1, intPtr);
		int size = Kernel32.SizeofResource(intptr_1, intPtr);
		Resource resource = null;
		resource = ResourceUtil.GetResourceName(intptr_2) switch
		{
			"14" => new GroupIconResource(intptr_1, hResource, intptr_2, intptr_3, ushort_0, size), 
			"16" => new VersionResource(intptr_1, hResource, intptr_2, intptr_3, ushort_0, size), 
			_ => new Resource(intptr_1, hResource, intptr_2, intptr_3, ushort_0, size), 
		};
		value.Add(resource);
		return true;
	}

	public void Save(string filename)
	{
		throw new NotImplementedException();
	}

	public void Dispose()
	{
		Unload();
	}
}
