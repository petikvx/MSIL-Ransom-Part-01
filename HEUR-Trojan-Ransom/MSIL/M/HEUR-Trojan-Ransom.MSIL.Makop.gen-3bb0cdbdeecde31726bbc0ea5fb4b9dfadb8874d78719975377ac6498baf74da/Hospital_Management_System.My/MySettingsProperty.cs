using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System.My;

[StandardModule]
[HideModuleName]
[DebuggerNonUserCode]
[CompilerGenerated]
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
				int num = -1423690095;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF0ADDB2Cu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1750848789) ^ -898667547;
						continue;
					case 1u:
						@default = MySettings.Default;
						num = ((int)num2 * -764396933) ^ -1461116484;
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
