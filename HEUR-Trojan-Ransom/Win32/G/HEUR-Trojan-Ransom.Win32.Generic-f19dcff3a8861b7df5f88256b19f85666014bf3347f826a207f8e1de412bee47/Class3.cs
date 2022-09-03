using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
internal sealed class Class3 : ApplicationSettingsBase
{
	private static Class3 class3_0 = (Class3)(object)SettingsBase.Synchronized((SettingsBase)(object)new Class3());

	private static bool bool_0;

	private static object object_0 = RuntimeHelpers.GetObjectValue(new object());

	public static Class3 Class3_0
	{
		get
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			if (!bool_0)
			{
				object obj = object_0;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				Monitor.Enter(obj);
				try
				{
					if (!bool_0)
					{
						((WindowsFormsApplicationBase)Class1.Form0_0).add_Shutdown((ShutdownEventHandler)delegate
						{
							if (((WindowsFormsApplicationBase)Class1.Form0_0).get_SaveMySettingsOnExit())
							{
								((ApplicationSettingsBase)Class4.Class3_0).Save();
							}
						});
						bool_0 = true;
					}
				}
				finally
				{
					Monitor.Exit(obj);
				}
			}
			return class3_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerNonUserCode]
	private static void smethod_0(object sender, EventArgs e)
	{
		if (((WindowsFormsApplicationBase)Class1.Form0_0).get_SaveMySettingsOnExit())
		{
			((ApplicationSettingsBase)Class4.Class3_0).Save();
		}
	}
}
