using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System.My;

[HideModuleName]
[StandardModule]
[CompilerGenerated]
[DebuggerNonUserCode]
internal sealed class MySettingsProperty
{
	[HelpKeyword("My.Settings")]
	internal static MySettings Settings
	{
		get
		{
			MySettings @default = default(MySettings);
			while (true)
			{
				int num = -241873043;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB4C568F2u) % 4u)
					{
					case 3u:
						@default = MySettings.Default;
						num = (int)((num2 * 1891480785) ^ 0x4A30D225);
						continue;
					case 0u:
						num = ((int)num2 * -818620090) ^ 0x4D8AAB6B;
						continue;
					case 2u:
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
