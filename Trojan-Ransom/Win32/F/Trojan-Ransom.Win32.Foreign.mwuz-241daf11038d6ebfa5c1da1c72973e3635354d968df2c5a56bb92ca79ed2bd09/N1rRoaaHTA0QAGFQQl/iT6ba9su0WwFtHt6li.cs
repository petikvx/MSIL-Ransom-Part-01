using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using RBkA0En6hx3Ki971At;

namespace N1rRoaaHTA0QAGFQQl;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class iT6ba9su0WwFtHt6li : WindowsFormsApplicationBase
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void XTfHeVfmt(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)Vtl02FUvCrDvQ5eskd.pOPaKYRE1).Run(args);
	}

	[DebuggerStepThrough]
	public iT6ba9su0WwFtHt6li()
	{
		while (true)
		{
			eL9CLmI1aHHaWqDBmH(this, (AuthenticationMode)0);
			J0jXQc1qlDqH8nqPqJ();
			if (!ztJYXfiyMr4UJduNdQ())
			{
				break;
			}
			if (ztJYXfiyMr4UJduNdQ())
			{
				switch (0)
				{
				case 2:
					break;
				case 0:
				case 1:
					goto IL_0045;
				case 5:
					goto IL_004c;
				default:
					goto end_IL_0001;
				case 6:
					return;
				}
				continue;
			}
			goto IL_0045;
			IL_0045:
			G3E4s4hMbbGFhnW4IL(this, bool_0: false);
			goto IL_004c;
			IL_004c:
			mJcME6Lq6Z8RxkZC8a(this, bool_0: true);
			break;
			continue;
			end_IL_0001:
			break;
		}
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)((Vtl02FUvCrDvQ5eskd.MJZV135YDm2sobTv15)tHPFTTY6IUIO8PTYo0()).sdfgh);
	}

	internal static bool ztJYXfiyMr4UJduNdQ()
	{
		return true;
	}

	internal static bool J0jXQc1qlDqH8nqPqJ()
	{
		return false;
	}

	internal static void eL9CLmI1aHHaWqDBmH(object object_0, AuthenticationMode authenticationMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((WindowsFormsApplicationBase)object_0)._002Ector(authenticationMode_0);
	}

	internal static void G3E4s4hMbbGFhnW4IL(object object_0, bool bool_0)
	{
		((WindowsFormsApplicationBase)object_0).set_IsSingleInstance(bool_0);
	}

	internal static void mJcME6Lq6Z8RxkZC8a(object object_0, bool bool_0)
	{
		((WindowsFormsApplicationBase)object_0).set_EnableVisualStyles(bool_0);
	}

	internal static object tHPFTTY6IUIO8PTYo0()
	{
		return Vtl02FUvCrDvQ5eskd.p6lniP1rR;
	}
}
