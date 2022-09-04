using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

[EditorBrowsable(EditorBrowsableState.Never)]
internal class a : WindowsFormsApplicationBase
{
	[DebuggerStepThrough]
	public a()
		: base((AuthenticationMode)l.a(0))
	{
		((WindowsFormsApplicationBase)this).set_IsSingleInstance((byte)l.a(4) != 0);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles((byte)l.a(8) != 0);
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit((byte)l.a(12) != 0);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)l.a(16));
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	[STAThread]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerHidden]
	internal static void a(string[] P_0)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)c.b).Run(P_0);
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)c.d.a);
	}
}
