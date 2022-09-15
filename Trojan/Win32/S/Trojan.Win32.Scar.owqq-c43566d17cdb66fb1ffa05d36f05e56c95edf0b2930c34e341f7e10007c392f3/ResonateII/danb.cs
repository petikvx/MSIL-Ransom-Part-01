using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ResonateII;

public class danb : Form
{
	public static string keyBuff = "";

	private IContainer components = null;

	private Label label1;

	public danb()
	{
		InitializeComponent();
		int width = ((Control)label1).get_Width();
		int height = ((Control)label1).get_Height();
		((Control)this).set_Width(Screen.get_PrimaryScreen().get_Bounds().Width);
		((Control)this).set_Height(Screen.get_PrimaryScreen().get_Bounds().Height);
		((Control)label1).set_Location(new Point(((Control)this).get_Width() / 2 - width / 2, ((Control)this).get_Height() / 2 - height / 2));
	}

	private void danb_KeyPress(object sender, KeyPressEventArgs e)
	{
		keyBuff += e.get_KeyChar();
		if (keyBuff.Contains("Happy Birthday Dan"))
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		label1 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.LightGray);
		((Control)label1).set_Font(new Font("Lucida Console", 27.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Black);
		((Control)label1).set_Location(new Point(13, 13));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(611, 37));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Type \"Happy Birthday Dan\" !");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkCyan);
		((Form)this).set_ClientSize(new Size(700, 270));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("danb");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Control)this).set_Text("danb");
		((Form)this).set_TopMost(true);
		((Control)this).add_KeyPress(new KeyPressEventHandler(danb_KeyPress));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
