using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;
using SmartAssembly.SmartExceptionsCore;

namespace cyber1.My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance;

	public static MySettings Default
	{
		get
		{
			try
			{
				return defaultInstance;
			}
			catch (Exception exception_)
			{
				MySettings object_ = default(MySettings);
				StackFrameHelper.CreateException1(exception_, object_);
				throw;
			}
		}
	}

	static MySettings()
	{
		try
		{
			defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException0(exception_);
			throw;
		}
	}

	public MySettings()
	{
		try
		{
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException1(exception_, this);
			throw;
		}
	}
}
