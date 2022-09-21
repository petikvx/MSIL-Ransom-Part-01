using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Pexeso.My;

namespace Pexeso;

[DesignerGenerated]
public class frmHelp : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("panEasyTitle")]
	internal virtual Panel panEasyTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
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

	[field: AccessedThroughProperty("panBottom")]
	internal virtual Panel panBottom
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button cmdBack
	{
		[CompilerGenerated]
		get
		{
			return _cmdBack;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cmdBack_Click;
			Button val = _cmdBack;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_cmdBack = value;
			val = _cmdBack;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel6")]
	internal virtual Panel Panel6
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public frmHelp()
	{
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
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected O, but got Unknown
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected O, but got Unknown
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected O, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Expected O, but got Unknown
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0906: Unknown result type (might be due to invalid IL or missing references)
		//IL_0910: Expected O, but got Unknown
		//IL_092c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c5: Expected O, but got Unknown
		//IL_09e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba7: Expected O, but got Unknown
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmHelp));
		Label7 = new Label();
		panEasyTitle = new Panel();
		Panel5 = new Panel();
		Label4 = new Label();
		panBottom = new Panel();
		cmdBack = new Button();
		Label14 = new Label();
		Panel6 = new Panel();
		Label2 = new Label();
		Label3 = new Label();
		Panel1 = new Panel();
		Panel2 = new Panel();
		Label5 = new Label();
		Label1 = new Label();
		Panel3 = new Panel();
		((Control)panEasyTitle).SuspendLayout();
		((Control)Panel5).SuspendLayout();
		((Control)panBottom).SuspendLayout();
		((Control)Panel6).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Label7).set_Dock((DockStyle)5);
		((Control)Label7).set_Font(new Font("Cambria", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label7).set_Location(new Point(0, 0));
		((Control)Label7).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Padding(new Padding(13, 0, 0, 0));
		((Control)Label7).set_Size(new Size(512, 329));
		((Control)Label7).set_TabIndex(15);
		Label7.set_Text("Pexeso or Memory game in English is game where player have to guess pictures and remember their position in order to guess same picture next time ");
		((Control)panEasyTitle).set_BackColor(Color.FromArgb(224, 224, 224));
		panEasyTitle.set_BorderStyle((BorderStyle)1);
		((Control)panEasyTitle).get_Controls().Add((Control)(object)Label7);
		((Control)panEasyTitle).set_Location(new Point(19, 148));
		((Control)panEasyTitle).set_Margin(new Padding(8, 7, 8, 7));
		((Control)panEasyTitle).set_Name("panEasyTitle");
		((Control)panEasyTitle).set_Size(new Size(514, 331));
		((Control)panEasyTitle).set_TabIndex(15);
		((Control)Panel5).set_BackColor(SystemColors.Control);
		((Control)Panel5).get_Controls().Add((Control)(object)panEasyTitle);
		((Control)Panel5).get_Controls().Add((Control)(object)Label4);
		((Control)Panel5).set_Dock((DockStyle)3);
		((Control)Panel5).set_Location(new Point(0, 143));
		((Control)Panel5).set_Margin(new Padding(8, 7, 8, 7));
		((Control)Panel5).set_Name("Panel5");
		((Control)Panel5).set_Size(new Size(555, 623));
		((Control)Panel5).set_TabIndex(21);
		((Control)Label4).set_Dock((DockStyle)1);
		((Control)Label4).set_Font(new Font("Cambria", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label4).set_Location(new Point(0, 0));
		((Control)Label4).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(555, 160));
		((Control)Label4).set_TabIndex(10);
		Label4.set_Text("About game");
		Label4.set_TextAlign((ContentAlignment)32);
		((Control)panBottom).set_BackColor(SystemColors.Control);
		((Control)panBottom).get_Controls().Add((Control)(object)cmdBack);
		((Control)panBottom).set_Dock((DockStyle)2);
		((Control)panBottom).set_Location(new Point(0, 766));
		((Control)panBottom).set_Margin(new Padding(8, 7, 8, 7));
		((Control)panBottom).set_Name("panBottom");
		((Control)panBottom).set_Size(new Size(1851, 238));
		((Control)panBottom).set_TabIndex(20);
		cmdBack.set_DialogResult((DialogResult)2);
		((Control)cmdBack).set_Font(new Font("Cambria", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)cmdBack).set_Location(new Point(733, 72));
		((Control)cmdBack).set_Margin(new Padding(8, 7, 8, 7));
		((Control)cmdBack).set_Name("cmdBack");
		((Control)cmdBack).set_Size(new Size(427, 95));
		((Control)cmdBack).set_TabIndex(4);
		((ButtonBase)cmdBack).set_Text("Back to menu");
		((ButtonBase)cmdBack).set_UseVisualStyleBackColor(true);
		((Control)Label14).set_Dock((DockStyle)5);
		((Control)Label14).set_Font(new Font("Cambria", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label14).set_Location(new Point(0, 0));
		((Control)Label14).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label14).set_Name("Label14");
		((Control)Label14).set_Padding(new Padding(13, 0, 0, 0));
		((Control)Label14).set_Size(new Size(512, 329));
		((Control)Label14).set_TabIndex(15);
		Label14.set_Text("The faster you are, better position in Stats! Each difficulty level is evaluated separately so don't have to worry about being beaten by 10yrs old kid!");
		((Control)Panel6).set_BackColor(Color.FromArgb(224, 224, 224));
		Panel6.set_BorderStyle((BorderStyle)1);
		((Control)Panel6).get_Controls().Add((Control)(object)Label14);
		((Control)Panel6).set_Location(new Point(19, 148));
		((Control)Panel6).set_Margin(new Padding(8, 7, 8, 7));
		((Control)Panel6).set_Name("Panel6");
		((Control)Panel6).set_Size(new Size(514, 331));
		((Control)Panel6).set_TabIndex(18);
		((Control)Label2).set_BackColor(SystemColors.Control);
		((Control)Label2).set_Dock((DockStyle)1);
		((Control)Label2).set_Font(new Font("Cambria", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label2).set_Location(new Point(0, 0));
		((Control)Label2).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(1851, 143));
		((Control)Label2).set_TabIndex(17);
		Label2.set_Text("Help");
		Label2.set_TextAlign((ContentAlignment)32);
		((Control)Label3).set_Dock((DockStyle)1);
		((Control)Label3).set_Font(new Font("Cambria", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label3).set_Location(new Point(0, 0));
		((Control)Label3).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(555, 160));
		((Control)Label3).set_TabIndex(12);
		Label3.set_Text("Stats");
		Label3.set_TextAlign((ContentAlignment)32);
		((Control)Panel1).set_BackColor(SystemColors.Control);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel2);
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).set_Dock((DockStyle)5);
		((Control)Panel1).set_Location(new Point(555, 143));
		((Control)Panel1).set_Margin(new Padding(8, 7, 8, 7));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(741, 623));
		((Control)Panel1).set_TabIndex(18);
		((Control)Panel2).set_BackColor(Color.FromArgb(224, 224, 224));
		Panel2.set_BorderStyle((BorderStyle)1);
		((Control)Panel2).get_Controls().Add((Control)(object)Label5);
		((Control)Panel2).set_Location(new Point(0, 148));
		((Control)Panel2).set_Margin(new Padding(8, 7, 8, 7));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(738, 469));
		((Control)Panel2).set_TabIndex(18);
		((Control)Label5).set_Dock((DockStyle)5);
		((Control)Label5).set_Font(new Font("Cambria", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label5).set_Location(new Point(0, 0));
		((Control)Label5).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Padding(new Padding(13, 0, 0, 0));
		((Control)Label5).set_Size(new Size(736, 467));
		((Control)Label5).set_TabIndex(15);
		Label5.set_Text(componentResourceManager.GetString("Label5.Text"));
		((Control)Label1).set_Dock((DockStyle)1);
		((Control)Label1).set_Font(new Font("Cambria", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label1).set_Location(new Point(0, 0));
		((Control)Label1).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(741, 160));
		((Control)Label1).set_TabIndex(11);
		Label1.set_Text("How to play");
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)Panel3).set_BackColor(SystemColors.Control);
		((Control)Panel3).get_Controls().Add((Control)(object)Panel6);
		((Control)Panel3).get_Controls().Add((Control)(object)Label3);
		((Control)Panel3).set_Dock((DockStyle)4);
		((Control)Panel3).set_Location(new Point(1296, 143));
		((Control)Panel3).set_Margin(new Padding(8, 7, 8, 7));
		((Control)Panel3).set_Name("Panel3");
		((Control)Panel3).set_Size(new Size(555, 623));
		((Control)Panel3).set_TabIndex(19);
		((Form)this).set_AcceptButton((IButtonControl)(object)cmdBack);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(16f, 31f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)cmdBack);
		((Form)this).set_ClientSize(new Size(1851, 1004));
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)Panel3);
		((Control)this).get_Controls().Add((Control)(object)Panel5);
		((Control)this).get_Controls().Add((Control)(object)panBottom);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(8, 7, 8, 7));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmHelp");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("frmHelp");
		((Control)panEasyTitle).ResumeLayout(false);
		((Control)Panel5).ResumeLayout(false);
		((Control)panBottom).ResumeLayout(false);
		((Control)Panel6).ResumeLayout(false);
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel3).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void cmdBack_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.frmMainMenu).Show();
	}
}
