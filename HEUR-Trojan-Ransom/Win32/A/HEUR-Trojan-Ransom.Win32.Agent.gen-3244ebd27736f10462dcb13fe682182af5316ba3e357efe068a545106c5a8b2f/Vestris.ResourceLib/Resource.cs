using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Vestris.ResourceLib;

public abstract class Resource
{
	protected ResourceId _type;

	protected ResourceId _name;

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

	public ResourceId Type => _type;

	public string TypeName
	{
		get
		{
			if (!_type.IsIntResource())
			{
				return _type.Name;
			}
			return _type.ResourceType.ToString();
		}
	}

	public ResourceId Name
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

	internal Resource()
	{
	}

	internal Resource(IntPtr hModule, IntPtr hResource, ResourceId type, ResourceId name, ushort language, int size)
	{
		_hModule = hModule;
		_type = type;
		_name = name;
		_language = language;
		_hResource = hResource;
		_size = size;
		LockAndReadResource(hModule, hResource);
	}

	internal void LockAndReadResource(IntPtr hModule, IntPtr hResource)
	{
		if (!(hResource == IntPtr.Zero))
		{
			IntPtr intPtr = Kernel32.LockResource(hResource);
			if (intPtr == IntPtr.Zero)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			Read(hModule, intPtr);
		}
	}

	public virtual void LoadFrom(string filename)
	{
		LoadFrom(filename, _type, _name, _language);
	}

	internal void LoadFrom(string filename, ResourceId type, ResourceId name, ushort lang)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = Kernel32.LoadLibraryEx(filename, IntPtr.Zero, 3u);
			LoadFrom(intPtr, type, name, lang);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Kernel32.FreeLibrary(intPtr);
			}
		}
	}

	internal void LoadFrom(IntPtr hModule, ResourceId type, ResourceId name, ushort lang)
	{
		if (IntPtr.Zero == hModule)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		IntPtr intPtr = Kernel32.FindResourceExW(hModule, type.Id, name.Id, lang);
		if (IntPtr.Zero == intPtr)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		IntPtr intPtr2 = Kernel32.LoadResource(hModule, intPtr);
		if (IntPtr.Zero == intPtr2)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		IntPtr intPtr3 = Kernel32.LockResource(intPtr2);
		if (intPtr3 == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		_size = Kernel32.SizeofResource(hModule, intPtr);
		if (_size <= 0)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		_type = type;
		_name = name;
		_language = lang;
		Read(hModule, intPtr3);
	}

	internal abstract IntPtr Read(IntPtr hModule, IntPtr lpRes);

	internal abstract void Write(BinaryWriter w);

	public byte[] WriteAndGetBytes()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream, Encoding.Default);
		Write(binaryWriter);
		binaryWriter.Close();
		return memoryStream.ToArray();
	}

	public virtual void SaveTo(string filename)
	{
		SaveTo(filename, _type, _name, _language);
	}

	internal void SaveTo(string filename, ResourceId type, ResourceId name, ushort langid)
	{
		byte[] data = WriteAndGetBytes();
		SaveTo(filename, type, name, langid, data);
	}

	public virtual void DeleteFrom(string filename)
	{
		Delete(filename, _type, _name, _language);
	}

	internal static void Delete(string filename, ResourceId type, ResourceId name, ushort lang)
	{
		SaveTo(filename, type, name, lang, null);
	}

	internal static void SaveTo(string filename, ResourceId type, ResourceId name, ushort lang, byte[] data)
	{
		IntPtr intPtr = Kernel32.BeginUpdateResourceW(filename, bDeleteExistingResources: false);
		if (intPtr == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		if (!Kernel32.UpdateResourceW(intPtr, type.Id, name.Id, lang, data, (data != null) ? ((uint)data.Length) : 0u))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		if (!Kernel32.EndUpdateResourceW(intPtr, fDiscard: false))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
	}
}
