using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;

namespace fLaSh.Dissembler;

public class GroupIconResource : Resource
{
	public enum GroupType
	{
		Icon = 1,
		Cursor
	}

	private Kernel32.GRPICONDIR grpicondir_0 = default(Kernel32.GRPICONDIR);

	private List<IconResource> list_0 = new List<IconResource>();

	public GroupType GroupIconResourceType
	{
		get
		{
			return (GroupType)grpicondir_0.wType;
		}
		set
		{
			grpicondir_0.wType = (byte)value;
		}
	}

	public List<IconResource> Icons
	{
		get
		{
			return list_0;
		}
		set
		{
			list_0 = value;
		}
	}

	public GroupIconResource(IntPtr hModule, IntPtr hResource, IntPtr type, IntPtr name, ushort ushort_0, int size)
		: base(hModule, hResource, type, name, ushort_0, size)
	{
		IntPtr intPtr = Kernel32.LockResource(hResource);
		if (intPtr == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		Read(hModule, intPtr);
	}

	public GroupIconResource()
		: base(IntPtr.Zero, IntPtr.Zero, new IntPtr(14L), new IntPtr(1), 1033, Marshal.SizeOf(typeof(Kernel32.GRPICONDIR)))
	{
		GroupIconResourceType = GroupType.Icon;
	}

	public void LoadFrom(string filename)
	{
		LoadFrom(filename, new IntPtr(1), new IntPtr(14L));
	}

	public void SaveTo(string filename)
	{
		SaveTo(filename, new IntPtr(int.Parse(base.Name)), new IntPtr(14L), base.Language);
		foreach (IconResource item in list_0)
		{
			item.SaveIconTo(filename);
		}
	}

	public override IntPtr Read(IntPtr hModule, IntPtr lpRes)
	{
		list_0.Clear();
		grpicondir_0 = (Kernel32.GRPICONDIR)Marshal.PtrToStructure(lpRes, typeof(Kernel32.GRPICONDIR));
		IntPtr intPtr = new IntPtr(lpRes.ToInt32() + Marshal.SizeOf((object)grpicondir_0));
		for (int i = 0; i < grpicondir_0.wImageCount; i++)
		{
			IconResource iconResource = new IconResource();
			intPtr = iconResource.Read(hModule, intPtr);
			list_0.Add(iconResource);
		}
		return intPtr;
	}

	public override void Write(BinaryWriter w)
	{
		w.Write(grpicondir_0.wReserved);
		w.Write(grpicondir_0.wType);
		w.Write((ushort)list_0.Count);
		ResourceUtil.smethod_0(w);
		foreach (IconResource item in list_0)
		{
			item.Write(w);
		}
	}
}
