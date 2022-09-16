using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public sealed class GForm2 : Form
{
	private IContainer icontainer_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label label_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ComboBox comboBox_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TextBox textBox_0;

	public List<GClass9> list_0;

	public int int_0;

	public GForm2(int int_1)
	{
		((Form)this).add_Load((EventHandler)GForm2_Load);
		list_0 = new List<GClass9>();
		int_0 = -1;
		method_0();
		checked
		{
			int num = int_1 - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass9 gClass = Class24.gclass6_0.method_3(-1);
				list_0.Add(gClass);
				vmethod_2().get_Items().Add((object)gClass.vmethod_4());
			}
			int selectedIndex = Class24.smethod_0(0, int_1 - 1);
			vmethod_2().set_SelectedIndex(selectedIndex);
		}
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		vmethod_1(new Label());
		vmethod_3(new ComboBox());
		vmethod_5(new Button());
		vmethod_7(new TextBox());
		((Control)this).SuspendLayout();
		vmethod_0().set_AutoSize(true);
		((Control)vmethod_0()).set_Location(new Point(13, 13));
		((Control)vmethod_0()).set_Name(Class16.smethod_0(-561829487));
		((Control)vmethod_0()).set_Size(new Size(229, 13));
		((Control)vmethod_0()).set_TabIndex(0);
		vmethod_0().set_Text(Class16.smethod_0(-561834201));
		((ListControl)vmethod_2()).set_FormattingEnabled(true);
		((Control)vmethod_2()).set_Location(new Point(13, 30));
		((Control)vmethod_2()).set_Name(Class16.smethod_0(-561834145));
		((Control)vmethod_2()).set_Size(new Size(229, 21));
		((Control)vmethod_2()).set_TabIndex(1);
		((Control)vmethod_4()).set_Location(new Point(261, 13));
		((Control)vmethod_4()).set_Name(Class16.smethod_0(-561834129));
		((Control)vmethod_4()).set_Size(new Size(62, 40));
		((Control)vmethod_4()).set_TabIndex(2);
		((ButtonBase)vmethod_4()).set_Text(Class16.smethod_0(-561834115));
		((ButtonBase)vmethod_4()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_6()).set_Location(new Point(13, 57));
		vmethod_6().set_Multiline(true);
		((Control)vmethod_6()).set_Name(Class16.smethod_0(-561834102));
		((Control)vmethod_6()).set_Size(new Size(310, 354));
		((Control)vmethod_6()).set_TabIndex(3);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(337, 423));
		((Control)this).get_Controls().Add((Control)(object)vmethod_6());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).set_Name(Class16.smethod_0(-561834069));
		((Form)this).set_Text(Class16.smethod_0(-561834049));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	internal virtual Label vmethod_0()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_1(Label label_1)
	{
		label_0 = label_1;
	}

	internal virtual ComboBox vmethod_2()
	{
		return comboBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_3(ComboBox comboBox_1)
	{
		EventHandler eventHandler = method_2;
		ComboBox val = comboBox_0;
		if (val != null)
		{
			val.remove_SelectedIndexChanged(eventHandler);
		}
		comboBox_0 = comboBox_1;
		val = comboBox_0;
		if (val != null)
		{
			val.add_SelectedIndexChanged(eventHandler);
		}
	}

	internal virtual Button vmethod_4()
	{
		return button_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_5(Button button_1)
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

	internal virtual TextBox vmethod_6()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_7(TextBox textBox_1)
	{
		textBox_0 = textBox_1;
	}

	private void GForm2_Load(object sender, EventArgs e)
	{
		int_0 = -1;
	}

	private void method_1(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void method_2(object sender, EventArgs e)
	{
		int selectedIndex = vmethod_2().get_SelectedIndex();
		GClass9 gClass = list_0[selectedIndex];
		string text = gClass.ToString();
		vmethod_6().set_Text(text);
		int_0 = gClass.int_0;
	}
}
