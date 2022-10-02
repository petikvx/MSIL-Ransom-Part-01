using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
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
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)Delegate4.smethod_0()).Run(args);
	}

	[DebuggerStepThrough]
	public Form0()
		: base((AuthenticationMode)Class45.smethod_0(0))
	{
		while (true)
		{
			int num = Class40.smethod_1(11);
			while (true)
			{
				switch (num ^ Class45.smethod_0(44))
				{
				case -1:
					num = -24;
					continue;
				case -2:
					num = -23;
					continue;
				case -3:
					((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit((byte)Class45.smethod_0(1) != 0);
					num = -19;
					continue;
				case -4:
					((WindowsFormsApplicationBase)this).set_EnableVisualStyles((byte)Class45.smethod_0(1) != 0);
					num = -22;
					continue;
				case -5:
					num = Class40.smethod_1(13);
					continue;
				case -6:
					((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)Class45.smethod_0(0));
					num = -20;
					continue;
				case -7:
					num = -18;
					continue;
				case -8:
					num = 20;
					continue;
				case -9:
					((WindowsFormsApplicationBase)this).set_IsSingleInstance((byte)Class45.smethod_0(0) != 0);
					num = -21;
					continue;
				case 0:
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
			int num = Class45.smethod_0(14);
			while (true)
			{
				switch (num ^ Class45.smethod_0(68))
				{
				case 13:
					num = 1;
					continue;
				case 12:
					((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)Delegate6.smethod_0(Delegate5.smethod_0()));
					num = 2;
					continue;
				case 11:
					num = Class45.smethod_0(11);
					continue;
				case 14:
					return;
				}
				break;
			}
		}
	}
}
