using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace Vestris.ResourceLib;

public class IconFile
{
	public enum GroupType
	{
		Icon = 1,
		Cursor
	}

	private Kernel32.FILEGRPICONDIR _header = default(Kernel32.FILEGRPICONDIR);

	private List<IconFileIcon> _icons = new List<IconFileIcon>();

	public GroupType Type
	{
		get
		{
			return (GroupType)_header.wType;
		}
		set
		{
			_header.wType = (byte)value;
		}
	}

	public List<IconFileIcon> Icons
	{
		get
		{
			return _icons;
		}
		set
		{
			_icons = value;
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

	internal IntPtr Read(IntPtr lpData)
	{
		_icons.Clear();
		_header = (Kernel32.FILEGRPICONDIR)Marshal.PtrToStructure(lpData, typeof(Kernel32.FILEGRPICONDIR));
		IntPtr intPtr = new IntPtr(lpData.ToInt32() + Marshal.SizeOf((object)_header));
		for (int i = 0; i < _header.wCount; i++)
		{
			IconFileIcon iconFileIcon = new IconFileIcon();
			intPtr = iconFileIcon.Read(intPtr, lpData);
			_icons.Add(iconFileIcon);
		}
		return intPtr;
	}
}
