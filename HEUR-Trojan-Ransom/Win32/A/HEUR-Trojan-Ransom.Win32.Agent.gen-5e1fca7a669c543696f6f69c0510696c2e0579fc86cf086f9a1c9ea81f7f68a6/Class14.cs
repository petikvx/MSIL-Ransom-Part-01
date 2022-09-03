using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;

internal sealed class Class14
{
	private static bool bool_0;

	private string string_0 = string.Empty;

	private int int_0 = -1;

	private static Class8.IShellFolder ishellFolder_0;

	private Class8.IShellFolder ishellFolder_1;

	private IntPtr intptr_0 = IntPtr.Zero;

	private bool bool_1;

	private bool bool_2;

	private string string_1 = string.Empty;

	public Class14()
	{
		if (bool_0)
		{
			throw new Exception("The Desktop shell item already exists so cannot be created again.");
		}
		int num = Class8.SHGetDesktopFolder(ref ishellFolder_0);
		if (num != 0)
		{
			Marshal.ThrowExceptionForHR(num);
		}
		num = Class8.SHGetSpecialFolderLocation(IntPtr.Zero, (Class8.Enum6)0u, ref intptr_0);
		if (num != 0)
		{
			Marshal.ThrowExceptionForHR(num);
		}
		Class8.Struct1 struct1_ = default(Class8.Struct1);
		Class8.SHGetFileInfo_1(intptr_0, 0u, out struct1_, (uint)Marshal.SizeOf((object)struct1_), (Class8.Enum4)16905);
		method_3(struct1_.string_0);
		method_5(struct1_.int_0);
		method_10(bool_3: true);
		method_12(bool_3: true);
		method_14(method_0());
		ishellFolder_1 = method_6();
		bool_0 = true;
	}

	public Class14(Class8.IShellFolder ishellFolder_2, IntPtr intptr_1, Class14 class14_0)
	{
		if (!bool_0)
		{
			throw new Exception("The root shell item must be created before creating a sub-item");
		}
		intptr_0 = Class8.ILCombine(class14_0.method_8(), intptr_1);
		Class8.Enum3 rgfInOut = Class8.Enum3.SFGAO_FOLDER | Class8.Enum3.SFGAO_HASSUBFOLDER;
		ishellFolder_2.GetAttributesOf(1, out intptr_0, out rgfInOut);
		method_10(Convert.ToBoolean(rgfInOut & Class8.Enum3.SFGAO_FOLDER));
		method_12(Convert.ToBoolean(rgfInOut & Class8.Enum3.SFGAO_HASSUBFOLDER));
		Class8.Struct1 struct1_ = default(Class8.Struct1);
		Class8.SHGetFileInfo_1(intptr_0, 0u, out struct1_, (uint)Marshal.SizeOf((object)struct1_), (Class8.Enum4)16905);
		method_3(struct1_.string_0);
		method_5(struct1_.int_0);
		method_14(method_0());
		if (method_9())
		{
			uint num = class14_0.ishellFolder_1.BindToObject(intptr_1, IntPtr.Zero, ref Class8.guid_0, out ishellFolder_1);
			if (num != 0)
			{
				Marshal.ThrowExceptionForHR((int)num);
			}
		}
	}

	~Class14()
	{
		if (ishellFolder_1 != null)
		{
			Marshal.ReleaseComObject(ishellFolder_1);
		}
		if (!intptr_0.Equals((object?)(nint)IntPtr.Zero))
		{
			Marshal.FreeCoTaskMem(intptr_0);
		}
		GC.SuppressFinalize(this);
	}

	public string method_0()
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		Class8.SHGetPathFromIDList(intptr_0, stringBuilder);
		return stringBuilder.ToString();
	}

	public ArrayList method_1()
	{
		if (!method_9())
		{
			throw new Exception("Unable to retrieve sub-folders for a non-folder.");
		}
		ArrayList arrayList = new ArrayList();
		try
		{
			Class8.IEnumIDList ppenumIDList = null;
			uint num = method_7().EnumObjects(IntPtr.Zero, (Class8.Enum2)32u, out ppenumIDList);
			if (num != 0)
			{
				Marshal.ThrowExceptionForHR((int)num);
			}
			IntPtr rgelt = IntPtr.Zero;
			int pceltFetched = 0;
			ppenumIDList.Next(1u, out rgelt, out pceltFetched);
			while (!rgelt.Equals((object?)(nint)IntPtr.Zero) && pceltFetched == 1)
			{
				arrayList.Add(new Class14(ishellFolder_0, rgelt, this));
				Marshal.FreeCoTaskMem(rgelt);
				rgelt = IntPtr.Zero;
				pceltFetched = 0;
				ppenumIDList.Next(1u, out rgelt, out pceltFetched);
			}
			if (ppenumIDList != null)
			{
				Marshal.ReleaseComObject(ppenumIDList);
				return arrayList;
			}
			return arrayList;
		}
		catch
		{
			return arrayList;
		}
	}

	public string method_2()
	{
		return string_0;
	}

	public void method_3(string string_2)
	{
		string_0 = string_2;
	}

	public int method_4()
	{
		return int_0;
	}

	public void method_5(int int_1)
	{
		int_0 = int_1;
	}

	public Class8.IShellFolder method_6()
	{
		return ishellFolder_0;
	}

	public Class8.IShellFolder method_7()
	{
		return ishellFolder_1;
	}

	public IntPtr method_8()
	{
		return intptr_0;
	}

	public bool method_9()
	{
		return bool_1;
	}

	public void method_10(bool bool_3)
	{
		bool_1 = bool_3;
	}

	public bool method_11()
	{
		return bool_2;
	}

	public void method_12(bool bool_3)
	{
		bool_2 = bool_3;
	}

	public string method_13()
	{
		return string_1;
	}

	public void method_14(string string_2)
	{
		string_1 = string_2;
	}
}
