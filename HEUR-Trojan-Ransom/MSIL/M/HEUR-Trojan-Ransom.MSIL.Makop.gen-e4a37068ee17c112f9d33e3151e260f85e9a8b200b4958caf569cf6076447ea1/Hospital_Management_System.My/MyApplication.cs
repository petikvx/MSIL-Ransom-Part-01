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
			while (true)
			{
				IL_004b:
				int num = -1586865061;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD74A4961u) % 4u)
					{
					case 2u:
						Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
						num = ((int)num2 * -1496971941) ^ 0x63D8C62;
						continue;
					case 1u:
						num = ((int)num2 * -830143087) ^ 0x19719678;
						continue;
					default:
						goto end_IL_002a;
					case 3u:
						break;
					case 0u:
						goto end_IL_002a;
					}
					goto IL_004b;
					continue;
					end_IL_002a:
					break;
				}
				break;
			}
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)MyProject.Application).Run(args);
		while (true)
		{
			int num3 = -2026878370;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num3 ^ 0xD74A4961u) % 3u)
				{
				case 1u:
					goto IL_0062;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0062:
				num3 = (int)(num2 * 1001384826) ^ -950482478;
			}
		}
	}

	[DebuggerStepThrough]
	public MyApplication()
		: base((AuthenticationMode)0)
	{
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		MyApplication.smethod_2((WindowsFormsApplicationBase)(object)this, bool_0: true);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)MyProject.Forms.Form1);
		while (true)
		{
			int num = -2035540598;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB5AA2CF6u) % 3u)
				{
				case 2u:
					goto IL_0012;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0012:
				num = ((int)num2 * -1518439823) ^ 0x21517D47;
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
