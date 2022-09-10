using System;
using System.CodeDom.Compiler;
using System.Configuration;
using SmartAssembly.SmartExceptionsCore;
using ns0;

namespace stub_2.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings settings_0;

	public static Settings Default
	{
		get
		{
			int num = default(int);
			try
			{
				num = 6;
				return settings_0;
			}
			catch (Exception exception)
			{
				int num2 = default(int);
				StackFrameHelper.CreateException2(exception, num2, num);
				throw;
			}
		}
	}

	public Settings()
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	static Settings()
	{
		try
		{
			Exception1.smethod_3();
			settings_0 = (Settings)(object)GClass0.smethod_0((SettingsBase)(object)new Settings(), 661, 744);
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException1(exception, num);
			throw;
		}
	}
}
