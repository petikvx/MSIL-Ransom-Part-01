using System;
using System.Reflection;
using cCMBEkOBGIwpDnI0MY;
using fJpF6sGRwSPY0tjIER;
using zjWSh2Z73jBs4TcJ0x;

namespace E0mWDu50FTH8alNftn;

internal class sMQ2qHhLX7jxe8all6
{
	internal delegate void p7dX3yenAUCJDn0fac(object o);

	internal static object dciWh9Sbxa;

	private static object xG5ReeG8LWeRVrgxIU8;

	internal static void eZZ5KZCCeb9DZ(int typemdt)
	{
		int num = 9;
		FieldInfo fieldInfo = default(FieldInfo);
		MethodInfo object_ = default(MethodInfo);
		while (true)
		{
			Type type = isa8nQG3y5y4W353H6Z(dciWh9Sbxa, 33554432 + typemdt);
			while (true)
			{
				FieldInfo[] fields = type.GetFields();
				while (true)
				{
					int num2 = 0;
					num = 5;
					while (true)
					{
						IL_00c6:
						int num3;
						if (num2 >= fields.Length)
						{
							num3 = 1;
							if (qKkdUdGC2Q8DNaUxbLu() != null)
							{
								goto IL_0021;
							}
							goto IL_004c;
						}
						goto IL_00ab;
						IL_0021:
						num3 = num;
						goto IL_004c;
						IL_00ab:
						fieldInfo = fields[num2];
						goto IL_007b;
						IL_007b:
						object_ = (MethodInfo)RpktgqGURPiQh3ym8dy(dciWh9Sbxa, fy9Yq6GshxVmAny2He8(fieldInfo) + 100663296);
						num3 = 0;
						if (!P0PdUQGpZ4iQ5igF54S())
						{
							goto IL_0027;
						}
						goto IL_004c;
						IL_004c:
						while (true)
						{
							switch (num3)
							{
							case 4:
								break;
							default:
								goto end_IL_004c;
							case 6:
								goto IL_007b;
							case 3:
								goto IL_00ab;
							case 2:
							case 5:
								goto IL_00c6;
							case 7:
								goto end_IL_00c6;
							case 8:
								goto end_IL_00d0;
							case 9:
								goto end_IL_00de;
							case 1:
								return;
							}
							num2++;
							num3 = 2;
							if (qKkdUdGC2Q8DNaUxbLu() == null)
							{
								continue;
							}
							goto IL_0021;
							continue;
							end_IL_004c:
							break;
						}
						goto IL_0027;
						IL_0027:
						fieldInfo.SetValue(null, (MulticastDelegate)p3hLvDGKSfZXjyeSlAe(type, object_));
						num3 = 4;
						if (!P0PdUQGpZ4iQ5igF54S())
						{
							goto IL_0021;
						}
						goto IL_004c;
						continue;
						end_IL_00c6:
						break;
					}
					continue;
					end_IL_00d0:
					break;
				}
				continue;
				end_IL_00de:
				break;
			}
		}
	}

	public sMQ2qHhLX7jxe8all6()
	{
		bh0HEvGkO7X7wRFO0Bg();
		U2cjRWGbIpZY1MnxPVD();
		base._002Ector();
	}

	static sMQ2qHhLX7jxe8all6()
	{
		XaXlykERDhtdRwMnBY.jXRWMU6APG();
		zB3PVH9hASM2TtLqpf.unC5KZCzPQ9Xt();
		dciWh9Sbxa = qJaXwcGuq1ynT5p0QaW(Type.GetTypeFromHandle(aVemsvvaraXSsOXEKR.lBC5KZxj6LMe3(33554470)).Assembly);
	}

	internal static Type isa8nQG3y5y4W353H6Z(object object_0, int int_0)
	{
		return ((Module)object_0).ResolveType(int_0);
	}

	internal static int fy9Yq6GshxVmAny2He8(object object_0)
	{
		return ((MemberInfo)object_0).MetadataToken;
	}

	internal static object RpktgqGURPiQh3ym8dy(object object_0, int int_0)
	{
		return ((Module)object_0).ResolveMethod(int_0);
	}

	internal static object p3hLvDGKSfZXjyeSlAe(Type type_0, object object_0)
	{
		return Delegate.CreateDelegate(type_0, (MethodInfo)object_0);
	}

	internal static bool P0PdUQGpZ4iQ5igF54S()
	{
		return xG5ReeG8LWeRVrgxIU8 == null;
	}

	internal static sMQ2qHhLX7jxe8all6 qKkdUdGC2Q8DNaUxbLu()
	{
		return (sMQ2qHhLX7jxe8all6)xG5ReeG8LWeRVrgxIU8;
	}

	internal static void bh0HEvGkO7X7wRFO0Bg()
	{
		XaXlykERDhtdRwMnBY.jXRWMU6APG();
	}

	internal static void U2cjRWGbIpZY1MnxPVD()
	{
		zB3PVH9hASM2TtLqpf.unC5KZCzPQ9Xt();
	}

	internal static object qJaXwcGuq1ynT5p0QaW(object object_0)
	{
		return ((Assembly)object_0).ManifestModule;
	}
}
