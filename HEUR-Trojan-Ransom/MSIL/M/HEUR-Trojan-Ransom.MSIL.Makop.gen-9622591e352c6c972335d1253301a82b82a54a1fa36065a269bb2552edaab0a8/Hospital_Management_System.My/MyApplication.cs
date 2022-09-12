using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace Hospital_Management_System.My;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class MyApplication : WindowsFormsApplicationBase
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
		((WindowsFormsApplicationBase)MyProject.Application).Run(args);
	}

	[DebuggerStepThrough]
	public MyApplication()
		: base((AuthenticationMode)0)
	{
		while (true)
		{
			int num = -371644011;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA9A1B7DAu) % 9u)
				{
				case 8u:
					((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
					num = ((int)num2 * -2143787406) ^ 0x7DFED65E;
					continue;
				case 7u:
					num = ((int)num2 * -1357307993) ^ -1002348550;
					continue;
				case 6u:
					MyApplication.smethod_2((WindowsFormsApplicationBase)(object)this, bool_0: true);
					num = (int)((num2 * 444737370) ^ 0x1D5F85F3);
					continue;
				case 5u:
					num = ((int)num2 * -1763717010) ^ 0x3180AF3D;
					continue;
				case 4u:
					((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
					num = (int)(num2 * 477013633) ^ -566787810;
					continue;
				case 3u:
					num = (int)((num2 * 957778237) ^ 0x24F29354);
					continue;
				case 1u:
					((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
					num = ((int)num2 * -828296068) ^ -282945746;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		while (true)
		{
			int num = -255646597;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF8642EA9u) % 4u)
				{
				case 2u:
					((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)MyProject.Forms.Form1);
					num = ((int)num2 * -1424153963) ^ 0x2CE75A5E;
					continue;
				case 1u:
					num = ((int)num2 * -231508448) ^ 0x3745E92E;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	static void smethod_0(bool bool_0)
	{
		Application.SetCompatibleTextRenderingDefault(bool_0);
	}

	static void smethod_1(WindowsFormsApplicationBase windowsFormsApplicationBase_0, string[] string_0)
	{
		windowsFormsApplicationBase_0.Run(string_0);
	}

	static void smethod_2(WindowsFormsApplicationBase windowsFormsApplicationBase_0, bool bool_0)
	{
		windowsFormsApplicationBase_0.set_SaveMySettingsOnExit(bool_0);
	}
}
