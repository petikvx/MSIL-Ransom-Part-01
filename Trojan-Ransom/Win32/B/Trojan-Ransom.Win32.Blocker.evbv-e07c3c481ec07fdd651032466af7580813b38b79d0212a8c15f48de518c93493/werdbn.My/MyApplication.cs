using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace werdbn.My;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class MyApplication : WindowsFormsApplicationBase
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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

	[DebuggerStepThrough]
	public MyApplication()
	{
		while (true)
		{
			((WindowsFormsApplicationBase)this)._002Ector((AuthenticationMode)0);
			_ = 0;
			if (!VKnJ4UxE4vyRSvXVmw())
			{
				if (VKnJ4UxE4vyRSvXVmw())
				{
					switch (0)
					{
					case 4:
						break;
					case 1:
					case 3:
						goto IL_0044;
					case 0:
					case 2:
						goto IL_004b;
					default:
						goto end_IL_0001;
					case 6:
						return;
					}
				}
				continue;
			}
			goto IL_0044;
			IL_0044:
			((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
			goto IL_004b;
			IL_004b:
			NayfQbXTZyWIRp3pne(this, bool_0: true);
			break;
			continue;
			end_IL_0001:
			break;
		}
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
		EBqHIoT7TF68UY79Zg(this, (ShutdownMode)0);
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)xDCetV02LApi68kN0n(MyProject.Forms));
	}

	internal static bool VKnJ4UxE4vyRSvXVmw()
	{
		return true;
	}

	internal static bool IFmVZYjEHfRHQ0OXdK()
	{
		return false;
	}

	internal static void NayfQbXTZyWIRp3pne(object object_0, bool bool_0)
	{
		((WindowsFormsApplicationBase)object_0).set_EnableVisualStyles(bool_0);
	}

	internal static void EBqHIoT7TF68UY79Zg(object object_0, ShutdownMode shutdownMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((WindowsFormsApplicationBase)object_0).set_ShutdownStyle(shutdownMode_0);
	}

	internal static object xDCetV02LApi68kN0n(object object_0)
	{
		return ((MyProject.MyForms)object_0).uytrdfgh;
	}
}
