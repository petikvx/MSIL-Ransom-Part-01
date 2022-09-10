using System.ComponentModel.Design;
using System.Configuration;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Ym5t1;

namespace k5R2L;

[HideModuleName]
[StandardModule]
internal sealed class r9R2T
{
	[HelpKeyword("My.Settings")]
	internal static Pj7w1 Settings
	{
		get
		{
			ApplicationSettingsBase @default = (ApplicationSettingsBase)(object)Pj7w1.Default;
			return @default as Pj7w1;
		}
	}
}
