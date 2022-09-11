using System;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace BmHCcZGH;

internal sealed class Class8
{
	internal static double double_0;

	internal static double double_1;

	internal static double double_2;

	internal static double double_3;

	internal static double double_4;

	internal static double double_5;

	internal static Enum0 enum0_0;

	internal static string smethod_0()
	{
		return "a";
	}

	internal static void smethod_1(ref Matrix matrix_0, double double_6, double double_7)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		if (enum0_0 == Enum0.flag_0)
		{
			matrix_0 = new Matrix(1f, 0f, 0f, 1f, (float)double_6, (float)double_7);
			enum0_0 = Enum0.flag_1;
			return;
		}
		double_4 += double_0 * double_6 + double_2 * double_7;
		double_5 += double_1 * double_6 + double_3 * double_7;
		if (enum0_0 != Enum0.flag_3)
		{
			enum0_0 |= Enum0.flag_1;
		}
	}

	internal static bool smethod_2(ResolveEventArgs resolveEventArgs_0, string string_0, AppDomain appDomain_0, out Assembly assembly_0)
	{
		if (resolveEventArgs_0.Name.Contains(string_0))
		{
			assembly_0 = appDomain_0.Load(Class1.smethod_0(Class2.smethod_0(Class10.smethod_0()), Class5.smethod_1()));
			return true;
		}
		assembly_0 = null;
		return false;
	}
}
