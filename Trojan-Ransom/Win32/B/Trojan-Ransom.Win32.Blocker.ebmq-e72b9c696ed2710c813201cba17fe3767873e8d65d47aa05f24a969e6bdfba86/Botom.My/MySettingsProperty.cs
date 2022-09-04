using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Botom.My;

[StandardModule]
[DebuggerNonUserCode]
[CompilerGenerated]
[HideModuleName]
internal sealed class MySettingsProperty
{
	[HelpKeyword("My.Settings")]
	internal static MySettings Settings => (MySettings)hBxswS6sLpaKiug0lhE();

	internal static object hBxswS6sLpaKiug0lhE()
	{
		return MySettings.Default;
	}
}
