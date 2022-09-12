using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using WindowsApplication1.My;

namespace ns0;

[CompilerGenerated]
[StandardModule]
[HideModuleName]
[DebuggerNonUserCode]
internal sealed class Class20
{
	[HelpKeyword("My.Settings")]
	internal static MySettings Settings
	{
		get
		{
			MySettings @default = default(MySettings);
			try
			{
				@default = MySettings.Default;
				return @default;
			}
			catch (Exception exception_)
			{
				Class11.smethod_22(exception_, @default);
				throw;
			}
		}
	}
}
