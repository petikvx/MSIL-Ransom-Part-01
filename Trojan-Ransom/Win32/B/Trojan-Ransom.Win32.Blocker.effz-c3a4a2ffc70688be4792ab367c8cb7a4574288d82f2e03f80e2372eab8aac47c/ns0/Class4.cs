using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using SmartAssembly.License;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsWithUI;

namespace ns0;

internal sealed class Class4
{
	public struct Struct13
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		static Struct13()
		{
			try
			{
				Exception1.smethod_3();
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException1(exception, num);
				throw;
			}
		}
	}

	public struct Struct14
	{
		public bool bool_0;

		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		public int int_6;

		public int int_7;

		public int int_8;

		static Struct14()
		{
			try
			{
				Exception1.smethod_3();
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException1(exception, num);
				throw;
			}
		}
	}

	public static Struct14 struct14_0;

	public static string[] string_0;

	public static MemoryStream[] memoryStream_0;

	public static string[] string_1;

	public static string[] string_2;

	public static bool bool_0;

	public Class4()
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	static Class4()
	{
		try
		{
			Exception1.smethod_3();
			bool_0 = false;
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException1(exception, num);
			throw;
		}
	}

	private static long smethod_0(Stream stream_0)
	{
		int num = default(int);
		long num2 = default(long);
		int num3 = default(int);
		int num4 = default(int);
		int num6 = default(int);
		try
		{
			num = 4;
			while (true)
			{
				num2 = 0L;
				num3 = 0;
				num4 = 2;
				num = 2;
				while (true)
				{
					num = 9;
					int num5;
					if (num3 < 8)
					{
						num = 6;
						num5 = 8;
					}
					else
					{
						num = 13;
						num5 = 4;
					}
					num4 = num5;
					num = 2;
					switch (num4)
					{
					case 1:
						num = 1;
						goto IL_0070;
					case 5:
						num = 1;
						goto IL_0070;
					case 6:
						num = 8;
						goto IL_0047;
					case 8:
						num = 8;
						goto IL_0047;
					case 7:
						num = 1;
						goto IL_0070;
					case 2:
						break;
					default:
						num = 5;
						goto IL_008f;
					case 0:
						num = 5;
						goto IL_008f;
					case 3:
						goto end_IL_0080;
					case 4:
						{
							num = 0;
							return num2;
						}
						IL_008f:
						num4 = 3;
						num = 2;
						goto end_IL_0080;
						IL_0047:
						num6 = Class0.smethod_3(stream_0, 163, 203);
						num2 |= (long)((ulong)(byte)num6 << 8 * num3);
						num = 10;
						num4 = 7;
						num = 2;
						goto case 7;
						IL_0070:
						num3++;
						num4 = 2;
						num = 2;
						break;
					}
					continue;
					end_IL_0080:
					break;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num2, num3, num6, num4, num, stream_0);
			throw;
		}
	}

	private static Struct14 smethod_1(MemoryStream memoryStream_1)
	{
		int num = default(int);
		byte[] array = default(byte[]);
		int num2 = default(int);
		GCHandle gchandle_ = default(GCHandle);
		Struct14 @struct = default(Struct14);
		try
		{
			num = 0;
			array = new byte[Class0.smethod_5(Class0.smethod_4(typeof(Struct14).TypeHandle, 859, 834), 710, 740)];
			num = 12;
			num2 = 3;
			num = 9;
			Exception0.smethod_0(memoryStream_1, array, 0, Class0.smethod_5(Class0.smethod_4(typeof(Struct14).TypeHandle, 855, 846), 29, 63), 915, 981);
			num = 7;
			num2 = 0;
			num = 9;
			gchandle_ = Class10.Class11.smethod_6(array, GCHandleType.Pinned, 488, 395);
			@struct = (Struct14)Class7.Class8.Class9.smethod_1(Class10.Class11.smethod_7(ref gchandle_, 749, 689), Class10.smethod_0(typeof(Struct14).TypeHandle, 67, 116), 640, 683);
			num = 1;
			num2 = 1;
			num = 9;
			gchandle_.Free();
			return @struct;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, array, gchandle_, @struct, num2, num, memoryStream_1);
			throw;
		}
	}

	private static Struct13 smethod_2(MemoryStream memoryStream_1, int int_0, ref string string_3, ref MemoryStream memoryStream_2)
	{
		int num = default(int);
		byte[] array = default(byte[]);
		int num2 = default(int);
		GCHandle gchandle_ = default(GCHandle);
		Struct13 @struct = default(Struct13);
		byte[] array2 = default(byte[]);
		byte[] array3 = default(byte[]);
		try
		{
			num = 10;
			array = new byte[Class0.smethod_5(Class0.smethod_4(typeof(Struct13).TypeHandle, 486, 511), 407, 437)];
			num2 = 8;
			num = 2;
			Class1.smethod_2(memoryStream_1, int_0, SeekOrigin.Begin, 49, 32);
			Exception0.smethod_0(memoryStream_1, array, 0, Class0.smethod_5(Class0.smethod_4(typeof(Struct13).TypeHandle, 659, 650), 36, 6), 538, 604);
			num = 18;
			num2 = 7;
			num = 2;
			gchandle_ = GClass1.smethod_4(array, GCHandleType.Pinned, 477, 480);
			@struct = (Struct13)Class5.smethod_0(GClass1.smethod_5(ref gchandle_, 746, 667), Class0.smethod_4(typeof(Struct13).TypeHandle, 979, 970), 1007, 919);
			num = 11;
			num2 = 9;
			num = 2;
			GClass1.smethod_6(ref gchandle_, 821, 842);
			array2 = new byte[@struct.int_3];
			Class1.smethod_2(memoryStream_1, @struct.int_2, SeekOrigin.Begin, 449, 464);
			num = 16;
			num2 = 10;
			num = 2;
			Class7.Class8.smethod_1(memoryStream_1, array2, 0, @struct.int_3, 97, 113);
			num = 13;
			string_3 = Class7.Class8.smethod_3(Class7.Class8.Class9.smethod_2(865, 779), array2, 603, 605);
			num = 0;
			num2 = 0;
			num = 2;
			array3 = new byte[@struct.int_1];
			Class7.Class8.Class9.smethod_3(memoryStream_1, @struct.int_0, SeekOrigin.Begin, 643, 728);
			num = 15;
			num2 = 5;
			num = 2;
			Class7.Class8.smethod_1(memoryStream_1, array3, 0, @struct.int_1, 867, 883);
			num = 6;
			memoryStream_2.Write(array3, 0, @struct.int_1);
			num2 = 4;
			num = 2;
			return @struct;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[11]
			{
				array, gchandle_, @struct, array2, array3, num2, num, memoryStream_1, int_0, string_3,
				memoryStream_2
			});
			throw;
		}
	}

	private static string smethod_3(MemoryStream memoryStream_1, int int_0, int int_1)
	{
		int num = default(int);
		byte[] array = default(byte[]);
		int num2 = default(int);
		string text = default(string);
		try
		{
			num = 5;
			array = new byte[int_1];
			num = 1;
			Class1.smethod_2(memoryStream_1, int_0, SeekOrigin.Begin, 1001, 1016);
			num2 = 0;
			num = 7;
			Exception0.smethod_0(memoryStream_1, array, 0, int_1, 943, 1001);
			text = Class7.Class8.smethod_3(Class7.Class8.Class9.smethod_2(760, 658), array, 556, 554);
			num = 0;
			num2 = 6;
			num = 7;
			return text;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, array, text, num2, num, memoryStream_1, int_0, int_1);
			throw;
		}
	}

	private static Assembly smethod_4(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		int num = default(int);
		string o = default(string);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			num = 13;
			while (true)
			{
				o = GClass1.smethod_7(GClass2.smethod_1(new AssemblyName(Class0.smethod_6(resolveEventArgs_0, 710, 718)), 465, 411), GClass2.smethod_0(1618745721, 1), 527, 519);
				num = 6;
				num2 = 4;
				num = 10;
				while (true)
				{
					num = 4;
					num3 = 1;
					num2 = 5;
					num = 10;
					while (true)
					{
						num = 18;
						int num4;
						if (num3 < struct14_0.int_0)
						{
							num = 2;
							num4 = 10;
						}
						else
						{
							num = 8;
							num4 = 1;
						}
						num2 = num4;
						num = 10;
						while (true)
						{
							int num5;
							switch (num2)
							{
							case 10:
								num = 11;
								goto IL_0015;
							case 2:
								num = 11;
								goto IL_0015;
							case 0:
								num = 0;
								goto IL_007d;
							case 7:
								num = 0;
								goto IL_007d;
							case 5:
								break;
							case 4:
								goto end_IL_0090;
							default:
								num = 7;
								goto IL_00ba;
							case 6:
								num = 7;
								goto IL_00ba;
							case 8:
								num = 7;
								goto IL_00ba;
							case 9:
								num = 13;
								goto end_IL_00a5;
							case 1:
								num = 12;
								return null;
							case 3:
								{
									num = 5;
									return Class10.smethod_5(Exception0.smethod_1(memoryStream_0[num3], 483, 502), 493, 391);
								}
								IL_00ba:
								num2 = 9;
								num = 10;
								goto case 9;
								IL_007d:
								num3++;
								num2 = 5;
								num = 10;
								break;
								IL_0015:
								if (Exception1.smethod_0(string_0[num3], o, bool_1: true, 680, 706) == 0)
								{
									num = 14;
									num5 = 3;
								}
								else
								{
									num = 1;
									num5 = 0;
								}
								num2 = num5;
								num = 10;
								continue;
							}
							break;
						}
						continue;
						end_IL_0090:
						break;
					}
					continue;
					end_IL_00a5:
					break;
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, o, num3, num2, num, object_0, resolveEventArgs_0);
			throw;
		}
	}

	public static bool smethod_5(string string_3, string string_4)
	{
		int num = default(int);
		int num3 = default(int);
		Regex regex = default(Regex);
		try
		{
			num = 8;
			while (true)
			{
				int num2;
				if (string_3 == null)
				{
					num = 12;
					num2 = 6;
				}
				else
				{
					num = 6;
					num2 = 8;
				}
				num3 = num2;
				num = 4;
				while (true)
				{
					int num4;
					switch (num3)
					{
					case 8:
						num = 5;
						if (GClass2.smethod_2(string_3, 630, 557) == 0)
						{
							num = 3;
							num4 = 6;
						}
						else
						{
							num = 11;
							num4 = 0;
						}
						goto IL_002a;
					default:
						num = 9;
						goto IL_005f;
					case 7:
						num = 9;
						goto IL_005f;
					case 1:
						break;
					case 0:
						num = 7;
						goto IL_007b;
					case 2:
						num = 1;
						goto IL_00ea;
					case 4:
						num = 7;
						goto IL_007b;
					case 3:
						num = 10;
						goto IL_00f6;
					case 5:
						num = 10;
						goto IL_00f6;
					case 6:
						{
							num = 16;
							return false;
						}
						IL_007b:
						regex = new Regex(Class7.smethod_4(Class10.Class11.smethod_8(Exception1.smethod_1(Exception1.smethod_1(string_4, GClass2.smethod_0(1618745718, 7), GClass2.smethod_0(1618745719, 2), 529, 559), GClass2.smethod_0(1618745705, 2), GClass2.smethod_0(1618745705, 6), 14, 48), '?', '.', 675, 755), 299, 259));
						num = 1;
						goto IL_00ea;
						IL_00ea:
						num3 = 3;
						num = 4;
						goto case 3;
						IL_00f6:
						return regex.IsMatch(string_3.ToLower());
						IL_005f:
						num3 = 1;
						num = 4;
						break;
					}
					break;
					IL_002a:
					num3 = num4;
					num = 4;
				}
				num = 8;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, regex, num3, num, string_3, string_4);
			throw;
		}
	}

	public static bool smethod_6(string string_3, string[] string_4)
	{
		int num = default(int);
		string[] array = default(string[]);
		int num2 = default(int);
		int num3 = default(int);
		string text = default(string);
		bool flag = default(bool);
		try
		{
			num = 9;
			while (true)
			{
				array = string_4;
				num2 = 0;
				num3 = 8;
				num = 5;
				while (true)
				{
					num = 17;
					int num4;
					if (num2 < array.Length)
					{
						num = 8;
						num4 = 3;
					}
					else
					{
						num = 2;
						num4 = 7;
					}
					num3 = num4;
					num = 5;
					while (true)
					{
						switch (num3)
						{
						case 3:
						{
							num = 11;
							text = array[num2];
							int num5;
							if (smethod_5(string_3, text))
							{
								num = 7;
								num5 = 6;
							}
							else
							{
								num = 13;
								num5 = 2;
							}
							num3 = num5;
							num = 5;
							continue;
						}
						case 2:
							num = 3;
							num2++;
							num3 = 8;
							num = 5;
							break;
						case 8:
							break;
						default:
							num = 10;
							goto IL_0090;
						case 1:
							num = 9;
							goto end_IL_0073;
						case 4:
							num = 9;
							goto end_IL_0073;
						case 5:
							num = 10;
							goto IL_0090;
						case 10:
							num = 9;
							goto end_IL_0073;
						case 0:
							num = 16;
							goto IL_00af;
						case 6:
							num = 6;
							flag = true;
							num = 16;
							goto IL_00af;
						case 7:
							num = 1;
							return false;
						case 9:
							{
								num = 18;
								return flag;
							}
							IL_00af:
							num3 = 9;
							num = 5;
							goto case 9;
							IL_0090:
							num3 = 10;
							num = 5;
							goto case 10;
						}
						break;
					}
					continue;
					end_IL_0073:
					break;
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException8(exception, text, flag, array, num2, num3, num, string_3, string_4);
			throw;
		}
	}

	public static void smethod_7()
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 3;
			num2 = 3;
			num = 4;
			Class0.smethod_8(Class0.smethod_7(682, 743), 112, 6);
			Class7.Class8.Class9.smethod_4(Class7.Class8.smethod_4(922, 902), 277, 289);
			num = 6;
			num2 = 0;
			num = 4;
			Process.GetCurrentProcess().Kill();
		}
		catch (Exception exception)
		{
			int num3 = default(int);
			StackFrameHelper.CreateException3(exception, num2, num, num3);
			throw;
		}
	}

	public static void smethod_8()
	{
		int num = default(int);
		int num2 = default(int);
		Process[] array = default(Process[]);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		try
		{
			while (true)
			{
				num = 4;
				num2 = 3;
				num = 6;
				if (bool_0)
				{
					break;
				}
				while (true)
				{
					array = GClass1.smethod_8(658, 760);
					num3 = 0;
					num4 = 3;
					while (true)
					{
						num5 = 9;
						num4 = 17;
						while (true)
						{
							num4 = 15;
							int num6;
							if (num3 < array.Length - 1)
							{
								num4 = 6;
								num6 = 4;
							}
							else
							{
								num4 = 8;
								num6 = 0;
							}
							num5 = num6;
							num4 = 17;
							while (true)
							{
								int num8;
								switch (num5)
								{
								case 11:
									num4 = 20;
									smethod_7();
									goto IL_0026;
								case 10:
									num4 = 18;
									goto IL_0026;
								case 4:
								{
									num4 = 9;
									int num7;
									if (smethod_6(Exception1.smethod_2(array[num3], 118, 20), string_1))
									{
										num4 = 16;
										num7 = 11;
									}
									else
									{
										num4 = 1;
										num7 = 10;
									}
									num5 = num7;
									num4 = 17;
									continue;
								}
								case 2:
									num4 = 7;
									goto IL_00c6;
								case 3:
									num4 = 7;
									goto IL_00c6;
								case 5:
									num4 = 12;
									goto IL_00d0;
								case 9:
									break;
								case 7:
									goto end_IL_00f7;
								case 1:
									goto end_IL_010b;
								case 8:
									goto IL_0118;
								case 0:
									goto end_IL_011b;
								default:
									num4 = 19;
									return;
								case 6:
									{
										num4 = 19;
										return;
									}
									IL_00c6:
									smethod_7();
									goto IL_00d0;
									IL_00d0:
									GClass0.smethod_1(100, 938, 913);
									num3++;
									num5 = 9;
									num4 = 17;
									break;
									IL_0026:
									if (smethod_6(Exception1.smethod_2(array[num3], 308, 343), string_2))
									{
										num4 = 2;
										num8 = 2;
									}
									else
									{
										num4 = 5;
										num8 = 5;
									}
									num5 = num8;
									num4 = 17;
									continue;
								}
								break;
							}
							continue;
							end_IL_00f7:
							break;
						}
						num4 = 3;
						continue;
						end_IL_010b:
						break;
					}
					num4 = 21;
					continue;
					IL_0118:
					num4 = 21;
					continue;
					end_IL_011b:
					break;
				}
				num4 = 14;
				Class10.Class11.smethod_9(1500, 70, 18);
			}
			num = 7;
			num2 = 4;
			num = 6;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, array, num3, num2, num5, num, num4);
			throw;
		}
	}

	[STAThread]
	private static void Main(string[] args)
	{
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		if (!License.Validate())
		{
			return;
		}
		int num = default(int);
		int num2 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		MemoryStream memoryStream2 = default(MemoryStream);
		long num3 = default(long);
		byte[] array = default(byte[]);
		GClass3 gClass = default(GClass3);
		long num4 = default(long);
		DateTime dateTime_ = default(DateTime);
		string text = default(string);
		string text2 = default(string);
		int num5 = default(int);
		int num7 = default(int);
		string text3 = default(string);
		string text4 = default(string);
		Assembly assembly = default(Assembly);
		char[] array4 = default(char[]);
		Thread thread = default(Thread);
		int num10 = default(int);
		object[] array3 = default(object[]);
		int num12 = default(int);
		char[] array2 = default(char[]);
		try
		{
			if (!UnhandledExceptionHandlerWithUI.AttachApp())
			{
				return;
			}
			num = 5;
			Exception1.smethod_3();
			num2 = 1;
			num = 20;
			memoryStream = new MemoryStream();
			num = 7;
			memoryStream2 = new MemoryStream(Class1.smethod_1());
			Class1.smethod_2(memoryStream2, -8L, SeekOrigin.End, 951, 934);
			num = 17;
			num2 = 6;
			num = 20;
			num3 = smethod_0(memoryStream2);
			Class1.smethod_2(memoryStream2, -num3 - 8L, SeekOrigin.Current, 279, 262);
			num = 3;
			num2 = 4;
			num = 20;
			array = new byte[5];
			Exception0.smethod_0(memoryStream2, array, 0, 5, 517, 579);
			num = 9;
			num2 = 3;
			num = 20;
			gClass = new GClass3();
			gClass.imethod_1(array);
			num4 = smethod_0(memoryStream2);
			gClass.imethod_0(memoryStream2, memoryStream, num3, num4, null);
			num = 4;
			num2 = 10;
			num = 20;
			Exception0.smethod_2(memoryStream2, 459, 407);
			Class1.smethod_2(memoryStream, 0L, SeekOrigin.Begin, 904, 921);
			num = 10;
			num2 = 7;
			num = 20;
			struct14_0 = smethod_1(memoryStream);
			dateTime_ = new DateTime(struct14_0.int_6, struct14_0.int_7, struct14_0.int_8);
			num = 12;
			num2 = 5;
			num = 20;
			if (Exception0.smethod_4(Exception0.smethod_3(450, 458), dateTime_, 869, 863))
			{
				num = 14;
				num2 = 8;
				num = 20;
				text = GClass2.smethod_0(1618745706, 8);
				num = 19;
				text2 = GClass2.smethod_0(1618745349, 5);
				GClass3.smethod_0(GClass2.smethod_3(text, Class5.smethod_1(Class1.smethod_3(567, 580), 849, 891), 511, 390), text2, (MessageBoxButtons)0, (MessageBoxIcon)16, 479, 492);
				return;
			}
			while (true)
			{
				int num6;
				if (!struct14_0.bool_0)
				{
					num5 = 25;
					num6 = 3;
				}
				else
				{
					num5 = 30;
					num6 = 12;
				}
				num7 = num6;
				num5 = 38;
				while (true)
				{
					int num14;
					switch (num7)
					{
					case 23:
						num5 = 12;
						text3 = GClass2.smethod_0(1618745384, 2);
						text4 = GClass2.smethod_0(1618746158, 2);
						Class7.smethod_5(Class7.Class8.Class9.smethod_6(text3, Class10.smethod_6(ref dateTime_, GClass2.smethod_0(1618746331, 1), 312, 310), Class10.smethod_4(Class7.Class8.Class9.smethod_5(463, 401), 97, 79), 37, 111), text4, (MessageBoxButtons)0, (MessageBoxIcon)64, 415, 443);
						num5 = 43;
						num7 = 1;
						num5 = 38;
						goto case 1;
					case 1:
					{
						num5 = 0;
						int num9;
						if (Class7.Class8.Class9.smethod_7(Class7.Class8.smethod_5(assembly, 363, 326), 514, 638).Length == 0)
						{
							num5 = 21;
							num9 = 7;
						}
						else
						{
							num5 = 46;
							num9 = 19;
						}
						num7 = num9;
						num5 = 38;
						continue;
					}
					case 22:
						num5 = 14;
						Exception0.smethod_5(Class5.smethod_2(677, 721), smethod_4, 148, 216);
						goto IL_02cf;
					case 21:
					{
						num5 = 3;
						string text6 = smethod_3(memoryStream, struct14_0.int_3, struct14_0.int_4);
						array4 = new char[1] { '|' };
						string_2 = GClass3.smethod_1(text6, array4, 164, 144);
						num5 = 40;
						num7 = 11;
						num5 = 38;
						goto case 11;
					}
					case 11:
						num5 = 8;
						thread = new Thread(smethod_8);
						GClass3.smethod_2(thread, 677, 703);
						goto IL_0384;
					case 9:
						num5 = 24;
						num10 = 0;
						num7 = 0;
						num5 = 38;
						goto case 0;
					case 0:
					{
						num5 = 22;
						int num11;
						if (num10 >= struct14_0.int_0)
						{
							num5 = 36;
							num11 = 2;
						}
						else
						{
							num5 = 45;
							num11 = 16;
						}
						num7 = num11;
						num5 = 38;
						continue;
					}
					case 20:
						num5 = 7;
						goto IL_0418;
					case 14:
						num5 = 33;
						goto IL_0424;
					case 19:
					{
						num5 = 29;
						MethodInfo? entryPoint = assembly.EntryPoint;
						array3 = new object[1] { args };
						entryPoint!.Invoke(null, array3);
						num5 = 26;
						num7 = 13;
						num5 = 38;
						goto case 13;
					}
					case 13:
					{
						num5 = 18;
						int num13;
						if (struct14_0.bool_0)
						{
							num5 = 19;
							num13 = 8;
						}
						else
						{
							num5 = 34;
							num13 = 5;
						}
						num7 = num13;
						num5 = 38;
						continue;
					}
					case 17:
						num5 = 20;
						goto IL_02cf;
					case 16:
						num5 = 17;
						string_0[num10] = string.Empty;
						memoryStream_0[num10] = new MemoryStream();
						smethod_2(memoryStream, num12, ref string_0[num10], ref memoryStream_0[num10]);
						num5 = 27;
						num7 = 10;
						num5 = 38;
						goto case 10;
					case 10:
						num5 = 2;
						num12 += Class0.smethod_5(Class0.smethod_4(typeof(Struct13).TypeHandle, 50, 43), 594, 624);
						num5 = 7;
						goto IL_0418;
					case 12:
					{
						num5 = 16;
						string text5 = smethod_3(memoryStream, struct14_0.int_1, struct14_0.int_2);
						array2 = new char[1] { '|' };
						string_1 = GClass3.smethod_1(text5, array2, 344, 364);
						num5 = 4;
						num7 = 21;
						num5 = 38;
						goto case 21;
					}
					case 7:
						num5 = 9;
						Class10.Class11.smethod_10(Class7.Class8.smethod_5(assembly, 834, 879), null, null, 744, 715);
						num5 = 37;
						num7 = 13;
						num5 = 38;
						goto case 13;
					case 6:
						num5 = 33;
						goto IL_0424;
					case 4:
						num5 = 13;
						goto IL_02f4;
					case 3:
						num5 = 1;
						goto IL_0384;
					case 2:
					{
						num5 = 10;
						int num8;
						if (struct14_0.int_0 > 1)
						{
							num5 = 5;
							num8 = 22;
						}
						else
						{
							num5 = 11;
							num8 = 17;
						}
						num7 = num8;
						num5 = 38;
						continue;
					}
					case 15:
						break;
					default:
						num5 = 31;
						return;
					case 8:
						num5 = 47;
						bool_0 = struct14_0.bool_0;
						num7 = 5;
						num5 = 38;
						goto case 5;
					case 5:
						num5 = 35;
						return;
					case 18:
						{
							num5 = 31;
							return;
						}
						IL_02cf:
						assembly = Class10.smethod_5(Class10.smethod_1(memoryStream_0[0], 129, 173), 62, 84);
						num5 = 13;
						goto IL_02f4;
						IL_02f4:
						if ((object)assembly != null)
						{
							num5 = 32;
							num14 = 23;
						}
						else
						{
							num5 = 6;
							num14 = 13;
						}
						num7 = num14;
						num5 = 38;
						continue;
						IL_0418:
						num7 = 14;
						num5 = 38;
						goto case 14;
						IL_0424:
						num10++;
						num7 = 0;
						num5 = 38;
						goto case 0;
						IL_0384:
						string_0 = new string[struct14_0.int_0];
						memoryStream_0 = new MemoryStream[struct14_0.int_0];
						num12 = Class0.smethod_5(Class0.smethod_4(typeof(Struct14).TypeHandle, 926, 903), 738, 704);
						num5 = 28;
						num7 = 9;
						num5 = 38;
						goto case 9;
					}
					break;
				}
				num5 = 41;
			}
		}
		catch (Exception exception)
		{
			UnhandledExceptionHandler.EntryPointException(exception, new object[23]
			{
				memoryStream, memoryStream2, num3, array, gClass, num4, dateTime_, text, text2, thread,
				num12, num10, assembly, text3, text4, array2, array4, array3, num2, num7,
				num, num5, args
			});
		}
	}
}
