using System;
using System.Reflection;

namespace dfb44QxstTvciGRseP;

internal class TkPiOacdIY1Wp3PVSj8
{
	internal delegate void J4YEVRcE4xM4ig5rtJ8(object o);

	internal static Module TsCCCuHV2d;

	internal static TkPiOacdIY1Wp3PVSj8 hpfcQ2uiFR3XdvMsSbG;

	internal static void ptR4tCZZUG5r5(int typemdt)
	{
		Type type = RX8mpAufJRLjxN5s8Up(TsCCCuHV2d, 33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		int num = 0;
		FieldInfo fieldInfo = default(FieldInfo);
		MethodInfo method = default(MethodInfo);
		int num3 = default(int);
		while (true)
		{
			int num2;
			if (num < fields.Length)
			{
				fieldInfo = fields[num];
				method = (MethodInfo)TsCCCuHV2d.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				num2 = 1;
				if (!tyo2MVuyEPmlA23AdVu())
				{
					goto IL_0053;
				}
			}
			else
			{
				num2 = 0;
				if (!tyo2MVuyEPmlA23AdVu())
				{
					goto IL_0053;
				}
			}
			goto IL_0057;
			IL_0053:
			num2 = num3;
			goto IL_0057;
			IL_0057:
			switch (num2)
			{
			default:
				return;
			case 1:
				break;
			case 0:
				return;
			}
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
			num++;
		}
	}

	public TkPiOacdIY1Wp3PVSj8()
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		base._002Ector();
	}

	static TkPiOacdIY1Wp3PVSj8()
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		TsCCCuHV2d = typeof(TkPiOacdIY1Wp3PVSj8).Assembly.ManifestModule;
	}

	internal static Type RX8mpAufJRLjxN5s8Up(object object_0, int int_0)
	{
		return ((Module)object_0).ResolveType(int_0);
	}

	internal static bool tyo2MVuyEPmlA23AdVu()
	{
		return hpfcQ2uiFR3XdvMsSbG == null;
	}

	internal static TkPiOacdIY1Wp3PVSj8 DH8DIguV3AD4O8mqVQu()
	{
		return hpfcQ2uiFR3XdvMsSbG;
	}
}
