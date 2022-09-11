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
	[DebuggerHidden]
	[STAThread]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)Delegate10.smethod_0()).Run(args);
	}

	[DebuggerStepThrough]
	public Form0()
		: base((AuthenticationMode)Class84.smethod_0(0))
	{
		while (true)
		{
			int num = Class89.smethod_1(57);
			while (true)
			{
				switch (num ^ Class84.smethod_0(87))
				{
				case -50:
					((WindowsFormsApplicationBase)this).set_IsSingleInstance((byte)Class84.smethod_0(0) != 0);
					num = -5;
					continue;
				case -51:
					((WindowsFormsApplicationBase)this).set_EnableVisualStyles((byte)Class84.smethod_0(1) != 0);
					num = Class89.smethod_1(61);
					continue;
				case -52:
					num = -10;
					continue;
				case -53:
					num = -9;
					continue;
				case -54:
					num = -4;
					continue;
				case -55:
					num = -2;
					continue;
				case -56:
					num = -7;
					continue;
				case -57:
					((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)Class84.smethod_0(0));
					num = -8;
					continue;
				case -58:
					((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit((byte)Class84.smethod_0(1) != 0);
					num = -3;
					continue;
				case -49:
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
			int num = Class84.smethod_0(60);
			while (true)
			{
				switch (num ^ Class84.smethod_0(378))
				{
				case 65:
					((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)Delegate12.smethod_0(Delegate11.smethod_0()));
					num = 117;
					continue;
				case 64:
					num = 119;
					continue;
				case 63:
					num = 10;
					continue;
				case 66:
					return;
				}
				break;
			}
		}
	}
}
