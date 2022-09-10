using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using NCDRxx4R49CZy0gNBsi;

namespace thuRUH4hLAP2RWJE1x1;

internal class KZdkSP4TI7E9vZqimgc
{
	internal delegate void SFU4mbT3GMret7THonf(object o);

	internal static Module TDnA7qt6EI;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Bhvn9WFFeYUst(int typemdt)
	{
		//Discarded unreachable code: IL_0035
		int num = 3;
		if (!cfusMRLIf2pLkkjsSic())
		{
		}
		MethodInfo method = default(MethodInfo);
		FieldInfo fieldInfo = default(FieldInfo);
		Type type = default(Type);
		int num3 = default(int);
		FieldInfo[] fields = default(FieldInfo[]);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 9:
				method = (MethodInfo)TDnA7qt6EI.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				goto case 0;
			default:
				num2 = 0;
				goto IL_003e;
			case 0:
				fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
				num = 1;
				break;
			case 4:
			case 7:
			case 8:
				if (num3 >= fields.Length)
				{
					num2 = 10;
				}
				else
				{
					fieldInfo = fields[num3];
					num2 = 9;
				}
				goto IL_003e;
			case 5:
				fields = type.GetFields();
				num = 6;
				break;
			case 2:
			case 6:
				num3 = 0;
				num = 8;
				if (lDlXNhL9VORrHwPtbU8())
				{
					break;
				}
				goto case 1;
			case 1:
				num3++;
				num2 = 4;
				goto IL_003e;
			case 3:
				type = TDnA7qt6EI.ResolveType(33554432 + typemdt);
				num2 = 5;
				goto IL_003e;
			case 10:
				return;
				IL_003e:
				num = num2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KZdkSP4TI7E9vZqimgc()
	{
		QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static KZdkSP4TI7E9vZqimgc()
	{
		QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
		TDnA7qt6EI = typeof(KZdkSP4TI7E9vZqimgc).Assembly.ManifestModule;
	}

	internal static bool lDlXNhL9VORrHwPtbU8()
	{
		return true;
	}

	internal static bool cfusMRLIf2pLkkjsSic()
	{
		return false;
	}
}
