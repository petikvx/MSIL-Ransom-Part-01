using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;

namespace ns0;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
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
		((WindowsFormsApplicationBase)Class1.Application).Run(args);
	}

	private void Form0_NetworkAvailabilityChanged(object sender, NetworkAvailableEventArgs e)
	{
		if (e.get_IsNetworkAvailable())
		{
			Class1.Forms.frmLock.lblStatus.set_Text("Warte...");
		}
		else
		{
			Class1.Forms.frmLock.lblStatus.set_Text("Ein trennen der Verbindung entfernt diese Sperre nicht.");
		}
	}

	private void Form0_StartupNextInstance(object sender, StartupNextInstanceEventArgs e)
	{
		e.set_BringToForeground(true);
	}

	[DebuggerStepThrough]
	public Form0()
		: base((AuthenticationMode)0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		((WindowsFormsApplicationBase)this).add_NetworkAvailabilityChanged(new NetworkAvailableEventHandler(Form0_NetworkAvailabilityChanged));
		((WindowsFormsApplicationBase)this).add_StartupNextInstance(new StartupNextInstanceEventHandler(Form0_StartupNextInstance));
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(true);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	[DebuggerStepThrough]
	void WindowsFormsApplicationBase.OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)Class1.Forms.frmLock);
	}
}
