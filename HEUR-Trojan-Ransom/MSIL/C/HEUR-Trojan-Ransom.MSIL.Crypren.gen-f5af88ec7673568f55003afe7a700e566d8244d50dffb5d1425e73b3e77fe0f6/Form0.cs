using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.ApplicationServices;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal class Form0 : WindowsFormsApplicationBase
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerHidden]
	internal static void Main(string[] args)
	{
		Class29.smethod_0(7579574, null, new object[1] { args });
	}

	[DebuggerStepThrough]
	public Form0()
		: base((AuthenticationMode)0)
	{
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		while (true)
		{
			int num = Class54.smethod_0(79);
			int num2 = -4;
			while (true)
			{
				IL_00d8:
				num2 ^= 0x4B;
				int num3;
				while (true)
				{
					num3 = Class54.smethod_0(77);
					while (true)
					{
						switch (num3 ^ 0x4A)
						{
						case -78:
							num3 = Class54.smethod_0(72);
							continue;
						case -77:
							goto end_IL_0039;
						case -76:
							goto IL_00cb;
						case -75:
							goto IL_00d8;
						}
						break;
					}
					continue;
					end_IL_0039:
					break;
				}
				switch (num2)
				{
				case -76:
					goto IL_0064;
				case -74:
					goto IL_006e;
				case -73:
					goto IL_00b7;
				case -75:
					goto end_IL_00d8;
				}
				num3 = -2;
				num3 = -76;
				goto IL_00cb;
				IL_0064:
				num2 = Class54.smethod_0(79);
				continue;
				IL_00cb:
				num2 = Class54.smethod_0(73);
				num3 = -1;
				num3 = -75;
				continue;
				IL_006e:
				switch (num)
				{
				default:
					num2 = -2;
					continue;
				case -81:
					((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
					num = -3;
					break;
				case -80:
					num = -2;
					break;
				case -79:
					((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
					num = -4;
					break;
				case -78:
					((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
					num = -31;
					break;
				case -77:
					return;
				}
				goto IL_00b7;
				IL_00b7:
				num ^= 0x4E;
				num2 = Class54.smethod_0(73);
				num3 = -1;
				num3 = -75;
				continue;
				end_IL_00d8:
				break;
			}
		}
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		Class29.smethod_0(7579533, this, null);
	}
}
