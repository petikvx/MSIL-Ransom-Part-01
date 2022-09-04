using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace Final.My;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal sealed class MyApplication : WindowsFormsApplicationBase
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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
		((WindowsFormsApplicationBase)MyProject.MyApplication_0).Run(args);
	}

	public MyApplication()
		: base((AuthenticationMode)0)
	{
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)MyProject.Class0_0.method_0());
	}
}
