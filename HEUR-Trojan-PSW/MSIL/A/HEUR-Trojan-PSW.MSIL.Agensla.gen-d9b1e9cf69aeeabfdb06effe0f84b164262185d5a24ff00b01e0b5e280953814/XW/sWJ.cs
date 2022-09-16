using System;
using System.Reflection;

namespace XW;

internal class sWJ
{
	internal delegate void AW9(object o);

	internal static Module CaC;

	internal static sWJ Dfj;

	internal static void MLUCPP(int typemdt)
	{
		Type type = jtq.nJ(CaC, 33554432 + typemdt, jtq.st9);
		FieldInfo[] array = WPu.nJ(type, WPu.aPP);
		int i = 0;
		int num = 0;
		if (sf9() != null)
		{
			goto IL_008d;
		}
		goto IL_00a6;
		IL_00a6:
		switch (num)
		{
		case 1:
			return;
		}
		goto IL_008d;
		IL_008d:
		for (; i < array.Length; i++)
		{
			FieldInfo object_ = array[i];
			MethodInfo methodInfo_ = (MethodInfo)htB.nJ(CaC, IJa.nJ(object_, IJa.JtZ) + 100663296, htB.Gtx);
			Tt0.nJ(object_, null, (MulticastDelegate)ttR.nJ(type, methodInfo_, ttR.sti), Tt0.itm);
		}
		num = 1;
		if (sf9() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_00a6;
	}

	public sWJ()
	{
		G3.nJ(G3.By);
		base._002Ector();
	}

	static sWJ()
	{
		G3.nJ(G3.By);
		CaC = Lt1.nJ(zXv.nJ(aG.nJ(typeof(sWJ).TypeHandle, aG.ta), zXv.gXH), Lt1.QtY);
	}

	internal static bool efG()
	{
		return Dfj == null;
	}

	internal static sWJ sf9()
	{
		return Dfj;
	}
}
