using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using O;

namespace ns0;

internal sealed class Class11
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 3)]
	private struct Struct8
	{
	}

	internal static readonly Struct8 struct8_0/* Not supported: data(01 01 01) */;

	internal static uint smethod_0(string string_0)
	{
		uint num = 2166136261u;
		if (string_0 != null)
		{
			for (int i = 0; i < GClass2.DRV.smethod_1(string_0, 96, 62); i++)
			{
				num = (string_0[i] ^ num) * 16777619;
			}
		}
		return num;
	}

	internal static DateTime smethod_1(short short_0, char char_0)
	{
		int num = 0;
		DateTime result = (((char_0 ^ short_0) - 120) ^ 0) switch
		{
			0 => DateTime.Now, 
			_ => default(DateTime), 
		};
		num++;
		return result;
	}

	internal static Clock smethod_2<T>(T gparam_0, char char_0, short short_0) where T : ServerComputer
	{
		int num = 0;
		Clock result;
		int num2;
		do
		{
			result = (Clock)((((short_0 ^ char_0) - 16) ^ num) switch
			{
				0 => ((ServerComputer)gparam_0).get_Clock(), 
				_ => null, 
			});
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static int smethod_3(ref DateTime dateTime_0, int int_0, short short_0)
	{
		int num = 0;
		int result;
		int num2;
		do
		{
			result = (((short_0 ^ int_0) - 8) ^ num) switch
			{
				3 => dateTime_0.Minute, 
				2 => dateTime_0.Year, 
				1 => dateTime_0.Month, 
				0 => dateTime_0.Day, 
				_ => 10, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static void smethod_4(int int_0, char char_0, short short_0)
	{
		int num = 0;
		switch (((char_0 ^ short_0) - 80) ^ 0)
		{
		case 0:
			Thread.Sleep(int_0);
			break;
		}
		num++;
	}

	internal static Process smethod_5(int int_0, char char_0, int int_1)
	{
		int num = 0;
		Process result = (((int_1 ^ char_0) - 33) ^ 0) switch
		{
			0 => (Process)(Component)Process.GetProcessById(int_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_6<T>(T gparam_0, int int_0, int int_1) where T : TextBox
	{
		int num = 0;
		string result = (((int_1 ^ int_0) - 59) ^ 0) switch
		{
			0 => (string)(IComparable<string>)((TextBox)gparam_0).get_Text(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static int smethod_7<T, U>(U gparam_0, T gparam_1, bool bool_0, char char_0, char char_1) where T : string where U : string
	{
		int num = 0;
		int result;
		do
		{
			result = (((char_1 ^ char_0) - 56) ^ num) switch
			{
				0 => Operators.CompareString((string)gparam_0, (string)gparam_1, bool_0), 
				_ => 8, 
			};
			num++;
		}
		while ((char_1 * char_1 + char_1) % 2 != 0);
		return result;
	}

	internal static byte[] smethod_8<T>(T gparam_0, char char_0, int int_0) where T : MemoryStream
	{
		int num = 0;
		byte[] result;
		do
		{
			result = (((int_0 ^ char_0) - 55) ^ num) switch
			{
				0 => gparam_0.ToArray(), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static string smethod_9<T, U, V>(T gparam_0, U gparam_1, V gparam_2, int int_0, short short_0) where T : string where U : string where V : string
	{
		int num = 0;
		string result;
		do
		{
			result = (((short_0 ^ int_0) - 86) ^ num) switch
			{
				0 => (string)(IEquatable<string>)string.Concat(gparam_0, gparam_1, gparam_2), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static Array smethod_10<T, U>(U gparam_0, T gparam_1, char char_0, int int_0) where T : Array where U : Array
	{
		int num = 0;
		Array result;
		int num2;
		do
		{
			result = (((int_0 ^ char_0) - 4) ^ num) switch
			{
				0 => (Array)(ICloneable)Utils.CopyArray((Array)gparam_0, (Array)gparam_1), 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static Encoding smethod_11(short short_0, short short_1)
	{
		int num = 0;
		Encoding result;
		int num2;
		do
		{
			result = (((short_1 ^ short_0) - 48) ^ num) switch
			{
				0 => (Encoding)(ICloneable)Encoding.Unicode, 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static Group smethod_12<T>(T gparam_0, int int_0, short short_0, short short_1) where T : GroupCollection
	{
		int num = 0;
		Group result;
		do
		{
			result = (((short_1 ^ short_0) - 83) ^ num) switch
			{
				0 => (Group)(Capture)gparam_0[int_0], 
				_ => null, 
			};
			num++;
		}
		while ((short_1 * short_1 + short_1) % 2 != 0);
		return result;
	}

	internal static RegistryKey smethod_13<T, U>(U gparam_0, T gparam_1, int int_0, int int_1) where T : string where U : RegistryKey
	{
		int num = 0;
		RegistryKey result = (((int_0 ^ int_1) - 61) ^ 0) switch
		{
			0 => (RegistryKey)(IDisposable)gparam_0.OpenSubKey(gparam_1), 
			1 => (RegistryKey)(IDisposable)gparam_0.CreateSubKey(gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static GCHandle smethod_14<T>(T gparam_0, GCHandleType gchandleType_0, int int_0, char char_0)
	{
		int num = 0;
		GCHandle result = (((int_0 ^ char_0) - 1) ^ 0) switch
		{
			0 => GCHandle.Alloc(gparam_0, gchandleType_0), 
			_ => default(GCHandle), 
		};
		num++;
		return result;
	}

	internal static ImageCodecInfo[] smethod_15(int int_0, char char_0)
	{
		int num = 0;
		ImageCodecInfo[] result;
		int num2;
		do
		{
			result = (((int_0 ^ char_0) - 123) ^ num) switch
			{
				0 => ImageCodecInfo.GetImageEncoders(), 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static int smethod_16(ref Rectangle rectangle_0, short short_0, short short_1)
	{
		int num = 0;
		int result = (((short_0 ^ short_1) - 125) ^ 0) switch
		{
			0 => rectangle_0.Height, 
			_ => 4, 
		};
		num++;
		return result;
	}

	internal static Bitmap smethod_17<T>(T gparam_0, Rectangle rectangle_0, PixelFormat pixelFormat_0, char char_0, char char_1) where T : Bitmap
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		Bitmap result = (Bitmap)((((char_1 ^ char_0) - 40) ^ 0) switch
		{
			0 => ((Bitmap)gparam_0).Clone(rectangle_0, pixelFormat_0), 
			_ => null, 
		});
		num++;
		return result;
	}

	internal static int smethod_18(ref Point point_0, char char_0, int int_0)
	{
		int num = 0;
		int result = (((int_0 ^ char_0) - 8) ^ 0) switch
		{
			0 => point_0.X, 
			1 => point_0.Y, 
			_ => int_0, 
		};
		num++;
		return result;
	}

	internal static bool smethod_19<T, U>(T gparam_0, U gparam_1, short short_0, short short_1) where T : Hashtable
	{
		int num = 0;
		bool result = (((short_1 ^ short_0) - 41) ^ 0) switch
		{
			0 => gparam_0.ContainsKey(gparam_1), 
			_ => false, 
		};
		num++;
		return result;
	}

	internal static Exception smethod_20<T>(T gparam_0, short short_0, char char_0) where T : Exception
	{
		int num = 0;
		Exception result;
		do
		{
			result = (((short_0 ^ char_0) - 90) ^ num) switch
			{
				0 => (Exception)(ISerializable)gparam_0.InnerException, 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static void smethod_21<T, U>(U gparam_0, T gparam_1, short short_0, char char_0) where T : string where U : string
	{
		int num = 0;
		switch (((short_0 ^ char_0) - 54) ^ 0)
		{
		case 0:
			File.Copy(gparam_0, gparam_1);
			break;
		}
		num++;
	}

	internal static DirectoryInfo[] smethod_22<T>(T gparam_0, int int_0, char char_0) where T : DirectoryInfo
	{
		int num = 0;
		DirectoryInfo[] result = (((char_0 ^ int_0) - 105) ^ 0) switch
		{
			0 => (DirectoryInfo[])(Array)gparam_0.GetDirectories(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_23<T, U, V>(U gparam_0, V gparam_1, T gparam_2, object[] object_0, string[] string_0, Type[] type_0, char char_0, char char_1) where T : string where V : Type
	{
		int num = 0;
		switch (((char_1 ^ char_0) - 58) ^ 0)
		{
		case 0:
			NewLateBinding.LateSet((object)gparam_0, (Type)gparam_1, (string)gparam_2, object_0, string_0, type_0);
			break;
		}
		num++;
	}

	internal static void smethod_24<T, U>(U gparam_0, T gparam_1, char char_0, int int_0) where U : Thread
	{
		int num = 0;
		switch (((int_0 ^ char_0) - 5) ^ 0)
		{
		case 0:
			gparam_0.Start(gparam_1);
			break;
		}
		num++;
	}

	internal static DirectoryInfo smethod_25<T>(T gparam_0, short short_0, int int_0) where T : FileInfo
	{
		int num = 0;
		DirectoryInfo result;
		int num2;
		do
		{
			result = (((short_0 ^ int_0) - 108) ^ num) switch
			{
				0 => gparam_0.Directory, 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}
}
