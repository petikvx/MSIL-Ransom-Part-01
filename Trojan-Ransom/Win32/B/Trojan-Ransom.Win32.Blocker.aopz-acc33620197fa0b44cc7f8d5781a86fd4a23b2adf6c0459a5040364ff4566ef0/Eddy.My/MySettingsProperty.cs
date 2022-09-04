using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eddy.My;

[StandardModule]
[CompilerGenerated]
[HideModuleName]
[DebuggerNonUserCode]
internal sealed class MySettingsProperty
{
	[HelpKeyword("My.Settings")]
	internal static MySettings Settings => (MySettings)Bd2qm63s9ADNPWrom4I();

	internal static object Bd2qm63s9ADNPWrom4I()
	{
		return MySettings.Default;
	}
}
