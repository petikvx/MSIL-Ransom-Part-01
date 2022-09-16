using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace The_Book;

[DesignerGenerated]
public class Main_Menu : Form
{
	private IContainer components;

	internal virtual Button btnRecords
	{
		[CompilerGenerated]
		get
		{
			return _btnRecords;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnRecords_Click;
			Button val = _btnRecords;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnRecords = value;
			val = _btnRecords;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnClassrooms
	{
		[CompilerGenerated]
		get
		{
			return _btnClassrooms;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnClassrooms_Click;
			Button val = _btnClassrooms;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnClassrooms = value;
			val = _btnClassrooms;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("mnuStrip")]
	internal virtual MenuStrip mnuStrip
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem mnuAbout
	{
		[CompilerGenerated]
		get
		{
			return _mnuAbout;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = AboutToolStripMenuItem_Click;
			ToolStripMenuItem val = _mnuAbout;
			if (val != null)
			{
				((ToolStripItem)val).remove_Click(eventHandler);
			}
			_mnuAbout = value;
			val = _mnuAbout;
			if (val != null)
			{
				((ToolStripItem)val).add_Click(eventHandler);
			}
		}
	}

	public Main_Menu()
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		btnRecords = new Button();
		btnClassrooms = new Button();
		mnuStrip = new MenuStrip();
		mnuAbout = new ToolStripMenuItem();
		((Control)mnuStrip).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)btnRecords).set_BackColor(Color.Transparent);
		((Control)btnRecords).set_Font(new Font("Segoe Print", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnRecords).set_Location(new Point(24, 60));
		((Control)btnRecords).set_Name("btnRecords");
		((Control)btnRecords).set_Size(new Size(286, 61));
		((Control)btnRecords).set_TabIndex(0);
		((ButtonBase)btnRecords).set_Text("Records");
		((ButtonBase)btnRecords).set_UseVisualStyleBackColor(false);
		((ButtonBase)btnClassrooms).set_BackColor(Color.Transparent);
		((Control)btnClassrooms).set_Font(new Font("Segoe Print", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnClassrooms).set_Location(new Point(24, 153));
		((Control)btnClassrooms).set_Name("btnClassrooms");
		((Control)btnClassrooms).set_Size(new Size(286, 61));
		((Control)btnClassrooms).set_TabIndex(2);
		((ButtonBase)btnClassrooms).set_Text("Classrooms");
		((ButtonBase)btnClassrooms).set_UseVisualStyleBackColor(false);
		((ToolStrip)mnuStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)mnuAbout });
		((Control)mnuStrip).set_Location(new Point(0, 0));
		((Control)mnuStrip).set_Name("mnuStrip");
		((Control)mnuStrip).set_Size(new Size(334, 24));
		((Control)mnuStrip).set_TabIndex(3);
		((Control)mnuStrip).set_Text("MenuStrip1");
		((ToolStripItem)mnuAbout).set_Name("mnuAbout");
		((ToolStripItem)mnuAbout).set_Size(new Size(52, 20));
		((ToolStripItem)mnuAbout).set_Text("About");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(334, 274));
		((Control)this).get_Controls().Add((Control)(object)btnClassrooms);
		((Control)this).get_Controls().Add((Control)(object)btnRecords);
		((Control)this).get_Controls().Add((Control)(object)mnuStrip);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MainMenuStrip(mnuStrip);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Main_Menu");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Main Menu");
		((Control)mnuStrip).ResumeLayout(false);
		((Control)mnuStrip).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void btnRecords_Click(object sender, EventArgs e)
	{
		Records_Screen records_Screen = new Records_Screen();
		((Control)records_Screen).Show();
		((Form)this).Close();
	}

	private void btnClassrooms_Click(object sender, EventArgs e)
	{
		Projection_GridMode projection_GridMode = new Projection_GridMode();
		((Control)projection_GridMode).Show();
		((Form)this).Close();
	}

	private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Program created by: Alex Thimineur, 2014");
	}
}
