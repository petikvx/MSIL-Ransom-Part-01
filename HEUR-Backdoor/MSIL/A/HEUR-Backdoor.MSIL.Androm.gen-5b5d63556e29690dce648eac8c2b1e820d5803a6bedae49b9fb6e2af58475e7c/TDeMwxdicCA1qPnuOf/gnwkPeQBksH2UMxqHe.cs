using System;
using System.Reflection;
using CywHuCRSJ9Nc0dmtm00;
using NhGuxCR4JrLw4OnYlkG;
using SRo1MyRyNCF0HMnMeRy;
using mqTn2KRuHaeVC7qZfAP;

namespace TDeMwxdicCA1qPnuOf;

internal class gnwkPeQBksH2UMxqHe
{
	internal delegate void WePU3Fl7Ad6VjdwK8i(object o);

	internal static Module KHuFwCJ9Nc;

	private static gnwkPeQBksH2UMxqHe vdmFWtm00R;

	internal static void cy7FkgUySt(int int_0)
	{
		int num = 3;
		FieldInfo fieldInfo = default(FieldInfo);
		MethodInfo method = default(MethodInfo);
		int num3 = default(int);
		FieldInfo[] fields = default(FieldInfo[]);
		while (true)
		{
			IL_009e:
			Type type = KHuFwCJ9Nc.ResolveType(33554432 + int_0);
			int num2 = 0;
			if (XD6Fy2SZYj())
			{
				goto IL_000e;
			}
			goto IL_0087;
			IL_0087:
			while (true)
			{
				switch (num2)
				{
				case 2:
					break;
				case 1:
					fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
					num3++;
					goto IL_0046;
				default:
					num3 = 0;
					goto IL_0046;
				case 3:
					goto IL_009e;
					IL_0046:
					if (num3 >= fields.Length)
					{
						return;
					}
					goto IL_004e;
				}
				break;
				IL_004e:
				fieldInfo = fields[num3];
				method = (MethodInfo)wn6Fi4MV7h(KHuFwCJ9Nc, fieldInfo.MetadataToken + 100663296);
				num2 = 1;
				if (U1bFeUlt4I() == null)
				{
					continue;
				}
				goto IL_0024;
			}
			goto IL_000e;
			IL_000e:
			fields = type.GetFields();
			num2 = 0;
			if (!XD6Fy2SZYj())
			{
				goto IL_0024;
			}
			goto IL_0087;
			IL_0024:
			num2 = num;
			goto IL_0087;
		}
	}

	public gnwkPeQBksH2UMxqHe()
	{
		h5jVfKRi6h9cyEPcYxd.nviIH7hzRoY0Y();
		NYjo1bRqUlt4IQc9SFk.Vax9ZyXknj();
		base._002Ector();
	}

	static gnwkPeQBksH2UMxqHe()
	{
		uOxwGiRTS5ExO0AcR6j.vIHvRlxcnv();
		h5jVfKRi6h9cyEPcYxd.nviIH7hzRoY0Y();
		NYjo1bRqUlt4IQc9SFk.Vax9ZyXknj();
		KHuFwCJ9Nc = (Module)Wc9F4SFk8y(Type.GetTypeFromHandle(RfHjVHRe7jq1PgnsRwN.zl0IH7UDOAV3O(33554467)).Assembly);
	}

	internal static object wn6Fi4MV7h(object object_0, int int_0)
	{
		return ((Module)object_0).ResolveMethod(int_0);
	}

	internal static bool XD6Fy2SZYj()
	{
		return vdmFWtm00R == null;
	}

	internal static gnwkPeQBksH2UMxqHe U1bFeUlt4I()
	{
		return vdmFWtm00R;
	}

	internal static object Wc9F4SFk8y(object object_0)
	{
		return ((Assembly)object_0).ManifestModule;
	}
}
