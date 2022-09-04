using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Reflection.Emit;
using System.Security;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace ns0;

internal sealed class Class2
{
	private static string string_0;

	public static object smethod_0()
	{
		string_0 = Class0.smethod_1(521208883, 1);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521213924, 7), 639, 576);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521213926, 5), 463, 496);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521213920, 3), 60, 3);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521217684, 4), 702, 641);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521218116, 5), 318, 257);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521223145, 7), 478, 481);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521259673, 6), 434, 397);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521264203, 7), 140, 179);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521269247, 2), 782, 817);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521273005, 7), 920, 935);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521240659, 8), 575, 512);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521245451, 3), 960, 1023);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521249468, 5), 418, 413);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521253986, 4), 276, 299);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521160467, 4), 191, 128);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521164483, 7), 112, 79);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521164916, 1), 378, 325);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521169701, 7), 158, 161);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521173717, 6), 849, 878);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521145730, 2), 515, 572);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521150260, 5), 803, 796);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521154265, 7), 775, 824);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521154956, 3), 491, 468);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521192251, 7), 8, 55);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521196266, 7), 455, 504);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521201052, 6), 347, 356);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521205582, 5), 496, 463);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521176831, 7), 722, 749);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521177514, 3), 311, 264);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521182032, 6), 774, 825);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521185794, 5), 712, 759);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521190839, 3), 826, 773);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521359203, 6), 759, 712);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521362960, 2), 234, 213);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521363908, 7), 252, 195);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521368438, 6), 771, 828);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521339429, 4), 838, 889);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521344462, 0), 807, 792);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521348990, 1), 173, 146);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521352751, 3), 757, 714);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521353685, 8), 50, 13);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521390221, 7), 582, 633);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521394750, 5), 583, 632);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521399784, 0), 841, 886);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521403537, 8), 214, 233);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521375298, 4), 332, 371);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521376247, 0), 726, 745);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521380005, 1), 382, 321);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521384530, 7), 111, 80);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521291012, 6), 149, 170);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521295031, 4), 441, 390);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521299553, 1), 78, 113);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521300241, 0), 559, 528);
		string_0 = Class5.smethod_5(string_0, Class0.smethod_1(521304251, 5), 364, 339);
		string_0 += Class0.smethod_1(521276010, 5);
		string_0 += Class0.smethod_1(521280788, 8);
		string_0 += Class0.smethod_1(521284812, 1);
		string_0 += Class0.smethod_1(521289343, 5);
		string_0 += Class0.smethod_1(521322798, 5);
		string_0 += Class0.smethod_1(521326815, 7);
		string_0 += Class0.smethod_1(521331592, 1);
		string_0 += Class0.smethod_1(521336113, 7);
		string_0 += Class0.smethod_1(521307363, 4);
		string_0 += Class0.smethod_1(521312144, 4);
		string_0 += Class0.smethod_1(521312580, 1);
		string_0 += Class0.smethod_1(521316598, 4);
		string_0 += Class0.smethod_1(521321381, 6);
		string_0 += Class0.smethod_1(521489747, 3);
		string_0 += Class0.smethod_1(521493511, 6);
		string_0 += Class0.smethod_1(521498536, 6);
		string_0 += Class0.smethod_1(521213921, 2);
		string_0 += Class0.smethod_1(521213922, 1);
		string_0 += Class0.smethod_1(521213926, 5);
		string_0 += Class0.smethod_1(521498973, 2);
		string_0 += Class0.smethod_1(521213921, 2);
		string_0 += Class0.smethod_1(521213924, 7);
		string_0 += Class0.smethod_1(521213921, 2);
		string_0 += Class0.smethod_1(521469967, 3);
		string_0 = Strings.Replace(string_0, Class0.smethod_1(521472174, 7), Class0.smethod_1(521225907, 3), 1, -1, (CompareMethod)0);
		return string_0;
	}

	[SecuritySafeCritical]
	internal static void smethod_1(Control control_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 61:
				control_0.set_Visible(bool_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_2(Control control_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 86:
				control_0.set_Name(string_1);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_3(Form form_0, Size size_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 125:
				form_0.set_ClientSize(size_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static ProcessModule smethod_4(Process process_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 86:
				return process_0.MainModule;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_5(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 42:
				ProjectData.EndApp();
				return;
			case 43:
				ProjectData.ClearProjectError();
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_6(string string_1, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 101:
				return string_1.Substring(int_0, int_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_7(ILGenerator ilgenerator_0, OpCode opCode_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 124:
				ilgenerator_0.Emit(opCode_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Type smethod_8(Assembly assembly_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 66:
				return assembly_0.GetType(string_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static MethodInfo smethod_9(Type type_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 94:
				return type_0.GetMethod(string_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool smethod_10(object object_0, object object_1, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 89:
				return Operators.ConditionalCompareObjectEqual(object_0, object_1, bool_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_11(object object_0, Type type_0, string string_1, object[] object_1, string[] string_2, Type[] type_1, bool[] bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 88:
				return NewLateBinding.LateGet(object_0, type_0, string_1, object_1, string_2, type_1, bool_0);
			}
		}
	}
}
