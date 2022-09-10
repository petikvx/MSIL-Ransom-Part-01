using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.ApplicationServices;
using ns0;

namespace RunIt.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)Delegate81.smethod_0((SettingsBase)(object)Delegate28.smethod_0());

	private static bool addedHandler;

	private static object addedHandlerLockObject = Delegate26.smethod_0(Delegate124.smethod_0());

	public static MySettings Default
	{
		get
		{
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			bool flag = default(bool);
			object obj = default(object);
			MySettings mySettings = default(MySettings);
			try
			{
				if (flag = !addedHandler)
				{
					obj = addedHandlerLockObject;
					Delegate126.smethod_0(obj);
					Delegate101.smethod_0(obj);
					try
					{
						if (flag = !addedHandler)
						{
							Delegate107.smethod_0(Class2.Form0_0, (ShutdownEventHandler)delegate(object sender, EventArgs e)
							{
								bool flag2 = default(bool);
								try
								{
									if (flag2 = Delegate125.smethod_0(Class2.Form0_0))
									{
										Delegate72.smethod_0(Delegate5.smethod_0());
									}
								}
								catch (Exception exception_2)
								{
									Class9.smethod_27(exception_2, sender, e, flag2);
									throw;
								}
							});
							addedHandler = true;
						}
					}
					finally
					{
						Delegate96.smethod_0(obj);
					}
				}
				mySettings = defaultInstance;
				return mySettings;
			}
			catch (Exception exception_)
			{
				Class9.smethod_27(exception_, mySettings, obj, flag);
				throw;
			}
		}
	}

	[DebuggerNonUserCode]
	public MySettings()
	{
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		bool flag = default(bool);
		try
		{
			if (flag = Delegate125.smethod_0(Class2.Form0_0))
			{
				Delegate72.smethod_0(Delegate5.smethod_0());
			}
		}
		catch (Exception exception_)
		{
			Class9.smethod_27(exception_, sender, e, flag);
			throw;
		}
	}
}
