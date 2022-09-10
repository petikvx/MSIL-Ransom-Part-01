using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SpiritMagnifier.My;

[StandardModule]
[CompilerGenerated]
[HideModuleName]
[DebuggerNonUserCode]
internal sealed class MySettingsProperty
{
	[HelpKeyword("My.Settings")]
	internal static MySettings Settings => (MySettings)smethod_0();

	internal static object smethod_0()
	{
		return MySettings.Default;
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static bool smethod_2()
	{
		return false;
	}
}
