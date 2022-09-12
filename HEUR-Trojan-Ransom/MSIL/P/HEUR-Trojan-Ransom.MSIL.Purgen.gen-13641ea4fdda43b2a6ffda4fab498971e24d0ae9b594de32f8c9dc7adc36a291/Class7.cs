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
				int num = 486639677;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x72635BD0u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -774894581) ^ -1013772415;
						continue;
					case 1u:
						@default = MySettings.Default;
						num = ((int)num2 * -933602276) ^ 0x754CFA26;
						continue;
					case 0u:
						break;
					default:
						return @default;
					}
					break;
				}
			}
		}
	}
}
