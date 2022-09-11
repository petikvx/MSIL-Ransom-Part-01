using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal class Form0 : WindowsFormsApplicationBase
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerHidden]
	[STAThread]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
			Class8.t3hvLuccnmfIO();
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)Class3.Form0_0).Run(args);
	}

	[DebuggerStepThrough]
	public Form0()
	{
		Class8.t3hvLuccnmfIO();
		((WindowsFormsApplicationBase)this)._002Ector((AuthenticationMode)0);
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(true);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)Class3.Class4_0.Form1);
	}

	static Form0()
	{
		Class14.lLHifFIsCLsZtjvFfN0i();
	}
}
