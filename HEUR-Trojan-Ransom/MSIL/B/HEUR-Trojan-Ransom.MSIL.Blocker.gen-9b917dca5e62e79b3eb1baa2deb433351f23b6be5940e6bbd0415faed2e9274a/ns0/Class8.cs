using System.ComponentModel.Design;
using System.Configuration;
using Client.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[HideModuleName]
[StandardModule]
internal sealed class Class8
{
	[HelpKeyword("My.Settings")]
	internal static MySettings MySettings_0 => (MySettings)(ApplicationSettingsBase)MySettings.Default;
}
