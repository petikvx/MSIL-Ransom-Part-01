using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public sealed class GForm3 : Form
{
	private string string_0;

	private IContainer icontainer_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TextBox textBox_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_2;

	public GForm3(string string_1)
	{
		method_0();
		string_0 = string_1;
		vmethod_0().set_Text(string_0);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	internal virtual TextBox vmethod_0()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_1(TextBox textBox_1)
	{
		textBox_0 = textBox_1;
	}

	internal virtual Button vmethod_2()
	{
		return button_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_3(Button button_3)
	{
		EventHandler eventHandler = method_3;
		Button val = button_0;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_0 = button_3;
		val = button_0;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_4()
	{
		return button_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_5(Button button_3)
	{
		EventHandler eventHandler = method_1;
		Button val = button_1;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_1 = button_3;
		val = button_1;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_6()
	{
		return button_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_7(Button button_3)
	{
		EventHandler eventHandler = method_2;
		Button val = button_2;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_2 = button_3;
		val = button_2;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		vmethod_1(new TextBox());
		vmethod_3(new Button());
		vmethod_5(new Button());
		vmethod_7(new Button());
		((Control)this).SuspendLayout();
		vmethod_0().set_AcceptsReturn(true);
		((TextBoxBase)vmethod_0()).set_AcceptsTab(true);
		((Control)vmethod_0()).set_Location(new Point(16, 16));
		vmethod_0().set_Multiline(true);
		((Control)vmethod_0()).set_Name(Class16.smethod_0(-561792303));
		vmethod_0().set_ScrollBars((ScrollBars)2);
		((Control)vmethod_0()).set_Size(new Size(248, 224));
		((Control)vmethod_0()).set_TabIndex(2);
		((Control)vmethod_2()).set_Location(new Point(200, 256));
		((Control)vmethod_2()).set_Name(Class16.smethod_0(-561792286));
		((Control)vmethod_2()).set_Size(new Size(64, 25));
		((Control)vmethod_2()).set_TabIndex(17);
		((ButtonBase)vmethod_2()).set_Text(Class16.smethod_0(-561792273));
		((Control)vmethod_4()).set_Location(new Point(16, 256));
		((Control)vmethod_4()).set_Name(Class16.smethod_0(-561792262));
		((Control)vmethod_4()).set_Size(new Size(96, 25));
		((Control)vmethod_4()).set_TabIndex(18);
		((ButtonBase)vmethod_4()).set_Text(Class16.smethod_0(-561806069));
		((Control)vmethod_6()).set_Location(new Point(120, 256));
		((Control)vmethod_6()).set_Name(Class16.smethod_0(-561806049));
		((Control)vmethod_6()).set_Size(new Size(72, 25));
		((Control)vmethod_6()).set_TabIndex(19);
		((ButtonBase)vmethod_6()).set_Text(Class16.smethod_0(-561806031));
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(280, 294));
		((Control)this).get_Controls().Add((Control)(object)vmethod_6());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name(Class16.smethod_0(-561806014));
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text(Class16.smethod_0(-561806014));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void method_1(object sender, EventArgs e)
	{
		((Form)this).set_DialogResult((DialogResult)5);
		((Form)this).Close();
	}

	private void method_2(object sender, EventArgs e)
	{
		((Form)this).set_DialogResult((DialogResult)6);
		((Form)this).Close();
	}

	private void method_3(object sender, EventArgs e)
	{
		((Form)this).set_DialogResult((DialogResult)7);
		((Form)this).Close();
	}
}
