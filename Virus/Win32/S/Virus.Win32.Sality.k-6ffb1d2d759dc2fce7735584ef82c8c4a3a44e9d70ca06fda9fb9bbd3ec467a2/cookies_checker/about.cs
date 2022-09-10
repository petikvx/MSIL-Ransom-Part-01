using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace cookies_checker;

public class about : Form
{
	private IContainer icontainer_0;

	private Button button1;

	private TextBox textBox1;

	private TextBox LdvXiQiPR;

	private LinkLabel linkLabel2;

	private LinkLabel linkLabel3;

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		button1 = new Button();
		textBox1 = new TextBox();
		LdvXiQiPR = new TextBox();
		linkLabel2 = new LinkLabel();
		linkLabel3 = new LinkLabel();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(79, 121));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 25));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("close");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)textBox1).set_BackColor(SystemColors.AppWorkspace);
		((Control)textBox1).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_Location(new Point(12, 12));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(252, 71));
		((Control)textBox1).set_TabIndex(2);
		((Control)textBox1).set_Text("\r\nwebsite:");
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)LdvXiQiPR).set_BackColor(SystemColors.ControlLightLight);
		((Control)LdvXiQiPR).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)LdvXiQiPR).set_Location(new Point(54, 89));
		((TextBoxBase)LdvXiQiPR).set_Multiline(true);
		((Control)LdvXiQiPR).set_Name("textBox2");
		((TextBoxBase)LdvXiQiPR).set_ReadOnly(true);
		((Control)LdvXiQiPR).set_Size(new Size(134, 26));
		((Control)LdvXiQiPR).set_TabIndex(4);
		((Control)LdvXiQiPR).set_TabStop(false);
		((Control)LdvXiQiPR).set_Text("Cookies Cheker V5");
		((Control)LdvXiQiPR).add_TextChanged((EventHandler)LdvXiQiPR_TextChanged);
		((Control)linkLabel2).set_AutoSize(true);
		((Control)linkLabel2).set_BackColor(SystemColors.ControlLightLight);
		((Control)linkLabel2).set_Font(new Font("Comic Sans MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)linkLabel2).set_ForeColor(Color.Red);
		linkLabel2.set_LinkColor(Color.Red);
		((Control)linkLabel2).set_Location(new Point(33, 149));
		((Control)linkLabel2).set_Name("linkLabel2");
		((Control)linkLabel2).set_Size(new Size(189, 30));
		((Control)linkLabel2).set_TabIndex(19);
		((Label)linkLabel2).set_TabStop(true);
		((Control)linkLabel2).set_Text("Support me: Donate using  Alertpay\r\n    to \"a.shawky.1@gmail.com\"           \r\n");
		linkLabel2.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel2_LinkClicked));
		((Control)linkLabel3).set_AutoSize(true);
		((Control)linkLabel3).set_BackColor(SystemColors.ControlLightLight);
		((Control)linkLabel3).set_Location(new Point(76, 32));
		((Control)linkLabel3).set_Name("linkLabel3");
		((Control)linkLabel3).set_Size(new Size(0, 13));
		((Control)linkLabel3).set_TabIndex(20);
		linkLabel3.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel3_LinkClicked));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(268, 180));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)linkLabel3);
		((Control)this).get_Controls().Add((Control)(object)linkLabel2);
		((Control)this).get_Controls().Add((Control)(object)LdvXiQiPR);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Control)this).set_Name("about");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Cookies Cheker V5");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)about_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public about()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void method_0(object sender, LinkLabelLinkClickedEventArgs e)
	{
	}

	private void about_Load(object sender, EventArgs e)
	{
		((Control)this).set_Text(Form2.program_name);
		((Control)LdvXiQiPR).set_Text(Form2.program_name);
		((Control)linkLabel3).set_Text(Form2.website_link);
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void SycMnakMw(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start(Form2.website_link);
		}
		catch
		{
		}
	}

	private void LdvXiQiPR_TextChanged(object sender, EventArgs e)
	{
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.alertpay.com/SendMoney.aspx");
	}

	private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start(Form2.website_link);
		}
		catch
		{
		}
	}
}
