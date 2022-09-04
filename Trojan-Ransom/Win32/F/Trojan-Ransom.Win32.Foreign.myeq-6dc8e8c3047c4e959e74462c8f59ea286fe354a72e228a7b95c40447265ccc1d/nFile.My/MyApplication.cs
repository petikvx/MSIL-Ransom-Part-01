using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace nFile.My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal class MyApplication : WindowsFormsApplicationBase
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[DebuggerHidden]
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
		((WindowsFormsApplicationBase)MyProject.Application).Run(args);
	}

	[DebuggerStepThrough]
	public MyApplication()
	{
		_ = 1;
		if (j63lVsSpavTTKwhrfq())
		{
			if (j63lVsSpavTTKwhrfq())
			{
			}
			switch (2)
			{
			case 0:
			case 5:
				break;
			case 1:
			case 2:
				goto IL_0042;
			case 3:
				goto IL_0050;
			default:
				goto IL_0057;
			case 6:
				return;
			}
		}
		((WindowsFormsApplicationBase)this)._002Ector((AuthenticationMode)0);
		goto IL_0042;
		IL_0050:
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
		goto IL_0057;
		IL_0057:
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
		return;
		IL_0042:
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		goto IL_0050;
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)MyProject.Forms.urwxgd);
	}

	internal static bool XroefWBv0qEdkjOpHm()
	{
		return true;
	}

	internal static bool j63lVsSpavTTKwhrfq()
	{
		return false;
	}
}
