using System;
using System.Reflection;

namespace vc;

internal class AD
{
	internal delegate void Wa(object o);

	internal static Module enq;

	private static AD kO;

	internal static void ydPcGG(int typemdt)
	{
		int num = 1;
		FieldInfo object_ = default(FieldInfo);
		int num3 = default(int);
		FieldInfo[] array = default(FieldInfo[]);
		while (true)
		{
			Type type = Ovu.kN(enq, 33554432 + typemdt, Ovu.Hvv);
			int num2 = 0;
			if (!LK())
			{
				goto IL_0078;
			}
			goto IL_0091;
			IL_0091:
			while (true)
			{
				switch (num2)
				{
				case 2:
				{
					MethodInfo methodInfo_ = (MethodInfo)uvI.kN(enq, wk.kN(object_, wk.HvK) + 100663296, uvI.uvE);
					Xv0.kN(object_, null, (MulticastDelegate)rv4.kN(type, methodInfo_, rv4.Fvo), Xv0.nvc);
					num3++;
					goto IL_005c;
				}
				default:
					array = kv8.kN(type, kv8.nvW);
					num3 = 0;
					goto IL_005c;
				case 1:
					break;
					IL_005c:
					if (num3 >= array.Length)
					{
						return;
					}
					goto IL_0064;
				}
				break;
				IL_0064:
				object_ = array[num3];
				num2 = 2;
				if (Ed() == null)
				{
					continue;
				}
				goto IL_0078;
			}
			continue;
			IL_0078:
			num2 = num;
			goto IL_0091;
		}
	}

	public AD()
	{
		OZ.kN(OZ.Ou);
		base._002Ector();
	}

	static AD()
	{
		OZ.kN(OZ.Ou);
		enq = OvS.kN(wuG.kN(INq.kN(typeof(AD).TypeHandle, INq.PN6), wuG.SuY), OvS.Wvw);
	}

	internal static bool LK()
	{
		return kO == null;
	}

	internal static AD Ed()
	{
		return kO;
	}
}
