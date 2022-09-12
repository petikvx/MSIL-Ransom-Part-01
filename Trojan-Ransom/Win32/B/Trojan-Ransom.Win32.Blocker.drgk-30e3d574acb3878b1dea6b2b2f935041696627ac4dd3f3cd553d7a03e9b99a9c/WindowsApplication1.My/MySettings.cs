using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ns0;

namespace WindowsApplication1.My;

[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	public static MySettings Default
	{
		get
		{
			MySettings mySettings = default(MySettings);
			try
			{
				mySettings = defaultInstance;
				return mySettings;
			}
			catch (Exception exception_)
			{
				Class11.smethod_22(exception_, mySettings);
				throw;
			}
		}
	}

	[DebuggerNonUserCode]
	public MySettings()
	{
	}
}
