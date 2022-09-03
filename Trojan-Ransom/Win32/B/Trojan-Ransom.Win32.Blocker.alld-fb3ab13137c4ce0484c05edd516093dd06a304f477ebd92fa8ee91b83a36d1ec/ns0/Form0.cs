using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using ns2;
using ns4;

namespace ns0;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class Form0 : WindowsFormsApplicationBase
{
	[AccessedThroughProperty("Domaene")]
	private AppDomain appDomain_0;

	private virtual AppDomain Domaene
	{
		get
		{
			return appDomain_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			ResolveEventHandler value2 = Domaene_AssemblyResolve;
			if (appDomain_0 != null)
			{
				appDomain_0.AssemblyResolve -= value2;
			}
			appDomain_0 = value;
			if (appDomain_0 != null)
			{
				appDomain_0.AssemblyResolve += value2;
			}
		}
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
		((WindowsFormsApplicationBase)Class1.Application).Run(args);
	}

	private Assembly Domaene_AssemblyResolve(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (resolveEventArgs_0.Name.Contains("x"))
		{
			return pass.assembly_0;
		}
		return null;
	}

	[DebuggerStepThrough]
	public Form0()
		: base((AuthenticationMode)0)
	{
		Domaene = AppDomain.CurrentDomain;
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	[DebuggerStepThrough]
	void WindowsFormsApplicationBase.OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)Class1.Forms.pass);
	}
}
