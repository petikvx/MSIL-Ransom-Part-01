using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication2.My;

[DebuggerNonUserCode]
[StandardModule]
[CompilerGenerated]
[HideModuleName]
internal sealed class MySettingsProperty
{
	[HelpKeyword("My.Settings")]
	internal static MySettings Settings => MySettings.Default;
}
