using System;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class g : ApplicationSettingsBase
{
	private static g m_a = (g)(object)SettingsBase.Synchronized((SettingsBase)(object)new g());

	private static bool b;

	private static object c = RuntimeHelpers.GetObjectValue(new object());

	public static g a
	{
		get
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			if (!b)
			{
				object obj = c;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				Monitor.Enter(obj);
				try
				{
					if (!b)
					{
						((WindowsFormsApplicationBase)global::c.b).add_Shutdown(new ShutdownEventHandler(a));
						b = true;
					}
				}
				finally
				{
					Monitor.Exit(obj);
				}
			}
			return g.m_a;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void a(object sender, EventArgs e)
	{
		if (((WindowsFormsApplicationBase)global::c.b).get_SaveMySettingsOnExit())
		{
			((ApplicationSettingsBase)h.a).Save();
		}
	}
}
