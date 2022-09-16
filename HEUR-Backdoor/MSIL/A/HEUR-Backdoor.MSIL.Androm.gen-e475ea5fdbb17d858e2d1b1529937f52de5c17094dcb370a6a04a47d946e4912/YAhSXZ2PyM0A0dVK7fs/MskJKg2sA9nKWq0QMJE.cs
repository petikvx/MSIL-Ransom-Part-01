using System;
using System.Reflection;
using LvkKBh2A1CcgxuCWgH4;
using Pj91rV27dKBAsuQFb5U;
using WEVFYJ2WPuik8y16vgG;

namespace YAhSXZ2PyM0A0dVK7fs;

internal class MskJKg2sA9nKWq0QMJE
{
	internal delegate void lajyof257vktxHKsksa(object o);

	internal static Module AriTxCwUtA;

	internal static void vbZk2FYYjEyjk(int typemdt)
	{
		Type type = AriTxCwUtA.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)AriTxCwUtA.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public MskJKg2sA9nKWq0QMJE()
	{
		SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
		base._002Ector();
	}

	static MskJKg2sA9nKWq0QMJE()
	{
		nohvtg2Jq63jo2SldqX.Yg2TdiiKvR();
		SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
		AriTxCwUtA = Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(33554494)).Assembly.ManifestModule;
	}
}
