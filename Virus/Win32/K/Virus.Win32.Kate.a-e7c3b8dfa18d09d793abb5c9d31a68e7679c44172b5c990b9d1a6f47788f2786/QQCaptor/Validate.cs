using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QQCaptor.Tools;
using QQCaptor.Users;

namespace QQCaptor;

public class Validate : Form
{
	private User m_use;

	public bool m_bOK;

	public string m_sQQNum;

	public string m_sDown;

	private IContainer components;

	private Label label1;

	private TextBox textBox1;

	private Button button1;

	private Button button2;

	private PictureBox pictureBoxValidate;

	public Validate()
	{
		InitializeComponent();
	}

	public void SetUser(object use, string sQQNum)
	{
		m_use = (User)use;
		m_sQQNum = sQQNum;
		((Control)textBox1).Select();
		try
		{
			Stream validate = m_use.GetValidate2();
			if (validate != null)
			{
				pictureBoxValidate.set_Image(Image.FromStream(validate));
			}
		}
		catch
		{
		}
		((Control)textBox1).set_Text("");
	}

	private void pictureBoxValidate_Click(object sender, EventArgs e)
	{
		((Control)textBox1).Select();
		pictureBoxValidate.set_Image(Image.FromStream(m_use.GetValidate2()));
		((Control)textBox1).set_Text("");
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		string text = ((Control)textBox1).get_Text();
		if (text == string.Empty)
		{
			MessageBox.Show("请输入验证码！", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			((Control)textBox1).Select();
			return;
		}
		string text2 = m_use.m_hh.Post("http://world.show.qq.com/cgi-bin/parker_user_info", "uin=" + m_sQQNum + "&field=0|3&code=" + text);
		string text3 = null;
		int num = 0;
		int num2 = text2.IndexOf(" code=", 0);
		if (num2 == -1)
		{
			return;
		}
		int num3 = text2.IndexOf(" message=", num2);
		if (num2 == -1 || num3 == -1)
		{
			return;
		}
		num2 += 7;
		num = num3;
		string text4 = text2.Substring(num2, num3 - num2 - 1);
		text3 = text4;
		if (text3 != "0")
		{
			new StringChar();
			num2 = text2.IndexOf(" message=", num);
			if (num2 == -1)
			{
				return;
			}
			num3 = text2.IndexOf("</QQHOME>", num2);
			if (num2 != -1 && num3 != -1)
			{
				num2 += 10;
				num = num3;
				text4 = text2.Substring(num2, num3 - num2 - 3);
				string text5 = StringChar.ChinaUnicodeToASCII(text4);
				if (text5 != null && !(text5 == string.Empty) && !(text5 == ""))
				{
					MessageBox.Show(text5, "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				else
				{
					MessageBox.Show("未知错误：Code = " + text3, "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				((Control)textBox1).Select();
				pictureBoxValidate.set_Image(Image.FromStream(m_use.GetValidate2()));
				((Control)textBox1).set_Text("");
			}
		}
		else
		{
			m_sDown = text2;
			m_bOK = true;
			((Form)this).Close();
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		m_bOK = false;
		((Form)this).Close();
	}

	private void textBox1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.get_KeyValue() == Convert.ToChar(13))
		{
			button1_Click(sender, (EventArgs)(object)e);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
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
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		label1 = new Label();
		textBox1 = new TextBox();
		button1 = new Button();
		button2 = new Button();
		pictureBoxValidate = new PictureBox();
		((ISupportInitialize)pictureBoxValidate).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label1).set_ForeColor(Color.Blue);
		((Control)label1).set_Location(new Point(25, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(281, 31));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("你们不是好友关系或者他没有开通或其他原因，要查看TA的车，需要输入验证码");
		((Control)textBox1).set_Location(new Point(180, 72));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(96, 21));
		((Control)textBox1).set_TabIndex(2);
		((Control)textBox1).add_KeyDown(new KeyEventHandler(textBox1_KeyDown));
		((Control)button1).set_Location(new Point(83, 125));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(77, 33));
		((Control)button1).set_TabIndex(3);
		((Control)button1).set_Text("确定");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_Location(new Point(180, 125));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(77, 33));
		((Control)button2).set_TabIndex(4);
		((Control)button2).set_Text("取消");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)pictureBoxValidate).set_Cursor(Cursors.get_Hand());
		((Control)pictureBoxValidate).set_Location(new Point(27, 43));
		((Control)pictureBoxValidate).set_Name("pictureBoxValidate");
		((Control)pictureBoxValidate).set_Size(new Size(133, 50));
		pictureBoxValidate.set_TabIndex(5);
		pictureBoxValidate.set_TabStop(false);
		((Control)pictureBoxValidate).add_Click((EventHandler)pictureBoxValidate_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(340, 181));
		((Control)this).get_Controls().Add((Control)(object)pictureBoxValidate);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("Validate");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("输入验证码");
		((ISupportInitialize)pictureBoxValidate).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
