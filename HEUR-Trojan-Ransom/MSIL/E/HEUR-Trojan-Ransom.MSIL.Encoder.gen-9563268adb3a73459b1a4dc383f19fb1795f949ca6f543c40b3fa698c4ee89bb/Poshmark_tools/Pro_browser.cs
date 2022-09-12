using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace Poshmark_tools;

public class Pro_browser : UserControl
{
	private IContainer components = null;

	private SplitContainer splitContainer1;

	public CheckBox canadian_closet_CheckBox1;

	public Pro_browser()
	{
		InitializeComponent();
	}

	public void main_initialize()
	{
		if (((CheckBox)Form1.pro_configuration_class.browser_checkBox1).get_Checked())
		{
			((Control)Form1.eob).set_Dock((DockStyle)5);
			((Control)this).get_Controls().Add((Control)(object)Form1.eob);
			Form1.eob.get_WebView().set_Url("https://poshmark.com/login");
		}
		else
		{
			((Control)Form1.brower_webbrowser_2).set_Dock((DockStyle)5);
			Form1.brower_webbrowser_2.set_ScriptErrorsSuppressed(true);
			((Control)this).get_Controls().Add((Control)(object)Form1.brower_webbrowser_2);
			Form1.brower_webbrowser_2.Navigate("https://poshmark.com/login");
		}
	}

	private void canadian_closet_CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (canadian_closet_CheckBox1.get_Checked())
		{
			((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).set_Checked(true);
		}
		else
		{
			((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).set_Checked(false);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		splitContainer1 = new SplitContainer();
		canadian_closet_CheckBox1 = new CheckBox();
		((ISupportInitialize)splitContainer1).BeginInit();
		((Control)splitContainer1.get_Panel2()).SuspendLayout();
		((Control)splitContainer1).SuspendLayout();
		((Control)this).SuspendLayout();
		splitContainer1.set_Dock((DockStyle)2);
		((Control)splitContainer1).set_Location(new Point(0, 539));
		((Control)splitContainer1).set_Name("splitContainer1");
		splitContainer1.set_Panel1MinSize(800);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)canadian_closet_CheckBox1);
		((Control)splitContainer1).set_Size(new Size(1006, 29));
		splitContainer1.set_SplitterDistance(800);
		((Control)splitContainer1).set_TabIndex(1);
		((Control)canadian_closet_CheckBox1).set_AutoSize(true);
		((Control)canadian_closet_CheckBox1).set_Dock((DockStyle)4);
		((Control)canadian_closet_CheckBox1).set_Font(new Font("Microsoft Sans Serif", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)canadian_closet_CheckBox1).set_ForeColor(Color.YellowGreen);
		((Control)canadian_closet_CheckBox1).set_Location(new Point(-81, 0));
		((Control)canadian_closet_CheckBox1).set_Name("canadian_closet_CheckBox1");
		((Control)canadian_closet_CheckBox1).set_Size(new Size(283, 29));
		((Control)canadian_closet_CheckBox1).set_TabIndex(0);
		((Control)canadian_closet_CheckBox1).set_Text("For Canadian Closet Click here");
		((ButtonBase)canadian_closet_CheckBox1).set_UseVisualStyleBackColor(true);
		canadian_closet_CheckBox1.add_CheckedChanged((EventHandler)canadian_closet_CheckBox1_CheckedChanged);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)splitContainer1);
		((Control)this).set_Margin(new Padding(4, 5, 4, 5));
		((Control)this).set_Name("Pro_browser");
		((Control)this).set_Size(new Size(1006, 568));
		((Control)splitContainer1.get_Panel2()).ResumeLayout(false);
		((Control)splitContainer1.get_Panel2()).PerformLayout();
		((ISupportInitialize)splitContainer1).EndInit();
		((Control)splitContainer1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
