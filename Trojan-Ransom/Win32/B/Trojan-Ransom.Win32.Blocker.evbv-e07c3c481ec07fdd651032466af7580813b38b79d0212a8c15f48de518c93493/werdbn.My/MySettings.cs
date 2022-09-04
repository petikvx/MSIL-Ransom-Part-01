using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace werdbn.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)goTMSOI1TppFa9amxo(new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject = ohBaajhsWoovywtHD6(new object());

	public static MySettings Default
	{
		get
		{
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			if (!addedHandler)
			{
				object obj = addedHandlerLockObject;
				hhIm752bwPiaFVdYBg();
				if (!avd2tGN14ruo3N52rb())
				{
					eKMmMtv8rxGrx1cGH7(obj);
				}
				Monitor.Enter(obj);
				try
				{
					if (!addedHandler)
					{
						((WindowsFormsApplicationBase)zRv83pYVLmHSoHNDAe()).add_Shutdown((ShutdownEventHandler)delegate
						{
							if (((WindowsFormsApplicationBase)MyProject.Application).get_SaveMySettingsOnExit())
							{
								((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
							}
						});
						_ = 0;
						if (hhIm752bwPiaFVdYBg())
						{
							goto IL_007b;
						}
						if (hhIm752bwPiaFVdYBg())
						{
							switch (3)
							{
							default:
								goto end_IL_002c;
							case 0:
							case 2:
								break;
							case 1:
							case 3:
								goto end_IL_002c;
							}
							goto IL_007b;
						}
					}
					goto end_IL_002c;
					IL_007b:
					addedHandler = true;
					end_IL_002c:;
				}
				finally
				{
					Monitor.Exit(obj);
				}
			}
			return defaultInstance;
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (((WindowsFormsApplicationBase)MyProject.Application).get_SaveMySettingsOnExit())
		{
			((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
		}
	}

	internal static object goTMSOI1TppFa9amxo(object object_0)
	{
		return SettingsBase.Synchronized((SettingsBase)object_0);
	}

	internal static object ohBaajhsWoovywtHD6(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	internal static bool hhIm752bwPiaFVdYBg()
	{
		return true;
	}

	internal static bool avd2tGN14ruo3N52rb()
	{
		return false;
	}

	internal static void eKMmMtv8rxGrx1cGH7(object object_0)
	{
		ObjectFlowControl.CheckForSyncLockOnValueType(object_0);
	}

	internal static object zRv83pYVLmHSoHNDAe()
	{
		return MyProject.Application;
	}
}
