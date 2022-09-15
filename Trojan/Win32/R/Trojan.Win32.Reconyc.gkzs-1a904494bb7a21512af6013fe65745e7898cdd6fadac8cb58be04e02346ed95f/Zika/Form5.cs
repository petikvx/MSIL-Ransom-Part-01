using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using AxWMPLib;

namespace Zika;

public class Form5 : Form
{
	private IContainer components;

	private AxWindowsMediaPlayer axWindowsMediaPlayer1;

	public Form5()
	{
		InitializeComponent();
	}

	private void Form5_Load(object sender, EventArgs e)
	{
	}

	private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
	{
	}

	private void axWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)axWindowsMediaPlayer1.get_playState() == 1)
		{
			((Form)this).Close();
		}
	}

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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form5));
		axWindowsMediaPlayer1 = new AxWindowsMediaPlayer();
		((ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)axWindowsMediaPlayer1).set_Dock((DockStyle)5);
		((AxHost)axWindowsMediaPlayer1).set_Enabled(true);
		((Control)axWindowsMediaPlayer1).set_Location(new Point(0, 0));
		((Control)axWindowsMediaPlayer1).set_Name("axWindowsMediaPlayer1");
		((AxHost)axWindowsMediaPlayer1).set_OcxState((State)componentResourceManager.GetObject("axWindowsMediaPlayer1.OcxState"));
		((Control)axWindowsMediaPlayer1).set_Size(new Size(284, 261));
		((Control)axWindowsMediaPlayer1).set_TabIndex(0);
		axWindowsMediaPlayer1.add_PlayStateChange(new _WMPOCXEvents_PlayStateChangeEventHandler(axWindowsMediaPlayer1_PlayStateChange));
		((Control)axWindowsMediaPlayer1).add_Enter((EventHandler)axWindowsMediaPlayer1_Enter);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(284, 261));
		((Control)this).get_Controls().Add((Control)(object)axWindowsMediaPlayer1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form5");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form5");
		((Form)this).add_Load((EventHandler)Form5_Load);
		((ISupportInitialize)axWindowsMediaPlayer1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
