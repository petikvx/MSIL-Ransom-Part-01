using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using Client.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
[HideModuleName]
internal sealed class Class8
{
	internal sealed class Class9
	{
		internal static void smethod_0(char char_0, int int_0)
		{
			int num = 0;
			switch (((char_0 ^ int_0) - 46) ^ 0)
			{
			case 0:
				ProjectData.ClearProjectError();
				break;
			case 1:
				ProjectData.EndApp();
				break;
			case 2:
				Application.Restart();
				break;
			}
			num++;
		}

		internal static int smethod_1<T>(T gparam_0, AppWinStyle appWinStyle_0, bool bool_0, int int_0, char char_0, short short_0) where T : string
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			int result = (((char_0 ^ short_0) - 54) ^ 0) switch
			{
				0 => Interaction.Shell((string)gparam_0, appWinStyle_0, bool_0, int_0), 
				_ => 3, 
			};
			num++;
			return result;
		}
	}

	[HelpKeyword("My.Settings")]
	internal static MySettings MySettings_0 => (MySettings)(object)(INotifyPropertyChanged)(object)MySettings.Default;

	internal static void smethod_0<T>(T gparam_0, short short_0, short short_1) where T : Exception
	{
		int num = 0;
		switch (((short_1 ^ short_0) - 114) ^ 0)
		{
		case 0:
			ProjectData.SetProjectError((Exception)gparam_0);
			break;
		}
		num++;
	}

	internal static int smethod_1<T, U>(T gparam_0, U gparam_1, bool bool_0, int int_0, int int_1) where T : string where U : string
	{
		int num = 0;
		int result = (((int_0 ^ int_1) - 48) ^ 0) switch
		{
			0 => Operators.CompareString((string)gparam_0, (string)gparam_1, bool_0), 
			_ => int_1, 
		};
		num++;
		return result;
	}
}
