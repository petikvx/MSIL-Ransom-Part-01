using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ASCAvSvc;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("PerplexTheme1")]
	internal virtual PerplexTheme PerplexTheme1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PerplexButton1")]
	internal virtual PerplexButton PerplexButton1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PerplexCheckBox1")]
	internal virtual PerplexCheckBox PerplexCheckBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form1()
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
		PerplexTheme1 = new PerplexTheme();
		TextBox1 = new TextBox();
		PerplexCheckBox1 = new PerplexCheckBox();
		PerplexButton1 = new PerplexButton();
		((Control)PerplexTheme1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)PerplexTheme1).set_BackColor(Color.FromArgb(25, 25, 25));
		((Control)PerplexTheme1).get_Controls().Add((Control)(object)TextBox1);
		((Control)PerplexTheme1).get_Controls().Add((Control)(object)PerplexCheckBox1);
		((Control)PerplexTheme1).get_Controls().Add((Control)(object)PerplexButton1);
		((Control)PerplexTheme1).set_Dock((DockStyle)5);
		((Control)PerplexTheme1).set_Location(new Point(0, 0));
		((Control)PerplexTheme1).set_Name("PerplexTheme1");
		((Control)PerplexTheme1).set_Size(new Size(340, 225));
		((Control)PerplexTheme1).set_TabIndex(0);
		((Control)PerplexTheme1).set_Text("Main Board");
		((Control)TextBox1).set_Location(new Point(26, 42));
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(280, 130));
		((Control)TextBox1).set_TabIndex(3);
		((Control)PerplexCheckBox1).set_BackColor(Color.Transparent);
		PerplexCheckBox1.Checked = false;
		((Control)PerplexCheckBox1).set_ForeColor(Color.Black);
		((Control)PerplexCheckBox1).set_Location(new Point(214, 183));
		((Control)PerplexCheckBox1).set_Name("PerplexCheckBox1");
		((Control)PerplexCheckBox1).set_Size(new Size(60, 14));
		((Control)PerplexCheckBox1).set_TabIndex(2);
		((Control)PerplexCheckBox1).set_Text("True?");
		((Control)PerplexButton1).set_BackColor(Color.Transparent);
		((Control)PerplexButton1).set_ForeColor(Color.FromArgb(205, 205, 205));
		((Control)PerplexButton1).set_Location(new Point(133, 178));
		((Control)PerplexButton1).set_Name("PerplexButton1");
		((Control)PerplexButton1).set_Size(new Size(75, 23));
		((Control)PerplexButton1).set_TabIndex(1);
		((Control)PerplexButton1).set_Text("OK");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(340, 225));
		((Control)this).get_Controls().Add((Control)(object)PerplexTheme1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Form1");
		((Form)this).set_TransparencyKey(Color.Fuchsia);
		((Control)PerplexTheme1).ResumeLayout(false);
		((Control)PerplexTheme1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
