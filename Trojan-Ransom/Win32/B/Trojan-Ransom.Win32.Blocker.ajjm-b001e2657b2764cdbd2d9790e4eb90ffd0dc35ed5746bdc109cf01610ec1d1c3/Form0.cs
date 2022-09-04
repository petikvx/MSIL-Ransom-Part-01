using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Pass;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class Form0 : WindowsFormsApplicationBase
{
	[AccessedThroughProperty("Domaene")]
	private AppDomain appDomain_0;

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
		((WindowsFormsApplicationBase)Class2.Form0_0).Run(args);
	}

	[SpecialName]
	private virtual AppDomain vmethod_0()
	{
		return appDomain_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void vmethod_1(AppDomain appDomain_1)
	{
		ResolveEventHandler value = method_0;
		if (appDomain_0 != null)
		{
			appDomain_0.AssemblyResolve -= value;
		}
		appDomain_0 = appDomain_1;
		if (appDomain_0 != null)
		{
			appDomain_0.AssemblyResolve += value;
		}
	}

	private Assembly method_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (resolveEventArgs_0.Name.Contains("x"))
		{
			return pass.loads;
		}
		return null;
	}

	[DebuggerStepThrough]
	public Form0()
		: base((AuthenticationMode)0)
	{
		vmethod_1(AppDomain.CurrentDomain);
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)Class2.Class3_0.pass);
	}
}
