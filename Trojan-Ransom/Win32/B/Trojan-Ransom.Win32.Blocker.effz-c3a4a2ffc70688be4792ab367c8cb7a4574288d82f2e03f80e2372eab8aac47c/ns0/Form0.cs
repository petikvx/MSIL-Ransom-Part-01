using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal sealed class Form0 : Form
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1652)]
	private struct Struct20
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1 = new char[826];

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	public Form0(string string_1, string string_2, string string_3)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		Label val = default(Label);
		Button val2 = default(Button);
		PictureBox val3 = default(PictureBox);
		Control[] array = default(Control[]);
		try
		{
			val = new Label();
			val2 = new Button();
			val3 = new PictureBox();
			((Control)this).SuspendLayout();
			val3.set_Image((Image)(object)Class12.smethod_0(string_3));
			((Control)val3).set_Location(new Point(8, 8));
			((Control)val3).set_Size(new Size(48, 48));
			val3.set_TabStop(false);
			((Control)val).set_Location(new Point(64, 24));
			((Control)val).set_Size(new Size(308, 108));
			((Control)val).set_Text(string_1);
			((ButtonBase)val2).set_FlatStyle((FlatStyle)3);
			((Control)val2).set_Location(new Point(172, 140));
			((Control)val2).set_TabIndex(0);
			((Control)val2).set_Text("OK");
			((Control)val2).add_Click((EventHandler)method_0);
			((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
			((Form)this).set_ClientSize(new Size(398, 174));
			ControlCollection controls = ((Control)this).get_Controls();
			array = (Control[])(object)new Control[3]
			{
				(Control)val2,
				(Control)val,
				(Control)val3
			};
			controls.AddRange(array);
			((Form)this).set_AcceptButton((IButtonControl)(object)val2);
			((Form)this).set_CancelButton((IButtonControl)(object)val2);
			((Form)this).set_FormBorderStyle((FormBorderStyle)3);
			((Form)this).set_MaximizeBox(false);
			((Form)this).set_MinimizeBox(false);
			((Control)this).set_Text(string_2);
			((Form)this).set_StartPosition((FormStartPosition)1);
			((Form)this).set_TopMost(true);
			((Control)this).ResumeLayout(false);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException8(exception, val, val2, val3, array, this, string_1, string_2, string_3);
			throw;
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		try
		{
			((Form)this).Close();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, sender, e);
			throw;
		}
	}

	static Form0()
	{
		char[] array = new char[8];
		array[3] = 'Ƽ';
		array[1] = '\u073c';
		array[5] = 'Ս';
		array[6] = '\u0873';
		array[2] = '\u0ad1';
		array[0] = '㏞';
		array[4] = '\u05f5';
		array[7] = '㐠';
		string_0 = new string[36];
		char_0 = array;
	}
}
