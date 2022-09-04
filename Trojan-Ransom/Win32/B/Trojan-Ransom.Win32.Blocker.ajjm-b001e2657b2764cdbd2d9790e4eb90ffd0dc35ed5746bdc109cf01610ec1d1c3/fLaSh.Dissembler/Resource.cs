using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace fLaSh.Dissembler;

public class Resource
{
	protected string _type;

	protected string _name;

	protected ushort _language;

	protected IntPtr _hModule = IntPtr.Zero;

	protected IntPtr _hResource = IntPtr.Zero;

	protected int _size;

	public int Size => _size;

	public ushort Language
	{
		get
		{
			return _language;
		}
		set
		{
			_language = value;
		}
	}

	public string Type => _type;

	public string Name
	{
		get
		{
			return _name;
		}
		set
		{
			_name = value;
		}
	}

	public Resource()
	{
	}

	public Resource(IntPtr hModule, IntPtr hResource, IntPtr type, IntPtr name, ushort ushort_0, int size)
	{
		_hModule = hModule;
		_type = ResourceUtil.GetResourceName(type);
		_name = ResourceUtil.GetResourceName(name);
		_language = ushort_0;
		_hResource = hResource;
		_size = size;
	}

	public static byte[] LoadBytesFrom(string filename, IntPtr name, IntPtr type)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = Kernel32.LoadLibraryEx(filename, IntPtr.Zero, 3u);
			if (IntPtr.Zero == intPtr)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			IntPtr intPtr2 = Kernel32.FindResource(intPtr, name, type);
			if (IntPtr.Zero == intPtr2)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			IntPtr intPtr3 = Kernel32.LoadResource(intPtr, intPtr2);
			if (IntPtr.Zero == intPtr3)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			IntPtr intPtr4 = Kernel32.LockResource(intPtr3);
			if (intPtr4 == IntPtr.Zero)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			int num = Kernel32.SizeofResource(intPtr, intPtr2);
			if (num <= 0)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			byte[] array = new byte[num];
			Marshal.Copy(intPtr4, array, 0, num);
			return array;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Kernel32.FreeLibrary(intPtr);
			}
		}
	}

	public void LoadFrom(string filename, IntPtr name, IntPtr type)
	{
		_type = ResourceUtil.GetResourceName(type);
		_name = ResourceUtil.GetResourceName(name);
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = Kernel32.LoadLibraryEx(filename, IntPtr.Zero, 3u);
			if (IntPtr.Zero == intPtr)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			IntPtr intPtr2 = Kernel32.FindResource(intPtr, name, type);
			if (IntPtr.Zero == intPtr2)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			IntPtr intPtr3 = Kernel32.LoadResource(intPtr, intPtr2);
			if (IntPtr.Zero == intPtr3)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			IntPtr intPtr4 = Kernel32.LockResource(intPtr3);
			if (intPtr4 == IntPtr.Zero)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			_size = Kernel32.SizeofResource(intPtr, intPtr2);
			if (_size <= 0)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			Read(intPtr, intPtr4);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Kernel32.FreeLibrary(intPtr);
			}
		}
	}

	public virtual IntPtr Read(IntPtr hModule, IntPtr lpRes)
	{
		throw new NotImplementedException();
	}

	public virtual void Write(BinaryWriter w)
	{
		throw new NotImplementedException();
	}

	public byte[] WriteAndGetBytes()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream, Encoding.Default);
		Write(binaryWriter);
		binaryWriter.Close();
		return memoryStream.ToArray();
	}

	public void SaveTo(string filename, IntPtr name, IntPtr type, ushort langid)
	{
		byte[] data = WriteAndGetBytes();
		SaveTo(filename, name, type, langid, data);
	}

	public static void SaveTo(string filename, IntPtr name, IntPtr type, ushort lang, byte[] data)
	{
		IntPtr intPtr = Kernel32.BeginUpdateResourceW(filename, bDeleteExistingResources: false);
		if (intPtr == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		if (!Kernel32.UpdateResourceW(intPtr, type, name, lang, data, (uint)data.Length))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		if (!Kernel32.EndUpdateResourceW(intPtr, fDiscard: false))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
	}
}
