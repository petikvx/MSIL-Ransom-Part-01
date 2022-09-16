using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public sealed class GForm5 : Form
{
	private IContainer icontainer_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TextBox textBox_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_0;

	public GForm5()
	{
		method_0();
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
	internal virtual void vmethod_3(Button button_1)
	{
		EventHandler eventHandler = method_1;
		Button val = button_0;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_0 = button_1;
		val = button_0;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		ResourceManager resourceManager = new ResourceManager(typeof(GForm5));
		vmethod_1(new TextBox());
		vmethod_3(new Button());
		((Control)this).SuspendLayout();
		((Control)vmethod_0()).set_Location(new Point(8, 8));
		((Control)vmethod_0()).set_Name(Class16.smethod_0(-561834485));
		((Control)vmethod_0()).set_Size(new Size(176, 21));
		((Control)vmethod_0()).set_TabIndex(0);
		((Control)vmethod_2()).set_Location(new Point(200, 8));
		((Control)vmethod_2()).set_Name(Class16.smethod_0(-561834467));
		((Control)vmethod_2()).set_Size(new Size(48, 23));
		((Control)vmethod_2()).set_TabIndex(1);
		((ButtonBase)vmethod_2()).set_Text(Class16.smethod_0(-561834456));
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(258, 48));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)resourceManager.GetObject(Class16.smethod_0(-561834447)));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name(Class16.smethod_0(-561834430));
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text(Class16.smethod_0(-561834414));
		((Control)this).ResumeLayout(false);
	}

	private void method_1(object sender, EventArgs e)
	{
		Class24.string_0 = vmethod_0().get_Text().ToString().Trim();
		((Form)this).set_DialogResult((DialogResult)2);
		((Form)this).Close();
	}
}
