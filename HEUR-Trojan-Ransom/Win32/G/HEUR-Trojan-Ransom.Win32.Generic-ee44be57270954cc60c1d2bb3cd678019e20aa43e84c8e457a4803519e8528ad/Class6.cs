using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using QMBVMDQaJJw.My;

[StandardModule]
[DebuggerNonUserCode]
[CompilerGenerated]
[HideModuleName]
internal sealed class Class6
{
	[HelpKeyword("My.Settings")]
	internal static MySettings MySettings_0
	{
		get
		{
			MySettings @default = default(MySettings);
			while (true)
			{
				int num = 557609584;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5034C04Bu) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return @default;
					}
					break;
					IL_0003:
					@default = MySettings.Default;
					num = (int)(num2 * 935318405) ^ -222248903;
				}
			}
		}
	}
}
