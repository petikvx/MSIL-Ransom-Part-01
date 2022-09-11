using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using winlogon;

namespace File_encryption;

public class password_display : Form
{
	private IContainer components;

	private TextBox key_txt;

	private Button copy_btn;

	public password_display()
	{
		InitializeComponent();
		((Control)key_txt).set_Text(winlogone.Key);
	}

	private void Copy_btn_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(((Control)key_txt).get_Text());
	}

	private void Password_display_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", (MessageBoxButtons)4) == 6)
		{
			MessageBox.Show("The application has been closed successfully.", "Application Closed!", (MessageBoxButtons)0);
			return;
		}
		((CancelEventArgs)(object)e).Cancel = true;
		((Form)this).Activate();
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		key_txt = new TextBox();
		copy_btn = new Button();
		((Control)this).SuspendLayout();
		((Control)key_txt).set_Location(new Point(8, 12));
		((TextBoxBase)key_txt).set_Multiline(true);
		((Control)key_txt).set_Name("key_txt");
		((TextBoxBase)key_txt).set_ReadOnly(true);
		((Control)key_txt).set_Size(new Size(426, 47));
		((Control)key_txt).set_TabIndex(0);
		((Control)copy_btn).set_Location(new Point(440, 12));
		((Control)copy_btn).set_Name("copy_btn");
		((Control)copy_btn).set_Size(new Size(58, 47));
		((Control)copy_btn).set_TabIndex(1);
		((Control)copy_btn).set_Text("copy");
		((ButtonBase)copy_btn).set_UseVisualStyleBackColor(true);
		((Control)copy_btn).add_Click((EventHandler)Copy_btn_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(505, 71));
		((Control)this).get_Controls().Add((Control)(object)copy_btn);
		((Control)this).get_Controls().Add((Control)(object)key_txt);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("password_display");
		((Control)this).set_Text("password display");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Password_display_FormClosing));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
