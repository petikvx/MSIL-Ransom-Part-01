using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HP.SupportFramework.Common.HPSAIssues;
using Microsoft.VisualBasic.ApplicationServices;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal class Form0 : WindowsFormsApplicationBase
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[STAThread]
	internal static void Main(string[] args)
	{
		Class28.smethod_0(4813192, null, new object[1] { args });
	}

	[DebuggerStepThrough]
	public Form0()
		: base((AuthenticationMode)0)
	{
		while (true)
		{
			int num = ActionItemBase.smethod_0(27);
			int num2 = ActionItemBase.smethod_0(28);
			while (true)
			{
				switch (num2 ^ 0x16)
				{
				case -19:
					num ^= 0x17;
					num2 = ActionItemBase.smethod_0(24);
					continue;
				case -20:
					switch (num)
					{
					case -21:
						break;
					case -20:
						goto IL_0056;
					case -19:
						goto IL_0062;
					case -18:
						goto IL_0067;
					case -17:
						goto IL_006c;
					case -16:
						goto IL_0071;
					case -15:
						goto IL_0082;
					case -14:
						goto IL_0087;
					case -13:
						goto IL_0096;
					default:
						goto IL_00cd;
					case -12:
						return;
					}
					num = -27;
					goto case -19;
				default:
					num2 = ActionItemBase.smethod_0(24);
					continue;
				case -21:
					break;
				case -22:
					{
						while (true)
						{
							num2 = -4;
							num2 = -22;
						}
					}
					IL_00cd:
					num2 = -3;
					num2 = -21;
					break;
					IL_0096:
					((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
					num = -4;
					goto case -19;
					IL_0087:
					((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
					num = -6;
					goto case -19;
					IL_0082:
					num = -26;
					goto case -19;
					IL_0071:
					((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
					num = ActionItemBase.smethod_0(23);
					goto case -19;
					IL_006c:
					num = -29;
					goto case -19;
					IL_0067:
					num = -5;
					goto case -19;
					IL_0062:
					num = -25;
					goto case -19;
					IL_0056:
					((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
					num = -8;
					goto case -19;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		Class28.smethod_0(4813251, this, null);
	}
}
