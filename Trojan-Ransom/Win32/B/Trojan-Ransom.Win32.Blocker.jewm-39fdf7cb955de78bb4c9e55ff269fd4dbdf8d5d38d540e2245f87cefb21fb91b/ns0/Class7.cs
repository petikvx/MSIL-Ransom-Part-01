using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RunIt.My;

namespace ns0;

[CompilerGenerated]
[StandardModule]
[HideModuleName]
[DebuggerNonUserCode]
internal sealed class Class7
{
	[HelpKeyword("My.Settings")]
	internal static MySettings Settings
	{
		get
		{
			MySettings mySettings = default(MySettings);
			try
			{
				mySettings = Delegate114.smethod_0();
				return mySettings;
			}
			catch (Exception exception_)
			{
				Class9.smethod_25(exception_, mySettings);
				throw;
			}
		}
	}
}
