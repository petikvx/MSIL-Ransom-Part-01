using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Window.My.Resources;

namespace Window.My;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class MyApplication : WindowsFormsApplicationBase
{
	[AccessedThroughProperty("Domaene")]
	private AppDomain _Domaene;

	private virtual AppDomain Domaene
	{
		get
		{
			return _Domaene;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			ResolveEventHandler value2 = Domaene_AssemblyResolve;
			if (_Domaene != null)
			{
				_Domaene.AssemblyResolve -= value2;
			}
			_Domaene = value;
			if (_Domaene != null)
			{
				_Domaene.AssemblyResolve += value2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[DebuggerHidden]
	[STAThread]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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

	private Assembly Domaene_AssemblyResolve(object sender, ResolveEventArgs args)
	{
		if (args.Name.Contains("x"))
		{
			return Assembly.Load(Window.My.Resources.Resources.x);
		}
		return null;
	}

	[DebuggerStepThrough]
	public MyApplication()
		: base((AuthenticationMode)0)
	{
		Domaene = AppDomain.CurrentDomain;
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)MyProject.Forms.Win32);
	}
}
