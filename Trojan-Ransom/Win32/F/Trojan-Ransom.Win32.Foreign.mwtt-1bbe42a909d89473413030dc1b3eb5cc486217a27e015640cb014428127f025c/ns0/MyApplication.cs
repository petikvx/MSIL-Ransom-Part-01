using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using ___codefort;

namespace ns0;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class MyApplication : WindowsFormsApplicationBase
{
	[DebuggerStepThrough]
	public MyApplication()
		: base((AuthenticationMode)Class7.smethod_0(0))
	{
		((WindowsFormsApplicationBase)this).set_IsSingleInstance((byte)Class7.smethod_0(4) != 0);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles((byte)Class7.smethod_0(8) != 0);
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit((byte)Class7.smethod_0(12) != 0);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)Class7.smethod_0(16));
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerHidden]
	[STAThread]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)Class1.MyApplication_0).Run(args);
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)Class1.Class2_0.GForm0_0);
	}
}
