using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QQCaptor.Users;

namespace QQCaptor;

public class AddFriend : Form
{
	private IContainer components;

	private TextBox textBox1;

	private Button button1;

	private Button button2;

	private PictureBox pictureBoxValidate;

	private Label label1;

	private TextBox textBox2;

	private Label label2;

	private Button button3;

	private User m_use;

	public bool m_bOK;

	public string m_sString1 = "Hello!";

	public string m_sString2 = "";

	public string m_sQQnum = "";

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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		textBox1 = new TextBox();
		button1 = new Button();
		button2 = new Button();
		pictureBoxValidate = new PictureBox();
		label1 = new Label();
		textBox2 = new TextBox();
		label2 = new Label();
		button3 = new Button();
		((ISupportInitialize)pictureBoxValidate).BeginInit();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_Location(new Point(180, 72));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(96, 21));
		((Control)textBox1).set_TabIndex(2);
		((Control)textBox1).add_KeyDown(new KeyEventHandler(textBox1_KeyDown));
		((Control)button1).set_Location(new Point(51, 123));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(148, 33));
		((Control)button1).set_TabIndex(3);
		((Control)button1).set_Text("确定[对方需要验证]");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_Location(new Point(212, 123));
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
		((Control)label1).set_ForeColor(Color.Blue);
		((Control)label1).set_Location(new Point(25, 13));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(89, 16));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("输入验证信息：");
		((Control)textBox2).set_Location(new Point(120, 7));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(156, 21));
		((Control)textBox2).set_TabIndex(6);
		((Control)label2).set_ForeColor(Color.Blue);
		((Control)label2).set_Location(new Point(178, 48));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(89, 16));
		((Control)label2).set_TabIndex(7);
		((Control)label2).set_Text("输入验证码：");
		((Control)button3).set_Location(new Point(282, 67));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(57, 29));
		((Control)button3).set_TabIndex(8);
		((Control)button3).set_Text("确定[对方不需要验证]");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).set_Visible(false);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(340, 181));
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)pictureBoxValidate);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("AddFriend");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("输入验证码");
		((ISupportInitialize)pictureBoxValidate).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public AddFriend()
	{
		InitializeComponent();
	}

	public void SetUser(object use, string sQQnum)
	{
		m_use = (User)use;
		m_sQQnum = sQQnum;
		((Control)textBox2).set_Text(m_sString1);
		((Control)textBox1).Select();
		((Control)textBox1).set_Text("");
		try
		{
			Stream addFriend = m_use.GetAddFriend();
			if (addFriend != null)
			{
				pictureBoxValidate.set_Image(Image.FromStream(addFriend));
			}
		}
		catch
		{
		}
	}

	private void pictureBoxValidate_Click(object sender, EventArgs e)
	{
		((Control)textBox1).Select();
		pictureBoxValidate.set_Image(Image.FromStream(m_use.GetAddFriend()));
		((Control)textBox1).set_Text("");
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		string text = ((Control)textBox1).get_Text();
		if (text == string.Empty)
		{
			MessageBox.Show("请输入验证码！", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			((Control)textBox1).Select();
			return;
		}
		m_sString1 = ((Control)textBox2).get_Text();
		if (m_sString1 == string.Empty)
		{
			MessageBox.Show("请输入验证信息！", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			((Control)textBox2).Select();
			return;
		}
		string text2 = null;
		try
		{
			string text3 = m_use.m_hh.Post("http://users.qzone.qq.com/cgi-bin/tfriend/friend_addfriend.cgi", "ouin=" + m_sQQnum + "&uin=" + m_use.m_sQQnum + "&type=1&strmsg=" + m_sString1 + "&groupId=1&allowAdd=1&flag=0&verifycode=" + text);
			if (text3.IndexOf("\"ret\":\"error\"") != -1)
			{
				int num = text3.IndexOf("\"msg\"", 0);
				if (num != -1)
				{
					int num2 = text3.IndexOf("}", num);
					if (num != -1 && num2 != -1)
					{
						num += 7;
						string text4 = text3.Substring(num, num2 - num - 2);
						text2 = text4;
						MessageBox.Show(text2, "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
						pictureBoxValidate_Click(null, null);
					}
				}
				return;
			}
		}
		catch
		{
		}
		m_bOK = true;
		((Form)this).Close();
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

	private void button3_Click(object sender, EventArgs e)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		string text = null;
		try
		{
			string text2 = m_use.m_hh.Post("http://users.qzone.qq.com/cgi-bin/tfriend/friend_authfriend.cgi", "uin=" + m_use.m_sQQnum + "&ouin=" + m_sQQnum, "http://imgcache.qq.com/qzone/v5/toolpages/fp_utf8.html");
			if (text2.IndexOf("\"ret\":\"error\"") != -1)
			{
				int num = text2.IndexOf("\"msg\"", 0);
				if (num != -1)
				{
					int num2 = text2.IndexOf("}", num);
					if (num != -1 && num2 != -1)
					{
						num += 7;
						string text3 = text2.Substring(num, num2 - num - 2);
						text = text3;
						MessageBox.Show(text, "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
						pictureBoxValidate_Click(null, null);
					}
				}
				return;
			}
		}
		catch
		{
		}
		m_bOK = true;
		((Form)this).Close();
	}
}
