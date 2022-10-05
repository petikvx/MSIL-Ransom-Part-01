using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal class Form0 : WindowsFormsApplicationBase
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
			Class8.lqVWKbOzF3son();
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)Class2.Form0_0).Run(args);
	}

	[DebuggerStepThrough]
	public Form0()
		: base((AuthenticationMode)0)
	{
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)Class2.Class3_0.M4ov0bkisk_0);
	}
}
