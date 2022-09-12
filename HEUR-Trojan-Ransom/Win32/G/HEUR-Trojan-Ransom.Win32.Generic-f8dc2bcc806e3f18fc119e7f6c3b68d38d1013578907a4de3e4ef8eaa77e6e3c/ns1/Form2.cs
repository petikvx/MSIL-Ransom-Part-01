using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace ns1;

[DesignerGenerated]
public class Form2 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual TextBox TextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TextBox2_TextChanged;
			if (_TextBox2 != null)
			{
				((Control)_TextBox2).remove_TextChanged(eventHandler);
			}
			_TextBox2 = value;
			if (_TextBox2 != null)
			{
				((Control)_TextBox2).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox1_Click;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).remove_Click(eventHandler);
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual WebBrowser WebBrowser1
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			WebBrowserDocumentCompletedEventHandler val = new WebBrowserDocumentCompletedEventHandler(WebBrowser1_DocumentCompleted);
			if (_WebBrowser1 != null)
			{
				_WebBrowser1.remove_DocumentCompleted(val);
			}
			_WebBrowser1 = value;
			if (_WebBrowser1 != null)
			{
				_WebBrowser1.add_DocumentCompleted(val);
			}
		}
	}

	internal virtual CheckBox CheckBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox1 = value;
		}
	}

	internal virtual TextBox TextBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TextBox3_TextChanged;
			if (_TextBox3 != null)
			{
				((Control)_TextBox3).remove_TextChanged(eventHandler);
			}
			_TextBox3 = value;
			if (_TextBox3 != null)
			{
				((Control)_TextBox3).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Timer Timer2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			if (_Timer2 != null)
			{
				_Timer2.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			if (_Timer2 != null)
			{
				_Timer2.add_Tick(eventHandler);
			}
		}
	}

	internal virtual LinkLabel LinkLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.remove_LinkClicked(val);
			}
			_LinkLabel1 = value;
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.add_LinkClicked(val);
			}
		}
	}

	[DebuggerNonUserCode]
	public Form2()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Form)this).add_FormClosed(new FormClosedEventHandler(Form2_FormClosed));
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		Label1 = new Label();
		Label2 = new Label();
		Button1 = new Button();
		PictureBox1 = new PictureBox();
		Timer1 = new Timer(components);
		WebBrowser1 = new WebBrowser();
		CheckBox1 = new CheckBox();
		TextBox3 = new TextBox();
		Timer2 = new Timer(components);
		LinkLabel1 = new LinkLabel();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		TextBox textBox = TextBox1;
		Point location = new Point(45, 53);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(160, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		TextBox textBox3 = TextBox2;
		location = new Point(45, 117);
		((Control)textBox3).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox4 = TextBox2;
		size = new Size(160, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(1);
		TextBox2.set_UseSystemPasswordChar(true);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_ForeColor(Color.Black);
		Label label = Label1;
		location = new Point(42, 37);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(65, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(2);
		Label1.set_Text("Kulanıcı Adi:");
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_ForeColor(Color.Black);
		Label label3 = Label2;
		location = new Point(42, 101);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(28, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(3);
		Label2.set_Text("Şifre");
		((Control)Button1).set_Enabled(false);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_ForeColor(Color.FromArgb(0, 64, 0));
		Button button = Button1;
		location = new Point(67, 179);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(97, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(4);
		((ButtonBase)Button1).set_Text("Giriş Yap");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)PictureBox1).set_BackColor(SystemColors.Control);
		((Control)PictureBox1).set_Enabled(false);
		PictureBox pictureBox = PictureBox1;
		location = new Point(-8, -8);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(268, 245);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(6);
		PictureBox1.set_TabStop(false);
		WebBrowser1.set_IsWebBrowserContextMenuEnabled(false);
		WebBrowser webBrowser = WebBrowser1;
		location = new Point(-8, -21);
		((Control)webBrowser).set_Location(location);
		WebBrowser webBrowser2 = WebBrowser1;
		size = new Size(20, 20);
		((Control)webBrowser2).set_MinimumSize(size);
		((Control)WebBrowser1).set_Name("WebBrowser1");
		WebBrowser1.set_ScriptErrorsSuppressed(true);
		WebBrowser webBrowser3 = WebBrowser1;
		size = new Size(281, 258);
		((Control)webBrowser3).set_Size(size);
		((Control)WebBrowser1).set_TabIndex(7);
		WebBrowser1.set_Url(new Uri("http://teknoamiral.com/siteler/Burhan/burhanR/hit2/sayfaveri.php", UriKind.Absolute));
		((ButtonBase)CheckBox1).set_AutoSize(true);
		((ButtonBase)CheckBox1).set_BackColor(Color.Transparent);
		((Control)CheckBox1).set_Enabled(false);
		CheckBox checkBox = CheckBox1;
		location = new Point(122, 143);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(83, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(8);
		((ButtonBase)CheckBox1).set_Text("Vip Kullanıcı");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(false);
		TextBox textBox5 = TextBox3;
		location = new Point(312, 30);
		((Control)textBox5).set_Location(location);
		((Control)TextBox3).set_Name("TextBox3");
		TextBox textBox6 = TextBox3;
		size = new Size(100, 20);
		((Control)textBox6).set_Size(size);
		((Control)TextBox3).set_TabIndex(9);
		((Control)TextBox3).set_Visible(false);
		Timer2.set_Enabled(true);
		Timer2.set_Interval(1);
		((Label)LinkLabel1).set_AutoSize(true);
		((Control)LinkLabel1).set_BackColor(Color.Transparent);
		((Control)LinkLabel1).set_Enabled(false);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(190, 211);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(56, 13);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(5);
		LinkLabel1.set_TabStop(true);
		LinkLabel1.set_Text("Bana Ulaş");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		size = new Size(255, 234);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)6);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		size = new Size(271, 268);
		((Form)this).set_MaximumSize(size);
		((Form)this).set_MinimizeBox(false);
		size = new Size(271, 268);
		((Form)this).set_MinimumSize(size);
		((Control)this).set_Name("Form2");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Login");
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		((Control)this).set_BackgroundImage(PictureBox1.get_Image());
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(TextBox1.get_Text(), MyProject.Forms.Form1.f2kullanici.get_Text(), false) == 0) & (Operators.CompareString(TextBox2.get_Text(), MyProject.Forms.Form1.f2pass.get_Text(), false) == 0))
		{
			if (Operators.CompareString(TextBox3.get_Text(), "Wolfteam Aktif", false) == 0)
			{
				((Control)MyProject.Forms.Form1).Show();
				MyProject.Forms.Form1.Timer1.Start();
				MyProject.Forms.Form1.Timer2.Start();
				((Control)this).Hide();
				((Control)MyProject.Forms.Form3).Show();
			}
			else
			{
				Interaction.MsgBox((object)"Wolfteam'a  Giriş Yapın", (MsgBoxStyle)64, (object)null);
			}
		}
		else
		{
			Interaction.MsgBox((object)"Kullanıcı Adi Veya Şifre Hattalı", (MsgBoxStyle)48, (object)null);
		}
	}

	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Form)MyProject.Forms.Form1).Close();
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void TextBox3_TextChanged(object sender, EventArgs e)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			_ = Process.GetProcessesByName("Wolfteam.bin")[0];
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
			FileSystem.FileClose(new int[1] { 1 });
			FileSystem.FileClose(new int[1] { 2 });
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(folderPath + "\\xspirit.sys"))
			{
				FileSystem.FileOpen(1, folderPath + "\\xspirit.sys", (OpenMode)8, (OpenAccess)3, (OpenShare)0, -1);
			}
			else
			{
				File.WriteAllBytes(folderPath + "\\xspirit.sys", new byte[1] { 0 });
				FileSystem.FileOpen(1, folderPath + "\\xspirit.sys", (OpenMode)8, (OpenAccess)3, (OpenShare)0, -1);
				Interaction.MsgBox((object)"erişim Engellendi", (MsgBoxStyle)48, (object)null);
			}
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(folderPath + "wolfteam.bin\\xhunter1.sys"))
			{
				FileSystem.FileOpen(2, folderPath + "\\xhunter1.sys", (OpenMode)8, (OpenAccess)3, (OpenShare)0, -1);
			}
			else
			{
				File.WriteAllBytes(folderPath + "\\xhunter1.sys", new byte[1] { 0 });
				FileSystem.FileOpen(2, folderPath + "\\xhunter1.sys", (OpenMode)8, (OpenAccess)3, (OpenShare)0, -1);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		if ((Operators.CompareString(TextBox1.get_Text(), MyProject.Forms.Form1.f2kullanici.get_Text(), false) == 0) & (Operators.CompareString(TextBox2.get_Text(), MyProject.Forms.Form1.f2pass.get_Text(), false) == 0))
		{
			if (Operators.CompareString(TextBox3.get_Text(), "Wolfteam Aktif", false) == 0)
			{
				((Control)MyProject.Forms.Form1).Show();
				MyProject.Forms.Form1.Timer1.Start();
				MyProject.Forms.Form1.Timer2.Start();
				((Control)this).Hide();
			}
			else
			{
				Interaction.MsgBox((object)"Wolfteam'a Giriş Yapın", (MsgBoxStyle)64, (object)null);
			}
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		try
		{
			_ = Process.GetProcessesByName("Wolfteam.bin")[0];
			TextBox3.set_Text("Wolfteam Aktif");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		WebBrowser1.Navigate(WebBrowser1.get_Document().GetElementById("1").get_InnerText());
	}

	private void TextBox2_TextChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox2.get_Text(), MyProject.Forms.Form1.f2pass.get_Text(), false) == 0)
		{
			((Control)Button1).set_Enabled(true);
		}
	}
}
