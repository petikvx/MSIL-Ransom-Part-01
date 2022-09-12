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
			MySettings @default = MySettings.Default;
			while (true)
			{
				int num = 640006346;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4BFAB853u) % 3u)
					{
					case 2u:
						goto IL_0008;
					case 0u:
						break;
					default:
						return @default;
					}
					break;
					IL_0008:
					num = ((int)num2 * -1885555042) ^ 0x238EE3CF;
				}
			}
		}
	}
}
