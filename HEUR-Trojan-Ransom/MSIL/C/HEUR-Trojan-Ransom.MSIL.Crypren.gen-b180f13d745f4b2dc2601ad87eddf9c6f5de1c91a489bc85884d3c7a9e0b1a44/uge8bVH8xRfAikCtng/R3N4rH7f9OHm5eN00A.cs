using System;
using System.Reflection;

namespace uge8bVH8xRfAikCtng;

internal class R3N4rH7f9OHm5eN00A
{
	internal delegate void PQODPGl7dLmR8ymydS(object o);

	internal static object yObSTFaCW = gx7gwZRjbXqAqINcA3o(typeof(R3N4rH7f9OHm5eN00A).Assembly);

	internal static object TxflY9RRTHTXLemubMF;

	internal static void nOjDbYCmNa(int typemdt)
	{
		int num2 = default(int);
		FieldInfo fieldInfo = default(FieldInfo);
		MethodInfo object_ = default(MethodInfo);
		while (true)
		{
			Type type = ((Module)yObSTFaCW).ResolveType(33554432 + typemdt);
			while (true)
			{
				FieldInfo[] fields = type.GetFields();
				int num = 4;
				if (cU63uPRe8nalkl8oVIh() == null)
				{
					goto IL_0061;
				}
				goto IL_0073;
				IL_0073:
				switch (num)
				{
				case 9:
					break;
				case 5:
					goto IL_001c;
				case 7:
					goto IL_0024;
				case 4:
					goto IL_002b;
				default:
					goto IL_004b;
				case 8:
					goto IL_0061;
				case 2:
					continue;
				case 3:
					goto end_IL_00a2;
				case 1:
					return;
				}
				goto IL_0006;
				IL_0061:
				num2 = 0;
				num = 0;
				if (cU63uPRe8nalkl8oVIh() == null)
				{
					goto IL_004b;
				}
				goto IL_0073;
				IL_0006:
				fieldInfo.SetValue(null, (MulticastDelegate)zqCMlrRfgoyq2C7pVtb(type, object_));
				goto IL_001c;
				IL_001c:
				num2++;
				goto IL_004b;
				IL_004b:
				if (num2 < fields.Length)
				{
					goto IL_0024;
				}
				num = 0;
				if (cU63uPRe8nalkl8oVIh() == null)
				{
					return;
				}
				goto IL_0073;
				IL_002b:
				object_ = (MethodInfo)((Module)yObSTFaCW).ResolveMethod(KCwKO8RV2WPZknfHmU9(fieldInfo) + 100663296);
				goto IL_0006;
				IL_0024:
				fieldInfo = fields[num2];
				goto IL_002b;
				continue;
				end_IL_00a2:
				break;
			}
		}
	}

	internal static int KCwKO8RV2WPZknfHmU9(object object_0)
	{
		return ((MemberInfo)object_0).MetadataToken;
	}

	internal static object zqCMlrRfgoyq2C7pVtb(Type type_0, object object_0)
	{
		return Delegate.CreateDelegate(type_0, (MethodInfo)object_0);
	}

	internal static bool fOU3W0RUxw1YTrCFHF3()
	{
		return TxflY9RRTHTXLemubMF == null;
	}

	internal static R3N4rH7f9OHm5eN00A cU63uPRe8nalkl8oVIh()
	{
		return (R3N4rH7f9OHm5eN00A)TxflY9RRTHTXLemubMF;
	}

	internal static object gx7gwZRjbXqAqINcA3o(object object_0)
	{
		return ((Assembly)object_0).ManifestModule;
	}
}
