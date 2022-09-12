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
				IL_0038:
				int num = 1934198633;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x68866423u) % 3u)
					{
					case 1u:
						goto IL_0004;
					default:
						goto end_IL_001b;
					case 0u:
						break;
					case 2u:
						goto end_IL_001b;
					}
					goto IL_0038;
					IL_0004:
					Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
					num = ((int)num2 * -870622290) ^ -494722214;
					continue;
					end_IL_001b:
					break;
				}
				break;
			}
		}
		finally
		{
		}
		while (true)
		{
			int num3 = 2085251184;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num3 ^ 0x68866423u) % 3u)
				{
				case 1u:
					goto IL_0042;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0042:
				((WindowsFormsApplicationBase)MyProject.Application).Run(args);
				num3 = (int)((num2 * 793931945) ^ 0x613071D6);
			}
		}
	}

	[DebuggerStepThrough]
	public MyApplication()
		: base((AuthenticationMode)0)
	{
		while (true)
		{
			int num = -940179236;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBA7FBE3Cu) % 7u)
				{
				case 4u:
					((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
					num = ((int)num2 * -1271875972) ^ -469998507;
					continue;
				case 3u:
					((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
					num = (int)(num2 * 402162072) ^ -1298207050;
					continue;
				case 2u:
					((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
					num = ((int)num2 * -1746294262) ^ -1907972231;
					continue;
				case 1u:
					MyApplication.smethod_2((WindowsFormsApplicationBase)(object)this, bool_0: true);
					num = ((int)num2 * -743774541) ^ 0x70CD9992;
					continue;
				case 0u:
					num = (int)(num2 * 672150671) ^ -774595111;
					continue;
				default:
					return;
				case 6u:
					break;
				case 5u:
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
			int num = -944044892;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDC205259u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 523802507) ^ -101831342;
					continue;
				case 1u:
					((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)MyProject.Forms.Form1);
					num = ((int)num2 * -752490791) ^ -724001421;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
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
