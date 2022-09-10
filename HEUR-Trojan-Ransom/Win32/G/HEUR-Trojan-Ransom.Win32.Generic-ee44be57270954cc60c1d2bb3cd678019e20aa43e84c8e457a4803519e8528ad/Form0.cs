using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class Form0 : WindowsFormsApplicationBase
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
			while (true)
			{
				IL_0037:
				int num = 1537216435;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x74960546u) % 3u)
					{
					case 2u:
						goto IL_000d;
					default:
						goto end_IL_001a;
					case 0u:
						break;
					case 1u:
						goto end_IL_001a;
					}
					goto IL_0037;
					IL_000d:
					num = ((int)num2 * -1758548414) ^ 0x6ECED2AC;
					continue;
					end_IL_001a:
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
			int num3 = 340446674;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num3 ^ 0x74960546u) % 3u)
				{
				case 1u:
					goto IL_0041;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0041:
				((WindowsFormsApplicationBase)Class1.Form0_0).Run(args);
				num3 = (int)(num2 * 1247790422) ^ -1372129164;
			}
		}
	}

	[DebuggerStepThrough]
	public Form0()
		: base((AuthenticationMode)0)
	{
		while (true)
		{
			int num = -1024603128;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xADCBB01Eu) % 7u)
				{
				case 6u:
					((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
					num = ((int)num2 * -1056403635) ^ 0x252ABF73;
					continue;
				case 5u:
					((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
					num = ((int)num2 * -1156142955) ^ 0x6167815A;
					continue;
				case 3u:
					((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
					num = ((int)num2 * -1101290860) ^ 0xC17E1FF;
					continue;
				case 2u:
					num = (int)((num2 * 988532177) ^ 0x5C759EF4);
					continue;
				case 1u:
					((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
					num = ((int)num2 * -1578295132) ^ -2073269580;
					continue;
				default:
					return;
				case 4u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	void WindowsFormsApplicationBase.OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)Class1.Class2_0.Form1_0);
	}
}
