using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using The_Omegle_Game.My;

[StandardModule]
[HideModuleName]
[DebuggerNonUserCode]
[CompilerGenerated]
internal sealed class Class7
{
	[HelpKeyword("My.Settings")]
	internal static MySettings MySettings_0
	{
		get
		{
			MySettings @default = default(MySettings);
			while (true)
			{
				int num = -1522732512;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBD071D19u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						return @default;
					}
					break;
					IL_0003:
					@default = MySettings.Default;
					num = ((int)num2 * -356730753) ^ 0x62D342AF;
				}
			}
		}
	}
}
