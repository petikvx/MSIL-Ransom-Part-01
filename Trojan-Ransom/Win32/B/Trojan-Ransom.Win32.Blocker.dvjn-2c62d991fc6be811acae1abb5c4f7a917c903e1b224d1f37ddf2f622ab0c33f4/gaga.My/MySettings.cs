using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;
using ns3;

namespace gaga.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings mySettings_0;

	public static MySettings Default
	{
		get
		{
			try
			{
				return mySettings_0;
			}
			catch (Exception exception_)
			{
				MySettings object_ = default(MySettings);
				Class38.smethod_1(exception_, object_);
				throw;
			}
		}
	}

	static MySettings()
	{
		try
		{
			mySettings_0 = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());
		}
		catch (Exception exception_)
		{
			Class38.smethod_0(exception_);
			throw;
		}
	}
}
