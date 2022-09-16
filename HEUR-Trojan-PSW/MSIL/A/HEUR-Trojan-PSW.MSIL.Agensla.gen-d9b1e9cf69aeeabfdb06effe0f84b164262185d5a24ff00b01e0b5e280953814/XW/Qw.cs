using System;
using System.Reflection;

namespace XW;

public static class Qw
{
	private static Qw kq6;

	public static void ELz(this object object_0)
	{
		if (object_0 != null)
		{
			Dc0.nJ(object_0, Dc0.Scm);
		}
	}

	private static void Ri3(object object_0)
	{
		ayW.nJ(HcB.nJ("****** {0}", Xi.nJ(Xi.nJ(Hr.nJ(object_0, Hr.Rc1), Xi.XH), Xi.HcY), HcB.ncx), ayW.qcr);
		object[] object_ = null;
		PropertyInfo[] array = lcK.nJ(Hr.nJ(object_0, Hr.Rc1), lcK.Ocg);
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				PropertyInfo propertyInfo;
				while (true)
				{
					propertyInfo = array[num];
					bool flag = Am.nJ(propertyInfo, null, Am.l1);
					if (zqX())
					{
						switch (0)
						{
						case 1:
							break;
						default:
							goto IL_0090;
						case 2:
							goto end_IL_005a;
						}
						continue;
					}
					goto IL_0090;
					IL_0090:
					if (!flag)
					{
						break;
					}
					return;
					continue;
					end_IL_005a:
					break;
				}
				string string_ = Xi.nJ(propertyInfo, Xi.XH);
				try
				{
					object object_2 = pj.nJ(propertyInfo, object_0, object_, pj.h8) ?? string.Empty;
					HcD.nJ(string_, object_2, HcD.bcb);
				}
				catch (Exception object_3)
				{
					HcD.nJ(Xi.nJ(propertyInfo, Xi.XH), Xi.nJ(object_3, Xi.wXG), HcD.bcb);
					throw;
				}
				num++;
				continue;
			}
			ayW.nJ(HcB.nJ("****** {0}", Xi.nJ(Xi.nJ(Hr.nJ(object_0, Hr.Rc1), Xi.XH), Xi.HcY), HcB.ncx), ayW.qcr);
			ayW.nJ("\n", ayW.qcr);
			break;
		}
	}

	private static void oiW(string string_0, object object_0)
	{
		ayW.nJ(Lyn.nJ(HcB.nJ("{0} : ", string_0, HcB.ncx), (object_0 != null) ? Xi.nJ(object_0, Xi.l0) : null, Lyn.cyo), ayW.qcr);
	}

	public static void eiL(this string string_0)
	{
		int num;
		char[] array2 = default(char[]);
		int i = default(int);
		if (FXs.nJ(string_0, FXs.iXV))
		{
			ayW.nJ("String is null or empty.", ayW.qcr);
			num = 0;
			if (zqX())
			{
				return;
			}
		}
		else
		{
			char[] array = oyx.nJ(string_0, oyx.uXL);
			array2 = array;
			i = 0;
			num = 0;
			if (JqQ() == null)
			{
				goto IL_0091;
			}
		}
		switch (num)
		{
		default:
			return;
		case 1:
			break;
		case 0:
			return;
		}
		goto IL_0091;
		IL_0091:
		for (; i < array2.Length; i++)
		{
			char c = array2[i];
			ayW.nJ(Yc9.nJ("Character :{0} Value: {1}", c, (int)c, Yc9.wcZ), ayW.qcr);
		}
	}

	internal static bool zqX()
	{
		return kq6 == null;
	}

	internal static Qw JqQ()
	{
		return kq6;
	}
}
