using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace fLaSh.Dissembler;

public class IconFile
{
	public enum GroupType
	{
		Icon = 1,
		Cursor
	}

	private Kernel32.FILEGRPICONDIR filegrpicondir_0 = default(Kernel32.FILEGRPICONDIR);

	private List<IconFileIcon> rLtAxnOgO = new List<IconFileIcon>();

	public GroupType Type
	{
		get
		{
			return (GroupType)filegrpicondir_0.wType;
		}
		set
		{
			filegrpicondir_0.wType = (byte)value;
		}
	}

	public List<IconFileIcon> Icons
	{
		get
		{
			return rLtAxnOgO;
		}
		set
		{
			rLtAxnOgO = value;
		}
	}

	public IconFile(string filename)
	{
		LoadFrom(filename);
	}

	public void LoadFrom(string filename)
	{
		byte[] array = File.ReadAllBytes(filename);
		IntPtr intPtr = Marshal.AllocHGlobal(array.Length);
		try
		{
			Marshal.Copy(array, 0, intPtr, array.Length);
			Read(intPtr);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public IntPtr Read(IntPtr lpData)
	{
		rLtAxnOgO.Clear();
		filegrpicondir_0 = (Kernel32.FILEGRPICONDIR)Marshal.PtrToStructure(lpData, typeof(Kernel32.FILEGRPICONDIR));
		IntPtr intPtr = new IntPtr(lpData.ToInt32() + Marshal.SizeOf((object)filegrpicondir_0));
		for (int i = 0; i < filegrpicondir_0.wCount; i++)
		{
			IconFileIcon iconFileIcon = new IconFileIcon();
			intPtr = iconFileIcon.Read(intPtr, lpData);
			rLtAxnOgO.Add(iconFileIcon);
		}
		return intPtr;
	}

	public GroupIconResource ConvertToGroupIconResource()
	{
		GroupIconResource groupIconResource = new GroupIconResource();
		switch (Type)
		{
		case GroupType.Icon:
			groupIconResource.GroupIconResourceType = GroupIconResource.GroupType.Icon;
			break;
		case GroupType.Cursor:
			groupIconResource.GroupIconResourceType = GroupIconResource.GroupType.Cursor;
			break;
		}
		for (int i = 0; i < Icons.Count; i++)
		{
			IconResource item = Icons[i].ConvertToIconResource((ushort)i);
			groupIconResource.Icons.Add(item);
		}
		return groupIconResource;
	}
}
