using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace PackageIO.My;

[HideModuleName]
[CompilerGenerated]
[DebuggerNonUserCode]
[StandardModule]
internal sealed class MySettingsProperty
{
	[HelpKeyword("My.Settings")]
	internal static MySettings Settings => (MySettings)smethod_0();

	internal static object smethod_0()
	{
		return MySettings.Default;
	}
}
