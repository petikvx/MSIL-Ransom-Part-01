using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace ns0;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class Form0 : WindowsFormsApplicationBase
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
		((WindowsFormsApplicationBase)Class2.Form0_0).Run(args);
	}

	[DebuggerStepThrough]
	public Form0()
	{
		smethod_2(this, (AuthenticationMode)0);
		smethod_0();
		if (!smethod_1())
		{
			smethod_3(this, bool_0: false);
			smethod_4(this, bool_0: true);
			smethod_5(this, bool_0: true);
		}
		smethod_6(this, (ShutdownMode)0);
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		smethod_9(this, smethod_8(smethod_7()));
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static bool smethod_1()
	{
		return false;
	}

	internal static void smethod_2(object object_0, AuthenticationMode authenticationMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((WindowsFormsApplicationBase)object_0)._002Ector(authenticationMode_0);
	}

	internal static void smethod_3(object object_0, bool bool_0)
	{
		((WindowsFormsApplicationBase)object_0).set_IsSingleInstance(bool_0);
	}

	internal static void smethod_4(object object_0, bool bool_0)
	{
		((WindowsFormsApplicationBase)object_0).set_EnableVisualStyles(bool_0);
	}

	internal static void smethod_5(object object_0, bool bool_0)
	{
		((WindowsFormsApplicationBase)object_0).set_SaveMySettingsOnExit(bool_0);
	}

	internal static void smethod_6(object object_0, ShutdownMode shutdownMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((WindowsFormsApplicationBase)object_0).set_ShutdownStyle(shutdownMode_0);
	}

	internal static object smethod_7()
	{
		return Class2.Class3_0;
	}

	internal static object smethod_8(object object_0)
	{
		return ((Class2.Class3)object_0).Form1;
	}

	internal static void smethod_9(object object_0, object object_1)
	{
		((WindowsFormsApplicationBase)object_0).set_MainForm((Form)object_1);
	}
}
