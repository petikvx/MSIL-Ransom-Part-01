using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace wg;

public class SendMessageForm : Form
{
	private IContainer components;

	private TextBox MessageText;

	private Button Send;

	private TextBox Email;

	private Label EmailLabel;

	public SendMessageForm()
	{
		InitializeComponent();
	}

	private void Send_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(((Control)MessageText).get_Text()))
		{
			MessageBox.Show((IWin32Window)(object)this, "Message can not be empty", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return;
		}
		Utils.CheckInternetConnection();
		Utils.SendMessage(((Control)Email).get_Text() + " : " + MessageText, Utils.useProxy);
		((Form)this).Close();
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
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		MessageText = new TextBox();
		Send = new Button();
		Email = new TextBox();
		EmailLabel = new Label();
		((Control)this).SuspendLayout();
		((Control)MessageText).set_Location(new Point(12, 12));
		((TextBoxBase)MessageText).set_Multiline(true);
		((Control)MessageText).set_Name("MessageText");
		((Control)MessageText).set_Size(new Size(301, 153));
		((Control)MessageText).set_TabIndex(0);
		((Control)Send).set_Location(new Point(196, 171));
		((Control)Send).set_Name("Send");
		((Control)Send).set_Size(new Size(117, 29));
		((Control)Send).set_TabIndex(1);
		((Control)Send).set_Text("Send message");
		((ButtonBase)Send).set_UseVisualStyleBackColor(true);
		((Control)Send).add_Click((EventHandler)Send_Click);
		((Control)Email).set_Location(new Point(50, 176));
		((Control)Email).set_Name("Email");
		((Control)Email).set_Size(new Size(140, 20));
		((Control)Email).set_TabIndex(2);
		((Control)EmailLabel).set_AutoSize(true);
		((Control)EmailLabel).set_Location(new Point(9, 179));
		((Control)EmailLabel).set_Name("EmailLabel");
		((Control)EmailLabel).set_Size(new Size(35, 13));
		((Control)EmailLabel).set_TabIndex(3);
		((Control)EmailLabel).set_Text("Email:");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(325, 210));
		((Control)this).get_Controls().Add((Control)(object)EmailLabel);
		((Control)this).get_Controls().Add((Control)(object)Email);
		((Control)this).get_Controls().Add((Control)(object)Send);
		((Control)this).get_Controls().Add((Control)(object)MessageText);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("SendMessageForm");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("Support");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
