using System;
using System.Reflection;

namespace F0;

internal class zT
{
	internal delegate void YV(object o);

	internal static Module jna;

	private static zT ick;

	internal static void KRF6rr(int typemdt)
	{
		int num = 2;
		FieldInfo fieldInfo = default(FieldInfo);
		int num3 = default(int);
		FieldInfo[] fields = default(FieldInfo[]);
		while (true)
		{
			Type type = jna.ResolveType(33554432 + typemdt);
			int num2 = 0;
			if (gce())
			{
				goto IL_000e;
			}
			goto IL_007b;
			IL_007b:
			switch (num2)
			{
			case 1:
				break;
			default:
				goto IL_003f;
			case 2:
				continue;
			}
			goto IL_000e;
			IL_003f:
			MethodInfo method = (MethodInfo)jna.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
			num3++;
			goto IL_001a;
			IL_000e:
			fields = type.GetFields();
			num3 = 0;
			goto IL_001a;
			IL_001a:
			if (num3 < fields.Length)
			{
				fieldInfo = fields[num3];
				num2 = 0;
				if (!gce())
				{
					num2 = num;
				}
				goto IL_007b;
			}
			break;
		}
	}

	public zT()
	{
		Rg.XRF6rz();
		base._002Ector();
	}

	static zT()
	{
		Rg.XRF6rz();
		jna = typeof(zT).Assembly.ManifestModule;
	}

	internal static bool gce()
	{
		return ick == null;
	}

	internal static zT AcB()
	{
		return ick;
	}
}
