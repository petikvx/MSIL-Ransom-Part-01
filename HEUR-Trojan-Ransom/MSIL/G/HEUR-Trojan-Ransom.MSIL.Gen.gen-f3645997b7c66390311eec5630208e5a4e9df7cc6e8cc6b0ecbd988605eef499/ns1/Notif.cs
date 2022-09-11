using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

[DesignerGenerated]
public class Notif : Form
{
	private enum Exec
	{
		OLECMDID_OPTICAL_ZOOM = 63
	}

	private enum ExecOpt
	{
		OLECMDEXECOPT_DODEFAULT,
		OLECMDEXECOPT_PROMPTUSER,
		OLECMDEXECOPT_DONTPROMPTUSER,
		OLECMDEXECOPT_SHOWHELP
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TabPage3")]
	private TabPage _TabPage3;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	[AccessedThroughProperty("Panel5")]
	private Panel _Panel5;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual TabControl TabControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabControl1 = value;
		}
	}

	internal virtual TabPage TabPage1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage1 = value;
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
			WebBrowserDocumentCompletedEventHandler val = new WebBrowserDocumentCompletedEventHandler(WebBrowser1_DocumentCompleted_1);
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
			EventHandler eventHandler = TextBox1_TextChanged;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).remove_TextChanged(eventHandler);
			}
			_TextBox1 = value;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual TabPage TabPage3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage3 = value;
		}
	}

	internal virtual RichTextBox RichTextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RichTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RichTextBox1 = value;
		}
	}

	internal virtual Panel Panel5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel5 = value;
		}
	}

	internal virtual Panel Panel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel4 = value;
		}
	}

	internal virtual TabPage TabPage2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage2 = value;
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
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
			_PictureBox1 = value;
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

	internal virtual Timer Timer3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer3_Tick;
			if (_Timer3 != null)
			{
				_Timer3.remove_Tick(eventHandler);
			}
			_Timer3 = value;
			if (_Timer3 != null)
			{
				_Timer3.add_Tick(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public Notif()
	{
		((Form)this).add_Load((EventHandler)Form13_Load);
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
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected O, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected O, but got Unknown
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Expected O, but got Unknown
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Expected O, but got Unknown
		//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Expected O, but got Unknown
		//IL_0add: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae7: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Notif));
		Panel1 = new Panel();
		TabControl1 = new TabControl();
		TabPage1 = new TabPage();
		WebBrowser1 = new WebBrowser();
		TextBox1 = new TextBox();
		TabPage3 = new TabPage();
		RichTextBox1 = new RichTextBox();
		Panel5 = new Panel();
		Panel4 = new Panel();
		TabPage2 = new TabPage();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		PictureBox1 = new PictureBox();
		Label1 = new Label();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		Timer3 = new Timer(components);
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)TabPage3).SuspendLayout();
		((Control)TabPage2).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel1).set_BackColor(Color.Black);
		((Control)Panel1).set_Dock((DockStyle)1);
		Panel panel = Panel1;
		Point location = new Point(0, 0);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		Size size = new Size(769, 15);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(6);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage1);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage3);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage2);
		((Control)TabControl1).set_Dock((DockStyle)5);
		((Control)TabControl1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TabControl tabControl = TabControl1;
		location = new Point(0, 15);
		((Control)tabControl).set_Location(location);
		((Control)TabControl1).set_Name("TabControl1");
		TabControl1.set_SelectedIndex(0);
		TabControl tabControl2 = TabControl1;
		size = new Size(769, 457);
		((Control)tabControl2).set_Size(size);
		((Control)TabControl1).set_TabIndex(7);
		((Control)TabPage1).get_Controls().Add((Control)(object)WebBrowser1);
		((Control)TabPage1).get_Controls().Add((Control)(object)TextBox1);
		TabPage tabPage = TabPage1;
		location = new Point(4, 33);
		tabPage.set_Location(location);
		((Control)TabPage1).set_Name("TabPage1");
		TabPage tabPage2 = TabPage1;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage2).set_Padding(padding);
		TabPage tabPage3 = TabPage1;
		size = new Size(761, 420);
		((Control)tabPage3).set_Size(size);
		TabPage1.set_TabIndex(0);
		TabPage1.set_Text("Notificação");
		TabPage1.set_UseVisualStyleBackColor(true);
		((Control)WebBrowser1).set_Dock((DockStyle)5);
		WebBrowser webBrowser = WebBrowser1;
		location = new Point(3, 29);
		((Control)webBrowser).set_Location(location);
		WebBrowser webBrowser2 = WebBrowser1;
		size = new Size(20, 20);
		((Control)webBrowser2).set_MinimumSize(size);
		((Control)WebBrowser1).set_Name("WebBrowser1");
		WebBrowser1.set_ScriptErrorsSuppressed(true);
		WebBrowser webBrowser3 = WebBrowser1;
		size = new Size(755, 388);
		((Control)webBrowser3).set_Size(size);
		((Control)WebBrowser1).set_TabIndex(6);
		WebBrowser1.set_Url(new Uri("C:\\satwneyt\\publicidade-da-satwneyt.html", UriKind.Absolute));
		((Control)TextBox1).set_Dock((DockStyle)1);
		((Control)TextBox1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox textBox = TextBox1;
		location = new Point(3, 3);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(755, 26);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(2);
		TextBox1.set_Text("C:\\satwneyt\\publicidade-da-satwneyt.html");
		((Control)TextBox1).set_Visible(false);
		((Control)TabPage3).get_Controls().Add((Control)(object)RichTextBox1);
		((Control)TabPage3).get_Controls().Add((Control)(object)Panel5);
		((Control)TabPage3).get_Controls().Add((Control)(object)Panel4);
		TabPage tabPage4 = TabPage3;
		location = new Point(4, 33);
		tabPage4.set_Location(location);
		((Control)TabPage3).set_Name("TabPage3");
		TabPage tabPage5 = TabPage3;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage5).set_Padding(padding);
		TabPage tabPage6 = TabPage3;
		size = new Size(761, 420);
		((Control)tabPage6).set_Size(size);
		TabPage3.set_TabIndex(2);
		TabPage3.set_Text("Info Versão");
		TabPage3.set_UseVisualStyleBackColor(true);
		((TextBoxBase)RichTextBox1).set_BackColor(Color.White);
		((Control)RichTextBox1).set_Dock((DockStyle)5);
		RichTextBox richTextBox = RichTextBox1;
		location = new Point(3, 3);
		((Control)richTextBox).set_Location(location);
		((Control)RichTextBox1).set_Name("RichTextBox1");
		((TextBoxBase)RichTextBox1).set_ReadOnly(true);
		RichTextBox1.set_ShowSelectionMargin(true);
		RichTextBox richTextBox2 = RichTextBox1;
		size = new Size(755, 414);
		((Control)richTextBox2).set_Size(size);
		((Control)RichTextBox1).set_TabIndex(9);
		RichTextBox1.set_Text("Loading...");
		Panel panel3 = Panel5;
		location = new Point(-27, -93);
		((Control)panel3).set_Location(location);
		((Control)Panel5).set_Name("Panel5");
		Panel panel4 = Panel5;
		size = new Size(200, 100);
		((Control)panel4).set_Size(size);
		((Control)Panel5).set_TabIndex(8);
		Panel panel5 = Panel4;
		location = new Point(-27, -93);
		((Control)panel5).set_Location(location);
		((Control)Panel4).set_Name("Panel4");
		Panel panel6 = Panel4;
		size = new Size(200, 100);
		((Control)panel6).set_Size(size);
		((Control)Panel4).set_TabIndex(7);
		((Control)TabPage2).get_Controls().Add((Control)(object)Label5);
		((Control)TabPage2).get_Controls().Add((Control)(object)Label4);
		((Control)TabPage2).get_Controls().Add((Control)(object)Label3);
		((Control)TabPage2).get_Controls().Add((Control)(object)Label2);
		((Control)TabPage2).get_Controls().Add((Control)(object)PictureBox1);
		((Control)TabPage2).get_Controls().Add((Control)(object)Label1);
		TabPage tabPage7 = TabPage2;
		location = new Point(4, 33);
		tabPage7.set_Location(location);
		((Control)TabPage2).set_Name("TabPage2");
		TabPage tabPage8 = TabPage2;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage8).set_Padding(padding);
		TabPage tabPage9 = TabPage2;
		size = new Size(761, 420);
		((Control)tabPage9).set_Size(size);
		TabPage2.set_TabIndex(3);
		TabPage2.set_Text("Sobre Nós");
		TabPage2.set_UseVisualStyleBackColor(true);
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label = Label5;
		location = new Point(21, 370);
		((Control)label).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label2 = Label5;
		size = new Size(477, 20);
		((Control)label2).set_Size(size);
		((Control)Label5).set_TabIndex(5);
		Label5.set_Text("© 2011-2017  -  Massahiro Software. Todos os direitos reservados.");
		Label4.set_AutoSize(true);
		Label label3 = Label4;
		location = new Point(21, 260);
		((Control)label3).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label4 = Label4;
		size = new Size(306, 72);
		((Control)label4).set_Size(size);
		((Control)Label4).set_TabIndex(4);
		Label4.set_Text("+ INFORMAÇÕES E TIRA-DÚVIDA\r\nEntre no contato do desenvolvedor\r\n\r\n");
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(172, 190);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(402, 24);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(3);
		Label3.set_Text("Desenvolvedor de criação software e sistemas.");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label7 = Label2;
		location = new Point(157, 138);
		((Control)label7).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label8 = Label2;
		size = new Size(481, 42);
		((Control)label8).set_Size(size);
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("MASSAHIRO SOFTWARE");
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		PictureBox pictureBox = PictureBox1;
		location = new Point(25, 111);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(125, 127);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(1);
		PictureBox1.set_TabStop(false);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label9 = Label1;
		location = new Point(9, 12);
		((Control)label9).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label10 = Label1;
		size = new Size(602, 96);
		((Control)label10).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("SATWNEYT\r\nEste antivirus foi criado pelos desenvolvedores do Massahiro Software.\r\nTodos os programas e antivirus já foram testado e aprovado.\r\n\r\n");
		Timer1.set_Enabled(true);
		Timer2.set_Enabled(true);
		Timer2.set_Interval(2);
		Timer3.set_Enabled(true);
		Timer3.set_Interval(2);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		size = new Size(769, 472);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TabControl1);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MinimizeBox(false);
		size = new Size(785, 511);
		((Form)this).set_MinimumSize(size);
		((Control)this).set_Name("Notif");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("SATWNEYT PLUS ONE-X NOTIFICAÇÕES");
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TabPage1).PerformLayout();
		((Control)TabPage3).ResumeLayout(false);
		((Control)TabPage2).ResumeLayout(false);
		((Control)TabPage2).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Form13_Load(object sender, EventArgs e)
	{
		Timer3.set_Enabled(true);
		try
		{
			WebClient webClient = new WebClient();
			webClient.Credentials = new NetworkCredential("cnectoversy", "Msyende479280");
			webClient.DownloadFile("ftp://cnectoversy@files.000webhost.com/NOTIF/Notif.HTML", "C:\\Satwneyt\\publicidade-da-satwneyt.html");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process process = new Process();
			Process process2 = process;
			process2.StartInfo.FileName = TextBox1.get_Text();
			process2.Start();
			process2 = null;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			WebClient webClient2 = new WebClient();
			webClient2.Credentials = new NetworkCredential("cnectoversy", "Msyende479280");
			RichTextBox1.set_Text(webClient2.DownloadString("ftp://cnectoversy@files.000webhost.com/notif/info-text.txt"));
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		try
		{
			Process process = new Process();
			Process process2 = process;
			process2.StartInfo.FileName = "http://www.satwneyt-i-4-comprar.vai.la";
			process2.Start();
			process2 = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		TextBox1.set_Text("http://www.satwneyt-i-4-comprar.vai.la");
	}

	private void Button3_Click(object sender, EventArgs e)
	{
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			WebClient webClient = new WebClient();
			webClient.Credentials = new NetworkCredential("cnectoversy", "Msyende479280");
			webClient.DownloadFile("ftp://cnectoversy@files.000webhost.com/NOTIF/Notif.HTML", "C:\\Satwneyt\\publicidade-da-satwneyt.html");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(((WebBrowserBase)WebBrowser1).get_ActiveXInstance());
			NewLateBinding.LateCall(objectValue, (Type)null, "ExecWB", new object[4]
			{
				Exec.OLECMDID_OPTICAL_ZOOM,
				ExecOpt.OLECMDEXECOPT_PROMPTUSER,
				100,
				IntPtr.Zero
			}, (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		try
		{
			RichTextBox1.set_ForeColor(Color.Black);
			WebClient webClient = new WebClient();
			webClient.Credentials = new NetworkCredential("cnectoversy", "Msyende479280");
			RichTextBox1.set_Text(webClient.DownloadString("ftp://cnectoversy@files.000webhost.com/notif/info-text.txt"));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			RichTextBox1.set_ForeColor(Color.Red);
			RichTextBox1.set_Text("OCORREU UMA FALHA NA INFORMAÇÃO !!!\r\n\r\nDATA DO DIA: " + Conversions.ToString(DateAndTime.get_Now()) + "\r\nNenhuma novidade até hoje ou na falha da atualização do produto.\r\nTalvez a informação do produto pode chegar amanhã e deverá estar conectado a internet. Verifique a sua rede para continuar acessar.");
			ProjectData.ClearProjectError();
		}
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		WebBrowser1.GoBack();
		TextBox1.set_Text("C:\\Satwneyt\\publicidade-da-satwneyt.html");
		WebBrowser1.Navigate("C:\\Satwneyt\\publicidade-da-satwneyt.html");
		if ((double)Timer3.get_Interval() == Conversions.ToDouble("500"))
		{
			WebBrowser1.GoBack();
			TextBox1.set_Text("C:\\Satwneyt\\publicidade-da-satwneyt.html");
			WebBrowser1.Navigate("C:\\Satwneyt\\publicidade-da-satwneyt.html");
			Timer3.set_Enabled(false);
		}
	}

	private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
	}

	private void WebBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		Timer3.set_Interval(Conversions.ToInteger("500"));
	}
}
