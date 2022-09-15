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
	[STAThread]
	[DebuggerHidden]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)Class1.Form0_0).Run(args);
	}

	[DebuggerStepThrough]
	public Form0()
		: base((AuthenticationMode)0)
	{
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		Form0.smethod_0((WindowsFormsApplicationBase)(object)this, bool_0: true);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	[DebuggerStepThrough]
	void WindowsFormsApplicationBase.OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)Class1.Class2_0.Form1_0);
	}

	static void smethod_0(WindowsFormsApplicationBase windowsFormsApplicationBase_0, bool bool_0)
	{
		windowsFormsApplicationBase_0.set_SaveMySettingsOnExit(bool_0);
	}
}
