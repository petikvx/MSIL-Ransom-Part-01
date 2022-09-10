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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[STAThread]
	[DebuggerHidden]
	internal static void Main(string[] args)
	{
		try
		{
			Delegate5.smethod_0(Delegate4.smethod_0());
		}
		finally
		{
		}
		Delegate6.smethod_0(Class1.Form0_0, args);
	}

	[DebuggerStepThrough]
	public Form0()
		: base((AuthenticationMode)Class43.smethod_0(0))
	{
		while (true)
		{
			int num = Class35.smethod_0(10);
			while (true)
			{
				switch (num ^ Class43.smethod_0(3))
				{
				case 0:
					num = -1;
					continue;
				case -1:
					num = -8;
					continue;
				case -2:
					num = -2;
					continue;
				case -3:
					Delegate8.smethod_0(this, (byte)Class43.smethod_0(1) != 0);
					num = 5;
					continue;
				case -4:
					Delegate7.smethod_0(this, (byte)Class43.smethod_0(0) != 0);
					num = -6;
					continue;
				case -5:
					Delegate10.smethod_0(this, (ShutdownMode)Class43.smethod_0(0));
					num = Class35.smethod_0(13);
					continue;
				case -6:
					Delegate9.smethod_0(this, (byte)Class43.smethod_0(1) != 0);
					num = -5;
					continue;
				case -7:
					num = -4;
					continue;
				case -8:
					num = 4;
					continue;
				case 1:
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
			int num = Class35.smethod_0(8);
			while (true)
			{
				switch (num ^ Class43.smethod_0(2))
				{
				case -2:
					num = -4;
					continue;
				case -3:
					num = -2;
					continue;
				case -4:
					Delegate11.smethod_0(this, (Form)(object)Class1.Class2_0.GForm0_0);
					num = -3;
					continue;
				case -1:
					return;
				}
				break;
			}
		}
	}
}
