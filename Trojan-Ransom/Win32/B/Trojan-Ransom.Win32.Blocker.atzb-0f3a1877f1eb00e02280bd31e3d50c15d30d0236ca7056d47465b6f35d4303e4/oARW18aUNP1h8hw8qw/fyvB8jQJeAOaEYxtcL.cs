using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using O5s5Kn8OVJPrvJeppq;
using fB9X1j46LrxZRgCDdG;
using fRRx6BicIRcysE8uY6;

namespace oARW18aUNP1h8hw8qw;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class fyvB8jQJeAOaEYxtcL : WindowsFormsApplicationBase
{
	[AccessedThroughProperty("maene")]
	private AppDomain pyXwy1yYh;

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[DebuggerHidden]
	[STAThread]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void UcyKByOHY(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
			OvK5syuwLncDiFcn3n.whxSeZ6Qumm54();
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)RII6oclWQ6H5gbttbi.wZONnyvB8).Run(args);
	}

	[SpecialName]
	private virtual AppDomain UcyKiByOHY()
	{
		return pyXwy1yYh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void EGsK2sGW3T(AppDomain appDomain_0)
	{
		ResolveEventHandler value = EGs5sGW3T;
		if (pyXwy1yYh != null)
		{
			pyXwy1yYh.AssemblyResolve -= value;
		}
		pyXwy1yYh = appDomain_0;
		if (pyXwy1yYh != null)
		{
			pyXwy1yYh.AssemblyResolve += value;
		}
	}

	private Assembly EGs5sGW3T(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (resolveEventArgs_0.Name.Contains("x"))
		{
			return w78O8XZrrPZXl69nX7.zPvrpD5v3;
		}
		Assembly result = default(Assembly);
		return result;
	}

	[DebuggerStepThrough]
	public fyvB8jQJeAOaEYxtcL()
		: base((AuthenticationMode)0)
	{
		EGsK2sGW3T(AppDomain.CurrentDomain);
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)RII6oclWQ6H5gbttbi.vw8kqwtcC.Form1);
	}
}
