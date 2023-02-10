using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Windows_Loader.My;

namespace WindowsLoader;

[CompilerGenerated]
[DebuggerNonUserCode]
[HideModuleName]
[StandardModule]
internal sealed class TemplateFactory
{
	[HelpKeyword("My.Settings")]
	internal static MySettings Settings => ProjectLayout.RemovePane();
}
