using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using nLQv3ubX3DSfu4BQ1f;

namespace xl7YkIY46t0tbFwAl2;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal class QWkmT5kb6y5doMXENx : WindowsFormsApplicationBase
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[DebuggerHidden]
	[STAThread]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void e0HcB5f28(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)i2e7bM2YvUOxUiJcWX.PQ6FVMEjI).Run(args);
	}

	[DebuggerStepThrough]
	public QWkmT5kb6y5doMXENx()
	{
		int num = 0;
		if (iho3Bi5Sjj4NhKXrEO())
		{
			goto IL_000d;
		}
		goto IL_0038;
		IL_0038:
		switch (num)
		{
		case 6:
			break;
		case 0:
			HDmRgwaD2FtchZJG3V(this, (AuthenticationMode)0);
			break;
		case 2:
		case 3:
			goto IL_0060;
		default:
			goto IL_0067;
		case 4:
		case 5:
			goto IL_006e;
		case 7:
			return;
		}
		goto IL_000d;
		IL_006e:
		WpoC02ZUd37HvHRwcM(this, (ShutdownMode)0);
		return;
		IL_000d:
		CFSnaLe5xhP6AUTr52(this, bool_0: false);
		jluxAKMh6SJYZve96F();
		if (iho3Bi5Sjj4NhKXrEO())
		{
			num = 5;
			if (iho3Bi5Sjj4NhKXrEO())
			{
				return;
			}
			goto IL_0038;
		}
		goto IL_0060;
		IL_0067:
		P1ia5Xc2XYkSXMnMlq(this, bool_0: true);
		goto IL_006e;
		IL_0060:
		WQoBCtHcj5KGmnIOsZ(this, bool_0: true);
		goto IL_0067;
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		wk9EWYp2wsaNeGF8Bw(this, f1MfMMoSO8oqI8Peaj(IDaDLyvkeV56aBtXQL()));
	}

	internal static bool jluxAKMh6SJYZve96F()
	{
		return true;
	}

	internal static bool iho3Bi5Sjj4NhKXrEO()
	{
		return false;
	}

	internal static void HDmRgwaD2FtchZJG3V(object object_0, AuthenticationMode authenticationMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((WindowsFormsApplicationBase)object_0)._002Ector(authenticationMode_0);
	}

	internal static void CFSnaLe5xhP6AUTr52(object object_0, bool bool_0)
	{
		((WindowsFormsApplicationBase)object_0).set_IsSingleInstance(bool_0);
	}

	internal static void WQoBCtHcj5KGmnIOsZ(object object_0, bool bool_0)
	{
		((WindowsFormsApplicationBase)object_0).set_EnableVisualStyles(bool_0);
	}

	internal static void P1ia5Xc2XYkSXMnMlq(object object_0, bool bool_0)
	{
		((WindowsFormsApplicationBase)object_0).set_SaveMySettingsOnExit(bool_0);
	}

	internal static void WpoC02ZUd37HvHRwcM(object object_0, ShutdownMode shutdownMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((WindowsFormsApplicationBase)object_0).set_ShutdownStyle(shutdownMode_0);
	}

	internal static object IDaDLyvkeV56aBtXQL()
	{
		return i2e7bM2YvUOxUiJcWX.SLZ8fHes9;
	}

	internal static object f1MfMMoSO8oqI8Peaj(object object_0)
	{
		return ((i2e7bM2YvUOxUiJcWX.oU1P0tUqXAvxSc9W3P)object_0).Form1;
	}

	internal static void wk9EWYp2wsaNeGF8Bw(object object_0, object object_1)
	{
		((WindowsFormsApplicationBase)object_0).set_MainForm((Form)object_1);
	}
}
